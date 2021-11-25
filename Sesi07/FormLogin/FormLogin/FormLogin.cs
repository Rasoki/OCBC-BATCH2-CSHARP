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
    public partial class frmLogin : Form
    {
        // Initialize the connection class
        Config db = new Config();
        public  frmLogin()
        {
            InitializeComponent();
            // pass the database you want to connect to
            db.Connect("userdata");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // querry MySQL database for the data passed from textboxes
            db.ExecuteSelect("SELECT * FROM user_info where username='" + edUsername.Text + "' and password ='" + edPassword.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //start register window
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
