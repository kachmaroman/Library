namespace Library
{
    partial class FrmHelpCode
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
            this.mlblGmail = new MetroFramework.Controls.MetroLabel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.picSend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblGmail
            // 
            this.mlblGmail.AutoSize = true;
            this.mlblGmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblGmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblGmail.Location = new System.Drawing.Point(51, 145);
            this.mlblGmail.Name = "mlblGmail";
            this.mlblGmail.Size = new System.Drawing.Size(170, 25);
            this.mlblGmail.TabIndex = 18;
            this.mlblGmail.Text = "lnt397@gmail.com";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHelp.Location = new System.Drawing.Point(10, 60);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(425, 72);
            this.lblHelp.TabIndex = 22;
            this.lblHelp.Text = "Sometimes spam filters block automated emails. \r\nIf you do not find the email in " +
    "your inbox, \r\nplease check your spam filter or bulk email folder. \r\nPlease conta" +
    "ct the owner for any questions.";
            // 
            // picCancel
            // 
            this.picCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancel.Image = global::Library.Properties.Resources.cancel;
            this.picCancel.Location = new System.Drawing.Point(377, 6);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(50, 34);
            this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCancel.TabIndex = 19;
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
            // 
            // picSend
            // 
            this.picSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSend.Image = global::Library.Properties.Resources.plane;
            this.picSend.Location = new System.Drawing.Point(13, 142);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(32, 32);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSend.TabIndex = 17;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // FrmHelpCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 188);
            this.ControlBox = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.picCancel);
            this.Controls.Add(this.mlblGmail);
            this.Controls.Add(this.picSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmHelpCode";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Help";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mlblGmail;
        private System.Windows.Forms.Label lblHelp;
        internal System.Windows.Forms.PictureBox picCancel;
        internal System.Windows.Forms.PictureBox picSend;
    }
}