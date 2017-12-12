namespace Library
{
    partial class ucOtherReaders
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.otherReadersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otherReadersTableAdapter = new Library.LibraryDBDataSetTableAdapters.OtherReadersTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.otherReadersMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.OtherIDTextBox = new System.Windows.Forms.TextBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OtherIDLabel = new MetroFramework.Controls.MetroLabel();
            this.PhoneLabel = new MetroFramework.Controls.MetroLabel();
            this.picOtherReadersExcel = new System.Windows.Forms.PictureBox();
            this.picOtherReadersPrint = new System.Windows.Forms.PictureBox();
            this.picOtherReadersSave = new System.Windows.Forms.PictureBox();
            this.tbOtherReadersSearch = new System.Windows.Forms.TextBox();
            this.picOtherReadersMinus = new System.Windows.Forms.PictureBox();
            this.picOtherReadersAdd = new System.Windows.Forms.PictureBox();
            this.printOtherReaders = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherReadersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherReadersMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otherReadersBindingSource
            // 
            this.otherReadersBindingSource.DataMember = "OtherReaders";
            this.otherReadersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // otherReadersTableAdapter
            // 
            this.otherReadersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CathedraTableAdapter = null;
            this.tableAdapterManager.DateMinTableAdapter = null;
            this.tableAdapterManager.DebtorsTableAdapter = null;
            this.tableAdapterManager.DegreesTableAdapter = null;
            this.tableAdapterManager.EditionsTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.GiveBookTableAdapter = null;
            this.tableAdapterManager.OtherReadersTableAdapter = this.otherReadersTableAdapter;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // otherReadersMetroGrid
            // 
            this.otherReadersMetroGrid.AllowUserToOrderColumns = true;
            this.otherReadersMetroGrid.AllowUserToResizeRows = false;
            this.otherReadersMetroGrid.AutoGenerateColumns = false;
            this.otherReadersMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.otherReadersMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherReadersMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.otherReadersMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.otherReadersMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.otherReadersMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otherReadersMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.otherReadersMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otherReadersMetroGrid.DataSource = this.otherReadersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.otherReadersMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.otherReadersMetroGrid.EnableHeadersVisualStyles = false;
            this.otherReadersMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.otherReadersMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.otherReadersMetroGrid.Location = new System.Drawing.Point(0, 79);
            this.otherReadersMetroGrid.Name = "otherReadersMetroGrid";
            this.otherReadersMetroGrid.ReadOnly = true;
            this.otherReadersMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.otherReadersMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.otherReadersMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.otherReadersMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.otherReadersMetroGrid.Size = new System.Drawing.Size(970, 233);
            this.otherReadersMetroGrid.TabIndex = 1;
            // 
            // OtherIDTextBox
            // 
            this.OtherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otherReadersBindingSource, "OtherID", true));
            this.OtherIDTextBox.Location = new System.Drawing.Point(147, 348);
            this.OtherIDTextBox.Name = "OtherIDTextBox";
            this.OtherIDTextBox.Size = new System.Drawing.Size(293, 20);
            this.OtherIDTextBox.TabIndex = 2;
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otherReadersBindingSource, "Phone", true));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(513, 348);
            this.PhoneMaskedTextBox.Mask = "000 (00) 000-00-00";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(105, 20);
            this.PhoneMaskedTextBox.TabIndex = 4;
            // 
            // OtherIDLabel
            // 
            this.OtherIDLabel.AutoSize = true;
            this.OtherIDLabel.Location = new System.Drawing.Point(45, 348);
            this.OtherIDLabel.Name = "OtherIDLabel";
            this.OtherIDLabel.Size = new System.Drawing.Size(96, 19);
            this.OtherIDLabel.TabIndex = 5;
            this.OtherIDLabel.Text = "Other Read ID:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(458, 348);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 19);
            this.PhoneLabel.TabIndex = 6;
            this.PhoneLabel.Text = "Phone:";
            // 
            // picOtherReadersExcel
            // 
            this.picOtherReadersExcel.BackColor = System.Drawing.Color.White;
            this.picOtherReadersExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOtherReadersExcel.Image = global::Library.Properties.Resources.excel;
            this.picOtherReadersExcel.Location = new System.Drawing.Point(752, 3);
            this.picOtherReadersExcel.Name = "picOtherReadersExcel";
            this.picOtherReadersExcel.Size = new System.Drawing.Size(64, 64);
            this.picOtherReadersExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOtherReadersExcel.TabIndex = 28;
            this.picOtherReadersExcel.TabStop = false;
            this.picOtherReadersExcel.Click += new System.EventHandler(this.picOtherReadersExcel_Click);
            // 
            // picOtherReadersPrint
            // 
            this.picOtherReadersPrint.BackColor = System.Drawing.Color.White;
            this.picOtherReadersPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOtherReadersPrint.Image = global::Library.Properties.Resources.printer;
            this.picOtherReadersPrint.Location = new System.Drawing.Point(883, 3);
            this.picOtherReadersPrint.Name = "picOtherReadersPrint";
            this.picOtherReadersPrint.Size = new System.Drawing.Size(64, 64);
            this.picOtherReadersPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOtherReadersPrint.TabIndex = 27;
            this.picOtherReadersPrint.TabStop = false;
            this.picOtherReadersPrint.Click += new System.EventHandler(this.picOtherReadersPrint_Click);
            // 
            // picOtherReadersSave
            // 
            this.picOtherReadersSave.BackColor = System.Drawing.Color.White;
            this.picOtherReadersSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOtherReadersSave.Image = global::Library.Properties.Resources.accept;
            this.picOtherReadersSave.Location = new System.Drawing.Point(621, 5);
            this.picOtherReadersSave.Name = "picOtherReadersSave";
            this.picOtherReadersSave.Size = new System.Drawing.Size(64, 64);
            this.picOtherReadersSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOtherReadersSave.TabIndex = 26;
            this.picOtherReadersSave.TabStop = false;
            this.picOtherReadersSave.Click += new System.EventHandler(this.picOtherReadersSave_Click);
            // 
            // tbOtherReadersSearch
            // 
            this.tbOtherReadersSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOtherReadersSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtherReadersSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbOtherReadersSearch.Location = new System.Drawing.Point(3, 3);
            this.tbOtherReadersSearch.Name = "tbOtherReadersSearch";
            this.tbOtherReadersSearch.Size = new System.Drawing.Size(305, 66);
            this.tbOtherReadersSearch.TabIndex = 25;
            this.tbOtherReadersSearch.TabStop = false;
            this.tbOtherReadersSearch.Text = "Search";
            this.tbOtherReadersSearch.Click += new System.EventHandler(this.tbOtherReadersSearch_Click);
            this.tbOtherReadersSearch.TextChanged += new System.EventHandler(this.tbOtherReadersSearch_TextChanged);
            this.tbOtherReadersSearch.Leave += new System.EventHandler(this.tbOtherReadersSearch_Leave);
            // 
            // picOtherReadersMinus
            // 
            this.picOtherReadersMinus.BackColor = System.Drawing.Color.White;
            this.picOtherReadersMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOtherReadersMinus.Image = global::Library.Properties.Resources.minus;
            this.picOtherReadersMinus.Location = new System.Drawing.Point(490, 3);
            this.picOtherReadersMinus.Name = "picOtherReadersMinus";
            this.picOtherReadersMinus.Size = new System.Drawing.Size(64, 64);
            this.picOtherReadersMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOtherReadersMinus.TabIndex = 24;
            this.picOtherReadersMinus.TabStop = false;
            this.picOtherReadersMinus.Click += new System.EventHandler(this.picOtherReadersMinus_Click);
            // 
            // picOtherReadersAdd
            // 
            this.picOtherReadersAdd.BackColor = System.Drawing.Color.White;
            this.picOtherReadersAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOtherReadersAdd.Image = global::Library.Properties.Resources.add;
            this.picOtherReadersAdd.Location = new System.Drawing.Point(359, 5);
            this.picOtherReadersAdd.Name = "picOtherReadersAdd";
            this.picOtherReadersAdd.Size = new System.Drawing.Size(64, 64);
            this.picOtherReadersAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOtherReadersAdd.TabIndex = 23;
            this.picOtherReadersAdd.TabStop = false;
            this.picOtherReadersAdd.Click += new System.EventHandler(this.picOtherReadersAdd_Click);
            // 
            // printOtherReaders
            // 
            this.printOtherReaders.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printOtherReaders_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OtherID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OtherID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 410;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 502;
            // 
            // ucOtherReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picOtherReadersExcel);
            this.Controls.Add(this.picOtherReadersPrint);
            this.Controls.Add(this.picOtherReadersSave);
            this.Controls.Add(this.tbOtherReadersSearch);
            this.Controls.Add(this.picOtherReadersMinus);
            this.Controls.Add(this.picOtherReadersAdd);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.OtherIDLabel);
            this.Controls.Add(this.OtherIDTextBox);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.otherReadersMetroGrid);
            this.Name = "ucOtherReaders";
            this.Size = new System.Drawing.Size(970, 400);
            this.Load += new System.EventHandler(this.ucOtherReaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherReadersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherReadersMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherReadersAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource otherReadersBindingSource;
        private LibraryDBDataSetTableAdapters.OtherReadersTableAdapter otherReadersTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid otherReadersMetroGrid;
        private System.Windows.Forms.TextBox OtherIDTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private MetroFramework.Controls.MetroLabel OtherIDLabel;
        private MetroFramework.Controls.MetroLabel PhoneLabel;
        private System.Windows.Forms.PictureBox picOtherReadersExcel;
        private System.Windows.Forms.PictureBox picOtherReadersPrint;
        private System.Windows.Forms.PictureBox picOtherReadersSave;
        private System.Windows.Forms.TextBox tbOtherReadersSearch;
        private System.Windows.Forms.PictureBox picOtherReadersMinus;
        private System.Windows.Forms.PictureBox picOtherReadersAdd;
        private System.Drawing.Printing.PrintDocument printOtherReaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
