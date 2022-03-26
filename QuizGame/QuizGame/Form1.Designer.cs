namespace QuizGame
{
    partial class FrmInit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblQG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInit.Location = new System.Drawing.Point(1001, 652);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(132, 56);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Iniciar";
            this.btnInit.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(842, 652);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblQG
            // 
            this.lblQG.Font = new System.Drawing.Font("Lucida Sans Unicode", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQG.Location = new System.Drawing.Point(272, 43);
            this.lblQG.Name = "lblQG";
            this.lblQG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQG.Size = new System.Drawing.Size(626, 83);
            this.lblQG.TabIndex = 2;
            this.lblQG.Text = "QUIZ GAME";
            this.lblQG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1145, 720);
            this.Controls.Add(this.lblQG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblQG;
    }
}
