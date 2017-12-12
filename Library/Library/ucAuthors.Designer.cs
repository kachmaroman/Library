namespace Library
{
    partial class ucAuthors
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
            this.authorsTableAdapter = new Library.LibraryDBDataSetTableAdapters.AuthorsTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.booksTableAdapter = new Library.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuthorIDLabel = new MetroFramework.Controls.MetroLabel();
            this.FullNameLabel = new MetroFramework.Controls.MetroLabel();
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.picAuthorExcel = new System.Windows.Forms.PictureBox();
            this.picAuthorPrint = new System.Windows.Forms.PictureBox();
            this.picAuthorSave = new System.Windows.Forms.PictureBox();
            this.picAuthorMinus = new System.Windows.Forms.PictureBox();
            this.picAuthorAdd = new System.Windows.Forms.PictureBox();
            this.printAuthors = new System.Drawing.Printing.PrintDocument();
            this.AuthorIDTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.authorsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = this.authorsTableAdapter;
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
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // AuthorIDLabel
            // 
            this.AuthorIDLabel.AutoSize = true;
            this.AuthorIDLabel.Location = new System.Drawing.Point(40, 355);
            this.AuthorIDLabel.Name = "AuthorIDLabel";
            this.AuthorIDLabel.Size = new System.Drawing.Size(68, 19);
            this.AuthorIDLabel.TabIndex = 5;
            this.AuthorIDLabel.Text = "Author ID:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(441, 355);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(69, 19);
            this.FullNameLabel.TabIndex = 6;
            this.FullNameLabel.Text = "Full name:";
            // 
            // tbAuthorSearch
            // 
            this.tbAuthorSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAuthorSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthorSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbAuthorSearch.Location = new System.Drawing.Point(3, 3);
            this.tbAuthorSearch.Name = "tbAuthorSearch";
            this.tbAuthorSearch.Size = new System.Drawing.Size(305, 66);
            this.tbAuthorSearch.TabIndex = 13;
            this.tbAuthorSearch.TabStop = false;
            this.tbAuthorSearch.Text = "Search";
            this.tbAuthorSearch.Click += new System.EventHandler(this.tbAuthorSearch_Click);
            this.tbAuthorSearch.TextChanged += new System.EventHandler(this.tbAuthorSearch_TextChanged);
            this.tbAuthorSearch.Leave += new System.EventHandler(this.tbAuthorSearch_Leave);
            // 
            // picAuthorExcel
            // 
            this.picAuthorExcel.BackColor = System.Drawing.Color.White;
            this.picAuthorExcel.Image = global::Library.Properties.Resources.excel;
            this.picAuthorExcel.Location = new System.Drawing.Point(752, 3);
            this.picAuthorExcel.Name = "picAuthorExcel";
            this.picAuthorExcel.Size = new System.Drawing.Size(64, 64);
            this.picAuthorExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAuthorExcel.TabIndex = 16;
            this.picAuthorExcel.TabStop = false;
            this.picAuthorExcel.Click += new System.EventHandler(this.picAuthorExcel_Click);
            // 
            // picAuthorPrint
            // 
            this.picAuthorPrint.BackColor = System.Drawing.Color.White;
            this.picAuthorPrint.Image = global::Library.Properties.Resources.printer;
            this.picAuthorPrint.Location = new System.Drawing.Point(883, 3);
            this.picAuthorPrint.Name = "picAuthorPrint";
            this.picAuthorPrint.Size = new System.Drawing.Size(64, 64);
            this.picAuthorPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAuthorPrint.TabIndex = 15;
            this.picAuthorPrint.TabStop = false;
            this.picAuthorPrint.Click += new System.EventHandler(this.picAuthorPrint_Click);
            // 
            // picAuthorSave
            // 
            this.picAuthorSave.BackColor = System.Drawing.Color.White;
            this.picAuthorSave.Image = global::Library.Properties.Resources.accept;
            this.picAuthorSave.Location = new System.Drawing.Point(621, 5);
            this.picAuthorSave.Name = "picAuthorSave";
            this.picAuthorSave.Size = new System.Drawing.Size(64, 64);
            this.picAuthorSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAuthorSave.TabIndex = 14;
            this.picAuthorSave.TabStop = false;
            this.picAuthorSave.Click += new System.EventHandler(this.picAuthorSave_Click);
            // 
            // picAuthorMinus
            // 
            this.picAuthorMinus.BackColor = System.Drawing.Color.White;
            this.picAuthorMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAuthorMinus.Image = global::Library.Properties.Resources.minus;
            this.picAuthorMinus.Location = new System.Drawing.Point(490, 3);
            this.picAuthorMinus.Name = "picAuthorMinus";
            this.picAuthorMinus.Size = new System.Drawing.Size(64, 64);
            this.picAuthorMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAuthorMinus.TabIndex = 8;
            this.picAuthorMinus.TabStop = false;
            this.picAuthorMinus.Click += new System.EventHandler(this.picAuthorMinus_Click);
            // 
            // picAuthorAdd
            // 
            this.picAuthorAdd.BackColor = System.Drawing.Color.White;
            this.picAuthorAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAuthorAdd.Image = global::Library.Properties.Resources.add;
            this.picAuthorAdd.Location = new System.Drawing.Point(359, 5);
            this.picAuthorAdd.Name = "picAuthorAdd";
            this.picAuthorAdd.Size = new System.Drawing.Size(64, 64);
            this.picAuthorAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAuthorAdd.TabIndex = 7;
            this.picAuthorAdd.TabStop = false;
            this.picAuthorAdd.Click += new System.EventHandler(this.picAuthorAdd_Click);
            // 
            // printAuthors
            // 
            this.printAuthors.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAuthors_PrintPage);
            // 
            // AuthorIDTextBox
            // 
            this.AuthorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "AuthorID", true));
            this.AuthorIDTextBox.Location = new System.Drawing.Point(114, 354);
            this.AuthorIDTextBox.Name = "AuthorIDTextBox";
            this.AuthorIDTextBox.Size = new System.Drawing.Size(309, 20);
            this.AuthorIDTextBox.TabIndex = 17;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "FullName", true));
            this.FullNameTextBox.Location = new System.Drawing.Point(516, 354);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(431, 20);
            this.FullNameTextBox.TabIndex = 19;
            // 
            // authorsMetroGrid
            // 
            this.authorsMetroGrid.AllowUserToOrderColumns = true;
            this.authorsMetroGrid.AllowUserToResizeRows = false;
            this.authorsMetroGrid.AutoGenerateColumns = false;
            this.authorsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.authorsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.authorsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.authorsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.authorsMetroGrid.DataSource = this.authorsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.authorsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.authorsMetroGrid.EnableHeadersVisualStyles = false;
            this.authorsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.authorsMetroGrid.Location = new System.Drawing.Point(3, 75);
            this.authorsMetroGrid.Name = "authorsMetroGrid";
            this.authorsMetroGrid.ReadOnly = true;
            this.authorsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.authorsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.authorsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorsMetroGrid.Size = new System.Drawing.Size(967, 239);
            this.authorsMetroGrid.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AuthorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AuthorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 393;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 516;
            // 
            // ucAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authorsMetroGrid);
            this.Controls.Add(this.AuthorIDTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.picAuthorExcel);
            this.Controls.Add(this.picAuthorPrint);
            this.Controls.Add(this.picAuthorSave);
            this.Controls.Add(this.tbAuthorSearch);
            this.Controls.Add(this.picAuthorMinus);
            this.Controls.Add(this.picAuthorAdd);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.AuthorIDLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucAuthors";
            this.Size = new System.Drawing.Size(970, 402);
            this.Load += new System.EventHandler(this.ucAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryDBDataSet libraryDBDataSet;
        private LibraryDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private MetroFramework.Controls.MetroLabel AuthorIDLabel;
        private MetroFramework.Controls.MetroLabel FullNameLabel;
        public System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.PictureBox picAuthorAdd;
        private System.Windows.Forms.PictureBox picAuthorMinus;
        private System.Windows.Forms.TextBox tbAuthorSearch;
        private System.Windows.Forms.PictureBox picAuthorSave;
        private System.Windows.Forms.PictureBox picAuthorPrint;
        private System.Windows.Forms.PictureBox picAuthorExcel;
        private System.Drawing.Printing.PrintDocument printAuthors;
        private System.Windows.Forms.TextBox AuthorIDTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private MetroFramework.Controls.MetroGrid authorsMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
