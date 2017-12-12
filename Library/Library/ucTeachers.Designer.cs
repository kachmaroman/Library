namespace Library
{
    partial class ucTeachers
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
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new Library.LibraryDBDataSetTableAdapters.TeachersTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.teachersMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.TeacherIDTextBox = new System.Windows.Forms.TextBox();
            this.CathedraIDTextBox = new System.Windows.Forms.TextBox();
            this.DegreeIDTextBox = new System.Windows.Forms.TextBox();
            this.TeacherIDLabel = new MetroFramework.Controls.MetroLabel();
            this.CathedraIDLabel = new MetroFramework.Controls.MetroLabel();
            this.DegreeIDLabel = new MetroFramework.Controls.MetroLabel();
            this.picTeachersExcel = new System.Windows.Forms.PictureBox();
            this.picTeachersPrint = new System.Windows.Forms.PictureBox();
            this.picTeachersSave = new System.Windows.Forms.PictureBox();
            this.tbTeachersSearch = new System.Windows.Forms.TextBox();
            this.picTeachersMinus = new System.Windows.Forms.PictureBox();
            this.picTeachersAdd = new System.Windows.Forms.PictureBox();
            this.printTeachers = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teachersMetroGrid
            // 
            this.teachersMetroGrid.AllowUserToOrderColumns = true;
            this.teachersMetroGrid.AllowUserToResizeRows = false;
            this.teachersMetroGrid.AutoGenerateColumns = false;
            this.teachersMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teachersMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teachersMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.teachersMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachersMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teachersMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.teachersMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teachersMetroGrid.DataSource = this.teachersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teachersMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.teachersMetroGrid.EnableHeadersVisualStyles = false;
            this.teachersMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.teachersMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teachersMetroGrid.Location = new System.Drawing.Point(0, 74);
            this.teachersMetroGrid.Name = "teachersMetroGrid";
            this.teachersMetroGrid.ReadOnly = true;
            this.teachersMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachersMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.teachersMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.teachersMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teachersMetroGrid.Size = new System.Drawing.Size(970, 285);
            this.teachersMetroGrid.TabIndex = 1;
            // 
            // TeacherIDTextBox
            // 
            this.TeacherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "TeacherID", true));
            this.TeacherIDTextBox.Location = new System.Drawing.Point(124, 390);
            this.TeacherIDTextBox.Name = "TeacherIDTextBox";
            this.TeacherIDTextBox.Size = new System.Drawing.Size(206, 20);
            this.TeacherIDTextBox.TabIndex = 2;
            // 
            // CathedraIDTextBox
            // 
            this.CathedraIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "CathedraID", true));
            this.CathedraIDTextBox.Location = new System.Drawing.Point(434, 390);
            this.CathedraIDTextBox.Name = "CathedraIDTextBox";
            this.CathedraIDTextBox.Size = new System.Drawing.Size(195, 20);
            this.CathedraIDTextBox.TabIndex = 4;
            // 
            // DegreeIDTextBox
            // 
            this.DegreeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "DegreeID", true));
            this.DegreeIDTextBox.Location = new System.Drawing.Point(724, 390);
            this.DegreeIDTextBox.Name = "DegreeIDTextBox";
            this.DegreeIDTextBox.Size = new System.Drawing.Size(206, 20);
            this.DegreeIDTextBox.TabIndex = 6;
            // 
            // TeacherIDLabel
            // 
            this.TeacherIDLabel.AutoSize = true;
            this.TeacherIDLabel.Location = new System.Drawing.Point(46, 390);
            this.TeacherIDLabel.Name = "TeacherIDLabel";
            this.TeacherIDLabel.Size = new System.Drawing.Size(72, 19);
            this.TeacherIDLabel.TabIndex = 7;
            this.TeacherIDLabel.Text = "Teacher ID:";
            // 
            // CathedraIDLabel
            // 
            this.CathedraIDLabel.AutoSize = true;
            this.CathedraIDLabel.Location = new System.Drawing.Point(346, 391);
            this.CathedraIDLabel.Name = "CathedraIDLabel";
            this.CathedraIDLabel.Size = new System.Drawing.Size(82, 19);
            this.CathedraIDLabel.TabIndex = 8;
            this.CathedraIDLabel.Text = "Cathedra ID:";
            // 
            // DegreeIDLabel
            // 
            this.DegreeIDLabel.AutoSize = true;
            this.DegreeIDLabel.Location = new System.Drawing.Point(647, 390);
            this.DegreeIDLabel.Name = "DegreeIDLabel";
            this.DegreeIDLabel.Size = new System.Drawing.Size(71, 19);
            this.DegreeIDLabel.TabIndex = 9;
            this.DegreeIDLabel.Text = "Degree ID:";
            // 
            // picTeachersExcel
            // 
            this.picTeachersExcel.BackColor = System.Drawing.Color.White;
            this.picTeachersExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeachersExcel.Image = global::Library.Properties.Resources.excel;
            this.picTeachersExcel.Location = new System.Drawing.Point(752, 3);
            this.picTeachersExcel.Name = "picTeachersExcel";
            this.picTeachersExcel.Size = new System.Drawing.Size(64, 64);
            this.picTeachersExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTeachersExcel.TabIndex = 28;
            this.picTeachersExcel.TabStop = false;
            this.picTeachersExcel.Click += new System.EventHandler(this.picTeachersExcel_Click);
            // 
            // picTeachersPrint
            // 
            this.picTeachersPrint.BackColor = System.Drawing.Color.White;
            this.picTeachersPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeachersPrint.Image = global::Library.Properties.Resources.printer;
            this.picTeachersPrint.Location = new System.Drawing.Point(883, 3);
            this.picTeachersPrint.Name = "picTeachersPrint";
            this.picTeachersPrint.Size = new System.Drawing.Size(64, 64);
            this.picTeachersPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTeachersPrint.TabIndex = 27;
            this.picTeachersPrint.TabStop = false;
            this.picTeachersPrint.Click += new System.EventHandler(this.picTeachersPrint_Click);
            // 
            // picTeachersSave
            // 
            this.picTeachersSave.BackColor = System.Drawing.Color.White;
            this.picTeachersSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeachersSave.Image = global::Library.Properties.Resources.accept;
            this.picTeachersSave.Location = new System.Drawing.Point(621, 5);
            this.picTeachersSave.Name = "picTeachersSave";
            this.picTeachersSave.Size = new System.Drawing.Size(64, 64);
            this.picTeachersSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTeachersSave.TabIndex = 26;
            this.picTeachersSave.TabStop = false;
            this.picTeachersSave.Click += new System.EventHandler(this.picTeachersSave_Click);
            // 
            // tbTeachersSearch
            // 
            this.tbTeachersSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTeachersSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTeachersSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbTeachersSearch.Location = new System.Drawing.Point(3, 3);
            this.tbTeachersSearch.Name = "tbTeachersSearch";
            this.tbTeachersSearch.Size = new System.Drawing.Size(305, 66);
            this.tbTeachersSearch.TabIndex = 25;
            this.tbTeachersSearch.TabStop = false;
            this.tbTeachersSearch.Text = "Search";
            this.tbTeachersSearch.Click += new System.EventHandler(this.tbTeachersSearch_Click);
            this.tbTeachersSearch.TextChanged += new System.EventHandler(this.tbTeachersSearch_TextChanged);
            this.tbTeachersSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTeachersSearch_KeyPress);
            this.tbTeachersSearch.Leave += new System.EventHandler(this.tbTeachersSearch_Leave);
            // 
            // picTeachersMinus
            // 
            this.picTeachersMinus.BackColor = System.Drawing.Color.White;
            this.picTeachersMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeachersMinus.Image = global::Library.Properties.Resources.minus;
            this.picTeachersMinus.Location = new System.Drawing.Point(490, 3);
            this.picTeachersMinus.Name = "picTeachersMinus";
            this.picTeachersMinus.Size = new System.Drawing.Size(64, 64);
            this.picTeachersMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTeachersMinus.TabIndex = 24;
            this.picTeachersMinus.TabStop = false;
            this.picTeachersMinus.Click += new System.EventHandler(this.picTeachersMinus_Click);
            // 
            // picTeachersAdd
            // 
            this.picTeachersAdd.BackColor = System.Drawing.Color.White;
            this.picTeachersAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeachersAdd.Image = global::Library.Properties.Resources.add;
            this.picTeachersAdd.Location = new System.Drawing.Point(359, 5);
            this.picTeachersAdd.Name = "picTeachersAdd";
            this.picTeachersAdd.Size = new System.Drawing.Size(64, 64);
            this.picTeachersAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTeachersAdd.TabIndex = 23;
            this.picTeachersAdd.TabStop = false;
            this.picTeachersAdd.Click += new System.EventHandler(this.picTeachersAdd_Click);
            // 
            // printTeachers
            // 
            this.printTeachers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTeachers_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeacherID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 303;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CathedraID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CathedraID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 302;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DegreeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "DegreeID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 307;
            // 
            // ucTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picTeachersExcel);
            this.Controls.Add(this.picTeachersPrint);
            this.Controls.Add(this.picTeachersSave);
            this.Controls.Add(this.tbTeachersSearch);
            this.Controls.Add(this.picTeachersMinus);
            this.Controls.Add(this.picTeachersAdd);
            this.Controls.Add(this.DegreeIDLabel);
            this.Controls.Add(this.CathedraIDLabel);
            this.Controls.Add(this.TeacherIDLabel);
            this.Controls.Add(this.TeacherIDTextBox);
            this.Controls.Add(this.CathedraIDTextBox);
            this.Controls.Add(this.DegreeIDTextBox);
            this.Controls.Add(this.teachersMetroGrid);
            this.Name = "ucTeachers";
            this.Size = new System.Drawing.Size(970, 440);
            this.Load += new System.EventHandler(this.ucTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeachersAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private LibraryDBDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid teachersMetroGrid;
        private System.Windows.Forms.TextBox TeacherIDTextBox;
        private System.Windows.Forms.TextBox CathedraIDTextBox;
        private System.Windows.Forms.TextBox DegreeIDTextBox;
        private MetroFramework.Controls.MetroLabel TeacherIDLabel;
        private MetroFramework.Controls.MetroLabel CathedraIDLabel;
        private MetroFramework.Controls.MetroLabel DegreeIDLabel;
        private System.Windows.Forms.PictureBox picTeachersExcel;
        private System.Windows.Forms.PictureBox picTeachersPrint;
        private System.Windows.Forms.PictureBox picTeachersSave;
        private System.Windows.Forms.TextBox tbTeachersSearch;
        private System.Windows.Forms.PictureBox picTeachersMinus;
        private System.Windows.Forms.PictureBox picTeachersAdd;
        private System.Drawing.Printing.PrintDocument printTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
