namespace Library
{
    partial class ucStudents
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
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Library.LibraryDBDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.studentsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.FacultyIDTextBox = new System.Windows.Forms.TextBox();
            this.StudentIDLabel = new MetroFramework.Controls.MetroLabel();
            this.GroupLabel = new MetroFramework.Controls.MetroLabel();
            this.FacultyIDLabel = new MetroFramework.Controls.MetroLabel();
            this.picStudentsExcel = new System.Windows.Forms.PictureBox();
            this.picStudentsPrint = new System.Windows.Forms.PictureBox();
            this.picStudentsSave = new System.Windows.Forms.PictureBox();
            this.tbStudentsSearch = new System.Windows.Forms.TextBox();
            this.picStudentsMinus = new System.Windows.Forms.PictureBox();
            this.picStudentsAdd = new System.Windows.Forms.PictureBox();
            this.printStudents = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsMetroGrid
            // 
            this.studentsMetroGrid.AllowUserToOrderColumns = true;
            this.studentsMetroGrid.AllowUserToResizeRows = false;
            this.studentsMetroGrid.AutoGenerateColumns = false;
            this.studentsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.studentsMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentsMetroGrid.DataSource = this.studentsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentsMetroGrid.EnableHeadersVisualStyles = false;
            this.studentsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studentsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsMetroGrid.Location = new System.Drawing.Point(0, 76);
            this.studentsMetroGrid.Name = "studentsMetroGrid";
            this.studentsMetroGrid.ReadOnly = true;
            this.studentsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsMetroGrid.Size = new System.Drawing.Size(970, 280);
            this.studentsMetroGrid.TabIndex = 1;
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentID", true));
            this.StudentIDTextBox.Location = new System.Drawing.Point(133, 398);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(195, 20);
            this.StudentIDTextBox.TabIndex = 2;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Group", true));
            this.GroupTextBox.Location = new System.Drawing.Point(401, 398);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(227, 20);
            this.GroupTextBox.TabIndex = 4;
            // 
            // FacultyIDTextBox
            // 
            this.FacultyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FacultyID", true));
            this.FacultyIDTextBox.Location = new System.Drawing.Point(722, 398);
            this.FacultyIDTextBox.Name = "FacultyIDTextBox";
            this.FacultyIDTextBox.Size = new System.Drawing.Size(218, 20);
            this.FacultyIDTextBox.TabIndex = 6;
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(47, 398);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(80, 19);
            this.StudentIDLabel.TabIndex = 8;
            this.StudentIDLabel.Text = "Studentd ID:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(346, 398);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(49, 19);
            this.GroupLabel.TabIndex = 9;
            this.GroupLabel.Text = "Group:";
            // 
            // FacultyIDLabel
            // 
            this.FacultyIDLabel.AutoSize = true;
            this.FacultyIDLabel.Location = new System.Drawing.Point(649, 398);
            this.FacultyIDLabel.Name = "FacultyIDLabel";
            this.FacultyIDLabel.Size = new System.Drawing.Size(67, 19);
            this.FacultyIDLabel.TabIndex = 10;
            this.FacultyIDLabel.Text = "Faculty ID:";
            // 
            // picStudentsExcel
            // 
            this.picStudentsExcel.BackColor = System.Drawing.Color.White;
            this.picStudentsExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudentsExcel.Image = global::Library.Properties.Resources.excel;
            this.picStudentsExcel.Location = new System.Drawing.Point(752, 4);
            this.picStudentsExcel.Name = "picStudentsExcel";
            this.picStudentsExcel.Size = new System.Drawing.Size(64, 64);
            this.picStudentsExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStudentsExcel.TabIndex = 28;
            this.picStudentsExcel.TabStop = false;
            this.picStudentsExcel.Click += new System.EventHandler(this.picStudentsExcel_Click);
            // 
            // picStudentsPrint
            // 
            this.picStudentsPrint.BackColor = System.Drawing.Color.White;
            this.picStudentsPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudentsPrint.Image = global::Library.Properties.Resources.printer;
            this.picStudentsPrint.Location = new System.Drawing.Point(883, 4);
            this.picStudentsPrint.Name = "picStudentsPrint";
            this.picStudentsPrint.Size = new System.Drawing.Size(64, 64);
            this.picStudentsPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStudentsPrint.TabIndex = 27;
            this.picStudentsPrint.TabStop = false;
            this.picStudentsPrint.Click += new System.EventHandler(this.picStudentsPrint_Click);
            // 
            // picStudentsSave
            // 
            this.picStudentsSave.BackColor = System.Drawing.Color.White;
            this.picStudentsSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudentsSave.Image = global::Library.Properties.Resources.accept;
            this.picStudentsSave.Location = new System.Drawing.Point(621, 6);
            this.picStudentsSave.Name = "picStudentsSave";
            this.picStudentsSave.Size = new System.Drawing.Size(64, 64);
            this.picStudentsSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStudentsSave.TabIndex = 26;
            this.picStudentsSave.TabStop = false;
            this.picStudentsSave.Click += new System.EventHandler(this.picStudentsSave_Click);
            // 
            // tbStudentsSearch
            // 
            this.tbStudentsSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStudentsSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStudentsSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbStudentsSearch.Location = new System.Drawing.Point(3, 4);
            this.tbStudentsSearch.Name = "tbStudentsSearch";
            this.tbStudentsSearch.Size = new System.Drawing.Size(305, 66);
            this.tbStudentsSearch.TabIndex = 25;
            this.tbStudentsSearch.TabStop = false;
            this.tbStudentsSearch.Text = "Search";
            this.tbStudentsSearch.Click += new System.EventHandler(this.tbStudentsSearch_Click);
            this.tbStudentsSearch.TextChanged += new System.EventHandler(this.tbStudentsSearch_TextChanged);
            this.tbStudentsSearch.Leave += new System.EventHandler(this.tbStudentsSearch_Leave);
            // 
            // picStudentsMinus
            // 
            this.picStudentsMinus.BackColor = System.Drawing.Color.White;
            this.picStudentsMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudentsMinus.Image = global::Library.Properties.Resources.minus;
            this.picStudentsMinus.Location = new System.Drawing.Point(490, 4);
            this.picStudentsMinus.Name = "picStudentsMinus";
            this.picStudentsMinus.Size = new System.Drawing.Size(64, 64);
            this.picStudentsMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStudentsMinus.TabIndex = 24;
            this.picStudentsMinus.TabStop = false;
            this.picStudentsMinus.Click += new System.EventHandler(this.picStudentsMinus_Click);
            // 
            // picStudentsAdd
            // 
            this.picStudentsAdd.BackColor = System.Drawing.Color.White;
            this.picStudentsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudentsAdd.Image = global::Library.Properties.Resources.add;
            this.picStudentsAdd.Location = new System.Drawing.Point(359, 6);
            this.picStudentsAdd.Name = "picStudentsAdd";
            this.picStudentsAdd.Size = new System.Drawing.Size(64, 64);
            this.picStudentsAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStudentsAdd.TabIndex = 23;
            this.picStudentsAdd.TabStop = false;
            this.picStudentsAdd.Click += new System.EventHandler(this.picStudentsAdd_Click);
            // 
            // printStudents
            // 
            this.printStudents.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStudents_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 303;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Group";
            this.dataGridViewTextBoxColumn2.HeaderText = "Group";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 302;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn3.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 307;
            // 
            // ucStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picStudentsExcel);
            this.Controls.Add(this.picStudentsPrint);
            this.Controls.Add(this.picStudentsSave);
            this.Controls.Add(this.tbStudentsSearch);
            this.Controls.Add(this.picStudentsMinus);
            this.Controls.Add(this.picStudentsAdd);
            this.Controls.Add(this.FacultyIDLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.FacultyIDTextBox);
            this.Controls.Add(this.studentsMetroGrid);
            this.Name = "ucStudents";
            this.Size = new System.Drawing.Size(970, 449);
            this.Load += new System.EventHandler(this.ucStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentsAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private LibraryDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid studentsMetroGrid;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TextBox FacultyIDTextBox;
        private MetroFramework.Controls.MetroLabel StudentIDLabel;
        private MetroFramework.Controls.MetroLabel GroupLabel;
        private MetroFramework.Controls.MetroLabel FacultyIDLabel;
        private System.Windows.Forms.PictureBox picStudentsExcel;
        private System.Windows.Forms.PictureBox picStudentsPrint;
        private System.Windows.Forms.PictureBox picStudentsSave;
        private System.Windows.Forms.TextBox tbStudentsSearch;
        private System.Windows.Forms.PictureBox picStudentsMinus;
        private System.Windows.Forms.PictureBox picStudentsAdd;
        private System.Drawing.Printing.PrintDocument printStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
