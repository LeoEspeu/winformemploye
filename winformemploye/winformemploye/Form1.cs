using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace winformemploye
{
    public partial class Form1 : Form
    {
        internal OracleConnection oracleCnx;
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
            string cnx = @"DATA SOURCE=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = freesio.lyc-bonaparte.fr)(PORT = 21521))(CONNECT_DATA = (SERVICE_NAME = slam)));User Id= " + textBox1.Text + ";Password=" + textBox3.Text;
            oracleCnx = new OracleConnection(cnx);
            oracleCnx.Open();
            string requete = "";
            consulterSéminaire consulteSem = new consulterSéminaire();
            consulteSem.Owner = this;
            consulteSem.ShowDialog(this);
        }

        private void consulterEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
