using QuizGame.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class frmQGInit : Form
    {
        public frmQGInit()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.Acertos = 0;
            VariaveisGlobais.Erros = 0;

            frmQ1 q1 = new frmQ1();
            this.Hide();
            q1.ShowDialog();
        }
    }
}
