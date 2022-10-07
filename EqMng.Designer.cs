namespace Polly_Pipe
{
    partial class FrmEqMng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEqMng));
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblEqMng = new System.Windows.Forms.Label();
            this.PnlEqMng = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TxtCatID = new System.Windows.Forms.TextBox();
            this.LblCatID = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.CmbID = new System.Windows.Forms.ComboBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblEnter = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PnlEqMng.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(818, 672);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(232, 34);
            this.BtnBack.TabIndex = 21;
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
            this.BtnExit.TabIndex = 20;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblEqMng
            // 
            this.LblEqMng.AutoSize = true;
            this.LblEqMng.BackColor = System.Drawing.Color.Transparent;
            this.LblEqMng.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEqMng.ForeColor = System.Drawing.Color.Navy;
            this.LblEqMng.Location = new System.Drawing.Point(345, 53);
            this.LblEqMng.Name = "LblEqMng";
            this.LblEqMng.Size = new System.Drawing.Size(394, 37);
            this.LblEqMng.TabIndex = 10;
            this.LblEqMng.Text = "Equipment Management";
            // 
            // PnlEqMng
            // 
            this.PnlEqMng.Controls.Add(this.BtnSearch);
            this.PnlEqMng.Controls.Add(this.BtnClose);
            this.PnlEqMng.Controls.Add(this.TxtName);
            this.PnlEqMng.Controls.Add(this.BtnEnter);
            this.PnlEqMng.Controls.Add(this.TxtCatID);
            this.PnlEqMng.Controls.Add(this.LblCatID);
            this.PnlEqMng.Controls.Add(this.BtnAdd);
            this.PnlEqMng.Controls.Add(this.BtnDelete);
            this.PnlEqMng.Controls.Add(this.BtnUpdate);
            this.PnlEqMng.Controls.Add(this.BtnClear);
            this.PnlEqMng.Controls.Add(this.CmbID);
            this.PnlEqMng.Controls.Add(this.TxtID);
            this.PnlEqMng.Controls.Add(this.LblEnter);
            this.PnlEqMng.Controls.Add(this.LblName);
            this.PnlEqMng.Controls.Add(this.LblID);
            this.PnlEqMng.Location = new System.Drawing.Point(113, 108);
            this.PnlEqMng.Name = "PnlEqMng";
            this.PnlEqMng.Size = new System.Drawing.Size(830, 530);
            this.PnlEqMng.TabIndex = 15;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = global::Polly_Pipe.Properties.Resources.Windows_Close_Program_22531;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(733, 30);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 40);
            this.BtnClose.TabIndex = 64;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(418, 116);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(282, 30);
            this.TxtName.TabIndex = 2;
            this.TxtName.TabIndexChanged += new System.EventHandler(this.TxtName_TabIndexChanged);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.Teal;
            this.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnter.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEnter.Location = new System.Drawing.Point(592, 375);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(108, 38);
            this.BtnEnter.TabIndex = 8;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TxtCatID
            // 
            this.TxtCatID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCatID.Location = new System.Drawing.Point(297, 181);
            this.TxtCatID.MaxLength = 4;
            this.TxtCatID.Name = "TxtCatID";
            this.TxtCatID.Size = new System.Drawing.Size(100, 30);
            this.TxtCatID.TabIndex = 3;
            this.TxtCatID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblCatID
            // 
            this.LblCatID.AutoSize = true;
            this.LblCatID.BackColor = System.Drawing.Color.Transparent;
            this.LblCatID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCatID.ForeColor = System.Drawing.Color.White;
            this.LblCatID.Location = new System.Drawing.Point(130, 184);
            this.LblCatID.Name = "LblCatID";
            this.LblCatID.Size = new System.Drawing.Size(139, 24);
            this.LblCatID.TabIndex = 13;
            this.LblCatID.Text = "Category ID";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(592, 254);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 38);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(442, 254);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 38);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(290, 254);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 38);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(132, 254);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 38);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // CmbID
            // 
            this.CmbID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbID.FormattingEnabled = true;
            this.CmbID.Location = new System.Drawing.Point(207, 116);
            this.CmbID.Name = "CmbID";
            this.CmbID.Size = new System.Drawing.Size(121, 31);
            this.CmbID.TabIndex = 1;
            this.CmbID.Visible = false;
            this.CmbID.SelectedIndexChanged += new System.EventHandler(this.CmbID_SelectedIndexChanged);
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(207, 116);
            this.TxtID.MaxLength = 5;
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 30);
            this.TxtID.TabIndex = 0;
            // 
            // LblEnter
            // 
            this.LblEnter.AutoSize = true;
            this.LblEnter.BackColor = System.Drawing.Color.Transparent;
            this.LblEnter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnter.ForeColor = System.Drawing.Color.White;
            this.LblEnter.Location = new System.Drawing.Point(130, 386);
            this.LblEnter.Name = "LblEnter";
            this.LblEnter.Size = new System.Drawing.Size(356, 20);
            this.LblEnter.TabIndex = 14;
            this.LblEnter.Text = "Click Enter to View Manage Category";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(346, 119);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 24);
            this.LblName.TabIndex = 12;
            this.LblName.Text = "Name";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(130, 119);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(71, 24);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID No";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = global::Polly_Pipe.Properties.Resources.search_locate_find_icon_icons_com_67287;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Location = new System.Drawing.Point(733, 30);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnSearch.TabIndex = 33;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmEqMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Polly_Pipe.Properties.Resources.Backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 743);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblEqMng);
            this.Controls.Add(this.PnlEqMng);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEqMng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polly Pipe | Equipment Management";
            this.Load += new System.EventHandler(this.FrmEqMng_Load);
            this.PnlEqMng.ResumeLayout(false);
            this.PnlEqMng.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblEqMng;
        private System.Windows.Forms.Panel PnlEqMng;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ComboBox CmbID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblEnter;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtCatID;
        private System.Windows.Forms.Label LblCatID;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnClose;
    }
}