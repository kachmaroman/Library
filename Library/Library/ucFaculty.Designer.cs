namespace Library
{
    partial class ucFaculty
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
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new Library.LibraryDBDataSetTableAdapters.FacultyTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.facultyMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.FacultyIDTextBox = new System.Windows.Forms.TextBox();
            this.FacultyNameTextBox = new System.Windows.Forms.TextBox();
            this.FacultyIDLabel = new MetroFramework.Controls.MetroLabel();
            this.FacultyNameLabel = new MetroFramework.Controls.MetroLabel();
            this.picFacultyExcel = new System.Windows.Forms.PictureBox();
            this.picFacultyPrint = new System.Windows.Forms.PictureBox();
            this.picFacultySave = new System.Windows.Forms.PictureBox();
            this.tbFacultySearch = new System.Windows.Forms.TextBox();
            this.picFacultyMinus = new System.Windows.Forms.PictureBox();
            this.picFacultyAdd = new System.Windows.Forms.PictureBox();
            this.printFaculty = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultySave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.GiveBookTableAdapter = null;
            this.tableAdapterManager.OtherReadersTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facultyMetroGrid
            // 
            this.facultyMetroGrid.AllowUserToOrderColumns = true;
            this.facultyMetroGrid.AllowUserToResizeRows = false;
            this.facultyMetroGrid.AutoGenerateColumns = false;
            this.facultyMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.facultyMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultyMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.facultyMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facultyMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.facultyMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.facultyMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facultyMetroGrid.DataSource = this.facultyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.facultyMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.facultyMetroGrid.EnableHeadersVisualStyles = false;
            this.facultyMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.facultyMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.facultyMetroGrid.Location = new System.Drawing.Point(0, 73);
            this.facultyMetroGrid.Name = "facultyMetroGrid";
            this.facultyMetroGrid.ReadOnly = true;
            this.facultyMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facultyMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.facultyMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.facultyMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facultyMetroGrid.Size = new System.Drawing.Size(970, 227);
            this.facultyMetroGrid.TabIndex = 1;
            // 
            // FacultyIDTextBox
            // 
            this.FacultyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyID", true));
            this.FacultyIDTextBox.Location = new System.Drawing.Point(119, 332);
            this.FacultyIDTextBox.Name = "FacultyIDTextBox";
            this.FacultyIDTextBox.Size = new System.Drawing.Size(312, 20);
            this.FacultyIDTextBox.TabIndex = 2;
            // 
            // FacultyNameTextBox
            // 
            this.FacultyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyName", true));
            this.FacultyNameTextBox.Location = new System.Drawing.Point(508, 332);
            this.FacultyNameTextBox.Name = "FacultyNameTextBox";
            this.FacultyNameTextBox.Size = new System.Drawing.Size(443, 20);
            this.FacultyNameTextBox.TabIndex = 4;
            // 
            // FacultyIDLabel
            // 
            this.FacultyIDLabel.AutoSize = true;
            this.FacultyIDLabel.Location = new System.Drawing.Point(41, 332);
            this.FacultyIDLabel.Name = "FacultyIDLabel";
            this.FacultyIDLabel.Size = new System.Drawing.Size(67, 19);
            this.FacultyIDLabel.TabIndex = 5;
            this.FacultyIDLabel.Text = "Faculty ID:";
            // 
            // FacultyNameLabel
            // 
            this.FacultyNameLabel.AutoSize = true;
            this.FacultyNameLabel.Location = new System.Drawing.Point(454, 332);
            this.FacultyNameLabel.Name = "FacultyNameLabel";
            this.FacultyNameLabel.Size = new System.Drawing.Size(48, 19);
            this.FacultyNameLabel.TabIndex = 6;
            this.FacultyNameLabel.Text = "Name:";
            // 
            // picFacultyExcel
            // 
            this.picFacultyExcel.BackColor = System.Drawing.Color.White;
            this.picFacultyExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacultyExcel.Image = global::Library.Properties.Resources.excel;
            this.picFacultyExcel.Location = new System.Drawing.Point(752, 3);
            this.picFacultyExcel.Name = "picFacultyExcel";
            this.picFacultyExcel.Size = new System.Drawing.Size(64, 64);
            this.picFacultyExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFacultyExcel.TabIndex = 28;
            this.picFacultyExcel.TabStop = false;
            this.picFacultyExcel.Click += new System.EventHandler(this.picFacultyExcel_Click);
            // 
            // picFacultyPrint
            // 
            this.picFacultyPrint.BackColor = System.Drawing.Color.White;
            this.picFacultyPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacultyPrint.Image = global::Library.Properties.Resources.printer;
            this.picFacultyPrint.Location = new System.Drawing.Point(883, 3);
            this.picFacultyPrint.Name = "picFacultyPrint";
            this.picFacultyPrint.Size = new System.Drawing.Size(64, 64);
            this.picFacultyPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFacultyPrint.TabIndex = 27;
            this.picFacultyPrint.TabStop = false;
            this.picFacultyPrint.Click += new System.EventHandler(this.picFacultyPrint_Click);
            // 
            // picFacultySave
            // 
            this.picFacultySave.BackColor = System.Drawing.Color.White;
            this.picFacultySave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacultySave.Image = global::Library.Properties.Resources.accept;
            this.picFacultySave.Location = new System.Drawing.Point(621, 5);
            this.picFacultySave.Name = "picFacultySave";
            this.picFacultySave.Size = new System.Drawing.Size(64, 64);
            this.picFacultySave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFacultySave.TabIndex = 26;
            this.picFacultySave.TabStop = false;
            this.picFacultySave.Click += new System.EventHandler(this.picFacultySave_Click);
            // 
            // tbFacultySearch
            // 
            this.tbFacultySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFacultySearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFacultySearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbFacultySearch.Location = new System.Drawing.Point(3, 3);
            this.tbFacultySearch.Name = "tbFacultySearch";
            this.tbFacultySearch.Size = new System.Drawing.Size(305, 66);
            this.tbFacultySearch.TabIndex = 25;
            this.tbFacultySearch.TabStop = false;
            this.tbFacultySearch.Text = "Search";
            this.tbFacultySearch.Click += new System.EventHandler(this.tbFacultySearch_Click);
            this.tbFacultySearch.TextChanged += new System.EventHandler(this.tbFacultySearch_TextChanged);
            this.tbFacultySearch.Leave += new System.EventHandler(this.tbFacultySearch_Leave);
            // 
            // picFacultyMinus
            // 
            this.picFacultyMinus.BackColor = System.Drawing.Color.White;
            this.picFacultyMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacultyMinus.Image = global::Library.Properties.Resources.minus;
            this.picFacultyMinus.Location = new System.Drawing.Point(490, 3);
            this.picFacultyMinus.Name = "picFacultyMinus";
            this.picFacultyMinus.Size = new System.Drawing.Size(64, 64);
            this.picFacultyMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFacultyMinus.TabIndex = 24;
            this.picFacultyMinus.TabStop = false;
            this.picFacultyMinus.Click += new System.EventHandler(this.picFacultyMinus_Click);
            // 
            // picFacultyAdd
            // 
            this.picFacultyAdd.BackColor = System.Drawing.Color.White;
            this.picFacultyAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacultyAdd.Image = global::Library.Properties.Resources.add;
            this.picFacultyAdd.Location = new System.Drawing.Point(359, 5);
            this.picFacultyAdd.Name = "picFacultyAdd";
            this.picFacultyAdd.Size = new System.Drawing.Size(64, 64);
            this.picFacultyAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFacultyAdd.TabIndex = 23;
            this.picFacultyAdd.TabStop = false;
            this.picFacultyAdd.Click += new System.EventHandler(this.picFacultyAdd_Click);
            // 
            // printFaculty
            // 
            this.printFaculty.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printFaculty_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 412;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FacultyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FacultyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 503;
            // 
            // ucFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFacultyExcel);
            this.Controls.Add(this.picFacultyPrint);
            this.Controls.Add(this.picFacultySave);
            this.Controls.Add(this.tbFacultySearch);
            this.Controls.Add(this.picFacultyMinus);
            this.Controls.Add(this.picFacultyAdd);
            this.Controls.Add(this.FacultyNameLabel);
            this.Controls.Add(this.FacultyIDLabel);
            this.Controls.Add(this.FacultyIDTextBox);
            this.Controls.Add(this.FacultyNameTextBox);
            this.Controls.Add(this.facultyMetroGrid);
            this.Name = "ucFaculty";
            this.Size = new System.Drawing.Size(970, 401);
            this.Load += new System.EventHandler(this.ucFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultySave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private LibraryDBDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid facultyMetroGrid;
        private System.Windows.Forms.TextBox FacultyIDTextBox;
        private System.Windows.Forms.TextBox FacultyNameTextBox;
        private MetroFramework.Controls.MetroLabel FacultyIDLabel;
        private MetroFramework.Controls.MetroLabel FacultyNameLabel;
        private System.Windows.Forms.PictureBox picFacultyExcel;
        private System.Windows.Forms.PictureBox picFacultyPrint;
        private System.Windows.Forms.PictureBox picFacultySave;
        private System.Windows.Forms.TextBox tbFacultySearch;
        private System.Windows.Forms.PictureBox picFacultyMinus;
        private System.Windows.Forms.PictureBox picFacultyAdd;
        private System.Drawing.Printing.PrintDocument printFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
