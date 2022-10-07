namespace Polly_Pipe
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnInsMng = new System.Windows.Forms.Button();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnCusMng = new System.Windows.Forms.Button();
            this.BtnEmpMng = new System.Windows.Forms.Button();
            this.BtnEqMng = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnInsMng
            // 
            this.BtnInsMng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInsMng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsMng.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsMng.Location = new System.Drawing.Point(540, 335);
            this.BtnInsMng.Name = "BtnInsMng";
            this.BtnInsMng.Size = new System.Drawing.Size(250, 150);
            this.BtnInsMng.TabIndex = 1;
            this.BtnInsMng.Text = "Installation Management";
            this.BtnInsMng.UseVisualStyleBackColor = true;
            this.BtnInsMng.Click += new System.EventHandler(this.BtnInsReg_Click);
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcome.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.Location = new System.Drawing.Point(656, 286);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(142, 37);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welcome !";
            // 
            // BtnCusMng
            // 
            this.BtnCusMng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCusMng.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCusMng.Location = new System.Drawing.Point(284, 335);
            this.BtnCusMng.Name = "BtnCusMng";
            this.BtnCusMng.Size = new System.Drawing.Size(250, 150);
            this.BtnCusMng.TabIndex = 1;
            this.BtnCusMng.Text = "Customer Management";
            this.BtnCusMng.UseVisualStyleBackColor = true;
            this.BtnCusMng.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEmpMng
            // 
            this.BtnEmpMng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpMng.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpMng.Location = new System.Drawing.Point(284, 491);
            this.BtnEmpMng.Name = "BtnEmpMng";
            this.BtnEmpMng.Size = new System.Drawing.Size(250, 150);
            this.BtnEmpMng.TabIndex = 1;
            this.BtnEmpMng.Text = "Employee Management";
            this.BtnEmpMng.UseVisualStyleBackColor = true;
            this.BtnEmpMng.Click += new System.EventHandler(this.BtnEmpReg_Click);
            // 
            // BtnEqMng
            // 
            this.BtnEqMng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEqMng.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqMng.Location = new System.Drawing.Point(540, 491);
            this.BtnEqMng.Name = "BtnEqMng";
            this.BtnEqMng.Size = new System.Drawing.Size(250, 150);
            this.BtnEqMng.TabIndex = 1;
            this.BtnEqMng.Text = "Equipment Management";
            this.BtnEqMng.UseVisualStyleBackColor = true;
            this.BtnEqMng.Click += new System.EventHandler(this.BtnEqMng_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::Polly_Pipe.Properties.Resources.delete_delete_exit_1577;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(1005, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(40, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Polly_Pipe.Properties.Resources.Logo_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(431, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 216);
            this.panel1.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Polly_Pipe.Properties.Resources.Backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 743);
            this.ControlBox = false;
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnEqMng);
            this.Controls.Add(this.BtnEmpMng);
            this.Controls.Add(this.BtnCusMng);
            this.Controls.Add(this.BtnInsMng);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polly Pipe | Home";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInsMng;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnCusMng;
        private System.Windows.Forms.Button BtnEmpMng;
        private System.Windows.Forms.Button BtnEqMng;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel1;
    }
}