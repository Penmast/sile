using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class imagename : UserControl
    {
        public event System.EventHandler clicked;

        public imagename()
        {
            InitializeComponent();
        }

        public void onClick(object sender, EventArgs e)
        {
            this.clicked(sender, e);
        }
    }
}
