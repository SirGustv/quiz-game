namespace QuizGame.Questions
{
    partial class frmQ4
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
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rbtnErrada3 = new System.Windows.Forms.RadioButton();
            this.rbtnErrada2 = new System.Windows.Forms.RadioButton();
            this.rbtnErrada1 = new System.Windows.Forms.RadioButton();
            this.rbtnCerta = new System.Windows.Forms.RadioButton();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(946, 527);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 46);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Próximo";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblPergunta);
            this.groupBox1.Controls.Add(this.rbtnErrada3);
            this.groupBox1.Controls.Add(this.rbtnErrada2);
            this.groupBox1.Controls.Add(this.rbtnErrada1);
            this.groupBox1.Controls.Add(this.rbtnCerta);
            this.groupBox1.Location = new System.Drawing.Point(33, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 415);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPergunta.Location = new System.Drawing.Point(27, 25);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(958, 117);
            this.lblPergunta.TabIndex = 4;
            this.lblPergunta.Text = "Qual o maior animal do mundo?";
            // 
            // rbtnErrada3
            // 
            this.rbtnErrada3.AutoSize = true;
            this.rbtnErrada3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnErrada3.Location = new System.Drawing.Point(27, 180);
            this.rbtnErrada3.Name = "rbtnErrada3";
            this.rbtnErrada3.Size = new System.Drawing.Size(95, 29);
            this.rbtnErrada3.TabIndex = 4;
            this.rbtnErrada3.TabStop = true;
            this.rbtnErrada3.Text = "Elefante";
            this.rbtnErrada3.UseVisualStyleBackColor = true;
            // 
            // rbtnErrada2
            // 
            this.rbtnErrada2.AutoSize = true;
            this.rbtnErrada2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnErrada2.Location = new System.Drawing.Point(27, 215);
            this.rbtnErrada2.Name = "rbtnErrada2";
            this.rbtnErrada2.Size = new System.Drawing.Size(79, 29);
            this.rbtnErrada2.TabIndex = 3;
            this.rbtnErrada2.TabStop = true;
            this.rbtnErrada2.Text = "Girafa";
            this.rbtnErrada2.UseVisualStyleBackColor = true;
            // 
            // rbtnErrada1
            // 
            this.rbtnErrada1.AutoSize = true;
            this.rbtnErrada1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnErrada1.Location = new System.Drawing.Point(27, 145);
            this.rbtnErrada1.Name = "rbtnErrada1";
            this.rbtnErrada1.Size = new System.Drawing.Size(101, 29);
            this.rbtnErrada1.TabIndex = 2;
            this.rbtnErrada1.TabStop = true;
            this.rbtnErrada1.Text = "Golfinho";
            this.rbtnErrada1.UseVisualStyleBackColor = true;
            // 
            // rbtnCerta
            // 
            this.rbtnCerta.AutoSize = true;
            this.rbtnCerta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCerta.Location = new System.Drawing.Point(27, 250);
            this.rbtnCerta.Name = "rbtnCerta";
            this.rbtnCerta.Size = new System.Drawing.Size(119, 29);
            this.rbtnCerta.TabIndex = 1;
            this.rbtnCerta.TabStop = true;
            this.rbtnCerta.Text = "Baleia-Azul";
            this.rbtnCerta.UseVisualStyleBackColor = true;
            // 
            // lblQ4
            // 
            this.lblQ4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQ4.Location = new System.Drawing.Point(33, 27);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(181, 46);
            this.lblQ4.TabIndex = 9;
            this.lblQ4.Text = "Questão 4";
            // 
            // frmQ4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQ4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQ4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rbtnErrada3;
        private System.Windows.Forms.RadioButton rbtnErrada2;
        private System.Windows.Forms.RadioButton rbtnErrada1;
        private System.Windows.Forms.RadioButton rbtnCerta;
        private System.Windows.Forms.Label lblQ4;
    }
}