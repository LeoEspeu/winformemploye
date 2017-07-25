using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformemploye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            (new connection()).ShowDialog();
        }

        private void consulterSéminaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consulterEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
