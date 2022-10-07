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
    public partial class FrmCatMng : Form
    {
        public FrmCatMng()
        {
            InitializeComponent();
        }

        // sql connection
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=CHVM2EN;Initial Catalog=PollyPipe;Integrated Security=True");

        private void erase()        // clear function
        {
            TxtID.Text = " ";
            TxtType.Text = " ";
            CmbID.Text = " ";
        }

        private void FrmCatMng_Load(object sender, EventArgs e)
        {
            PnlCatMng.BackColor = Color.FromArgb(50, 0, 0, 0);      // set panel colour to transparent
        }

        private void BtnPrevious_Click(object sender, EventArgs e)      // load eq mng form
        {
            erase();
            new FrmEqMng().Show();
            this.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)      // load main form
        {
            erase();
            new FrmMain().Show();
            this.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)        // button search
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
                String queGetCatID = "SELECT CatID FROM EquipCateg";        //load all data from table
                conn.Open();
                SqlDa = new SqlDataAdapter(queGetCatID, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                conn.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");        // set ids to cmb values
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["CatID"]);
                }

                CmbID.SelectedIndex = 0;

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void BtnAdd_Click(object sender, EventArgs e)       // add button
        {
            try
            {
                // save data to the database
                String queAdd = "INSERT INTO EquipCateg VALUES('" + TxtID.Text + "','" + TxtType.Text + "')";
                conn.Open();
                cmd = new SqlCommand(queAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Category " + TxtID.Text + " is added to the database", "Added Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // set all data to the form using cmb id
                if (CmbID.SelectedIndex > 0)
                {
                    String CatID = CmbID.Text;
                    String queGetDt = "SELECT * FROM EquipCateg WHERE CatID = '" + CatID + "'";
                    conn.Open();
                    cmd = new SqlCommand(queGetDt, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtType.Text = R.GetValue(1).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    TxtType.Text = "";
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
                // update the table
                String queUpdt = "UPDATE EquipCateg SET Type = '" + TxtType.Text + "' WHERE CatID='" + CmbID.Text + "'";
                conn.Open();
                cmd = new SqlCommand(queUpdt, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Category, " + TxtType.Text + ": details update was Successfull !", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erase();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)     // close the serch window
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
                // delete data from the table
                DialogResult resDel = MessageBox.Show("Do you want to DELETE the record " + CmbID.Text + " from the Database? ", "Confirm to DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    String queDel = "DELETE FROM EquipCateg WHERE CatID='" + CmbID.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Category " + CmbID.Text + " deleted from the database Successfully!", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
