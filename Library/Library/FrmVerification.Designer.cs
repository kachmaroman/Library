namespace Library
{
    partial class FrmVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerification));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recSignIn = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recShapeCode = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recShapeGmail = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbGmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblLostPass = new System.Windows.Forms.Label();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.picBoxCode = new System.Windows.Forms.PictureBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.picGoogle = new System.Windows.Forms.PictureBox();
            this.panelSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 30);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recSignIn,
            this.recShapeCode,
            this.recShapeGmail});
            this.shapeContainer1.Size = new System.Drawing.Size(295, 385);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // recSignIn
            // 
            this.recSignIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.recSignIn.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recSignIn.BorderColor = System.Drawing.Color.White;
            this.recSignIn.BorderWidth = 3;
            this.recSignIn.CornerRadius = 10;
            this.recSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recSignIn.Enabled = false;
            this.recSignIn.Location = new System.Drawing.Point(9, 301);
            this.recSignIn.Name = "recSignIn";
            this.recSignIn.Size = new System.Drawing.Size(275, 55);
            // 
            // recShapeCode
            // 
            this.recShapeCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recShapeCode.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recShapeCode.BorderColor = System.Drawing.Color.White;
            this.recShapeCode.BorderWidth = 3;
            this.recShapeCode.CornerRadius = 3;
            this.recShapeCode.Enabled = false;
            this.recShapeCode.Location = new System.Drawing.Point(-9, 205);
            this.recShapeCode.Name = "recShapeCode";
            this.recShapeCode.Size = new System.Drawing.Size(302, 55);
            // 
            // recShapeGmail
            // 
            this.recShapeGmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recShapeGmail.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recShapeGmail.BorderColor = System.Drawing.Color.White;
            this.recShapeGmail.BorderWidth = 3;
            this.recShapeGmail.CornerRadius = 3;
            this.recShapeGmail.Enabled = false;
            this.recShapeGmail.Location = new System.Drawing.Point(-9, 142);
            this.recShapeGmail.Name = "recShapeGmail";
            this.recShapeGmail.Size = new System.Drawing.Size(302, 55);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogin.Location = new System.Drawing.Point(64, 86);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(206, 75);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGmail
            // 
            this.tbGmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGmail.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.tbGmail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbGmail.Location = new System.Drawing.Point(60, 189);
            this.tbGmail.Name = "tbGmail";
            this.tbGmail.Size = new System.Drawing.Size(241, 26);
            this.tbGmail.TabIndex = 1;
            this.tbGmail.TabStop = false;
            this.tbGmail.Tag = "";
            this.tbGmail.Text = "Gmail";
            this.tbGmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGmail.Click += new System.EventHandler(this.tbGmail_Click);
            this.tbGmail.TextChanged += new System.EventHandler(this.tbGmail_TextChanged);
            this.tbGmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGmail_KeyPress);
            this.tbGmail.Leave += new System.EventHandler(this.tbGmail_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(60, 249);
            this.tbPassword.MaxLength = 12;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(241, 26);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = false;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelSignIn.Controls.Add(this.lblSignIn);
            this.panelSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSignIn.Enabled = false;
            this.panelSignIn.Location = new System.Drawing.Point(33, 338);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(267, 39);
            this.panelSignIn.TabIndex = 4;
            this.panelSignIn.Click += new System.EventHandler(this.panelSignIn_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(95, 7);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(84, 25);
            this.lblSignIn.TabIndex = 0;
            this.lblSignIn.Text = "Sign in";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // lblLostPass
            // 
            this.lblLostPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLostPass.AutoSize = true;
            this.lblLostPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLostPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLostPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLostPass.Location = new System.Drawing.Point(90, 406);
            this.lblLostPass.Name = "lblLostPass";
            this.lblLostPass.Size = new System.Drawing.Size(152, 18);
            this.lblLostPass.TabIndex = 5;
            this.lblLostPass.Text = "Forgot Password?";
            this.lblLostPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLostPass.Click += new System.EventHandler(this.lblLostPass_Click);
            // 
            // linkHelp
            // 
            this.linkHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkHelp.AutoSize = true;
            this.linkHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkHelp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkHelp.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkHelp.Location = new System.Drawing.Point(59, 298);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(227, 16);
            this.linkHelp.TabIndex = 5;
            this.linkHelp.Text = "I didn\'t receive the code to confirm";
            this.linkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkHelp.Click += new System.EventHandler(this.linkHelp_Click);
            // 
            // picBoxCode
            // 
            this.picBoxCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBoxCode.Image = global::Library.Properties.Resources.block;
            this.picBoxCode.Location = new System.Drawing.Point(20, 246);
            this.picBoxCode.Name = "picBoxCode";
            this.picBoxCode.Size = new System.Drawing.Size(35, 34);
            this.picBoxCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCode.TabIndex = 9;
            this.picBoxCode.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBoxUser.Image = global::Library.Properties.Resources.user;
            this.picBoxUser.Location = new System.Drawing.Point(20, 183);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(35, 34);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUser.TabIndex = 8;
            this.picBoxUser.TabStop = false;
            // 
            // picGoogle
            // 
            this.picGoogle.Image = global::Library.Properties.Resources.newGmail;
            this.picGoogle.Location = new System.Drawing.Point(64, -20);
            this.picGoogle.Name = "picGoogle";
            this.picGoogle.Size = new System.Drawing.Size(204, 119);
            this.picGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoogle.TabIndex = 0;
            this.picGoogle.TabStop = false;
            // 
            // FrmVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 435);
            this.Controls.Add(this.picBoxCode);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.lblLostPass);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbGmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.picGoogle);
            this.Controls.Add(this.shapeContainer1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 450);
            this.MinimumSize = new System.Drawing.Size(335, 425);
            this.Name = "FrmVerification";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TopMost = true;
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoogle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGoogle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLostPass;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape recShapeGmail;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape recShapeCode;
        protected Microsoft.VisualBasic.PowerPacks.RectangleShape recSignIn;
        internal System.Windows.Forms.TextBox tbPassword;
        internal System.Windows.Forms.Panel panelSignIn;
        internal System.Windows.Forms.TextBox tbGmail;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox picBoxCode;
        internal System.Windows.Forms.Label lblSignIn;
    }
}