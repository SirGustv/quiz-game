namespace QuizGame
{
    partial class frmQGInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQGInit));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblQG = new System.Windows.Forms.Label();
            this.lblIntruct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(594, 392);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(392, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 46);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblQG
            // 
            this.lblQG.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQG.Location = new System.Drawing.Point(3, 9);
            this.lblQG.Name = "lblQG";
            this.lblQG.Size = new System.Drawing.Size(1085, 134);
            this.lblQG.TabIndex = 2;
            this.lblQG.Text = "QUIZ GAME";
            this.lblQG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntruct
            // 
            this.lblIntruct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntruct.Location = new System.Drawing.Point(12, 143);
            this.lblIntruct.Name = "lblIntruct";
            this.lblIntruct.Size = new System.Drawing.Size(1076, 221);
            this.lblIntruct.TabIndex = 3;
            this.lblIntruct.Text = resources.GetString("lblIntruct.Text");
            this.lblIntruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQGInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.lblIntruct);
            this.Controls.Add(this.lblQG);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQGInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblQG;
        private System.Windows.Forms.Label lblIntruct;
    }
}
