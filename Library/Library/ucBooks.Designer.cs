namespace Library
{
    partial class ucBooks
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
            this.booksMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.booksTableAdapter = new Library.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorIDTextBox = new System.Windows.Forms.TextBox();
            this.EditionIDTextBox = new System.Windows.Forms.TextBox();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.BookIDLabel = new MetroFramework.Controls.MetroLabel();
            this.BookNameLabel = new MetroFramework.Controls.MetroLabel();
            this.AuthorIDLabel = new MetroFramework.Controls.MetroLabel();
            this.EditionIDLabel = new MetroFramework.Controls.MetroLabel();
            this.QtyLabel = new MetroFramework.Controls.MetroLabel();
            this.tbBookSearch = new System.Windows.Forms.TextBox();
            this.printBooks = new System.Drawing.Printing.PrintDocument();
            this.picBookDiagram = new System.Windows.Forms.PictureBox();
            this.picBookExcel = new System.Windows.Forms.PictureBox();
            this.picBookPrint = new System.Windows.Forms.PictureBox();
            this.picBookSave = new System.Windows.Forms.PictureBox();
            this.picBookMinus = new System.Windows.Forms.PictureBox();
            this.picBookAdd = new System.Windows.Forms.PictureBox();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // booksMetroGrid
            // 
            this.booksMetroGrid.AllowUserToOrderColumns = true;
            this.booksMetroGrid.AllowUserToResizeRows = false;
            this.booksMetroGrid.AutoGenerateColumns = false;
            this.booksMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.editionIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.booksMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booksMetroGrid.DataSource = this.booksBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.booksMetroGrid.EnableHeadersVisualStyles = false;
            this.booksMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.booksMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksMetroGrid.Location = new System.Drawing.Point(0, 73);
            this.booksMetroGrid.Name = "booksMetroGrid";
            this.booksMetroGrid.ReadOnly = true;
            this.booksMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.booksMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.booksMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksMetroGrid.Size = new System.Drawing.Size(970, 428);
            this.booksMetroGrid.TabIndex = 0;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CathedraTableAdapter = null;
            this.tableAdapterManager.DateMinTableAdapter = null;
            this.tableAdapterManager.DebtorsTableAdapter = null;
            this.tableAdapterManager.DegreesTableAdapter = null;
            this.tableAdapterManager.EditionsTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.GiveBookTableAdapter = null;
            this.tableAdapterManager.OtherReadersTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "BookID", true));
            this.BookIDTextBox.Location = new System.Drawing.Point(98, 523);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(370, 20);
            this.BookIDTextBox.TabIndex = 2;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "BookName", true));
            this.BookNameTextBox.Location = new System.Drawing.Point(98, 563);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(841, 20);
            this.BookNameTextBox.TabIndex = 4;
            // 
            // AuthorIDTextBox
            // 
            this.AuthorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "AuthorID", true));
            this.AuthorIDTextBox.Location = new System.Drawing.Point(559, 522);
            this.AuthorIDTextBox.Name = "AuthorIDTextBox";
            this.AuthorIDTextBox.Size = new System.Drawing.Size(72, 20);
            this.AuthorIDTextBox.TabIndex = 6;
            // 
            // EditionIDTextBox
            // 
            this.EditionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "EditionID", true));
            this.EditionIDTextBox.Location = new System.Drawing.Point(726, 522);
            this.EditionIDTextBox.Name = "EditionIDTextBox";
            this.EditionIDTextBox.Size = new System.Drawing.Size(70, 20);
            this.EditionIDTextBox.TabIndex = 8;
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Qty", true));
            this.QtyTextBox.Location = new System.Drawing.Point(884, 522);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(55, 20);
            this.QtyTextBox.TabIndex = 10;
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Location = new System.Drawing.Point(34, 523);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(58, 19);
            this.BookIDLabel.TabIndex = 11;
            this.BookIDLabel.Text = "Book ID:";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(34, 563);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(48, 19);
            this.BookNameLabel.TabIndex = 12;
            this.BookNameLabel.Text = "Name:";
            // 
            // AuthorIDLabel
            // 
            this.AuthorIDLabel.AutoSize = true;
            this.AuthorIDLabel.Location = new System.Drawing.Point(485, 523);
            this.AuthorIDLabel.Name = "AuthorIDLabel";
            this.AuthorIDLabel.Size = new System.Drawing.Size(68, 19);
            this.AuthorIDLabel.TabIndex = 13;
            this.AuthorIDLabel.Text = "Author ID:";
            // 
            // EditionIDLabel
            // 
            this.EditionIDLabel.AutoSize = true;
            this.EditionIDLabel.Location = new System.Drawing.Point(652, 523);
            this.EditionIDLabel.Name = "EditionIDLabel";
            this.EditionIDLabel.Size = new System.Drawing.Size(68, 19);
            this.EditionIDLabel.TabIndex = 14;
            this.EditionIDLabel.Text = "Edition ID:";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Location = new System.Drawing.Point(817, 523);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(61, 19);
            this.QtyLabel.TabIndex = 15;
            this.QtyLabel.Text = "Quantity:";
            // 
            // tbBookSearch
            // 
            this.tbBookSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBookSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBookSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbBookSearch.Location = new System.Drawing.Point(3, 3);
            this.tbBookSearch.Name = "tbBookSearch";
            this.tbBookSearch.Size = new System.Drawing.Size(305, 66);
            this.tbBookSearch.TabIndex = 19;
            this.tbBookSearch.TabStop = false;
            this.tbBookSearch.Text = "Search";
            this.tbBookSearch.Click += new System.EventHandler(this.tbBookSearch_Click);
            this.tbBookSearch.TextChanged += new System.EventHandler(this.tbBookSearch_TextChanged);
            this.tbBookSearch.Leave += new System.EventHandler(this.tbBookSearch_Leave);
            // 
            // printBooks
            // 
            this.printBooks.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBooks_PrintPage);
            // 
            // picBookDiagram
            // 
            this.picBookDiagram.BackColor = System.Drawing.Color.White;
            this.picBookDiagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookDiagram.Image = global::Library.Properties.Resources.Diagram;
            this.picBookDiagram.Location = new System.Drawing.Point(671, 5);
            this.picBookDiagram.Name = "picBookDiagram";
            this.picBookDiagram.Size = new System.Drawing.Size(64, 64);
            this.picBookDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookDiagram.TabIndex = 23;
            this.picBookDiagram.TabStop = false;
            this.picBookDiagram.Click += new System.EventHandler(this.picBookDiagram_Click);
            // 
            // picBookExcel
            // 
            this.picBookExcel.BackColor = System.Drawing.Color.White;
            this.picBookExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookExcel.Image = global::Library.Properties.Resources.excel;
            this.picBookExcel.Location = new System.Drawing.Point(775, 3);
            this.picBookExcel.Name = "picBookExcel";
            this.picBookExcel.Size = new System.Drawing.Size(64, 64);
            this.picBookExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookExcel.TabIndex = 22;
            this.picBookExcel.TabStop = false;
            this.picBookExcel.Click += new System.EventHandler(this.picBookExcel_Click);
            // 
            // picBookPrint
            // 
            this.picBookPrint.BackColor = System.Drawing.Color.White;
            this.picBookPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookPrint.Image = global::Library.Properties.Resources.printer;
            this.picBookPrint.Location = new System.Drawing.Point(879, 3);
            this.picBookPrint.Name = "picBookPrint";
            this.picBookPrint.Size = new System.Drawing.Size(64, 64);
            this.picBookPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookPrint.TabIndex = 21;
            this.picBookPrint.TabStop = false;
            this.picBookPrint.Click += new System.EventHandler(this.picBookPrint_Click);
            // 
            // picBookSave
            // 
            this.picBookSave.BackColor = System.Drawing.Color.White;
            this.picBookSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookSave.Image = global::Library.Properties.Resources.accept;
            this.picBookSave.Location = new System.Drawing.Point(567, 5);
            this.picBookSave.Name = "picBookSave";
            this.picBookSave.Size = new System.Drawing.Size(64, 64);
            this.picBookSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookSave.TabIndex = 20;
            this.picBookSave.TabStop = false;
            this.picBookSave.Click += new System.EventHandler(this.picBookSave_Click);
            // 
            // picBookMinus
            // 
            this.picBookMinus.BackColor = System.Drawing.Color.White;
            this.picBookMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookMinus.Image = global::Library.Properties.Resources.minus;
            this.picBookMinus.Location = new System.Drawing.Point(463, 3);
            this.picBookMinus.Name = "picBookMinus";
            this.picBookMinus.Size = new System.Drawing.Size(64, 64);
            this.picBookMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookMinus.TabIndex = 18;
            this.picBookMinus.TabStop = false;
            this.picBookMinus.Click += new System.EventHandler(this.picBookMinus_Click);
            // 
            // picBookAdd
            // 
            this.picBookAdd.BackColor = System.Drawing.Color.White;
            this.picBookAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookAdd.Image = global::Library.Properties.Resources.add;
            this.picBookAdd.Location = new System.Drawing.Point(359, 5);
            this.picBookAdd.Name = "picBookAdd";
            this.picBookAdd.Size = new System.Drawing.Size(64, 64);
            this.picBookAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBookAdd.TabIndex = 17;
            this.picBookAdd.TabStop = false;
            this.picBookAdd.Click += new System.EventHandler(this.picBookAdd_Click);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 370;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIDDataGridViewTextBoxColumn.Width = 145;
            // 
            // editionIDDataGridViewTextBoxColumn
            // 
            this.editionIDDataGridViewTextBoxColumn.DataPropertyName = "EditionID";
            this.editionIDDataGridViewTextBoxColumn.HeaderText = "EditionID";
            this.editionIDDataGridViewTextBoxColumn.Name = "editionIDDataGridViewTextBoxColumn";
            this.editionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.editionIDDataGridViewTextBoxColumn.Width = 165;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 133;
            // 
            // ucBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBookDiagram);
            this.Controls.Add(this.picBookExcel);
            this.Controls.Add(this.picBookPrint);
            this.Controls.Add(this.picBookSave);
            this.Controls.Add(this.tbBookSearch);
            this.Controls.Add(this.picBookMinus);
            this.Controls.Add(this.picBookAdd);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.EditionIDLabel);
            this.Controls.Add(this.AuthorIDLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.AuthorIDTextBox);
            this.Controls.Add(this.EditionIDTextBox);
            this.Controls.Add(this.QtyTextBox);
            this.Controls.Add(this.booksMetroGrid);
            this.Name = "ucBooks";
            this.Size = new System.Drawing.Size(970, 593);
            this.Load += new System.EventHandler(this.ucBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox AuthorIDTextBox;
        private System.Windows.Forms.TextBox EditionIDTextBox;
        private System.Windows.Forms.TextBox QtyTextBox;
        private MetroFramework.Controls.MetroLabel BookIDLabel;
        private MetroFramework.Controls.MetroLabel BookNameLabel;
        private MetroFramework.Controls.MetroLabel AuthorIDLabel;
        private MetroFramework.Controls.MetroLabel EditionIDLabel;
        private MetroFramework.Controls.MetroLabel QtyLabel;
        private System.Windows.Forms.PictureBox picBookExcel;
        private System.Windows.Forms.PictureBox picBookPrint;
        private System.Windows.Forms.PictureBox picBookSave;
        private System.Windows.Forms.TextBox tbBookSearch;
        private System.Windows.Forms.PictureBox picBookMinus;
        private System.Windows.Forms.PictureBox picBookAdd;
        private System.Drawing.Printing.PrintDocument printBooks;
        public MetroFramework.Controls.MetroGrid booksMetroGrid;
        public System.Windows.Forms.BindingSource booksBindingSource;
        public LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.PictureBox picBookDiagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
    }
}
