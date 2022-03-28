using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.Questions
{
    public partial class frmQ7 : Form
    {
        public frmQ7()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked)
            {
                MessageBox.Show("Resposta Correta!", "QUIZ");
                VariaveisGlobais.Acertos++;

                frmQ8 q8 = new frmQ8();
                this.Hide();
                q8.ShowDialog();
                this.Dispose();

            }
            else if (rbtnErrada1.Checked || rbtnErrada2.Checked || rbtnErrada3.Checked)
            {
                MessageBox.Show("Resposta Incorreta!", "QUIZ");
                VariaveisGlobais.Erros++;

                frmQ8 q8 = new frmQ8();
                this.Hide();
                q8.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa!", "QUIZ");
            }
        }
    }
}
