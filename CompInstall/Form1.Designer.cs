namespace CompInstall
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnInstallBoth = new System.Windows.Forms.Button();
            this.PBMain = new System.Windows.Forms.ProgressBar();
            this.btnInstallx86 = new System.Windows.Forms.Button();
            this.btnInstallx64 = new System.Windows.Forms.Button();
            this.chkvc2005 = new System.Windows.Forms.CheckBox();
            this.chkvc2008 = new System.Windows.Forms.CheckBox();
            this.chkvc2010 = new System.Windows.Forms.CheckBox();
            this.chkvc2012 = new System.Windows.Forms.CheckBox();
            this.chkvc2013 = new System.Windows.Forms.CheckBox();
            this.chkvc2022 = new System.Windows.Forms.CheckBox();
            this.chkXNA = new System.Windows.Forms.CheckBox();
            this.chkOAL = new System.Windows.Forms.CheckBox();
            this.chk7zip = new System.Windows.Forms.CheckBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstallBoth
            // 
            this.btnInstallBoth.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstallBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallBoth.Location = new System.Drawing.Point(145, 58);
            this.btnInstallBoth.Name = "btnInstallBoth";
            this.btnInstallBoth.Size = new System.Drawing.Size(229, 68);
            this.btnInstallBoth.TabIndex = 0;
            this.btnInstallBoth.Text = "Install Both";
            this.btnInstallBoth.UseVisualStyleBackColor = false;
            this.btnInstallBoth.Click += new System.EventHandler(this.btnInstallBoth_Click);
            // 
            // PBMain
            // 
            this.PBMain.Location = new System.Drawing.Point(7, 132);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(504, 33);
            this.PBMain.TabIndex = 1;
            // 
            // btnInstallx86
            // 
            this.btnInstallx86.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstallx86.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallx86.Location = new System.Drawing.Point(7, 87);
            this.btnInstallx86.Name = "btnInstallx86";
            this.btnInstallx86.Size = new System.Drawing.Size(132, 39);
            this.btnInstallx86.TabIndex = 2;
            this.btnInstallx86.Text = "Install x86";
            this.btnInstallx86.UseVisualStyleBackColor = false;
            this.btnInstallx86.Click += new System.EventHandler(this.btnInstallx86_Click);
            // 
            // btnInstallx64
            // 
            this.btnInstallx64.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstallx64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallx64.Location = new System.Drawing.Point(384, 87);
            this.btnInstallx64.Name = "btnInstallx64";
            this.btnInstallx64.Size = new System.Drawing.Size(132, 39);
            this.btnInstallx64.TabIndex = 3;
            this.btnInstallx64.Text = "Install x64";
            this.btnInstallx64.UseVisualStyleBackColor = false;
            this.btnInstallx64.Click += new System.EventHandler(this.btnInstallx64_Click);
            // 
            // chkvc2005
            // 
            this.chkvc2005.AutoSize = true;
            this.chkvc2005.Location = new System.Drawing.Point(7, 12);
            this.chkvc2005.Name = "chkvc2005";
            this.chkvc2005.Size = new System.Drawing.Size(79, 17);
            this.chkvc2005.TabIndex = 4;
            this.chkvc2005.Text = "VC++ 2005";
            this.chkvc2005.UseVisualStyleBackColor = true;
            // 
            // chkvc2008
            // 
            this.chkvc2008.AutoSize = true;
            this.chkvc2008.Location = new System.Drawing.Point(93, 12);
            this.chkvc2008.Name = "chkvc2008";
            this.chkvc2008.Size = new System.Drawing.Size(79, 17);
            this.chkvc2008.TabIndex = 5;
            this.chkvc2008.Text = "VC++ 2008";
            this.chkvc2008.UseVisualStyleBackColor = true;
            // 
            // chkvc2010
            // 
            this.chkvc2010.AutoSize = true;
            this.chkvc2010.Location = new System.Drawing.Point(179, 12);
            this.chkvc2010.Name = "chkvc2010";
            this.chkvc2010.Size = new System.Drawing.Size(79, 17);
            this.chkvc2010.TabIndex = 6;
            this.chkvc2010.Text = "VC++ 2010";
            this.chkvc2010.UseVisualStyleBackColor = true;
            // 
            // chkvc2012
            // 
            this.chkvc2012.AutoSize = true;
            this.chkvc2012.Location = new System.Drawing.Point(265, 12);
            this.chkvc2012.Name = "chkvc2012";
            this.chkvc2012.Size = new System.Drawing.Size(79, 17);
            this.chkvc2012.TabIndex = 7;
            this.chkvc2012.Text = "VC++ 2012";
            this.chkvc2012.UseVisualStyleBackColor = true;
            // 
            // chkvc2013
            // 
            this.chkvc2013.AutoSize = true;
            this.chkvc2013.Location = new System.Drawing.Point(351, 12);
            this.chkvc2013.Name = "chkvc2013";
            this.chkvc2013.Size = new System.Drawing.Size(79, 17);
            this.chkvc2013.TabIndex = 8;
            this.chkvc2013.Text = "VC++ 2013";
            this.chkvc2013.UseVisualStyleBackColor = true;
            // 
            // chkvc2022
            // 
            this.chkvc2022.AutoSize = true;
            this.chkvc2022.Location = new System.Drawing.Point(437, 12);
            this.chkvc2022.Name = "chkvc2022";
            this.chkvc2022.Size = new System.Drawing.Size(79, 17);
            this.chkvc2022.TabIndex = 9;
            this.chkvc2022.Text = "VC++ 2022";
            this.chkvc2022.UseVisualStyleBackColor = true;
            // 
            // chkXNA
            // 
            this.chkXNA.AutoSize = true;
            this.chkXNA.Location = new System.Drawing.Point(7, 35);
            this.chkXNA.Name = "chkXNA";
            this.chkXNA.Size = new System.Drawing.Size(235, 17);
            this.chkXNA.TabIndex = 10;
            this.chkXNA.Text = "XNA 4.0 Refresh (Includes DirectX Runtime)";
            this.chkXNA.UseVisualStyleBackColor = true;
            // 
            // chkOAL
            // 
            this.chkOAL.AutoSize = true;
            this.chkOAL.Location = new System.Drawing.Point(248, 35);
            this.chkOAL.Name = "chkOAL";
            this.chkOAL.Size = new System.Drawing.Size(187, 17);
            this.chkOAL.TabIndex = 11;
            this.chkOAL.Text = "OpenAL (Library for Steam games)";
            this.chkOAL.UseVisualStyleBackColor = true;
            // 
            // chk7zip
            // 
            this.chk7zip.AutoSize = true;
            this.chk7zip.Location = new System.Drawing.Point(437, 35);
            this.chk7zip.Name = "chk7zip";
            this.chk7zip.Size = new System.Drawing.Size(75, 17);
            this.chk7zip.TabIndex = 12;
            this.chk7zip.Text = "7zip 24.08";
            this.chk7zip.UseVisualStyleBackColor = true;
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(7, 58);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(132, 23);
            this.btnNone.TabIndex = 13;
            this.btnNone.Text = "Select none";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(384, 58);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(132, 23);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Select all";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 175);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.chk7zip);
            this.Controls.Add(this.chkOAL);
            this.Controls.Add(this.chkXNA);
            this.Controls.Add(this.chkvc2022);
            this.Controls.Add(this.chkvc2013);
            this.Controls.Add(this.chkvc2012);
            this.Controls.Add(this.chkvc2010);
            this.Controls.Add(this.chkvc2008);
            this.Controls.Add(this.chkvc2005);
            this.Controls.Add(this.btnInstallx64);
            this.Controls.Add(this.btnInstallx86);
            this.Controls.Add(this.PBMain);
            this.Controls.Add(this.btnInstallBoth);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexsitt Component Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstallBoth;
        private System.Windows.Forms.ProgressBar PBMain;
        private System.Windows.Forms.Button btnInstallx86;
        private System.Windows.Forms.Button btnInstallx64;
        private System.Windows.Forms.CheckBox chkvc2005;
        private System.Windows.Forms.CheckBox chkvc2008;
        private System.Windows.Forms.CheckBox chkvc2010;
        private System.Windows.Forms.CheckBox chkvc2012;
        private System.Windows.Forms.CheckBox chkvc2013;
        private System.Windows.Forms.CheckBox chkvc2022;
        private System.Windows.Forms.CheckBox chkXNA;
        private System.Windows.Forms.CheckBox chkOAL;
        private System.Windows.Forms.CheckBox chk7zip;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
    }
}

