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
    public partial class ecranprincipal : Form
    {
        public ecranprincipal()
        {
            InitializeComponent();
            new HandRecognitionPicture("aa");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lessons lessonsForm = new lessons();
            this.Hide();
            lessonsForm.Show();
        }

        private void buttonExercices_Click(object sender, EventArgs e)
        {
            exercices exercicesForm = new exercices();
            this.Hide();
            exercicesForm.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
