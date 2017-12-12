namespace Library
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
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cathedraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherReadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomReadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.changeMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.mcbChangeStyle = new MetroFramework.Controls.MetroComboBox();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblThreme = new System.Windows.Forms.Label();
            this.mcbThreme = new MetroFramework.Controls.MetroComboBox();
            this.lblTextSize = new System.Windows.Forms.Label();
            this.mcbTextSize = new MetroFramework.Controls.MetroComboBox();
            this.lblFontWeight = new System.Windows.Forms.Label();
            this.mcbFontWeight = new MetroFramework.Controls.MetroComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.mcbColor = new MetroFramework.Controls.MetroComboBox();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(20, 84);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(968, 564);
            this.mPanel.TabIndex = 1;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(20, 60);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(968, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeServerToolStripMenuItem,
            this.toolStripMenuItem3,
            this.changeMailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::Library.Properties.Resources.menu;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // changeServerToolStripMenuItem
            // 
            this.changeServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.editionsToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.readersToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.facultyToolStripMenuItem,
            this.degreesToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.cathedraToolStripMenuItem,
            this.otherReadersToolStripMenuItem,
            this.roomReadsToolStripMenuItem,
            this.debtorsToolStripMenuItem,
            this.giveBooksToolStripMenuItem});
            this.changeServerToolStripMenuItem.Image = global::Library.Properties.Resources.open_file;
            this.changeServerToolStripMenuItem.Name = "changeServerToolStripMenuItem";
            this.changeServerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changeServerToolStripMenuItem.Text = "Open";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // editionsToolStripMenuItem
            // 
            this.editionsToolStripMenuItem.Name = "editionsToolStripMenuItem";
            this.editionsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editionsToolStripMenuItem.Text = "Editions";
            this.editionsToolStripMenuItem.Click += new System.EventHandler(this.editionsToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            this.readersToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.readersToolStripMenuItem.Text = "Readers";
            this.readersToolStripMenuItem.Click += new System.EventHandler(this.readersToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.facultyToolStripMenuItem.Text = "Faculty";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // degreesToolStripMenuItem
            // 
            this.degreesToolStripMenuItem.Name = "degreesToolStripMenuItem";
            this.degreesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.degreesToolStripMenuItem.Text = "Degrees";
            this.degreesToolStripMenuItem.Click += new System.EventHandler(this.degreesToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.teachersToolStripMenuItem_Click);
            // 
            // cathedraToolStripMenuItem
            // 
            this.cathedraToolStripMenuItem.Name = "cathedraToolStripMenuItem";
            this.cathedraToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cathedraToolStripMenuItem.Text = "Cathedra";
            this.cathedraToolStripMenuItem.Click += new System.EventHandler(this.cathedraToolStripMenuItem_Click);
            // 
            // otherReadersToolStripMenuItem
            // 
            this.otherReadersToolStripMenuItem.Name = "otherReadersToolStripMenuItem";
            this.otherReadersToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.otherReadersToolStripMenuItem.Text = "Other readers";
            this.otherReadersToolStripMenuItem.Click += new System.EventHandler(this.otherReadersToolStripMenuItem_Click);
            // 
            // roomReadsToolStripMenuItem
            // 
            this.roomReadsToolStripMenuItem.Name = "roomReadsToolStripMenuItem";
            this.roomReadsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.roomReadsToolStripMenuItem.Text = "Room reads";
            this.roomReadsToolStripMenuItem.Click += new System.EventHandler(this.roomReadsToolStripMenuItem_Click);
            // 
            // debtorsToolStripMenuItem
            // 
            this.debtorsToolStripMenuItem.Name = "debtorsToolStripMenuItem";
            this.debtorsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.debtorsToolStripMenuItem.Text = "Debtors";
            this.debtorsToolStripMenuItem.Click += new System.EventHandler(this.debtorsToolStripMenuItem_Click);
            // 
            // giveBooksToolStripMenuItem
            // 
            this.giveBooksToolStripMenuItem.Name = "giveBooksToolStripMenuItem";
            this.giveBooksToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.giveBooksToolStripMenuItem.Text = "Give book";
            this.giveBooksToolStripMenuItem.Click += new System.EventHandler(this.giveBooksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(138, 6);
            // 
            // changeMailToolStripMenuItem
            // 
            this.changeMailToolStripMenuItem.Image = global::Library.Properties.Resources.user1;
            this.changeMailToolStripMenuItem.Name = "changeMailToolStripMenuItem";
            this.changeMailToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changeMailToolStripMenuItem.Text = "Change Mail";
            this.changeMailToolStripMenuItem.Click += new System.EventHandler(this.changeMailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Library.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::Library.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Image = global::Library.Properties.Resources.contact;
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.contactsToolStripMenuItem.Text = "Contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Library.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mlBack
            // 
            this.mlBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlBack.Image = global::Library.Properties.Resources.back1;
            this.mlBack.ImageSize = 50;
            this.mlBack.Location = new System.Drawing.Point(2, 5);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(76, 52);
            this.mlBack.TabIndex = 0;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mcbChangeStyle
            // 
            this.mcbChangeStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbChangeStyle.DropDownHeight = 180;
            this.mcbChangeStyle.DropDownWidth = 120;
            this.mcbChangeStyle.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbChangeStyle.FormattingEnabled = true;
            this.mcbChangeStyle.IntegralHeight = false;
            this.mcbChangeStyle.ItemHeight = 29;
            this.mcbChangeStyle.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Green",
            "Lime",
            "Magenta",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.mcbChangeStyle.Location = new System.Drawing.Point(292, 19);
            this.mcbChangeStyle.Name = "mcbChangeStyle";
            this.mcbChangeStyle.PromptText = "Blue";
            this.mcbChangeStyle.Size = new System.Drawing.Size(97, 35);
            this.mcbChangeStyle.Sorted = true;
            this.mcbChangeStyle.TabIndex = 3;
            this.mcbChangeStyle.TabStop = false;
            this.mcbChangeStyle.UseSelectable = true;
            this.mcbChangeStyle.SelectedIndexChanged += new System.EventHandler(this.mcbChangeStyle_SelectedIndexChanged);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStyle.Location = new System.Drawing.Point(237, 21);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(55, 24);
            this.lblStyle.TabIndex = 4;
            this.lblStyle.Text = "Style:";
            // 
            // lblThreme
            // 
            this.lblThreme.AutoSize = true;
            this.lblThreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThreme.Location = new System.Drawing.Point(79, 21);
            this.lblThreme.Name = "lblThreme";
            this.lblThreme.Size = new System.Drawing.Size(82, 24);
            this.lblThreme.TabIndex = 6;
            this.lblThreme.Text = "Threme:";
            // 
            // mcbThreme
            // 
            this.mcbThreme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbThreme.DropDownHeight = 105;
            this.mcbThreme.DropDownWidth = 120;
            this.mcbThreme.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbThreme.FormattingEnabled = true;
            this.mcbThreme.IntegralHeight = false;
            this.mcbThreme.ItemHeight = 29;
            this.mcbThreme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.mcbThreme.Location = new System.Drawing.Point(161, 19);
            this.mcbThreme.Name = "mcbThreme";
            this.mcbThreme.PromptText = "Light";
            this.mcbThreme.Size = new System.Drawing.Size(73, 35);
            this.mcbThreme.Sorted = true;
            this.mcbThreme.TabIndex = 5;
            this.mcbThreme.TabStop = false;
            this.mcbThreme.UseSelectable = true;
            this.mcbThreme.SelectedIndexChanged += new System.EventHandler(this.mcbThreme_SelectedIndexChanged);
            // 
            // lblTextSize
            // 
            this.lblTextSize.AutoSize = true;
            this.lblTextSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextSize.Location = new System.Drawing.Point(392, 21);
            this.lblTextSize.Name = "lblTextSize";
            this.lblTextSize.Size = new System.Drawing.Size(90, 24);
            this.lblTextSize.TabIndex = 8;
            this.lblTextSize.Text = "Text size:";
            // 
            // mcbTextSize
            // 
            this.mcbTextSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbTextSize.DropDownHeight = 180;
            this.mcbTextSize.DropDownWidth = 120;
            this.mcbTextSize.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbTextSize.FormattingEnabled = true;
            this.mcbTextSize.IntegralHeight = false;
            this.mcbTextSize.ItemHeight = 29;
            this.mcbTextSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Tall"});
            this.mcbTextSize.Location = new System.Drawing.Point(482, 19);
            this.mcbTextSize.Name = "mcbTextSize";
            this.mcbTextSize.PromptText = "Medium";
            this.mcbTextSize.Size = new System.Drawing.Size(101, 35);
            this.mcbTextSize.TabIndex = 7;
            this.mcbTextSize.TabStop = false;
            this.mcbTextSize.UseSelectable = true;
            this.mcbTextSize.SelectedIndexChanged += new System.EventHandler(this.mcbTextSize_SelectedIndexChanged);
            // 
            // lblFontWeight
            // 
            this.lblFontWeight.AutoSize = true;
            this.lblFontWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFontWeight.Location = new System.Drawing.Point(586, 21);
            this.lblFontWeight.Name = "lblFontWeight";
            this.lblFontWeight.Size = new System.Drawing.Size(113, 24);
            this.lblFontWeight.TabIndex = 10;
            this.lblFontWeight.Text = "Font weight:";
            // 
            // mcbFontWeight
            // 
            this.mcbFontWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbFontWeight.DropDownHeight = 180;
            this.mcbFontWeight.DropDownWidth = 120;
            this.mcbFontWeight.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbFontWeight.FormattingEnabled = true;
            this.mcbFontWeight.IntegralHeight = false;
            this.mcbFontWeight.ItemHeight = 29;
            this.mcbFontWeight.Items.AddRange(new object[] {
            "Light",
            "Regular",
            "Bold"});
            this.mcbFontWeight.Location = new System.Drawing.Point(699, 19);
            this.mcbFontWeight.Name = "mcbFontWeight";
            this.mcbFontWeight.PromptText = "Regular";
            this.mcbFontWeight.Size = new System.Drawing.Size(95, 35);
            this.mcbFontWeight.TabIndex = 9;
            this.mcbFontWeight.TabStop = false;
            this.mcbFontWeight.UseSelectable = true;
            this.mcbFontWeight.SelectedIndexChanged += new System.EventHandler(this.mcbFontWeight_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(797, 21);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 24);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color:";
            // 
            // mcbColor
            // 
            this.mcbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbColor.DropDownHeight = 180;
            this.mcbColor.DropDownWidth = 120;
            this.mcbColor.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbColor.FormattingEnabled = true;
            this.mcbColor.IntegralHeight = false;
            this.mcbColor.ItemHeight = 29;
            this.mcbColor.Items.AddRange(new object[] {
            "Aqua",
            "Black",
            "Blue",
            "Gold",
            "Gray",
            "Green",
            "Lime",
            "Magenta",
            "Orange",
            "Pink",
            "Red",
            "Teal",
            "White",
            "Yellow"});
            this.mcbColor.Location = new System.Drawing.Point(857, 19);
            this.mcbColor.Name = "mcbColor";
            this.mcbColor.PromptText = "White";
            this.mcbColor.Size = new System.Drawing.Size(93, 35);
            this.mcbColor.Sorted = true;
            this.mcbColor.TabIndex = 11;
            this.mcbColor.TabStop = false;
            this.mcbColor.UseSelectable = true;
            this.mcbColor.SelectedIndexChanged += new System.EventHandler(this.mcbColor_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 668);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.mcbColor);
            this.Controls.Add(this.lblFontWeight);
            this.Controls.Add(this.mcbFontWeight);
            this.Controls.Add(this.lblTextSize);
            this.Controls.Add(this.lblThreme);
            this.Controls.Add(this.mcbTextSize);
            this.Controls.Add(this.mcbThreme);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.mcbChangeStyle);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroPanel mPanel;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cathedraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherReadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomReadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        public MetroFramework.Controls.MetroComboBox mcbChangeStyle;
        public MetroFramework.Controls.MetroComboBox mcbThreme;
        public MetroFramework.Controls.MetroComboBox mcbTextSize;
        public MetroFramework.Controls.MetroComboBox mcbFontWeight;
        public MetroFramework.Controls.MetroComboBox mcbColor;
        public System.Windows.Forms.Label lblStyle;
        public System.Windows.Forms.Label lblThreme;
        public System.Windows.Forms.Label lblTextSize;
        public System.Windows.Forms.Label lblFontWeight;
        public System.Windows.Forms.Label lblColor;
    }
}