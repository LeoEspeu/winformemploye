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
    public partial class connection : Form
    {
        internal OracleConnection oracleCnx;
        public connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cnx = @"DATA SOURCE=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = freesio.lyc-bonaparte.fr)(PORT = 21521))(CONNECT_DATA = (SERVICE_NAME = slam)));User Id= "+textBox1.Text+";Password="+textBox3.Text;
                oracleCnx = new OracleConnection(cnx);
                oracleCnx.Open();
                MessageBox.Show("Vous êtes connectés à la base de donnée.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
