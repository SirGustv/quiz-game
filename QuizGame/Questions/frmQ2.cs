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
    public partial class frmQ2 : Form
    {
        public frmQ2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked)
            {
                MessageBox.Show("Resposta Correta!", "QUIZ");
                VariaveisGlobais.Acertos++;

                frmQ3 q3 = new frmQ3();
                this.Hide();
                q3.ShowDialog();
                this.Dispose();

            }
            else if (rbtnErrada1.Checked || rbtnErrada2.Checked || rbtnErrada3.Checked)
            {
                MessageBox.Show("Resposta Incorreta!", "QUIZ");
                VariaveisGlobais.Erros++;

                frmQ3 q3 = new frmQ3();
                this.Hide();
                q3.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa!", "QUIZ");
            }
        }
    }
}
