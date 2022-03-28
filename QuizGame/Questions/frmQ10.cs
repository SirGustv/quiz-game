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
    public partial class frmQ10 : Form
    {
        public frmQ10()
        {
            InitializeComponent();
        }

        private void btnFinishi_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked)
            {
                MessageBox.Show("Resposta Correta!", "QUIZ");
                VariaveisGlobais.Acertos++;

                frmEnd end = new frmEnd();
                this.Hide();
                end.ShowDialog();
                this.Dispose();

            }
            else if (rbtnErrada1.Checked || rbtnErrada2.Checked || rbtnErrada3.Checked)
            {
                MessageBox.Show("Resposta Incorreta!", "QUIZ");
                VariaveisGlobais.Erros++;

                frmEnd end = new frmEnd();
                this.Hide();
                end.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa!", "QUIZ");
            }
        }
    }
}
