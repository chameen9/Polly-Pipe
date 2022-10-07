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
    public partial class FrmCusMng : Form
    {
        public FrmCusMng()
        {
            InitializeComponent();
        }
                            // sql connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=CHVM2EN;Initial Catalog=PollyPipe;Integrated Security=True");

        private void erase () {     // clear function
            TxtID.Text = "";
            TxtName.Text = "";
            TxtNIC.Text = "";
            TxtGender.Text = "";
            TxtContact.Text = "";
            TxtAddress.Text = "";
            TxtEmail.Text = "";
            CmbID.Text = "";
            TxtID.Focus();
            
            }

        private void FrmCusMng_Load(object sender, EventArgs e)
        {
            PnlCusMng.BackColor = Color.FromArgb(80, 50, 50, 50);       // to change panel colour to transparent
        }

        private void BtnExit_Click(object sender, EventArgs e)      //exit button
        {
            DialogResult resExit = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)      // to load main form
        {
            erase();
            new FrmMain().Show();
            this.Visible = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)     // clear button
        {
            erase();
        }

        private void BtnSearch_Click(object sender, EventArgs e)        // search button
        {
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            TxtID.Visible = false;
            CmbID.Visible = true;
            BtnAdd.Visible = false;
            BtnClose.Visible = true;
            BtnSearch.Visible = false;
            CmbID.Focus();

            try
            {
                String queGetCusID = "SELECT CusID FROM Customer";      // calling customer id to the cmb
                conn.Open();
                SqlDa = new SqlDataAdapter(queGetCusID, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                conn.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["CusID"]);      // add cus ids to the cmbid
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
                // save data to the table
                String queAdd = "INSERT INTO Customer VALUES('" + TxtID.Text + "','" + TxtName.Text + "','" + TxtNIC.Text + "','" + TxtGender.Text + "','" + TxtContact.Text + "','" + TxtAddress.Text + "','" + TxtEmail.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer " + TxtName.Text + " is added to the database", "Added Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // load all table data to the form by using cmmb id
                if (CmbID.SelectedIndex > 0)
                {
                    String CusID = CmbID.Text;
                    String queGetDt = "SELECT * FROM Customer WHERE CusID = '" + CusID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetDt, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtName.Text = R.GetValue(1).ToString();
                        TxtNIC.Text = R.GetValue(2).ToString();
                        TxtGender.Text = R.GetValue(3).ToString();
                        TxtContact.Text = R.GetValue(4).ToString();
                        TxtAddress.Text = R.GetValue(5).ToString();
                        TxtEmail.Text = R.GetValue(6).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    TxtName.Text = "";
                    TxtNIC.Text = "";
                    TxtGender.Text = "";
                    TxtContact.Text = "";
                    TxtAddress.Text = "";
                    TxtEmail.Text = "";
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // update data to the table
                String queUpdt = "UPDATE Customer SET CusName = '" + TxtName.Text + "', NIC = '" + TxtNIC.Text + "', Gender = '" + TxtGender.Text + "' , Contact = '" + TxtContact.Text + "' , Address = '" + TxtAddress.Text + "' , Email = '" + TxtEmail.Text + "' WHERE CusID='" + CmbID.Text + "'";
                conn.Open();
                cmd = new SqlCommand(queUpdt, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer, " + TxtName.Text + "'s details update was Successfull !", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)     //close button in panel
        {
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            TxtID.Visible = true;
            CmbID.Visible = false;
            BtnAdd.Visible = true;
            BtnClose.Visible = false;
            BtnSearch.Visible = true;
            erase();
            TxtID.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)        // delete button
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Do you want to DELETE the record " + CmbID.Text + " from the Database? ", "Confirm to DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    String queDel = "DELETE FROM Customer WHERE CusID='" + CmbID.Text + "'";        // delete data from the tabale
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Customer " + CmbID.Text + " deleted from the database Successfully!", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
