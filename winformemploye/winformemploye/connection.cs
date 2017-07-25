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
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cnx ="Data Source=slam;User Id="+textBox1.Text+"; Password="+textBox2.Text+"";
                MessageBox.Show("Vous êtes connectés à la base de donnée.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
