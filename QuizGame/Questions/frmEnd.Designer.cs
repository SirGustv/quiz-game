namespace QuizGame.Questions
{
    partial class frmEnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOCÊ CHEGOU AO FINAL DO QUIZ!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(486, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acertos:";
            // 
            // lblAcertos
            // 
            this.lblAcertos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcertos.Location = new System.Drawing.Point(587, 148);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(121, 35);
            this.lblAcertos.TabIndex = 2;
            this.lblAcertos.Text = "label3";
            // 
            // lblErros
            // 
            this.lblErros.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErros.Location = new System.Drawing.Point(587, 208);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(121, 35);
            this.lblErros.TabIndex = 3;
            this.lblErros.Text = "label4";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(486, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Erros:";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSair.Location = new System.Drawing.Point(362, 429);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(121, 46);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestart.Location = new System.Drawing.Point(650, 429);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 46);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(362, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "OBRIGADO POR JOGAR!";
            // 
            // frmEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fim";
            this.Load += new System.EventHandler(this.frmEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label3;
    }
}