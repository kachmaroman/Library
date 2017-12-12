namespace Library
{
    partial class ucDebtors
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
            this.debtorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsTableAdapter = new Library.LibraryDBDataSetTableAdapters.DebtorsTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.debtorsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.DebtorIDTextBox = new System.Windows.Forms.TextBox();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.ReaderIDTextBox = new System.Windows.Forms.TextBox();
            this.DateWithMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.DateToMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.DebtorIDLabel = new MetroFramework.Controls.MetroLabel();
            this.BookIDLabel = new MetroFramework.Controls.MetroLabel();
            this.ReaderIDLabel = new MetroFramework.Controls.MetroLabel();
            this.DateWithLabel = new MetroFramework.Controls.MetroLabel();
            this.DateToLabel = new MetroFramework.Controls.MetroLabel();
            this.picDebtorsExcel = new System.Windows.Forms.PictureBox();
            this.picDebtorsPrint = new System.Windows.Forms.PictureBox();
            this.picDebtorsSave = new System.Windows.Forms.PictureBox();
            this.tbDebtorsSearch = new System.Windows.Forms.TextBox();
            this.picAuthorMinus = new System.Windows.Forms.PictureBox();
            this.picDebtorsAdd = new System.Windows.Forms.PictureBox();
            this.printDebtors = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debtorsBindingSource
            // 
            this.debtorsBindingSource.DataMember = "Debtors";
            this.debtorsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // debtorsTableAdapter
            // 
            this.debtorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CathedraTableAdapter = null;
            this.tableAdapterManager.DateMinTableAdapter = null;
            this.tableAdapterManager.DebtorsTableAdapter = this.debtorsTableAdapter;
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
            // debtorsMetroGrid
            // 
            this.debtorsMetroGrid.AllowUserToOrderColumns = true;
            this.debtorsMetroGrid.AllowUserToResizeRows = false;
            this.debtorsMetroGrid.AutoGenerateColumns = false;
            this.debtorsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.debtorsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debtorsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.debtorsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.debtorsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.debtorsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtorsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.debtorsMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.debtorsMetroGrid.DataSource = this.debtorsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.debtorsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.debtorsMetroGrid.EnableHeadersVisualStyles = false;
            this.debtorsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.debtorsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.debtorsMetroGrid.Location = new System.Drawing.Point(0, 75);
            this.debtorsMetroGrid.Name = "debtorsMetroGrid";
            this.debtorsMetroGrid.ReadOnly = true;
            this.debtorsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.debtorsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.debtorsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.debtorsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debtorsMetroGrid.Size = new System.Drawing.Size(970, 214);
            this.debtorsMetroGrid.TabIndex = 0;
            // 
            // DebtorIDTextBox
            // 
            this.DebtorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorsBindingSource, "DebtorID", true));
            this.DebtorIDTextBox.Location = new System.Drawing.Point(107, 340);
            this.DebtorIDTextBox.Name = "DebtorIDTextBox";
            this.DebtorIDTextBox.Size = new System.Drawing.Size(91, 20);
            this.DebtorIDTextBox.TabIndex = 2;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorsBindingSource, "BookID", true));
            this.BookIDTextBox.Location = new System.Drawing.Point(278, 340);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(87, 20);
            this.BookIDTextBox.TabIndex = 4;
            // 
            // ReaderIDTextBox
            // 
            this.ReaderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtorsBindingSource, "ReaderID", true));
            this.ReaderIDTextBox.Location = new System.Drawing.Point(458, 340);
            this.ReaderIDTextBox.Name = "ReaderIDTextBox";
            this.ReaderIDTextBox.Size = new System.Drawing.Size(73, 20);
            this.ReaderIDTextBox.TabIndex = 6;
            // 
            // DateWithMetroDateTime
            // 
            this.DateWithMetroDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateWithMetroDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.debtorsBindingSource, "DateWith", true));
            this.DateWithMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateWithMetroDateTime.Location = new System.Drawing.Point(622, 337);
            this.DateWithMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateWithMetroDateTime.Name = "DateWithMetroDateTime";
            this.DateWithMetroDateTime.Size = new System.Drawing.Size(108, 29);
            this.DateWithMetroDateTime.TabIndex = 8;
            this.DateWithMetroDateTime.TabStop = false;
            // 
            // DateToMetroDateTime
            // 
            this.DateToMetroDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateToMetroDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.debtorsBindingSource, "DateTo", true));
            this.DateToMetroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToMetroDateTime.Location = new System.Drawing.Point(816, 337);
            this.DateToMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateToMetroDateTime.Name = "DateToMetroDateTime";
            this.DateToMetroDateTime.Size = new System.Drawing.Size(108, 29);
            this.DateToMetroDateTime.TabIndex = 10;
            this.DateToMetroDateTime.TabStop = false;
            this.DateToMetroDateTime.UseCustomForeColor = true;
            this.DateToMetroDateTime.UseStyleColors = true;
            // 
            // DebtorIDLabel
            // 
            this.DebtorIDLabel.AutoSize = true;
            this.DebtorIDLabel.Location = new System.Drawing.Point(31, 340);
            this.DebtorIDLabel.Name = "DebtorIDLabel";
            this.DebtorIDLabel.Size = new System.Drawing.Size(69, 19);
            this.DebtorIDLabel.TabIndex = 11;
            this.DebtorIDLabel.Text = "Debtor ID:";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Location = new System.Drawing.Point(214, 340);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(58, 19);
            this.BookIDLabel.TabIndex = 12;
            this.BookIDLabel.Text = "Book ID:";
            // 
            // ReaderIDLabel
            // 
            this.ReaderIDLabel.AutoSize = true;
            this.ReaderIDLabel.Location = new System.Drawing.Point(381, 340);
            this.ReaderIDLabel.Name = "ReaderIDLabel";
            this.ReaderIDLabel.Size = new System.Drawing.Size(70, 19);
            this.ReaderIDLabel.TabIndex = 13;
            this.ReaderIDLabel.Text = "Reader ID:";
            // 
            // DateWithLabel
            // 
            this.DateWithLabel.AutoSize = true;
            this.DateWithLabel.Location = new System.Drawing.Point(550, 340);
            this.DateWithLabel.Name = "DateWithLabel";
            this.DateWithLabel.Size = new System.Drawing.Size(66, 19);
            this.DateWithLabel.TabIndex = 14;
            this.DateWithLabel.Text = "Date with:";
            // 
            // DateToLabel
            // 
            this.DateToLabel.AutoSize = true;
            this.DateToLabel.Location = new System.Drawing.Point(755, 340);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(55, 19);
            this.DateToLabel.TabIndex = 15;
            this.DateToLabel.Text = "Date to:";
            // 
            // picDebtorsExcel
            // 
            this.picDebtorsExcel.BackColor = System.Drawing.Color.White;
            this.picDebtorsExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDebtorsExcel.Image = global::Library.Properties.Resources.excel;
            this.picDebtorsExcel.Location = new System.Drawing.Point(752, 3);
            this.picDebtorsExcel.Name = "picDebtorsExcel";
            this.picDebtorsExcel.Size = new System.Drawing.Size(64, 64);
            this.picDebtorsExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDebtorsExcel.TabIndex = 22;
            this.picDebtorsExcel.TabStop = false;
            this.picDebtorsExcel.Click += new System.EventHandler(this.picDebtorsExcel_Click);
            // 
            // picDebtorsPrint
            // 
            this.picDebtorsPrint.BackColor = System.Drawing.Color.White;
            this.picDebtorsPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDebtorsPrint.Image = global::Library.Properties.Resources.printer;
            this.picDebtorsPrint.Location = new System.Drawing.Point(883, 3);
            this.picDebtorsPrint.Name = "picDebtorsPrint";
            this.picDebtorsPrint.Size = new System.Drawing.Size(64, 64);
            this.picDebtorsPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDebtorsPrint.TabIndex = 21;
            this.picDebtorsPrint.TabStop = false;
            this.picDebtorsPrint.Click += new System.EventHandler(this.picDebtorsPrint_Click);
            // 
            // picDebtorsSave
            // 
            this.picDebtorsSave.BackColor = System.Drawing.Color.White;
            this.picDebtorsSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDebtorsSave.Image = global::Library.Properties.Resources.accept;
            this.picDebtorsSave.Location = new System.Drawing.Point(621, 5);
            this.picDebtorsSave.Name = "picDebtorsSave";
            this.picDebtorsSave.Size = new System.Drawing.Size(64, 64);
            this.picDebtorsSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDebtorsSave.TabIndex = 20;
            this.picDebtorsSave.TabStop = false;
            this.picDebtorsSave.Click += new System.EventHandler(this.picDebtorsSave_Click);
            // 
            // tbDebtorsSearch
            // 
            this.tbDebtorsSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDebtorsSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDebtorsSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbDebtorsSearch.Location = new System.Drawing.Point(3, 3);
            this.tbDebtorsSearch.Name = "tbDebtorsSearch";
            this.tbDebtorsSearch.Size = new System.Drawing.Size(305, 66);
            this.tbDebtorsSearch.TabIndex = 19;
            this.tbDebtorsSearch.TabStop = false;
            this.tbDebtorsSearch.Text = "Search";
            this.tbDebtorsSearch.Click += new System.EventHandler(this.tbDebtorsSearch_Click);
            this.tbDebtorsSearch.TextChanged += new System.EventHandler(this.tbDebtorsSearch_TextChanged);
            this.tbDebtorsSearch.Leave += new System.EventHandler(this.tbDebtorsSearch_Leave);
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
            this.picAuthorMinus.TabIndex = 18;
            this.picAuthorMinus.TabStop = false;
            this.picAuthorMinus.Click += new System.EventHandler(this.picAuthorMinus_Click);
            // 
            // picDebtorsAdd
            // 
            this.picDebtorsAdd.BackColor = System.Drawing.Color.White;
            this.picDebtorsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDebtorsAdd.Image = global::Library.Properties.Resources.add;
            this.picDebtorsAdd.Location = new System.Drawing.Point(359, 5);
            this.picDebtorsAdd.Name = "picDebtorsAdd";
            this.picDebtorsAdd.Size = new System.Drawing.Size(64, 64);
            this.picDebtorsAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDebtorsAdd.TabIndex = 17;
            this.picDebtorsAdd.TabStop = false;
            this.picDebtorsAdd.Click += new System.EventHandler(this.picDebtorsAdd_Click);
            // 
            // printDebtors
            // 
            this.printDebtors.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDebtors_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DebtorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DebtorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReaderID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReaderID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateWith";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateWith";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateTo";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateTo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 202;
            // 
            // ucDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picDebtorsExcel);
            this.Controls.Add(this.picDebtorsPrint);
            this.Controls.Add(this.picDebtorsSave);
            this.Controls.Add(this.tbDebtorsSearch);
            this.Controls.Add(this.picAuthorMinus);
            this.Controls.Add(this.picDebtorsAdd);
            this.Controls.Add(this.DateToLabel);
            this.Controls.Add(this.DateWithLabel);
            this.Controls.Add(this.ReaderIDLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.DebtorIDLabel);
            this.Controls.Add(this.DebtorIDTextBox);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.ReaderIDTextBox);
            this.Controls.Add(this.DateWithMetroDateTime);
            this.Controls.Add(this.DateToMetroDateTime);
            this.Controls.Add(this.debtorsMetroGrid);
            this.Name = "ucDebtors";
            this.Size = new System.Drawing.Size(970, 398);
            this.Load += new System.EventHandler(this.ucDebtors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthorMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebtorsAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource debtorsBindingSource;
        private LibraryDBDataSetTableAdapters.DebtorsTableAdapter debtorsTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid debtorsMetroGrid;
        private System.Windows.Forms.TextBox DebtorIDTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox ReaderIDTextBox;
        private MetroFramework.Controls.MetroDateTime DateWithMetroDateTime;
        private MetroFramework.Controls.MetroDateTime DateToMetroDateTime;
        private MetroFramework.Controls.MetroLabel DebtorIDLabel;
        private MetroFramework.Controls.MetroLabel BookIDLabel;
        private MetroFramework.Controls.MetroLabel ReaderIDLabel;
        private MetroFramework.Controls.MetroLabel DateWithLabel;
        private MetroFramework.Controls.MetroLabel DateToLabel;
        private System.Windows.Forms.PictureBox picDebtorsExcel;
        private System.Windows.Forms.PictureBox picDebtorsPrint;
        private System.Windows.Forms.PictureBox picDebtorsSave;
        private System.Windows.Forms.TextBox tbDebtorsSearch;
        private System.Windows.Forms.PictureBox picAuthorMinus;
        private System.Windows.Forms.PictureBox picDebtorsAdd;
        private System.Drawing.Printing.PrintDocument printDebtors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
