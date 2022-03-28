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
    public partial class frmEnd : Form
    {
        public frmEnd()
        {
            InitializeComponent();
        }

        private void frmEnd_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            frmQGInit init = new frmQGInit();
            this.Hide();
            init.ShowDialog();
            this.Close();
        }
    }
}
