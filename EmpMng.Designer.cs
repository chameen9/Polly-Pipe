namespace Polly_Pipe
{
    partial class FrmEmpMng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpMng));
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlEmpMng = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbID = new System.Windows.Forms.ComboBox();
            this.DtpRelease = new System.Windows.Forms.DateTimePicker();
            this.LblRelease = new System.Windows.Forms.Label();
            this.DtpAssign = new System.Windows.Forms.DateTimePicker();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtNIC = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblAssign = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblContact = new System.Windows.Forms.Label();
            this.LblNIC = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblEmpMng = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlEmpMng.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::Polly_Pipe.Properties.Resources.delete_delete_exit_1577;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(1007, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(40, 40);
            this.BtnExit.TabIndex = 30;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlEmpMng
            // 
            this.PnlEmpMng.Controls.Add(this.BtnClose);
            this.PnlEmpMng.Controls.Add(this.CmbStatus);
            this.PnlEmpMng.Controls.Add(this.BtnSearch);
            this.PnlEmpMng.Controls.Add(this.BtnAdd);
            this.PnlEmpMng.Controls.Add(this.BtnDelete);
            this.PnlEmpMng.Controls.Add(this.BtnUpdate);
            this.PnlEmpMng.Controls.Add(this.BtnClear);
            this.PnlEmpMng.Controls.Add(this.LblStatus);
            this.PnlEmpMng.Controls.Add(this.CmbType);
            this.PnlEmpMng.Controls.Add(this.CmbID);
            this.PnlEmpMng.Controls.Add(this.DtpRelease);
            this.PnlEmpMng.Controls.Add(this.LblRelease);
            this.PnlEmpMng.Controls.Add(this.DtpAssign);
            this.PnlEmpMng.Controls.Add(this.TxtContact);
            this.PnlEmpMng.Controls.Add(this.TxtGender);
            this.PnlEmpMng.Controls.Add(this.TxtName);
            this.PnlEmpMng.Controls.Add(this.TxtNIC);
            this.PnlEmpMng.Controls.Add(this.TxtID);
            this.PnlEmpMng.Controls.Add(this.LblAssign);
            this.PnlEmpMng.Controls.Add(this.LblName);
            this.PnlEmpMng.Controls.Add(this.LblGender);
            this.PnlEmpMng.Controls.Add(this.LblType);
            this.PnlEmpMng.Controls.Add(this.LblContact);
            this.PnlEmpMng.Controls.Add(this.LblNIC);
            this.PnlEmpMng.Controls.Add(this.LblID);
            this.PnlEmpMng.Location = new System.Drawing.Point(113, 108);
            this.PnlEmpMng.Name = "PnlEmpMng";
            this.PnlEmpMng.Size = new System.Drawing.Size(830, 530);
            this.PnlEmpMng.TabIndex = 27;
            this.PnlEmpMng.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlEmpMng_Paint);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = global::Polly_Pipe.Properties.Resources.Windows_Close_Program_22531;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(748, 27);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 40);
            this.BtnClose.TabIndex = 29;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CmbStatus
            // 
            this.CmbStatus.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "-Selecet-",
            "Active",
            "Reserved"});
            this.CmbStatus.Location = new System.Drawing.Point(219, 397);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(132, 31);
            this.CmbStatus.TabIndex = 10;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = global::Polly_Pipe.Properties.Resources.search_locate_find_icon_icons_com_67287;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(748, 27);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(593, 449);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 38);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(443, 449);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 38);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(291, 449);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 38);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(133, 449);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 38);
            this.BtnClear.TabIndex = 12;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(132, 400);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(94, 24);
            this.LblStatus.TabIndex = 28;
            this.LblStatus.Text = "Status :";
            // 
            // CmbType
            // 
            this.CmbType.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "--Select--",
            "Plumber",
            "Installation Manager",
            "Aquatics installer",
            "Brick Layer"});
            this.CmbType.Location = new System.Drawing.Point(482, 242);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(219, 31);
            this.CmbType.TabIndex = 7;
            // 
            // CmbID
            // 
            this.CmbID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbID.FormattingEnabled = true;
            this.CmbID.Location = new System.Drawing.Point(208, 100);
            this.CmbID.Name = "CmbID";
            this.CmbID.Size = new System.Drawing.Size(121, 31);
            this.CmbID.TabIndex = 1;
            this.CmbID.Visible = false;
            this.CmbID.SelectedIndexChanged += new System.EventHandler(this.CmbID_SelectedIndexChanged);
            // 
            // DtpRelease
            // 
            this.DtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRelease.Location = new System.Drawing.Point(501, 339);
            this.DtpRelease.Name = "DtpRelease";
            this.DtpRelease.Size = new System.Drawing.Size(200, 22);
            this.DtpRelease.TabIndex = 9;
            // 
            // LblRelease
            // 
            this.LblRelease.AutoSize = true;
            this.LblRelease.BackColor = System.Drawing.Color.Transparent;
            this.LblRelease.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelease.ForeColor = System.Drawing.Color.White;
            this.LblRelease.Location = new System.Drawing.Point(497, 312);
            this.LblRelease.Name = "LblRelease";
            this.LblRelease.Size = new System.Drawing.Size(154, 24);
            this.LblRelease.TabIndex = 27;
            this.LblRelease.Text = "Release Date";
            this.LblRelease.Click += new System.EventHandler(this.label10_Click);
            // 
            // DtpAssign
            // 
            this.DtpAssign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAssign.Location = new System.Drawing.Point(136, 339);
            this.DtpAssign.Name = "DtpAssign";
            this.DtpAssign.Size = new System.Drawing.Size(200, 22);
            this.DtpAssign.TabIndex = 8;
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(521, 170);
            this.TxtContact.MaxLength = 10;
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(180, 30);
            this.TxtContact.TabIndex = 4;
            // 
            // TxtGender
            // 
            this.TxtGender.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGender.Location = new System.Drawing.Point(236, 243);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(100, 30);
            this.TxtGender.TabIndex = 5;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(419, 101);
            this.TxtName.MaxLength = 128;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(282, 30);
            this.TxtName.TabIndex = 2;
            // 
            // TxtNIC
            // 
            this.TxtNIC.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNIC.Location = new System.Drawing.Point(208, 173);
            this.TxtNIC.MaxLength = 12;
            this.TxtNIC.Name = "TxtNIC";
            this.TxtNIC.Size = new System.Drawing.Size(159, 30);
            this.TxtNIC.TabIndex = 3;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(208, 101);
            this.TxtID.MaxLength = 4;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 30);
            this.TxtID.TabIndex = 0;
            // 
            // LblAssign
            // 
            this.LblAssign.AutoSize = true;
            this.LblAssign.BackColor = System.Drawing.Color.Transparent;
            this.LblAssign.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAssign.ForeColor = System.Drawing.Color.White;
            this.LblAssign.Location = new System.Drawing.Point(131, 312);
            this.LblAssign.Name = "LblAssign";
            this.LblAssign.Size = new System.Drawing.Size(140, 24);
            this.LblAssign.TabIndex = 26;
            this.LblAssign.Text = "Assign Date";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(347, 104);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 24);
            this.LblName.TabIndex = 21;
            this.LblName.Text = "Name";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.ForeColor = System.Drawing.Color.White;
            this.LblGender.Location = new System.Drawing.Point(131, 246);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(88, 24);
            this.LblGender.TabIndex = 24;
            this.LblGender.Text = "Gender";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.BackColor = System.Drawing.Color.Transparent;
            this.LblType.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.ForeColor = System.Drawing.Color.White;
            this.LblType.Location = new System.Drawing.Point(413, 246);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(63, 24);
            this.LblType.TabIndex = 25;
            this.LblType.Text = "Type";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.BackColor = System.Drawing.Color.Transparent;
            this.LblContact.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact.ForeColor = System.Drawing.Color.White;
            this.LblContact.Location = new System.Drawing.Point(410, 173);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(96, 24);
            this.LblContact.TabIndex = 23;
            this.LblContact.Text = "Contact";
            // 
            // LblNIC
            // 
            this.LblNIC.AutoSize = true;
            this.LblNIC.BackColor = System.Drawing.Color.Transparent;
            this.LblNIC.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNIC.ForeColor = System.Drawing.Color.White;
            this.LblNIC.Location = new System.Drawing.Point(131, 176);
            this.LblNIC.Name = "LblNIC";
            this.LblNIC.Size = new System.Drawing.Size(50, 24);
            this.LblNIC.TabIndex = 22;
            this.LblNIC.Text = "NIC";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(131, 104);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(71, 24);
            this.LblID.TabIndex = 20;
            this.LblID.Text = "ID No";
            // 
            // LblEmpMng
            // 
            this.LblEmpMng.AutoSize = true;
            this.LblEmpMng.BackColor = System.Drawing.Color.Transparent;
            this.LblEmpMng.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpMng.ForeColor = System.Drawing.Color.Navy;
            this.LblEmpMng.Location = new System.Drawing.Point(328, 48);
            this.LblEmpMng.Name = "LblEmpMng";
            this.LblEmpMng.Size = new System.Drawing.Size(383, 37);
            this.LblEmpMng.TabIndex = 14;
            this.LblEmpMng.Text = "Employee Management";
            // 
            // BtnBack
            // 
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(818, 672);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(232, 34);
            this.BtnBack.TabIndex = 31;
            this.BtnBack.Text = "<< Back to Home Page";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmEmpMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Polly_Pipe.Properties.Resources.Backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 743);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblEmpMng);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PnlEmpMng);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEmpMng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polly Pipe | Employee Management";
            this.Load += new System.EventHandler(this.FrmEmpMng_Load);
            this.PnlEmpMng.ResumeLayout(false);
            this.PnlEmpMng.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlEmpMng;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNIC;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblAssign;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.Label LblNIC;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Label LblEmpMng;
        private System.Windows.Forms.ComboBox CmbID;
        private System.Windows.Forms.DateTimePicker DtpRelease;
        private System.Windows.Forms.Label LblRelease;
        private System.Windows.Forms.DateTimePicker DtpAssign;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Button BtnClose;
    }
}