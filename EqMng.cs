using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Polly_Pipe
{
    public partial class FrmEqMng : Form
    {
        public FrmEqMng()
        {
            InitializeComponent();
        }

        //sql connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=CHVM2EN;Initial Catalog=PollyPipe;Integrated Security=True");


        private void erase ()       // erase function
        {
            TxtID.Text = "";
            TxtCatID.Text = "";
            TxtName.Text = "";
            CmbID.Text = "";
            TxtID.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)      // exit button
        {
            DialogResult resExit = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmEqMng_Load(object sender, EventArgs e)
        {
            PnlEqMng.BackColor = Color.FromArgb(50, 0, 0, 0);       //set panel colour to transparent
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)      // load main form
        {
            new FrmMain().Show();
            this.Visible = false;
        }

        private void BtnEnter_Click(object sender, EventArgs e)     // load category form
        {
            erase();
            new FrmCatMng().Show();
            this.Visible = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)     // clear button
        {
            erase();
        }

        private void BtnSearch_Click(object sender, EventArgs e)        // serch button
        {
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            TxtID.Visible = false;
            CmbID.Visible = true;
            BtnAdd.Visible = false;
            BtnSearch.Visible = false;
            BtnClose.Visible = true;
            CmbID.Focus();

            try
            {
                String queGetEqID = "SELECT EqID FROM Equipment";       //call all data 
                conn.Open();
                SqlDa = new SqlDataAdapter(queGetEqID, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                conn.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["EqID"]);       // set that data to cmbid
                }



                CmbID.SelectedIndex = 0;



            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)       // add button
        {
            try
            {
                // save data to database
                String queAdd = "INSERT INTO Equipment VALUES('" + TxtID.Text + "','" + TxtName.Text + "','" + TxtCatID.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Equipment " + TxtName.Text + " is added to the database", "Added Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();

            }

            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // load data when select cmb value
                if (CmbID.SelectedIndex > 0)
                {
                    String EqID = CmbID.Text;
                    String queGetDt = "SELECT * FROM Equipment WHERE EqID = '" + EqID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetDt, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtName.Text = R.GetValue(1).ToString();
                        TxtCatID.Text = R.GetValue(2).ToString();  
                    }
                    conn.Close();
                }
                else
                {
                    TxtName.Text = "";
                    TxtCatID.Text = "";
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtName_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)        // update button
        {
            try
            {
                // update data to the table
                String queUpdt = "UPDATE Equipment SET EqName = '" + TxtName.Text + "', CatID = '" + TxtCatID.Text + "' WHERE EqID='" + CmbID.Text + "'";
                conn.Open();
                cmd = new SqlCommand(queUpdt, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Equipment, " + TxtName.Text + ": details update was Successfull !", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)     //close second form
        {
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            TxtID.Visible = true;
            CmbID.Visible = false;
            BtnAdd.Visible = true;
            BtnSearch.Visible = true;
            BtnClose.Visible = false;
            erase();
            TxtID.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)        // delete button
        {
            try
            {
                //delete data from the table
                DialogResult resDel = MessageBox.Show("Do you want to DELETE the record " + CmbID.Text + " from the Database? ", "Confirm to DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    String queDel = "DELETE FROM Equipment WHERE EqID='" + CmbID.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Equipment " + CmbID.Text + " deleted from the database Successfully!", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    erase();
                    CmbID.SelectedIndex = 0;
                    CmbID.Focus();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while Deleting..." + Environment.NewLine + DelErr.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
