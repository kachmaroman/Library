namespace Library
{
    partial class ucGiveBook
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
            this.RoomIDLabel = new MetroFramework.Controls.MetroLabel();
            this.DateGiveLabel = new MetroFramework.Controls.MetroLabel();
            this.DateTakeLabel = new MetroFramework.Controls.MetroLabel();
            this.ReaderIDLabel = new MetroFramework.Controls.MetroLabel();
            this.BookIDLabel = new MetroFramework.Controls.MetroLabel();
            this.GivingIDLabel = new MetroFramework.Controls.MetroLabel();
            this.GivingIDTextBox = new System.Windows.Forms.TextBox();
            this.giveBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.ReaderIDTextBox = new System.Windows.Forms.TextBox();
            this.DateTakeMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.dateGiveMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.giveBookTableAdapter = new Library.LibraryDBDataSetTableAdapters.GiveBookTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.giveBookMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.picBookExcel = new System.Windows.Forms.PictureBox();
            this.picGiveBookPrint = new System.Windows.Forms.PictureBox();
            this.picGiveBookSave = new System.Windows.Forms.PictureBox();
            this.tbGiveBookSearch = new System.Windows.Forms.TextBox();
            this.picGiveBookMinus = new System.Windows.Forms.PictureBox();
            this.picGiveBookAdd = new System.Windows.Forms.PictureBox();
            this.printGiveBooks = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.giveBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveBookMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomIDLabel
            // 
            this.RoomIDLabel.AutoSize = true;
            this.RoomIDLabel.Location = new System.Drawing.Point(792, 399);
            this.RoomIDLabel.Name = "RoomIDLabel";
            this.RoomIDLabel.Size = new System.Drawing.Size(64, 19);
            this.RoomIDLabel.TabIndex = 30;
            this.RoomIDLabel.Text = "Room ID:";
            // 
            // DateGiveLabel
            // 
            this.DateGiveLabel.AutoSize = true;
            this.DateGiveLabel.Location = new System.Drawing.Point(430, 400);
            this.DateGiveLabel.Name = "DateGiveLabel";
            this.DateGiveLabel.Size = new System.Drawing.Size(67, 19);
            this.DateGiveLabel.TabIndex = 29;
            this.DateGiveLabel.Text = "Date give:";
            // 
            // DateTakeLabel
            // 
            this.DateTakeLabel.AutoSize = true;
            this.DateTakeLabel.Location = new System.Drawing.Point(34, 400);
            this.DateTakeLabel.Name = "DateTakeLabel";
            this.DateTakeLabel.Size = new System.Drawing.Size(67, 19);
            this.DateTakeLabel.TabIndex = 28;
            this.DateTakeLabel.Text = "Date take:";
            // 
            // ReaderIDLabel
            // 
            this.ReaderIDLabel.AutoSize = true;
            this.ReaderIDLabel.Location = new System.Drawing.Point(792, 355);
            this.ReaderIDLabel.Name = "ReaderIDLabel";
            this.ReaderIDLabel.Size = new System.Drawing.Size(70, 19);
            this.ReaderIDLabel.TabIndex = 27;
            this.ReaderIDLabel.Text = "Reader ID:";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Location = new System.Drawing.Point(430, 356);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(58, 19);
            this.BookIDLabel.TabIndex = 26;
            this.BookIDLabel.Text = "Book ID:";
            // 
            // GivingIDLabel
            // 
            this.GivingIDLabel.AutoSize = true;
            this.GivingIDLabel.Location = new System.Drawing.Point(34, 356);
            this.GivingIDLabel.Name = "GivingIDLabel";
            this.GivingIDLabel.Size = new System.Drawing.Size(64, 19);
            this.GivingIDLabel.TabIndex = 25;
            this.GivingIDLabel.Text = "Giving ID:";
            // 
            // GivingIDTextBox
            // 
            this.GivingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giveBookBindingSource, "GivingID", true));
            this.GivingIDTextBox.Location = new System.Drawing.Point(107, 355);
            this.GivingIDTextBox.Name = "GivingIDTextBox";
            this.GivingIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.GivingIDTextBox.TabIndex = 19;
            // 
            // giveBookBindingSource
            // 
            this.giveBookBindingSource.DataMember = "GiveBook";
            this.giveBookBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giveBookBindingSource, "BookID", true));
            this.BookIDTextBox.Location = new System.Drawing.Point(502, 355);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(72, 20);
            this.BookIDTextBox.TabIndex = 20;
            // 
            // ReaderIDTextBox
            // 
            this.ReaderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giveBookBindingSource, "ReaderID", true));
            this.ReaderIDTextBox.Location = new System.Drawing.Point(868, 355);
            this.ReaderIDTextBox.Name = "ReaderIDTextBox";
            this.ReaderIDTextBox.Size = new System.Drawing.Size(64, 20);
            this.ReaderIDTextBox.TabIndex = 21;
            // 
            // DateTakeMetroDateTime
            // 
            this.DateTakeMetroDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTakeMetroDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.giveBookBindingSource, "DateTake", true));
            this.DateTakeMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTakeMetroDateTime.Location = new System.Drawing.Point(107, 395);
            this.DateTakeMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTakeMetroDateTime.Name = "DateTakeMetroDateTime";
            this.DateTakeMetroDateTime.Size = new System.Drawing.Size(134, 29);
            this.DateTakeMetroDateTime.TabIndex = 22;
            // 
            // dateGiveMetroDateTime
            // 
            this.dateGiveMetroDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateGiveMetroDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.giveBookBindingSource, "DateGive", true));
            this.dateGiveMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiveMetroDateTime.Location = new System.Drawing.Point(503, 396);
            this.dateGiveMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateGiveMetroDateTime.Name = "dateGiveMetroDateTime";
            this.dateGiveMetroDateTime.Size = new System.Drawing.Size(134, 29);
            this.dateGiveMetroDateTime.TabIndex = 23;
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giveBookBindingSource, "RoomID", true));
            this.roomIDTextBox.Location = new System.Drawing.Point(868, 399);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(64, 20);
            this.roomIDTextBox.TabIndex = 24;
            // 
            // giveBookTableAdapter
            // 
            this.giveBookTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GiveBookTableAdapter = this.giveBookTableAdapter;
            this.tableAdapterManager.OtherReadersTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // giveBookMetroGrid
            // 
            this.giveBookMetroGrid.AllowUserToResizeRows = false;
            this.giveBookMetroGrid.AutoGenerateColumns = false;
            this.giveBookMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.giveBookMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giveBookMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.giveBookMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.giveBookMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.giveBookMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giveBookMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.giveBookMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giveBookMetroGrid.DataSource = this.giveBookBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.giveBookMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.giveBookMetroGrid.EnableHeadersVisualStyles = false;
            this.giveBookMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.giveBookMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.giveBookMetroGrid.Location = new System.Drawing.Point(0, 72);
            this.giveBookMetroGrid.Name = "giveBookMetroGrid";
            this.giveBookMetroGrid.ReadOnly = true;
            this.giveBookMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.giveBookMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.giveBookMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.giveBookMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.giveBookMetroGrid.Size = new System.Drawing.Size(970, 265);
            this.giveBookMetroGrid.TabIndex = 31;
            // 
            // picBookExcel
            // 
            this.picBookExcel.BackColor = System.Drawing.Color.White;
            this.picBookExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookExcel.Image = global::Library.Properties.Resources.excel;
            this.picBookExcel.Location = new System.Drawing.Point(752, 3);
            this.picBookExcel.Name = "picBookExcel";
            this.picBookExcel.Size = new System.Drawing.Size(64, 64);
            this.picBookExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookExcel.TabIndex = 37;
            this.picBookExcel.TabStop = false;
            this.picBookExcel.Click += new System.EventHandler(this.picBookExcel_Click);
            // 
            // picGiveBookPrint
            // 
            this.picGiveBookPrint.BackColor = System.Drawing.Color.White;
            this.picGiveBookPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGiveBookPrint.Image = global::Library.Properties.Resources.printer;
            this.picGiveBookPrint.Location = new System.Drawing.Point(883, 3);
            this.picGiveBookPrint.Name = "picGiveBookPrint";
            this.picGiveBookPrint.Size = new System.Drawing.Size(64, 64);
            this.picGiveBookPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGiveBookPrint.TabIndex = 36;
            this.picGiveBookPrint.TabStop = false;
            this.picGiveBookPrint.Click += new System.EventHandler(this.picGiveBookPrint_Click);
            // 
            // picGiveBookSave
            // 
            this.picGiveBookSave.BackColor = System.Drawing.Color.White;
            this.picGiveBookSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGiveBookSave.Image = global::Library.Properties.Resources.accept;
            this.picGiveBookSave.Location = new System.Drawing.Point(621, 5);
            this.picGiveBookSave.Name = "picGiveBookSave";
            this.picGiveBookSave.Size = new System.Drawing.Size(64, 64);
            this.picGiveBookSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGiveBookSave.TabIndex = 35;
            this.picGiveBookSave.TabStop = false;
            this.picGiveBookSave.Click += new System.EventHandler(this.picGiveBookSave_Click);
            // 
            // tbGiveBookSearch
            // 
            this.tbGiveBookSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGiveBookSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGiveBookSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbGiveBookSearch.Location = new System.Drawing.Point(3, 3);
            this.tbGiveBookSearch.Name = "tbGiveBookSearch";
            this.tbGiveBookSearch.Size = new System.Drawing.Size(305, 66);
            this.tbGiveBookSearch.TabIndex = 34;
            this.tbGiveBookSearch.TabStop = false;
            this.tbGiveBookSearch.Text = "Search";
            this.tbGiveBookSearch.Click += new System.EventHandler(this.tbGiveBookSearch_Click);
            this.tbGiveBookSearch.TextChanged += new System.EventHandler(this.tbGiveBookSearch_TextChanged);
            this.tbGiveBookSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiveBookSearch_KeyPress);
            this.tbGiveBookSearch.Leave += new System.EventHandler(this.tbGiveBookSearch_Leave);
            // 
            // picGiveBookMinus
            // 
            this.picGiveBookMinus.BackColor = System.Drawing.Color.White;
            this.picGiveBookMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGiveBookMinus.Image = global::Library.Properties.Resources.minus;
            this.picGiveBookMinus.Location = new System.Drawing.Point(490, 3);
            this.picGiveBookMinus.Name = "picGiveBookMinus";
            this.picGiveBookMinus.Size = new System.Drawing.Size(64, 64);
            this.picGiveBookMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGiveBookMinus.TabIndex = 33;
            this.picGiveBookMinus.TabStop = false;
            this.picGiveBookMinus.Click += new System.EventHandler(this.picGiveBookMinus_Click);
            // 
            // picGiveBookAdd
            // 
            this.picGiveBookAdd.BackColor = System.Drawing.Color.White;
            this.picGiveBookAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGiveBookAdd.Image = global::Library.Properties.Resources.add;
            this.picGiveBookAdd.Location = new System.Drawing.Point(359, 5);
            this.picGiveBookAdd.Name = "picGiveBookAdd";
            this.picGiveBookAdd.Size = new System.Drawing.Size(64, 64);
            this.picGiveBookAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGiveBookAdd.TabIndex = 32;
            this.picGiveBookAdd.TabStop = false;
            this.picGiveBookAdd.Click += new System.EventHandler(this.picGiveBookAdd_Click);
            // 
            // printGiveBooks
            // 
            this.printGiveBooks.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printGiveBooks_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GivingID";
            this.dataGridViewTextBoxColumn1.HeaderText = "GivingID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReaderID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReaderID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateTake";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateTake";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateGive";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateGive";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RoomID";
            this.dataGridViewTextBoxColumn6.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 162;
            // 
            // ucGiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBookExcel);
            this.Controls.Add(this.picGiveBookPrint);
            this.Controls.Add(this.picGiveBookSave);
            this.Controls.Add(this.tbGiveBookSearch);
            this.Controls.Add(this.picGiveBookMinus);
            this.Controls.Add(this.picGiveBookAdd);
            this.Controls.Add(this.giveBookMetroGrid);
            this.Controls.Add(this.RoomIDLabel);
            this.Controls.Add(this.DateGiveLabel);
            this.Controls.Add(this.DateTakeLabel);
            this.Controls.Add(this.ReaderIDLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.GivingIDLabel);
            this.Controls.Add(this.GivingIDTextBox);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.ReaderIDTextBox);
            this.Controls.Add(this.DateTakeMetroDateTime);
            this.Controls.Add(this.dateGiveMetroDateTime);
            this.Controls.Add(this.roomIDTextBox);
            this.Name = "ucGiveBook";
            this.Size = new System.Drawing.Size(970, 440);
            this.Load += new System.EventHandler(this.ucGiveBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giveBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveBookMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveBookAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel RoomIDLabel;
        private MetroFramework.Controls.MetroLabel DateGiveLabel;
        private MetroFramework.Controls.MetroLabel DateTakeLabel;
        private MetroFramework.Controls.MetroLabel ReaderIDLabel;
        private MetroFramework.Controls.MetroLabel BookIDLabel;
        private MetroFramework.Controls.MetroLabel GivingIDLabel;
        private System.Windows.Forms.TextBox GivingIDTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox ReaderIDTextBox;
        private MetroFramework.Controls.MetroDateTime DateTakeMetroDateTime;
        private MetroFramework.Controls.MetroDateTime dateGiveMetroDateTime;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource giveBookBindingSource;
        private LibraryDBDataSetTableAdapters.GiveBookTableAdapter giveBookTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid giveBookMetroGrid;
        private System.Windows.Forms.PictureBox picBookExcel;
        private System.Windows.Forms.PictureBox picGiveBookPrint;
        private System.Windows.Forms.PictureBox picGiveBookSave;
        private System.Windows.Forms.TextBox tbGiveBookSearch;
        private System.Windows.Forms.PictureBox picGiveBookMinus;
        private System.Windows.Forms.PictureBox picGiveBookAdd;
        private System.Drawing.Printing.PrintDocument printGiveBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
