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
            this.SuspendLayout();
            // 
            // btnInstallBoth
            // 
            this.btnInstallBoth.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstallBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallBoth.Location = new System.Drawing.Point(150, 66);
            this.btnInstallBoth.Name = "btnInstallBoth";
            this.btnInstallBoth.Size = new System.Drawing.Size(229, 39);
            this.btnInstallBoth.TabIndex = 0;
            this.btnInstallBoth.Text = "Install Both";
            this.btnInstallBoth.UseVisualStyleBackColor = false;
            this.btnInstallBoth.Click += new System.EventHandler(this.btnInstallBoth_Click);
            // 
            // PBMain
            // 
            this.PBMain.Location = new System.Drawing.Point(12, 12);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(504, 48);
            this.PBMain.TabIndex = 1;
            // 
            // btnInstallx86
            // 
            this.btnInstallx86.BackColor = System.Drawing.SystemColors.Control;
            this.btnInstallx86.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallx86.Location = new System.Drawing.Point(12, 66);
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
            this.btnInstallx64.Location = new System.Drawing.Point(385, 66);
            this.btnInstallx64.Name = "btnInstallx64";
            this.btnInstallx64.Size = new System.Drawing.Size(132, 39);
            this.btnInstallx64.TabIndex = 3;
            this.btnInstallx64.Text = "Install x64";
            this.btnInstallx64.UseVisualStyleBackColor = false;
            this.btnInstallx64.Click += new System.EventHandler(this.btnInstallx64_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(528, 114);
            this.Controls.Add(this.btnInstallx64);
            this.Controls.Add(this.btnInstallx86);
            this.Controls.Add(this.PBMain);
            this.Controls.Add(this.btnInstallBoth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexsitt Component Installer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstallBoth;
        private System.Windows.Forms.ProgressBar PBMain;
        private System.Windows.Forms.Button btnInstallx86;
        private System.Windows.Forms.Button btnInstallx64;
    }
}

