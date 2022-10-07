namespace Polly_Pipe
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSignin = new System.Windows.Forms.Button();
            this.LblPw = new System.Windows.Forms.Label();
            this.LblUsrnm = new System.Windows.Forms.Label();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.TxtUsernm = new System.Windows.Forms.TextBox();
            this.LblLogo = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::Polly_Pipe.Properties.Resources.delete_delete_exit_1577;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(1008, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(40, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.BtnClear);
            this.PnlLogin.Controls.Add(this.BtnSignin);
            this.PnlLogin.Controls.Add(this.LblPw);
            this.PnlLogin.Controls.Add(this.LblUsrnm);
            this.PnlLogin.Controls.Add(this.TxtPw);
            this.PnlLogin.Controls.Add(this.TxtUsernm);
            this.PnlLogin.Controls.Add(this.LblLogo);
            this.PnlLogin.Controls.Add(this.PnlLogo);
            this.PnlLogin.Location = new System.Drawing.Point(230, 120);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(620, 500);
            this.PnlLogin.TabIndex = 1;
            // 
            // BtnClear
            // 
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(137, 390);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(89, 34);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSignin
            // 
            this.BtnSignin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignin.Location = new System.Drawing.Point(397, 390);
            this.BtnSignin.Name = "BtnSignin";
            this.BtnSignin.Size = new System.Drawing.Size(89, 34);
            this.BtnSignin.TabIndex = 2;
            this.BtnSignin.Text = "Sign In";
            this.BtnSignin.UseVisualStyleBackColor = false;
            this.BtnSignin.Click += new System.EventHandler(this.BtnSignin_Click);
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.BackColor = System.Drawing.Color.Transparent;
            this.LblPw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPw.ForeColor = System.Drawing.Color.White;
            this.LblPw.Location = new System.Drawing.Point(132, 289);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(101, 28);
            this.LblPw.TabIndex = 5;
            this.LblPw.Text = "Password";
            // 
            // LblUsrnm
            // 
            this.LblUsrnm.AutoSize = true;
            this.LblUsrnm.BackColor = System.Drawing.Color.Transparent;
            this.LblUsrnm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsrnm.ForeColor = System.Drawing.Color.White;
            this.LblUsrnm.Location = new System.Drawing.Point(132, 243);
            this.LblUsrnm.Name = "LblUsrnm";
            this.LblUsrnm.Size = new System.Drawing.Size(106, 28);
            this.LblUsrnm.TabIndex = 4;
            this.LblUsrnm.Text = "Username";
            this.LblUsrnm.Click += new System.EventHandler(this.LblUsrnm_Click);
            // 
            // TxtPw
            // 
            this.TxtPw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPw.Location = new System.Drawing.Point(247, 286);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.Size = new System.Drawing.Size(239, 31);
            this.TxtPw.TabIndex = 1;
            // 
            // TxtUsernm
            // 
            this.TxtUsernm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsernm.Location = new System.Drawing.Point(247, 240);
            this.TxtUsernm.Name = "TxtUsernm";
            this.TxtUsernm.Size = new System.Drawing.Size(239, 31);
            this.TxtUsernm.TabIndex = 0;
            this.TxtUsernm.TextChanged += new System.EventHandler(this.TxtUsernm_TextChanged);
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.BackColor = System.Drawing.Color.Transparent;
            this.LblLogo.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogo.ForeColor = System.Drawing.Color.MintCream;
            this.LblLogo.Location = new System.Drawing.Point(229, 50);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(288, 103);
            this.LblLogo.TabIndex = 6;
            this.LblLogo.Text = "Login";
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.PnlLogo.BackgroundImage = global::Polly_Pipe.Properties.Resources.Logo_2;
            this.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLogo.ForeColor = System.Drawing.Color.Transparent;
            this.PnlLogo.Location = new System.Drawing.Point(73, 19);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(150, 150);
            this.PnlLogo.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Polly_Pipe.Properties.Resources.Backg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 743);
            this.ControlBox = false;
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.BtnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polly Pipe | Login";
            this.Load += new System.EventHandler(this.PollyPipe_Load);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.TextBox TxtUsernm;
        private System.Windows.Forms.Label LblUsrnm;
        private System.Windows.Forms.Label LblPw;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSignin;
    }
}

