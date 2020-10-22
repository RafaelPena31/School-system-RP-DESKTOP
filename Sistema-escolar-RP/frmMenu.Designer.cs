namespace Sistema_escolar_RP
{
    partial class frmMenu
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
            this.ptx_alunos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // ptx_alunos
            // 
            this.ptx_alunos.Image = global::Sistema_escolar_RP.Properties.Resources.schroolTeacher;
            this.ptx_alunos.Location = new System.Drawing.Point(106, 35);
            this.ptx_alunos.Name = "ptx_alunos";
            this.ptx_alunos.Size = new System.Drawing.Size(586, 376);
            this.ptx_alunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptx_alunos.TabIndex = 0;
            this.ptx_alunos.TabStop = false;
            this.ptx_alunos.Click += new System.EventHandler(this.ptx_alunos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptx_alunos);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.ptx_alunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptx_alunos;
    }
}