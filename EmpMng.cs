using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // need to connect with sql

namespace Polly_Pipe
{
    public partial class FrmEmpMng : Form
    {
        public FrmEmpMng()
        {
            InitializeComponent();
        }


                            // SQL connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=CHVM2EN;Initial Catalog=PollyPipe;Integrated Security=True");

        private void erase()   // clear function
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtNIC.Text = "";
            TxtGender.Text = "";
            TxtContact.Text = "";
            CmbID.Text = "";
            CmbType.SelectedIndex = 0;
            DtpAssign.Value = DateTime.Now;
            DtpRelease.Value = DateTime.Now;
            CmbStatus.SelectedIndex = 0;
            TxtID.Focus();
        }


        private void button1_Click(object sender, EventArgs e)   // exit button
        {
            DialogResult resExit = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmpMng_Load(object sender, EventArgs e)
        {
            PnlEmpMng.BackColor = Color.FromArgb(50, 0, 0, 0);  // to make panel transparent
        }

        private void PnlEmpMng_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)      // to go back (load main form)
        {
            erase();
            new FrmMain().Show();
            this.Visible = false;
        }


        private void BtnClear_Click(object sender, EventArgs e)     // erase button
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
            erase();

            try
            {
                String queGetEmpID = "SELECT EmpID FROM Employee";      // calling data from database
                conn.Open();
                SqlDa = new SqlDataAdapter(queGetEmpID, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                conn.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["EmpID"]);      // set that data to the cmb id 
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
                // adding data to the table
                String queAdd = "INSERT INTO Employee VALUES('" + TxtID.Text + "','" + TxtName.Text + "','" + TxtNIC.Text + "','" + TxtContact.Text + "','" + DtpAssign.Text + "','" + DtpRelease.Text + "','" + TxtGender.Text + "','" + CmbType.Text + "','" + CmbStatus.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee " + TxtName.Text + " is added to the database !", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();


            }
            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LblSts_Click(object sender, EventArgs e)
        {

        }

        private void LblTime_Click(object sender, EventArgs e)
        {

        }

        private void LblDtime_Click(object sender, EventArgs e)
        {

        }

        private void DtpDtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // calling all data when cahnging tab index in cmb id
                if (CmbID.SelectedIndex > 0)
                {
                    String EmpID = CmbID.Text;
                    String queGetDt = "SELECT * FROM Employee WHERE EmpID = '" + EmpID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetDt, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtName.Text = R.GetValue(1).ToString();
                        TxtNIC.Text = R.GetValue(2).ToString();
                        TxtContact.Text = R.GetValue(3).ToString();
                        DtpAssign.Text = R.GetValue(4).ToString();
                        DtpRelease.Text = R.GetValue(5).ToString();
                        TxtGender.Text = R.GetValue(6).ToString();
                        CmbType.Text = R.GetValue(7).ToString();
                        CmbStatus.Text = R.GetValue(8).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    TxtName.Text = "";
                    TxtNIC.Text = "";
                    TxtContact.Text = "";
                    DtpAssign.Text = "";
                    DtpRelease.Text = "";
                    TxtGender.Text = "";
                    CmbType.Text = "";
                    CmbStatus.Text = "";
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)        // update button
        {
            try
            {
                // update data to the table
                String queUpdt = "UPDATE Employee SET EmpName = '" + TxtName.Text + "', NIC = '" + TxtNIC.Text + "', Contact = '" + TxtContact.Text + "' , AssignDate = '" + DtpAssign.Text + "' , ReleaseDate = '" + DtpRelease.Text + "' , Gender = '" + TxtGender.Text + "', Type = '" + CmbType.Text + "', Status = '" + CmbStatus.Text + "' WHERE EmpID='" + CmbID.Text + "'";
                conn.Open();
                cmd = new SqlCommand(queUpdt, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee, " + TxtName.Text + "'s details update was Successfull !", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)        // delete button
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Do you want to DELETE the record " + CmbID.Text + " from the Database? ","Confirm to DELETE", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {

                    // delete data from the table
                    String queDel = "DELETE FROM Employee WHERE EmpID='"+ CmbID.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Employee " + CmbID.Text + " deleted from the database Successfully!","DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    erase();
                    CmbID.SelectedIndex = 0;
                    CmbType.SelectedIndex = 0;
                    CmbID.Focus();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while Deleting..." +Environment.NewLine + DelErr.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)     //load emp mng form again
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
    }
}
