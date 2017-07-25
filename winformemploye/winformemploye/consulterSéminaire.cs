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
    public partial class consulterSéminaire : Form
    {
        internal OracleConnection oracleCnx;
        public consulterSéminaire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Owner = this;
            frm1.actionToolStripMenuItem.Enabled = true;
            frm1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cnx = @"DATA SOURCE=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = freesio.lyc-bonaparte.fr)(PORT = 21521))(CONNECT_DATA = (SERVICE_NAME = slam)));User Id= " + textBox1.Text + ";Password=" + textBox3.Text;
                oracleCnx = new OracleConnection(cnx);
                oracleCnx.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cnx = @"DATA SOURCE=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = freesio.lyc-bonaparte.fr)(PORT = 21521))(CONNECT_DATA = (SERVICE_NAME = slam)));User Id= " + textBox1.Text + ";Password=" + textBox3.Text;
                oracleCnx = new OracleConnection(cnx);
                oracleCnx.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
