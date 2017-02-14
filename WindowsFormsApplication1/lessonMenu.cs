using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class lessonMenu : Form
    {
        public lessonMenu()
        {

            InitializeComponent();
            imagename4.pic = Resources.signB;
            imagename3.pic = Resources.signA1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            lessons lessonsForm = new lessons();
            lessonsForm.Show();
        }
    }
}
