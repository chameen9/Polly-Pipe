namespace Polly_Pipe
{
    partial class FrmInsMng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsMng));
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblInsMng = new System.Windows.Forms.Label();
            this.PnlInsMng = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DtpEsEnd = new System.Windows.Forms.DateTimePicker();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.LblEsEnd = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.CmbID = new System.Windows.Forms.ComboBox();
            this.TxtCusID = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLocation = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblCusID = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.TxtEmpId = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtEqId = new System.Windows.Forms.TextBox();
            this.LblQty = new System.Windows.Forms.Label();
            this.LblEqID = new System.Windows.Forms.Label();
            this.LblEmpID = new System.Windows.Forms.Label();
            this.GrpEq = new System.Windows.Forms.GroupBox();
            this.P2BtnAdd = new System.Windows.Forms.Button();
            this.P2BtnDelete = new System.Windows.Forms.Button();
            this.P2BtnClear = new System.Windows.Forms.Button();
            this.GrpEmp = new System.Windows.Forms.GroupBox();
            this.P1BtnAdd = new System.Windows.Forms.Button();
            this.P1BtnDelete = new System.Windows.Forms.Button();
            this.P1BtnClear = new System.Windows.Forms.Button();
            this.PnlInsMng.SuspendLayout();
            this.Pnl2.SuspendLayout();
            this.GrpEq.SuspendLayout();
            this.GrpEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(818, 672);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(232, 34);
            this.BtnBack.TabIndex = 53;
            this.BtnBack.Text = "<< Back to Home Page";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            this.BtnExit.TabIndex = 54;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblInsMng
            // 
            this.LblInsMng.AutoSize = true;
            this.LblInsMng.BackColor = System.Drawing.Color.Transparent;
            this.LblInsMng.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInsMng.ForeColor = System.Drawing.Color.Navy;
            this.LblInsMng.Location = new System.Drawing.Point(345, 53);
            this.LblInsMng.Name = "LblInsMng";
            this.LblInsMng.Size = new System.Drawing.Size(393, 37);
            this.LblInsMng.TabIndex = 26;
            this.LblInsMng.Text = "Installation Management";
            // 
            // PnlInsMng
            // 
            this.PnlInsMng.Controls.Add(this.Pnl2);
            this.PnlInsMng.Controls.Add(this.BtnClose);
            this.PnlInsMng.Controls.Add(this.BtnPrev);
            this.PnlInsMng.Controls.Add(this.BtnNext);
            this.PnlInsMng.Controls.Add(this.BtnSearch);
            this.PnlInsMng.Controls.Add(this.DtpEsEnd);
            this.PnlInsMng.Controls.Add(this.DtpStart);
            this.PnlInsMng.Controls.Add(this.LblEsEnd);
            this.PnlInsMng.Controls.Add(this.CmbType);
            this.PnlInsMng.Controls.Add(this.TxtLocation);
            this.PnlInsMng.Controls.Add(this.BtnAdd);
            this.PnlInsMng.Controls.Add(this.BtnDelete);
            this.PnlInsMng.Controls.Add(this.BtnUpdate);
            this.PnlInsMng.Controls.Add(this.BtnClear);
            this.PnlInsMng.Controls.Add(this.CmbID);
            this.PnlInsMng.Controls.Add(this.TxtCusID);
            this.PnlInsMng.Controls.Add(this.TxtID);
            this.PnlInsMng.Controls.Add(this.LblLocation);
            this.PnlInsMng.Controls.Add(this.LblType);
            this.PnlInsMng.Controls.Add(this.LblStart);
            this.PnlInsMng.Controls.Add(this.LblCusID);
            this.PnlInsMng.Controls.Add(this.LblID);
            this.PnlInsMng.Location = new System.Drawing.Point(113, 108);
            this.PnlInsMng.Name = "PnlInsMng";
            this.PnlInsMng.Size = new System.Drawing.Size(830, 530);
            this.PnlInsMng.TabIndex = 27;
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
            this.BtnClose.TabIndex = 63;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrev.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrev.Location = new System.Drawing.Point(778, 447);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(52, 38);
            this.BtnPrev.TabIndex = 51;
            this.BtnPrev.Text = "<<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(778, 491);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(52, 38);
            this.BtnNext.TabIndex = 50;
            this.BtnNext.Text = ">>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = global::Polly_Pipe.Properties.Resources.search_locate_find_icon_icons_com_67287;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Location = new System.Drawing.Point(748, 27);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnSearch.TabIndex = 52;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DtpEsEnd
            // 
            this.DtpEsEnd.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEsEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEsEnd.Location = new System.Drawing.Point(468, 199);
            this.DtpEsEnd.Name = "DtpEsEnd";
            this.DtpEsEnd.Size = new System.Drawing.Size(232, 30);
            this.DtpEsEnd.TabIndex = 3;
            // 
            // DtpStart
            // 
            this.DtpStart.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStart.Location = new System.Drawing.Point(134, 199);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(232, 30);
            this.DtpStart.TabIndex = 2;
            // 
            // LblEsEnd
            // 
            this.LblEsEnd.AutoSize = true;
            this.LblEsEnd.BackColor = System.Drawing.Color.Transparent;
            this.LblEsEnd.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsEnd.ForeColor = System.Drawing.Color.Black;
            this.LblEsEnd.Location = new System.Drawing.Point(464, 163);
            this.LblEsEnd.Name = "LblEsEnd";
            this.LblEsEnd.Size = new System.Drawing.Size(226, 24);
            this.LblEsEnd.TabIndex = 23;
            this.LblEsEnd.Text = "Estimated End Date";
            // 
            // CmbType
            // 
            this.CmbType.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "--SELECT--",
            "Freshwater Tropical",
            "Freshwater Cold",
            "Marine"});
            this.CmbType.Location = new System.Drawing.Point(418, 90);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(282, 31);
            this.CmbType.TabIndex = 1;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocation.Location = new System.Drawing.Point(248, 265);
            this.TxtLocation.MaxLength = 300;
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(452, 30);
            this.TxtLocation.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(592, 438);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 38);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(442, 438);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 38);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(290, 438);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 38);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(132, 438);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 38);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // CmbID
            // 
            this.CmbID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbID.FormattingEnabled = true;
            this.CmbID.Location = new System.Drawing.Point(207, 90);
            this.CmbID.Name = "CmbID";
            this.CmbID.Size = new System.Drawing.Size(121, 31);
            this.CmbID.TabIndex = 0;
            this.CmbID.Visible = false;
            this.CmbID.SelectedIndexChanged += new System.EventHandler(this.CmbID_SelectedIndexChanged);
            // 
            // TxtCusID
            // 
            this.TxtCusID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCusID.Location = new System.Drawing.Point(297, 341);
            this.TxtCusID.MaxLength = 4;
            this.TxtCusID.Name = "TxtCusID";
            this.TxtCusID.Size = new System.Drawing.Size(100, 30);
            this.TxtCusID.TabIndex = 5;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(207, 90);
            this.TxtID.MaxLength = 5;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 30);
            this.TxtID.TabIndex = 0;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.BackColor = System.Drawing.Color.Transparent;
            this.LblLocation.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocation.ForeColor = System.Drawing.Color.Black;
            this.LblLocation.Location = new System.Drawing.Point(130, 268);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(103, 24);
            this.LblLocation.TabIndex = 24;
            this.LblLocation.Text = "Location";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.BackColor = System.Drawing.Color.Transparent;
            this.LblType.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.ForeColor = System.Drawing.Color.Black;
            this.LblType.Location = new System.Drawing.Point(346, 93);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(63, 24);
            this.LblType.TabIndex = 21;
            this.LblType.Text = "Type";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.BackColor = System.Drawing.Color.Transparent;
            this.LblStart.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.Black;
            this.LblStart.Location = new System.Drawing.Point(130, 163);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(123, 24);
            this.LblStart.TabIndex = 22;
            this.LblStart.Text = "Start Date";
            // 
            // LblCusID
            // 
            this.LblCusID.AutoSize = true;
            this.LblCusID.BackColor = System.Drawing.Color.Transparent;
            this.LblCusID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCusID.ForeColor = System.Drawing.Color.Black;
            this.LblCusID.Location = new System.Drawing.Point(130, 344);
            this.LblCusID.Name = "LblCusID";
            this.LblCusID.Size = new System.Drawing.Size(147, 24);
            this.LblCusID.TabIndex = 25;
            this.LblCusID.Text = "Customer ID";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Black;
            this.LblID.Location = new System.Drawing.Point(130, 93);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(71, 24);
            this.LblID.TabIndex = 20;
            this.LblID.Text = "ID No";
            // 
            // Pnl2
            // 
            this.Pnl2.Controls.Add(this.TxtEmpId);
            this.Pnl2.Controls.Add(this.TxtQty);
            this.Pnl2.Controls.Add(this.TxtEqId);
            this.Pnl2.Controls.Add(this.LblQty);
            this.Pnl2.Controls.Add(this.LblEqID);
            this.Pnl2.Controls.Add(this.LblEmpID);
            this.Pnl2.Controls.Add(this.GrpEq);
            this.Pnl2.Controls.Add(this.GrpEmp);
            this.Pnl2.Location = new System.Drawing.Point(132, 127);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(574, 349);
            this.Pnl2.TabIndex = 66;
            this.Pnl2.Visible = false;
            // 
            // TxtEmpId
            // 
            this.TxtEmpId.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpId.Location = new System.Drawing.Point(318, 120);
            this.TxtEmpId.MaxLength = 4;
            this.TxtEmpId.Name = "TxtEmpId";
            this.TxtEmpId.Size = new System.Drawing.Size(100, 30);
            this.TxtEmpId.TabIndex = 45;
            // 
            // TxtQty
            // 
            this.TxtQty.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(152, 120);
            this.TxtQty.MaxLength = 10;
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(100, 30);
            this.TxtQty.TabIndex = 41;
            // 
            // TxtEqId
            // 
            this.TxtEqId.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEqId.Location = new System.Drawing.Point(26, 120);
            this.TxtEqId.MaxLength = 5;
            this.TxtEqId.Name = "TxtEqId";
            this.TxtEqId.Size = new System.Drawing.Size(100, 30);
            this.TxtEqId.TabIndex = 40;
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.BackColor = System.Drawing.Color.Transparent;
            this.LblQty.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.ForeColor = System.Drawing.Color.Black;
            this.LblQty.Location = new System.Drawing.Point(175, 75);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(49, 24);
            this.LblQty.TabIndex = 23;
            this.LblQty.Text = "Qty";
            // 
            // LblEqID
            // 
            this.LblEqID.AutoSize = true;
            this.LblEqID.BackColor = System.Drawing.Color.Transparent;
            this.LblEqID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEqID.ForeColor = System.Drawing.Color.Black;
            this.LblEqID.Location = new System.Drawing.Point(40, 75);
            this.LblEqID.Name = "LblEqID";
            this.LblEqID.Size = new System.Drawing.Size(70, 24);
            this.LblEqID.TabIndex = 22;
            this.LblEqID.Text = "Eq ID";
            // 
            // LblEmpID
            // 
            this.LblEmpID.AutoSize = true;
            this.LblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.LblEmpID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpID.ForeColor = System.Drawing.Color.Black;
            this.LblEmpID.Location = new System.Drawing.Point(322, 74);
            this.LblEmpID.Name = "LblEmpID";
            this.LblEmpID.Size = new System.Drawing.Size(89, 24);
            this.LblEmpID.TabIndex = 21;
            this.LblEmpID.Text = "Emp ID";
            // 
            // GrpEq
            // 
            this.GrpEq.BackColor = System.Drawing.Color.Transparent;
            this.GrpEq.Controls.Add(this.P2BtnAdd);
            this.GrpEq.Controls.Add(this.P2BtnDelete);
            this.GrpEq.Controls.Add(this.P2BtnClear);
            this.GrpEq.ForeColor = System.Drawing.Color.Black;
            this.GrpEq.Location = new System.Drawing.Point(15, 21);
            this.GrpEq.Name = "GrpEq";
            this.GrpEq.Size = new System.Drawing.Size(249, 306);
            this.GrpEq.TabIndex = 29;
            this.GrpEq.TabStop = false;
            this.GrpEq.Text = "Equipments";
            // 
            // P2BtnAdd
            // 
            this.P2BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P2BtnAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.P2BtnAdd.Location = new System.Drawing.Point(11, 232);
            this.P2BtnAdd.Name = "P2BtnAdd";
            this.P2BtnAdd.Size = new System.Drawing.Size(100, 38);
            this.P2BtnAdd.TabIndex = 44;
            this.P2BtnAdd.Text = "Add";
            this.P2BtnAdd.UseVisualStyleBackColor = true;
            // 
            // P2BtnDelete
            // 
            this.P2BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P2BtnDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.P2BtnDelete.Location = new System.Drawing.Point(137, 165);
            this.P2BtnDelete.Name = "P2BtnDelete";
            this.P2BtnDelete.Size = new System.Drawing.Size(100, 38);
            this.P2BtnDelete.TabIndex = 43;
            this.P2BtnDelete.Text = "Delete";
            this.P2BtnDelete.UseVisualStyleBackColor = true;
            // 
            // P2BtnClear
            // 
            this.P2BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P2BtnClear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2BtnClear.ForeColor = System.Drawing.Color.Black;
            this.P2BtnClear.Location = new System.Drawing.Point(11, 165);
            this.P2BtnClear.Name = "P2BtnClear";
            this.P2BtnClear.Size = new System.Drawing.Size(100, 38);
            this.P2BtnClear.TabIndex = 42;
            this.P2BtnClear.Text = "Clear";
            this.P2BtnClear.UseVisualStyleBackColor = true;
            // 
            // GrpEmp
            // 
            this.GrpEmp.BackColor = System.Drawing.Color.Transparent;
            this.GrpEmp.Controls.Add(this.P1BtnAdd);
            this.GrpEmp.Controls.Add(this.P1BtnDelete);
            this.GrpEmp.Controls.Add(this.P1BtnClear);
            this.GrpEmp.ForeColor = System.Drawing.Color.Black;
            this.GrpEmp.Location = new System.Drawing.Point(306, 21);
            this.GrpEmp.Name = "GrpEmp";
            this.GrpEmp.Size = new System.Drawing.Size(249, 306);
            this.GrpEmp.TabIndex = 30;
            this.GrpEmp.TabStop = false;
            this.GrpEmp.Text = "Employees";
            // 
            // P1BtnAdd
            // 
            this.P1BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P1BtnAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.P1BtnAdd.Location = new System.Drawing.Point(12, 232);
            this.P1BtnAdd.Name = "P1BtnAdd";
            this.P1BtnAdd.Size = new System.Drawing.Size(100, 38);
            this.P1BtnAdd.TabIndex = 48;
            this.P1BtnAdd.Text = "Add";
            this.P1BtnAdd.UseVisualStyleBackColor = true;
            // 
            // P1BtnDelete
            // 
            this.P1BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P1BtnDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.P1BtnDelete.Location = new System.Drawing.Point(139, 165);
            this.P1BtnDelete.Name = "P1BtnDelete";
            this.P1BtnDelete.Size = new System.Drawing.Size(100, 38);
            this.P1BtnDelete.TabIndex = 47;
            this.P1BtnDelete.Text = "Delete";
            this.P1BtnDelete.UseVisualStyleBackColor = true;
            // 
            // P1BtnClear
            // 
            this.P1BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P1BtnClear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1BtnClear.ForeColor = System.Drawing.Color.Black;
            this.P1BtnClear.Location = new System.Drawing.Point(12, 165);
            this.P1BtnClear.Name = "P1BtnClear";
            this.P1BtnClear.Size = new System.Drawing.Size(100, 38);
            this.P1BtnClear.TabIndex = 46;
            this.P1BtnClear.Text = "Clear";
            this.P1BtnClear.UseVisualStyleBackColor = true;
            // 
            // FrmInsMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Polly_Pipe.Properties.Resources.Backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 743);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblInsMng);
            this.Controls.Add(this.PnlInsMng);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInsMng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polly Pipe | Installation Management";
            this.Load += new System.EventHandler(this.FrmInsMng_Load);
            this.PnlInsMng.ResumeLayout(false);
            this.PnlInsMng.PerformLayout();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            this.GrpEq.ResumeLayout(false);
            this.GrpEmp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblInsMng;
        private System.Windows.Forms.Panel PnlInsMng;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ComboBox CmbID;
        private System.Windows.Forms.TextBox TxtCusID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblCusID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.DateTimePicker DtpEsEnd;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.Label LblEsEnd;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.TextBox TxtEmpId;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtEqId;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Label LblEqID;
        private System.Windows.Forms.Label LblEmpID;
        private System.Windows.Forms.GroupBox GrpEq;
        private System.Windows.Forms.Button P2BtnAdd;
        private System.Windows.Forms.Button P2BtnDelete;
        private System.Windows.Forms.Button P2BtnClear;
        private System.Windows.Forms.GroupBox GrpEmp;
        private System.Windows.Forms.Button P1BtnAdd;
        private System.Windows.Forms.Button P1BtnDelete;
        private System.Windows.Forms.Button P1BtnClear;
    }
}