using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polly_Pipe
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

  

        private void erase() // clear function
        {
            TxtPw.Text = "";
            TxtUsernm.Text = "";
            TxtUsernm.Focus();
        }

        private void PollyPipe_Load(object sender, EventArgs e)
        {
            PnlLogin.BackColor = Color.FromArgb(80,50,50,50); // To make panel transparent
        }


        private void BtnExit_Click_1(object sender, EventArgs e) // Exit button
        {
            DialogResult resExit = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LblUsrnm_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e) // clear button
        {
            erase();
        }

        private void TxtUsernm_TextChanged(object sender, EventArgs e)
        {
            TxtUsernm.Focus();
        }

        private void BtnSignin_Click(object sender, EventArgs e)  // sign in button
        {
            String username = TxtUsernm.Text;
            string password = TxtPw.Text;

            if (username == "PPAdmin" && password == "admin@123") // the user name and password to the login
            {
                new FrmMain().Show();    // load main page
                this.Visible = false;
            }
            else
            {
                // the massege box if the UN or  PW are wrong
                MessageBox.Show("Sign In Error. Please check the User Name or Password", "Sign In Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erase();
            }
        }
    }
}