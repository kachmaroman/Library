namespace Library
{
    partial class FrmContact
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recContactCancel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recContactMessage = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recContactSend = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recContactLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.recContactContactUs = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblContactContactUs = new System.Windows.Forms.Label();
            this.lblContactSend = new System.Windows.Forms.Label();
            this.tbContactLogin = new System.Windows.Forms.TextBox();
            this.tbContactMessage = new System.Windows.Forms.TextBox();
            this.lblContactCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recContactCancel,
            this.recContactMessage,
            this.recContactSend,
            this.recContactLogin,
            this.recContactContactUs});
            this.shapeContainer1.Size = new System.Drawing.Size(319, 397);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // recContactCancel
            // 
            this.recContactCancel.BackColor = System.Drawing.Color.Red;
            this.recContactCancel.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recContactCancel.BorderColor = System.Drawing.SystemColors.Control;
            this.recContactCancel.BorderWidth = 3;
            this.recContactCancel.CornerRadius = 8;
            this.recContactCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recContactCancel.Enabled = false;
            this.recContactCancel.Location = new System.Drawing.Point(20, 342);
            this.recContactCancel.Name = "recContactCancel";
            this.recContactCancel.Size = new System.Drawing.Size(88, 36);
            this.recContactCancel.Click += new System.EventHandler(this.recContactCancel_Click);
            // 
            // recContactMessage
            // 
            this.recContactMessage.BackColor = System.Drawing.Color.White;
            this.recContactMessage.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recContactMessage.BorderColor = System.Drawing.SystemColors.Control;
            this.recContactMessage.CornerRadius = 5;
            this.recContactMessage.Enabled = false;
            this.recContactMessage.FillGradientColor = System.Drawing.Color.White;
            this.recContactMessage.Location = new System.Drawing.Point(20, 145);
            this.recContactMessage.Name = "recContactMessage";
            this.recContactMessage.SelectionColor = System.Drawing.SystemColors.Control;
            this.recContactMessage.Size = new System.Drawing.Size(275, 184);
            // 
            // recContactSend
            // 
            this.recContactSend.BackColor = System.Drawing.Color.LawnGreen;
            this.recContactSend.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recContactSend.BorderColor = System.Drawing.SystemColors.Control;
            this.recContactSend.BorderWidth = 3;
            this.recContactSend.CornerRadius = 18;
            this.recContactSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recContactSend.Enabled = false;
            this.recContactSend.Location = new System.Drawing.Point(213, 341);
            this.recContactSend.Name = "recContactSend";
            this.recContactSend.Size = new System.Drawing.Size(82, 36);
            this.recContactSend.Click += new System.EventHandler(this.recContactSend_Click);
            // 
            // recContactLogin
            // 
            this.recContactLogin.BackColor = System.Drawing.Color.White;
            this.recContactLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recContactLogin.BorderColor = System.Drawing.SystemColors.Control;
            this.recContactLogin.CornerRadius = 5;
            this.recContactLogin.Enabled = false;
            this.recContactLogin.FillGradientColor = System.Drawing.Color.White;
            this.recContactLogin.Location = new System.Drawing.Point(20, 87);
            this.recContactLogin.Name = "recContactLogin";
            this.recContactLogin.SelectionColor = System.Drawing.SystemColors.Control;
            this.recContactLogin.Size = new System.Drawing.Size(275, 39);
            // 
            // recContactContactUs
            // 
            this.recContactContactUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recContactContactUs.BackColor = System.Drawing.Color.Aqua;
            this.recContactContactUs.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recContactContactUs.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.recContactContactUs.Enabled = false;
            this.recContactContactUs.Location = new System.Drawing.Point(-4, -1);
            this.recContactContactUs.Name = "recContactContactUs";
            this.recContactContactUs.Size = new System.Drawing.Size(326, 69);
            // 
            // lblContactContactUs
            // 
            this.lblContactContactUs.AutoSize = true;
            this.lblContactContactUs.BackColor = System.Drawing.Color.Aqua;
            this.lblContactContactUs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactContactUs.ForeColor = System.Drawing.Color.White;
            this.lblContactContactUs.Location = new System.Drawing.Point(29, 14);
            this.lblContactContactUs.Name = "lblContactContactUs";
            this.lblContactContactUs.Size = new System.Drawing.Size(265, 43);
            this.lblContactContactUs.TabIndex = 0;
            this.lblContactContactUs.Text = "CONTACT US";
            this.lblContactContactUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContactSend
            // 
            this.lblContactSend.AutoSize = true;
            this.lblContactSend.BackColor = System.Drawing.Color.LawnGreen;
            this.lblContactSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContactSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContactSend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactSend.ForeColor = System.Drawing.Color.Transparent;
            this.lblContactSend.Location = new System.Drawing.Point(224, 347);
            this.lblContactSend.Name = "lblContactSend";
            this.lblContactSend.Size = new System.Drawing.Size(60, 23);
            this.lblContactSend.TabIndex = 4;
            this.lblContactSend.Text = "Send";
            this.lblContactSend.Click += new System.EventHandler(this.lblContactSend_Click);
            // 
            // tbContactLogin
            // 
            this.tbContactLogin.BackColor = System.Drawing.Color.White;
            this.tbContactLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContactLogin.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContactLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbContactLogin.Location = new System.Drawing.Point(33, 95);
            this.tbContactLogin.Name = "tbContactLogin";
            this.tbContactLogin.Size = new System.Drawing.Size(255, 25);
            this.tbContactLogin.TabIndex = 0;
            this.tbContactLogin.TabStop = false;
            this.tbContactLogin.Text = "From";
            this.tbContactLogin.Click += new System.EventHandler(this.tbContactLogin_Click);
            this.tbContactLogin.Leave += new System.EventHandler(this.tbContactLogin_Leave);
            // 
            // tbContactMessage
            // 
            this.tbContactMessage.BackColor = System.Drawing.Color.White;
            this.tbContactMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContactMessage.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContactMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbContactMessage.Location = new System.Drawing.Point(33, 156);
            this.tbContactMessage.Multiline = true;
            this.tbContactMessage.Name = "tbContactMessage";
            this.tbContactMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbContactMessage.Size = new System.Drawing.Size(255, 162);
            this.tbContactMessage.TabIndex = 3;
            this.tbContactMessage.TabStop = false;
            this.tbContactMessage.Text = "Message";
            this.tbContactMessage.Click += new System.EventHandler(this.tbContactMessage_Click);
            this.tbContactMessage.Leave += new System.EventHandler(this.tbContactMessage_Leave);
            // 
            // lblContactCancel
            // 
            this.lblContactCancel.AutoSize = true;
            this.lblContactCancel.BackColor = System.Drawing.Color.Red;
            this.lblContactCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContactCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactCancel.Location = new System.Drawing.Point(28, 349);
            this.lblContactCancel.Name = "lblContactCancel";
            this.lblContactCancel.Size = new System.Drawing.Size(73, 22);
            this.lblContactCancel.TabIndex = 5;
            this.lblContactCancel.Text = "Cancel";
            this.lblContactCancel.Click += new System.EventHandler(this.lblContactCancel_Click);
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(319, 397);
            this.Controls.Add(this.lblContactCancel);
            this.Controls.Add(this.tbContactMessage);
            this.Controls.Add(this.tbContactLogin);
            this.Controls.Add(this.lblContactSend);
            this.Controls.Add(this.lblContactContactUs);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContact";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContact";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recContactContactUs;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recContactLogin;
        private System.Windows.Forms.Label lblContactContactUs;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape recContactSend;
        internal System.Windows.Forms.Label lblContactSend;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recContactMessage;
        private System.Windows.Forms.TextBox tbContactLogin;
        private System.Windows.Forms.TextBox tbContactMessage;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape recContactCancel;
        private System.Windows.Forms.Label lblContactCancel;
    }
}