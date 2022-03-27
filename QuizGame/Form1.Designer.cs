namespace QuizGame
{
    partial class frmQG
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
            this.lblQG = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblTxtIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQG
            // 
            this.lblQG.AutoSize = true;
            this.lblQG.Font = new System.Drawing.Font("Lucida Sans Unicode", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQG.Location = new System.Drawing.Point(400, 50);
            this.lblQG.Name = "lblQG";
            this.lblQG.Size = new System.Drawing.Size(267, 54);
            this.lblQG.TabIndex = 0;
            this.lblQG.Text = "Quiz Game";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(340, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 52);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.Control;
            this.btnInit.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInit.Location = new System.Drawing.Point(604, 391);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(117, 52);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "Iniciar";
            this.btnInit.UseVisualStyleBackColor = false;
            // 
            // lblTxtIntro
            // 
            this.lblTxtIntro.AutoSize = true;
            this.lblTxtIntro.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTxtIntro.Location = new System.Drawing.Point(400, 157);
            this.lblTxtIntro.Name = "lblTxtIntro";
            this.lblTxtIntro.Size = new System.Drawing.Size(212, 108);
            this.lblTxtIntro.TabIndex = 3;
            this.lblTxtIntro.Text = "Texto Introdutório.\r\n-Explicar as funções \r\n-Explicar o tema\r\n-explicar o sistema" +
    "";
            // 
            // frmQG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.ControlBox = false;
            this.Controls.Add(this.lblTxtIntro);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblQG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQG;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblTxtIntro;
    }
}
