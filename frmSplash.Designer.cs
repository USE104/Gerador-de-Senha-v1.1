namespace Geradorador_de_Senha
{
    partial class frmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prgCarregando = new System.Windows.Forms.ProgressBar();
            this.tmrSlapsh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Geradorador_de_Senha.Properties.Resources._1943_security;
            this.pictureBox1.Location = new System.Drawing.Point(39, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prgCarregando
            // 
            this.prgCarregando.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.prgCarregando.Enabled = false;
            this.prgCarregando.ForeColor = System.Drawing.Color.Transparent;
            this.prgCarregando.Location = new System.Drawing.Point(71, 304);
            this.prgCarregando.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prgCarregando.Name = "prgCarregando";
            this.prgCarregando.Size = new System.Drawing.Size(297, 58);
            this.prgCarregando.Step = 1;
            this.prgCarregando.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgCarregando.TabIndex = 1;
            // 
            // tmrSlapsh
            // 
            this.tmrSlapsh.Tick += new System.EventHandler(this.tmrSlapsh_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 377);
            this.ControlBox = false;
            this.Controls.Add(this.prgCarregando);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar prgCarregando;
        private System.Windows.Forms.Timer tmrSlapsh;
    }
}