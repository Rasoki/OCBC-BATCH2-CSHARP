using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class frmRegister : Form
    {
        // Initialize the connection class
        Config db = new Config();
        public frmRegister()
        {
            InitializeComponent();

            // pass the database you want to connect to
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO user_info(names, username, password) VALUES('"+edNama.Text+"'," +" '"+edUsername.Text+"','"+edPassword+"'");

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // closses the register window
            this.Close();
        }
    }
}
