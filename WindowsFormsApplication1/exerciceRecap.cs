using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class exerciceRecap : Form
    {
        private int score;
        private int number_question;

        public exerciceRecap()
        {
            InitializeComponent();
        }

        public exerciceRecap(int score, int v)
        {
            this.score = score;
            this.number_question = v;

            score_pts.Text = this.score.ToString();
            percent_score.Text = (score/number_question).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void percent_score_Click(object sender, EventArgs e)
        {

        }
    }
}
