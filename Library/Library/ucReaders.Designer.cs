namespace Library
{
    partial class ucReaders
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
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Library.LibraryDBDataSetTableAdapters.ReadersTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.readersMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picReader = new System.Windows.Forms.PictureBox();
            this.mbtnReaderBrowse = new MetroFramework.Controls.MetroButton();
            this.ReaderIDTextBox = new System.Windows.Forms.TextBox();
            this.CategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.MNameTextBox = new System.Windows.Forms.TextBox();
            this.ImageUrlTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CategoryIDLabel = new MetroFramework.Controls.MetroLabel();
            this.ReaderIDLabel = new MetroFramework.Controls.MetroLabel();
            this.FNameLabel = new MetroFramework.Controls.MetroLabel();
            this.LNameLabel = new MetroFramework.Controls.MetroLabel();
            this.MNameLabel = new MetroFramework.Controls.MetroLabel();
            this.PhotoLabel = new MetroFramework.Controls.MetroLabel();
            this.picReadersExcel = new System.Windows.Forms.PictureBox();
            this.picReadersPrint = new System.Windows.Forms.PictureBox();
            this.picReadersSave = new System.Windows.Forms.PictureBox();
            this.tbReadersSearch = new System.Windows.Forms.TextBox();
            this.picReadersMinus = new System.Windows.Forms.PictureBox();
            this.picReadersAdd = new System.Windows.Forms.PictureBox();
            this.printReaders = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OtherReadersTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = this.readersTableAdapter;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // readersMetroGrid
            // 
            this.readersMetroGrid.AllowUserToOrderColumns = true;
            this.readersMetroGrid.AllowUserToResizeRows = false;
            this.readersMetroGrid.AutoGenerateColumns = false;
            this.readersMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readersMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readersMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.readersMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.readersMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.readersMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.readersMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readersMetroGrid.DataSource = this.readersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.readersMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.readersMetroGrid.EnableHeadersVisualStyles = false;
            this.readersMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.readersMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readersMetroGrid.Location = new System.Drawing.Point(0, 75);
            this.readersMetroGrid.Name = "readersMetroGrid";
            this.readersMetroGrid.ReadOnly = true;
            this.readersMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.readersMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.readersMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.readersMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readersMetroGrid.Size = new System.Drawing.Size(761, 295);
            this.readersMetroGrid.TabIndex = 1;
            this.readersMetroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readersMetroGrid_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReaderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReaderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MName";
            this.dataGridViewTextBoxColumn5.HeaderText = "MName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 148;
            // 
            // picReader
            // 
            this.picReader.Location = new System.Drawing.Point(767, 77);
            this.picReader.Name = "picReader";
            this.picReader.Size = new System.Drawing.Size(191, 170);
            this.picReader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReader.TabIndex = 5;
            this.picReader.TabStop = false;
            // 
            // mbtnReaderBrowse
            // 
            this.mbtnReaderBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnReaderBrowse.Location = new System.Drawing.Point(883, 261);
            this.mbtnReaderBrowse.Name = "mbtnReaderBrowse";
            this.mbtnReaderBrowse.Size = new System.Drawing.Size(75, 23);
            this.mbtnReaderBrowse.TabIndex = 6;
            this.mbtnReaderBrowse.Text = "Browse";
            this.mbtnReaderBrowse.UseSelectable = true;
            this.mbtnReaderBrowse.Click += new System.EventHandler(this.mbtnReaderBrowse_Click);
            // 
            // ReaderIDTextBox
            // 
            this.ReaderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "ReaderID", true));
            this.ReaderIDTextBox.Location = new System.Drawing.Point(841, 309);
            this.ReaderIDTextBox.Name = "ReaderIDTextBox";
            this.ReaderIDTextBox.Size = new System.Drawing.Size(114, 20);
            this.ReaderIDTextBox.TabIndex = 7;
            // 
            // CategoryIDTextBox
            // 
            this.CategoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "CategoryID", true));
            this.CategoryIDTextBox.Location = new System.Drawing.Point(854, 346);
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.Size = new System.Drawing.Size(101, 20);
            this.CategoryIDTextBox.TabIndex = 9;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "LName", true));
            this.LNameTextBox.Location = new System.Drawing.Point(356, 419);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.LNameTextBox.TabIndex = 11;
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "FName", true));
            this.FNameTextBox.Location = new System.Drawing.Point(116, 419);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.FNameTextBox.TabIndex = 13;
            // 
            // MNameTextBox
            // 
            this.MNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "MName", true));
            this.MNameTextBox.Location = new System.Drawing.Point(609, 419);
            this.MNameTextBox.Name = "MNameTextBox";
            this.MNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.MNameTextBox.TabIndex = 15;
            // 
            // ImageUrlTextBox
            // 
            this.ImageUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "ImageUrl", true));
            this.ImageUrlTextBox.Location = new System.Drawing.Point(854, 419);
            this.ImageUrlTextBox.Name = "ImageUrlTextBox";
            this.ImageUrlTextBox.Size = new System.Drawing.Size(101, 20);
            this.ImageUrlTextBox.TabIndex = 17;
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Location = new System.Drawing.Point(767, 346);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(83, 19);
            this.CategoryIDLabel.TabIndex = 18;
            this.CategoryIDLabel.Text = "Category ID:";
            // 
            // ReaderIDLabel
            // 
            this.ReaderIDLabel.AutoSize = true;
            this.ReaderIDLabel.Location = new System.Drawing.Point(767, 310);
            this.ReaderIDLabel.Name = "ReaderIDLabel";
            this.ReaderIDLabel.Size = new System.Drawing.Size(70, 19);
            this.ReaderIDLabel.TabIndex = 19;
            this.ReaderIDLabel.Text = "Reader ID:";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(279, 419);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(73, 19);
            this.FNameLabel.TabIndex = 20;
            this.FNameLabel.Text = "First name:";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(39, 418);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(71, 19);
            this.LNameLabel.TabIndex = 21;
            this.LNameLabel.Text = "Last name:";
            // 
            // MNameLabel
            // 
            this.MNameLabel.AutoSize = true;
            this.MNameLabel.Location = new System.Drawing.Point(513, 418);
            this.MNameLabel.Name = "MNameLabel";
            this.MNameLabel.Size = new System.Drawing.Size(90, 19);
            this.MNameLabel.TabIndex = 22;
            this.MNameLabel.Text = "Middle name:";
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Location = new System.Drawing.Point(766, 418);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(84, 19);
            this.PhotoLabel.TabIndex = 23;
            this.PhotoLabel.Text = "Photo name:";
            // 
            // picReadersExcel
            // 
            this.picReadersExcel.BackColor = System.Drawing.Color.White;
            this.picReadersExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReadersExcel.Image = global::Library.Properties.Resources.excel;
            this.picReadersExcel.Location = new System.Drawing.Point(752, 3);
            this.picReadersExcel.Name = "picReadersExcel";
            this.picReadersExcel.Size = new System.Drawing.Size(64, 64);
            this.picReadersExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReadersExcel.TabIndex = 29;
            this.picReadersExcel.TabStop = false;
            this.picReadersExcel.Click += new System.EventHandler(this.picReadersExcel_Click);
            // 
            // picReadersPrint
            // 
            this.picReadersPrint.BackColor = System.Drawing.Color.White;
            this.picReadersPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReadersPrint.Image = global::Library.Properties.Resources.printer;
            this.picReadersPrint.Location = new System.Drawing.Point(883, 3);
            this.picReadersPrint.Name = "picReadersPrint";
            this.picReadersPrint.Size = new System.Drawing.Size(64, 64);
            this.picReadersPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReadersPrint.TabIndex = 28;
            this.picReadersPrint.TabStop = false;
            this.picReadersPrint.Click += new System.EventHandler(this.picReadersPrint_Click);
            // 
            // picReadersSave
            // 
            this.picReadersSave.BackColor = System.Drawing.Color.White;
            this.picReadersSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReadersSave.Image = global::Library.Properties.Resources.accept;
            this.picReadersSave.Location = new System.Drawing.Point(621, 5);
            this.picReadersSave.Name = "picReadersSave";
            this.picReadersSave.Size = new System.Drawing.Size(64, 64);
            this.picReadersSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReadersSave.TabIndex = 27;
            this.picReadersSave.TabStop = false;
            this.picReadersSave.Click += new System.EventHandler(this.picReadersSave_Click);
            // 
            // tbReadersSearch
            // 
            this.tbReadersSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbReadersSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReadersSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbReadersSearch.Location = new System.Drawing.Point(3, 3);
            this.tbReadersSearch.Name = "tbReadersSearch";
            this.tbReadersSearch.Size = new System.Drawing.Size(305, 66);
            this.tbReadersSearch.TabIndex = 26;
            this.tbReadersSearch.TabStop = false;
            this.tbReadersSearch.Text = "Search";
            this.tbReadersSearch.Click += new System.EventHandler(this.tbReadersSearch_Click);
            this.tbReadersSearch.TextChanged += new System.EventHandler(this.tbReadersSearch_TextChanged);
            this.tbReadersSearch.Leave += new System.EventHandler(this.tbReadersSearch_Leave);
            // 
            // picReadersMinus
            // 
            this.picReadersMinus.BackColor = System.Drawing.Color.White;
            this.picReadersMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReadersMinus.Image = global::Library.Properties.Resources.minus;
            this.picReadersMinus.Location = new System.Drawing.Point(490, 3);
            this.picReadersMinus.Name = "picReadersMinus";
            this.picReadersMinus.Size = new System.Drawing.Size(64, 64);
            this.picReadersMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReadersMinus.TabIndex = 25;
            this.picReadersMinus.TabStop = false;
            this.picReadersMinus.Click += new System.EventHandler(this.picReadersMinus_Click);
            // 
            // picReadersAdd
            // 
            this.picReadersAdd.BackColor = System.Drawing.Color.White;
            this.picReadersAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReadersAdd.Image = global::Library.Properties.Resources.add;
            this.picReadersAdd.Location = new System.Drawing.Point(359, 5);
            this.picReadersAdd.Name = "picReadersAdd";
            this.picReadersAdd.Size = new System.Drawing.Size(64, 64);
            this.picReadersAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReadersAdd.TabIndex = 24;
            this.picReadersAdd.TabStop = false;
            this.picReadersAdd.Click += new System.EventHandler(this.picReadersAdd_Click);
            // 
            // printReaders
            // 
            this.printReaders.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReaders_PrintPage);
            // 
            // ucReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picReadersExcel);
            this.Controls.Add(this.picReadersPrint);
            this.Controls.Add(this.picReadersSave);
            this.Controls.Add(this.tbReadersSearch);
            this.Controls.Add(this.picReadersMinus);
            this.Controls.Add(this.picReadersAdd);
            this.Controls.Add(this.PhotoLabel);
            this.Controls.Add(this.MNameLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.ReaderIDLabel);
            this.Controls.Add(this.CategoryIDLabel);
            this.Controls.Add(this.ReaderIDTextBox);
            this.Controls.Add(this.CategoryIDTextBox);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.Controls.Add(this.MNameTextBox);
            this.Controls.Add(this.ImageUrlTextBox);
            this.Controls.Add(this.mbtnReaderBrowse);
            this.Controls.Add(this.picReader);
            this.Controls.Add(this.readersMetroGrid);
            this.Name = "ucReaders";
            this.Size = new System.Drawing.Size(970, 475);
            this.Load += new System.EventHandler(this.ucReaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadersAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private LibraryDBDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public MetroFramework.Controls.MetroGrid readersMetroGrid;
        public System.Windows.Forms.BindingSource readerBindingSource;
        private System.Windows.Forms.PictureBox picReader;
        private MetroFramework.Controls.MetroButton mbtnReaderBrowse;
        private System.Windows.Forms.TextBox ReaderIDTextBox;
        private System.Windows.Forms.TextBox CategoryIDTextBox;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.TextBox MNameTextBox;
        private System.Windows.Forms.TextBox ImageUrlTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroLabel CategoryIDLabel;
        private MetroFramework.Controls.MetroLabel ReaderIDLabel;
        private MetroFramework.Controls.MetroLabel FNameLabel;
        private MetroFramework.Controls.MetroLabel LNameLabel;
        private MetroFramework.Controls.MetroLabel MNameLabel;
        private MetroFramework.Controls.MetroLabel PhotoLabel;
        private System.Windows.Forms.PictureBox picReadersExcel;
        private System.Windows.Forms.PictureBox picReadersPrint;
        private System.Windows.Forms.PictureBox picReadersSave;
        private System.Windows.Forms.TextBox tbReadersSearch;
        private System.Windows.Forms.PictureBox picReadersMinus;
        private System.Windows.Forms.PictureBox picReadersAdd;
        private System.Drawing.Printing.PrintDocument printReaders;
    }
}
