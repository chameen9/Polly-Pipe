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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  // to load customer management form
        {
            new FrmCusMng().Show();
            this.Visible = false;
        }

        
        private void BtnExit_Click(object sender, EventArgs e)  // exit button
        {
            DialogResult resExit = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsReg_Click(object sender, EventArgs e)  // to load installation management form
        {
            new FrmInsMng().Show();
            this.Visible = false;
        }

        private void BtnEmpReg_Click(object sender, EventArgs e)  // to load employee management form
        {
            new FrmEmpMng().Show();
            this.Visible = false;
        }

        private void BtnEqMng_Click(object sender, EventArgs e)  // to load equiment management form
        {
            new FrmEqMng().Show();
            this.Visible = false;
        }

        private void LblUsernm_Click(object sender, EventArgs e)
        {

        }
    }
}
