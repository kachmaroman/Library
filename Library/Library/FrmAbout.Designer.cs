namespace Library
{
    partial class FrmAbout
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlblAboutName = new MetroFramework.Controls.MetroLabel();
            this.mlblAboutVersion = new MetroFramework.Controls.MetroLabel();
            this.mlblAboutAuthor = new MetroFramework.Controls.MetroLabel();
            this.mlblAboutOrganization = new MetroFramework.Controls.MetroLabel();
            this.tbAbout = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.colledge;
            this.pictureBox1.Location = new System.Drawing.Point(11, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mlblAboutName
            // 
            this.mlblAboutName.AutoSize = true;
            this.mlblAboutName.Location = new System.Drawing.Point(238, 16);
            this.mlblAboutName.Name = "mlblAboutName";
            this.mlblAboutName.Size = new System.Drawing.Size(50, 19);
            this.mlblAboutName.TabIndex = 1;
            this.mlblAboutName.Text = "Library";
            // 
            // mlblAboutVersion
            // 
            this.mlblAboutVersion.AutoSize = true;
            this.mlblAboutVersion.Location = new System.Drawing.Point(240, 59);
            this.mlblAboutVersion.Name = "mlblAboutVersion";
            this.mlblAboutVersion.Size = new System.Drawing.Size(90, 19);
            this.mlblAboutVersion.TabIndex = 2;
            this.mlblAboutVersion.Text = "Version 1.2.2.8";
            // 
            // mlblAboutAuthor
            // 
            this.mlblAboutAuthor.AutoSize = true;
            this.mlblAboutAuthor.Location = new System.Drawing.Point(240, 102);
            this.mlblAboutAuthor.Name = "mlblAboutAuthor";
            this.mlblAboutAuthor.Size = new System.Drawing.Size(106, 19);
            this.mlblAboutAuthor.TabIndex = 3;
            this.mlblAboutAuthor.Text = "Roman Kachmar";
            // 
            // mlblAboutOrganization
            // 
            this.mlblAboutOrganization.AutoSize = true;
            this.mlblAboutOrganization.Location = new System.Drawing.Point(240, 145);
            this.mlblAboutOrganization.Name = "mlblAboutOrganization";
            this.mlblAboutOrganization.Size = new System.Drawing.Size(48, 19);
            this.mlblAboutOrganization.TabIndex = 4;
            this.mlblAboutOrganization.Text = "COOP";
            // 
            // tbAbout
            // 
            this.tbAbout.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAbout.Location = new System.Drawing.Point(11, 183);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ReadOnly = true;
            this.tbAbout.Size = new System.Drawing.Size(497, 101);
            this.tbAbout.TabIndex = 5;
            this.tbAbout.TabStop = false;
            this.tbAbout.Text = "This program was developed as a librarian GUI interaction with the database and m" +
    "anipulate it.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 299);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.mlblAboutOrganization);
            this.Controls.Add(this.mlblAboutAuthor);
            this.Controls.Add(this.mlblAboutVersion);
            this.Controls.Add(this.mlblAboutName);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel mlblAboutName;
        private MetroFramework.Controls.MetroLabel mlblAboutVersion;
        private MetroFramework.Controls.MetroLabel mlblAboutAuthor;
        private MetroFramework.Controls.MetroLabel mlblAboutOrganization;
        private System.Windows.Forms.RichTextBox tbAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}