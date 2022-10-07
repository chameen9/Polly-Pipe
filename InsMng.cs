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
    public partial class FrmInsMng : Form
    {
        public FrmInsMng()
        {
            InitializeComponent();
        }
                                                        // sql connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=CHVM2EN;Initial Catalog=PollyPipe;Integrated Security=True");

        private void erase ()       //clear function
        {
            TxtID.Text = "";
            CmbType.Text = "";
            TxtLocation.Text = "";
            TxtCusID.Text = "";
            CmbType.SelectedIndex = 0;
            DtpStart.Value = DateTime.Now;
            DtpEsEnd.Value = DateTime.Now;
            TxtID.Focus();
        }

        private void FrmInsMng_Load(object sender, EventArgs e)     // set two panels colour to transparent
        {
            PnlInsMng.BackColor = Color.FromArgb(50, 0, 0, 0);
            Pnl2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void BtnExit_Click(object sender, EventArgs e)      // exit button
        {
            DialogResult resExit = MessageBox.Show("Are you sure, You want to Exit???", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)      // load main form
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
                String queGetInsID = "SELECT InsID FROM Installation";      // load all ins ids to cmb id
                conn.Open();
                SqlDa = new SqlDataAdapter(queGetInsID, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                conn.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["InsID"]);      // set all ids to cmb values
                }

                CmbID.SelectedIndex = 0;

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)       // add button
        {
            try
            {
                // save all data to the database
                String queAdd = "INSERT INTO Installation VALUES('" + TxtID.Text + "','" + CmbType.Text + "','" + TxtLocation.Text + "','" + DtpStart.Text + "','" + DtpEsEnd.Text + "','" + TxtCusID.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Installation " + TxtID.Text + " is added to the database", "Added Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();

            }

            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)      // load second panel
        {
            Pnl2.Visible = true;
            LblType.Visible = false;
            CmbType.Visible = false;
            LblStart.Visible = false;
            DtpStart.Visible = false;
            LblEsEnd.Visible = false;
            DtpEsEnd.Visible = false;
            LblLocation.Visible = false;
            TxtLocation.Visible = false;
            LblCusID.Visible = false;
            TxtCusID.Visible = false;
            BtnAdd.Visible = false;
            BtnClear.Visible = false;
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            BtnSearch.Visible = false;
            TxtEqId.Focus();
        }

        private void BtnPrev_Click(object sender, EventArgs e)      // hide second panel
        {
            Pnl2.Visible = false;
            LblType.Visible = true;
            CmbType.Visible = true;
            LblStart.Visible = true;
            DtpStart.Visible = true;
            LblEsEnd.Visible = true;
            DtpEsEnd.Visible = true;
            LblLocation.Visible = true;
            TxtLocation.Visible = true;
            LblCusID.Visible = true;
            TxtCusID.Visible = true;
            BtnAdd.Visible = true;
            BtnClear.Visible = true;
            BtnDelete.Visible = true;
            BtnUpdate.Visible = true;
            BtnSearch.Visible = true;
            TxtID.Text = "";
            TxtEqId.Focus();
            
        }

        private void P2BtnClear_Click(object sender, EventArgs e)       // ins eq clear button
        {
            TxtEqId.Text = "";
            TxtQty.Text = "";
            TxtEqId.Focus();
        }

        private void P2BtnDelete_Click(object sender, EventArgs e)      // ins eq delete button
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Do you want to DELETE the record " + TxtEqId.Text + " from the Database? ", "Confirm to DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    String queDel = "DELETE FROM Installation_Equipment WHERE EmpID='" + TxtEqId.Text + "'";        //delete all data from table
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Equipment " + TxtEqId.Text + " deleted from the database Successfully!", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void P2BtnAdd_Click(object sender, EventArgs e)     // ins eq add button
        {
            try
            {
                // save data to the table
                String queAdd3 = "INSERT INTO Installation_Equipment VALUES('" + TxtQty.Text + "','" + TxtEqId.Text + "','" + TxtID.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd3, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Equipment is added to the database with " + TxtID.Text + " InsID", "Added Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEqId.Text = "";
                TxtQty.Text = "";
                TxtEqId.Focus();

            }

            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void P1BtnClear_Click(object sender, EventArgs e)       // ins em clear button
        {
            TxtEmpId.Text = "";
            TxtEmpId.Focus();
        }

        private void P1BtnDelete_Click(object sender, EventArgs e)      // ins em delete button
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Do you want to DELETE the record " + TxtEmpId.Text + " from the Database? ", "Confirm to DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    // delete data from the table
                    String queDel = "DELETE FROM Installation_Employee WHERE EmpID='" + TxtEmpId.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Employee " + TxtEmpId.Text + " deleted from the database Successfully!", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void P1BtnAdd_Click(object sender, EventArgs e)     // ins em add button
        {
            try
            {
                // save data to the table
                String queAdd2 = "INSERT INTO Installation_Employee VALUES('" + TxtEmpId.Text + "','" + TxtID.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd2, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee is added to the database with " + TxtID.Text + " InsID", "Added Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmpId.Text = "";
                TxtEmpId.Focus();
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
                // load installation details to the form with cmbid
                if (CmbID.SelectedIndex > 0)
                {
                    String InsID = CmbID.Text;
                    String queGetDt = "SELECT * FROM Installation WHERE InsID = '" + InsID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetDt, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {
                        CmbType.Text = R.GetValue(1).ToString();
                        TxtLocation.Text = R.GetValue(2).ToString();
                        DtpStart.Text = R.GetValue(3).ToString();
                        DtpEsEnd.Text = R.GetValue(4).ToString();
                        TxtCusID.Text = R.GetValue(5).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    CmbType.Text = "";
                    TxtLocation.Text = "";
                    DtpStart.Text = "";
                    DtpEsEnd.Text = "";
                    TxtCusID.Text = "";
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
                // update data in the table
                String queUpdt = "UPDATE Installation SET InsType = '" + CmbType.Text + "', Location = '" + TxtLocation.Text + "', StartDate = '" + DtpStart.Text + "' , EsEndDate = '" + DtpEsEnd.Text + "' , CusID = '" + TxtCusID.Text + "' WHERE InsID='" + CmbID.Text + "'";
                conn.Open();
                cmd = new SqlCommand(queUpdt, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Installation " + CmbID.Text + ": Installation details update was Successfull !", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbID.SelectedIndex = 0;
                erase();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)     // close second panel
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
                    String queDel = "DELETE FROM Installation WHERE InsID='" + CmbID.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Installation " + CmbID.Text + " deleted from the database Successfully!", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    erase();
                    CmbID.SelectedIndex = 0;
                    CmbType.SelectedIndex = 0;
                    CmbID.Focus();
                }
            }
            catch (Exception DelErr)
            {
                MessageBox.Show("Error while Deleting..." + Environment.NewLine + DelErr.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrpEq_Enter(object sender, EventArgs e)
        {

        }
    }
}