using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
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
        }

        private void btnInstallBoth_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "CompInstall");
            Directory.CreateDirectory(tempPath);

            var installFiles = new (string fileName, string arguments)[]
            {
        ("2005x86.EXE", "/q"),
        ("2005x64.EXE", "/q"),
        ("2008x86.exe", "/q"),
        ("2008x64.exe", "/q"),
        ("2010x86.exe", "/quiet /norestart"),
        ("2010x64.exe", "/quiet /norestart"),
        ("2012x86.exe", "/quiet /norestart"),
        ("2012x64.exe", "/quiet /norestart"),
        ("2013x86.exe", "/quiet /norestart"),
        ("2013x64.exe", "/quiet /norestart"),
        ("2022x86.exe", "/quiet /norestart"),
        ("2022x64.exe", "/quiet /norestart"),
        ("xnafx40_redist.msi", "/quiet /norestart")
            };

            PBMain.Maximum = installFiles.Length;

            try
            {
                foreach (var (fileName, arguments) in installFiles)
                {
                    string filePath = Path.Combine(tempPath, fileName);

                    // Extract the embedded file to the temporary directory
                    using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CompInstall.{fileName}"))
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        resourceStream?.CopyTo(fileStream);

                    // Run the installation
                    var processStartInfo = new ProcessStartInfo(
                        fileName.EndsWith(".msi") ? "msiexec.exe" : filePath,
                        fileName.EndsWith(".msi") ? $"/i \"{filePath}\" {arguments}" : arguments)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };

                    using (var process = Process.Start(processStartInfo))
                    {
                        process?.WaitForExit();
                    }

                    // Update the progress bar
                    PBMain.Value++;
                }

                // Delete all temporary files after installing all packages
                Directory.Delete(tempPath, true); // Deletes the folder and its contents
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clean up temporary files if there's an issue
                try
                {
                    if (Directory.Exists(tempPath))
                    {
                        Directory.Delete(tempPath, true); // Deletes the folder and its contents
                    }
                }
                catch
                {
                    // Do nothing if there's an error deleting temporary files
                }

                // Close the application after the error
                Application.Exit();
            }

            // Display completion message after all installations and before closing the program
            MessageBox.Show("All installations have been successfully completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the application
            Application.Exit(); // Closes the entire application
        }

        private void btnInstallx86_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "CompInstall");
            Directory.CreateDirectory(tempPath);

            var installFiles = new (string fileName, string arguments)[]
            {
        ("2005x86.EXE", "/q"),
        ("2008x86.exe", "/q"),
        ("2010x86.exe", "/quiet /norestart"),
        ("2012x86.exe", "/quiet /norestart"),
        ("2013x86.exe", "/quiet /norestart"),
        ("2022x86.exe", "/quiet /norestart"),
        ("xnafx40_redist.msi", "/quiet /norestart")
            };

            PBMain.Maximum = installFiles.Length;

            try
            {
                foreach (var (fileName, arguments) in installFiles)
                {
                    string filePath = Path.Combine(tempPath, fileName);

                    // Extract the embedded file to the temporary directory
                    using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CompInstall.{fileName}"))
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        resourceStream?.CopyTo(fileStream);

                    // Run the installation
                    var processStartInfo = new ProcessStartInfo(
                        fileName.EndsWith(".msi") ? "msiexec.exe" : filePath,
                        fileName.EndsWith(".msi") ? $"/i \"{filePath}\" {arguments}" : arguments)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };

                    using (var process = Process.Start(processStartInfo))
                    {
                        process?.WaitForExit();
                    }

                    // Update the progress bar
                    PBMain.Value++;
                }

                // Delete all temporary files after installing all packages
                Directory.Delete(tempPath, true); // Deletes the folder and its contents
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clean up temporary files if there's an issue
                try
                {
                    if (Directory.Exists(tempPath))
                    {
                        Directory.Delete(tempPath, true); // Deletes the folder and its contents
                    }
                }
                catch
                {
                    // Do nothing if there's an error deleting temporary files
                }

                // Close the application after the error
                Application.Exit();
            }

            // Display completion message after all installations and before closing the program
            MessageBox.Show("All installations have been successfully completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the application
            Application.Exit(); // Closes the entire application
        }

        private void btnInstallx64_Click(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "CompInstall");
            Directory.CreateDirectory(tempPath);

            var installFiles = new (string fileName, string arguments)[]
            {
        ("2005x64.EXE", "/q"),
        ("2008x64.exe", "/q"),
        ("2010x64.exe", "/quiet /norestart"),
        ("2012x64.exe", "/quiet /norestart"),
        ("2013x64.exe", "/quiet /norestart"),
        ("2022x64.exe", "/quiet /norestart"),
        ("xnafx40_redist.msi", "/quiet /norestart")
            };

            PBMain.Maximum = installFiles.Length;

            try
            {
                foreach (var (fileName, arguments) in installFiles)
                {
                    string filePath = Path.Combine(tempPath, fileName);

                    // Extract the embedded file to the temporary directory
                    using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CompInstall.{fileName}"))
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        resourceStream?.CopyTo(fileStream);

                    // Run the installation
                    var processStartInfo = new ProcessStartInfo(
                        fileName.EndsWith(".msi") ? "msiexec.exe" : filePath,
                        fileName.EndsWith(".msi") ? $"/i \"{filePath}\" {arguments}" : arguments)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };

                    using (var process = Process.Start(processStartInfo))
                    {
                        process?.WaitForExit();
                    }

                    // Update the progress bar
                    PBMain.Value++;
                }

                // Delete all temporary files after installing all packages
                Directory.Delete(tempPath, true); // Deletes the folder and its contents
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clean up temporary files if there's an issue
                try
                {
                    if (Directory.Exists(tempPath))
                    {
                        Directory.Delete(tempPath, true); // Deletes the folder and its contents
                    }
                }
                catch
                {
                    // Do nothing if there's an error deleting temporary files
                }

                // Close the application after the error
                Application.Exit();
            }

            // Display completion message after all installations and before closing the program
            MessageBox.Show("All installations have been successfully completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the application
            Application.Exit(); // Closes the entire application
        }
    }
}