using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompInstall
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckSystemArchitecture();
        }

        private void btnInstallBoth_Click(object sender, EventArgs e)
        {
            chkvc2005.Enabled = false;
            chkvc2008.Enabled = false;
            chkvc2010.Enabled = false;
            chkvc2012.Enabled = false;
            chkvc2013.Enabled = false;
            chkvc2022.Enabled = false;
            chkXNA.Enabled = false;
            chkOAL.Enabled = false;
            chk7zip.Enabled = false;
            btnNone.Enabled = false;
            btnAll.Enabled = false;
            btnInstallx86.Enabled = false;
            btnInstallx64.Enabled = false;
            btnInstallBoth.Enabled = false;
            InstallSelectedPrograms("Both");
        }

        private void btnInstallx86_Click(object sender, EventArgs e)
        {
            chkvc2005.Enabled = false;
            chkvc2008.Enabled = false;
            chkvc2010.Enabled = false;
            chkvc2012.Enabled = false;
            chkvc2013.Enabled = false;
            chkvc2022.Enabled = false;
            chkXNA.Enabled = false;
            chkOAL.Enabled = false;
            chk7zip.Enabled = false;
            btnNone.Enabled = false;
            btnAll.Enabled = false;
            btnInstallx86.Enabled = false;
            btnInstallx64.Enabled = false;
            btnInstallBoth.Enabled = false;
            InstallSelectedPrograms("x86");
        }

        private void btnInstallx64_Click(object sender, EventArgs e)
        {
            chkvc2005.Enabled = false;
            chkvc2008.Enabled = false;
            chkvc2010.Enabled = false;
            chkvc2012.Enabled = false;
            chkvc2013.Enabled = false;
            chkvc2022.Enabled = false;
            chkXNA.Enabled = false;
            chkOAL.Enabled = false;
            chk7zip.Enabled = false;
            btnNone.Enabled = false;
            btnAll.Enabled = false;
            btnInstallx86.Enabled = false;
            btnInstallx64.Enabled = false;
            btnInstallBoth.Enabled = false;
            InstallSelectedPrograms("x64");
        }

        private void InstallSelectedPrograms(string architecture)
        {
            // List of programs based on checkboxes
            var installFiles = new List<(string fileName, string arguments)>();

            if (chkvc2005.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("2005x86.EXE", "/q"));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("2005x64.EXE", "/q"));
            }
            if (chkvc2008.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("2008x86.exe", "/q"));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("2008x64.exe", "/q"));
            }
            if (chkvc2010.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("2010x86.exe", "/quiet /norestart"));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("2010x64.exe", "/quiet /norestart"));
            }
            if (chkvc2012.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("2012x86.exe", "/quiet /norestart"));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("2012x64.exe", "/quiet /norestart"));
            }
            if (chkvc2013.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("2013x86.exe", "/quiet /norestart"));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("2013x64.exe", "/quiet /norestart"));
            }
            if (chkvc2022.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("2022x86.exe", "/quiet /norestart"));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("2022x64.exe", "/quiet /norestart"));
            }
            if (chk7zip.Checked)
            {
                if (architecture == "Both" || architecture == "x86")
                    installFiles.Add(("7z2408.exe", "/S /D=\"C:\\Program Files\\7-Zip\""));
                if (architecture == "Both" || architecture == "x64")
                    installFiles.Add(("7z2408-x64.exe", "/S /D=\"C:\\Program Files\\7-Zip\""));
            }
            if (chkOAL.Checked)
            {
                installFiles.Add(("oalinst.exe", "/silent"));
            }
            if (chkXNA.Checked)
            {
                installFiles.Add(("xnafx40_redist.msi", "/quiet /norestart"));
            }

            // Install the selected programs
            if (installFiles.Count > 0)
            {
                InstallPrograms(installFiles.ToArray());
            }
            else
            {
                MessageBox.Show("No options selected for installation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Re-enable checkboxes and buttons
                chkvc2005.Enabled = true;
                chkvc2008.Enabled = true;
                chkvc2010.Enabled = true;
                chkvc2012.Enabled = true;
                chkvc2013.Enabled = true;
                chkvc2022.Enabled = true;
                chkXNA.Enabled = true;
                chkOAL.Enabled = true;
                chk7zip.Enabled = true;
                btnNone.Enabled = true;
                btnAll.Enabled = true;
                btnInstallx86.Enabled = true;

                // Re-check system architecture for button states
                CheckSystemArchitecture();

                // Ensure the buttons are disabled on a 32-bit system
                if (!Environment.Is64BitOperatingSystem)
                {
                    btnInstallx64.Enabled = false;
                    btnInstallBoth.Enabled = false;
                }
            }
        }

        private void InstallPrograms((string fileName, string arguments)[] installFiles)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "CompInstall");
            Directory.CreateDirectory(tempPath);
            PBMain.Maximum = installFiles.Length;

            try
            {
                foreach (var (fileName, arguments) in installFiles)
                {
                    string filePath = Path.Combine(tempPath, fileName);

                    // Extract the embedded resource to the temporary directory
                    using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CompInstall.{fileName}"))
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        if (resourceStream == null)
                            throw new FileNotFoundException($"The resource '{fileName}' was not found.");
                        resourceStream.CopyTo(fileStream);
                    }

                    // Configure the installation process
                    var processStartInfo = new ProcessStartInfo(
                        fileName.EndsWith(".msi", StringComparison.OrdinalIgnoreCase) ? "msiexec.exe" : filePath,
                        fileName.EndsWith(".msi", StringComparison.OrdinalIgnoreCase) ? $"/i \"{filePath}\" {arguments}" : arguments)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        WorkingDirectory = tempPath
                    };

                    // Start the process
                    using (var process = Process.Start(processStartInfo))
                    {
                        if (process == null)
                            throw new InvalidOperationException($"The process for '{fileName}' could not be started.");
                        process.WaitForExit();

                        if (process.ExitCode != 0)
                            throw new Exception($"The installer '{fileName}' returned exit code {process.ExitCode}.");
                    }

                    PBMain.Value++;
                }

                // Remove temporary files
                Directory.Delete(tempPath, true);
                MessageBox.Show("All installations were successfully completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during installation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    if (Directory.Exists(tempPath))
                        Directory.Delete(tempPath, true);
                }
                catch
                {
                    // Ignore errors deleting temporary files
                }

                Application.Exit();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            chkvc2005.Checked = true;
            chkvc2008.Checked = true;
            chkvc2010.Checked = true;
            chkvc2012.Checked = true;
            chkvc2013.Checked = true;
            chkvc2022.Checked = true;
            chkXNA.Checked = true;
            chkOAL.Checked = true;
            chk7zip.Checked = true;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            chkvc2005.Checked = false;
            chkvc2008.Checked = false;
            chkvc2010.Checked = false;
            chkvc2012.Checked = false;
            chkvc2013.Checked = false;
            chkvc2022.Checked = false;
            chkXNA.Checked = false;
            chkOAL.Checked = false;
            chk7zip.Checked = false;
        }

        private void CheckSystemArchitecture()
        {
            // Detect if the system is 64-bit
            bool is64Bit = Environment.Is64BitOperatingSystem;

            if (is64Bit)
            {
                // Enable buttons for 64-bit systems
                btnInstallBoth.Enabled = true;
                btnInstallx64.Enabled = true;
            }
            else
            {
                // Disable buttons for 32-bit systems
                btnInstallBoth.Enabled = false;
                btnInstallx64.Enabled = false;
            }
        }
    }
}