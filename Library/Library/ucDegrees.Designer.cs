namespace Library
{
    partial class ucDegrees
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
            this.degreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.degreesTableAdapter = new Library.LibraryDBDataSetTableAdapters.DegreesTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.degreesMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.DegreeIDTextBox = new System.Windows.Forms.TextBox();
            this.DegreeNameTextBox = new System.Windows.Forms.TextBox();
            this.DegreeIDLabel = new MetroFramework.Controls.MetroLabel();
            this.DegreeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.picDegreesExcel = new System.Windows.Forms.PictureBox();
            this.picDegreesPrint = new System.Windows.Forms.PictureBox();
            this.picDegreesSave = new System.Windows.Forms.PictureBox();
            this.tbDegreesSearch = new System.Windows.Forms.TextBox();
            this.picDegreesMinus = new System.Windows.Forms.PictureBox();
            this.picDegreesAdd = new System.Windows.Forms.PictureBox();
            this.printDegrees = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // degreesBindingSource
            // 
            this.degreesBindingSource.DataMember = "Degrees";
            this.degreesBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // degreesTableAdapter
            // 
            this.degreesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DegreesTableAdapter = this.degreesTableAdapter;
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
            // degreesMetroGrid
            // 
            this.degreesMetroGrid.AllowUserToOrderColumns = true;
            this.degreesMetroGrid.AllowUserToResizeRows = false;
            this.degreesMetroGrid.AutoGenerateColumns = false;
            this.degreesMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.degreesMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.degreesMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.degreesMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.degreesMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.degreesMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.degreesMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.degreesMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.degreesMetroGrid.DataSource = this.degreesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.degreesMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.degreesMetroGrid.EnableHeadersVisualStyles = false;
            this.degreesMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.degreesMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.degreesMetroGrid.Location = new System.Drawing.Point(0, 75);
            this.degreesMetroGrid.Name = "degreesMetroGrid";
            this.degreesMetroGrid.ReadOnly = true;
            this.degreesMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.degreesMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.degreesMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.degreesMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.degreesMetroGrid.Size = new System.Drawing.Size(970, 234);
            this.degreesMetroGrid.TabIndex = 1;
            // 
            // DegreeIDTextBox
            // 
            this.DegreeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreesBindingSource, "DegreeID", true));
            this.DegreeIDTextBox.Location = new System.Drawing.Point(121, 348);
            this.DegreeIDTextBox.Name = "DegreeIDTextBox";
            this.DegreeIDTextBox.Size = new System.Drawing.Size(309, 20);
            this.DegreeIDTextBox.TabIndex = 2;
            // 
            // DegreeNameTextBox
            // 
            this.DegreeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreesBindingSource, "DegreeName", true));
            this.DegreeNameTextBox.Location = new System.Drawing.Point(501, 348);
            this.DegreeNameTextBox.Name = "DegreeNameTextBox";
            this.DegreeNameTextBox.Size = new System.Drawing.Size(442, 20);
            this.DegreeNameTextBox.TabIndex = 4;
            // 
            // DegreeIDLabel
            // 
            this.DegreeIDLabel.AutoSize = true;
            this.DegreeIDLabel.Location = new System.Drawing.Point(44, 348);
            this.DegreeIDLabel.Name = "DegreeIDLabel";
            this.DegreeIDLabel.Size = new System.Drawing.Size(71, 19);
            this.DegreeIDLabel.TabIndex = 5;
            this.DegreeIDLabel.Text = "Degree ID:";
            // 
            // DegreeNameLabel
            // 
            this.DegreeNameLabel.AutoSize = true;
            this.DegreeNameLabel.Location = new System.Drawing.Point(447, 348);
            this.DegreeNameLabel.Name = "DegreeNameLabel";
            this.DegreeNameLabel.Size = new System.Drawing.Size(48, 19);
            this.DegreeNameLabel.TabIndex = 6;
            this.DegreeNameLabel.Text = "Name:";
            // 
            // picDegreesExcel
            // 
            this.picDegreesExcel.BackColor = System.Drawing.Color.White;
            this.picDegreesExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDegreesExcel.Image = global::Library.Properties.Resources.excel;
            this.picDegreesExcel.Location = new System.Drawing.Point(752, 3);
            this.picDegreesExcel.Name = "picDegreesExcel";
            this.picDegreesExcel.Size = new System.Drawing.Size(64, 64);
            this.picDegreesExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDegreesExcel.TabIndex = 22;
            this.picDegreesExcel.TabStop = false;
            this.picDegreesExcel.Click += new System.EventHandler(this.picDegreesExcel_Click);
            // 
            // picDegreesPrint
            // 
            this.picDegreesPrint.BackColor = System.Drawing.Color.White;
            this.picDegreesPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDegreesPrint.Image = global::Library.Properties.Resources.printer;
            this.picDegreesPrint.Location = new System.Drawing.Point(883, 3);
            this.picDegreesPrint.Name = "picDegreesPrint";
            this.picDegreesPrint.Size = new System.Drawing.Size(64, 64);
            this.picDegreesPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDegreesPrint.TabIndex = 21;
            this.picDegreesPrint.TabStop = false;
            this.picDegreesPrint.Click += new System.EventHandler(this.picDegreesPrint_Click);
            // 
            // picDegreesSave
            // 
            this.picDegreesSave.BackColor = System.Drawing.Color.White;
            this.picDegreesSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDegreesSave.Image = global::Library.Properties.Resources.accept;
            this.picDegreesSave.Location = new System.Drawing.Point(621, 5);
            this.picDegreesSave.Name = "picDegreesSave";
            this.picDegreesSave.Size = new System.Drawing.Size(64, 64);
            this.picDegreesSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDegreesSave.TabIndex = 20;
            this.picDegreesSave.TabStop = false;
            this.picDegreesSave.Click += new System.EventHandler(this.picDegreesSave_Click);
            // 
            // tbDegreesSearch
            // 
            this.tbDegreesSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDegreesSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDegreesSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbDegreesSearch.Location = new System.Drawing.Point(3, 3);
            this.tbDegreesSearch.Name = "tbDegreesSearch";
            this.tbDegreesSearch.Size = new System.Drawing.Size(305, 66);
            this.tbDegreesSearch.TabIndex = 19;
            this.tbDegreesSearch.TabStop = false;
            this.tbDegreesSearch.Text = "Search";
            this.tbDegreesSearch.Click += new System.EventHandler(this.tbDegreesSearch_Click);
            this.tbDegreesSearch.TextChanged += new System.EventHandler(this.tbDegreesSearch_TextChanged);
            this.tbDegreesSearch.Leave += new System.EventHandler(this.tbDegreesSearch_Leave);
            // 
            // picDegreesMinus
            // 
            this.picDegreesMinus.BackColor = System.Drawing.Color.White;
            this.picDegreesMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDegreesMinus.Image = global::Library.Properties.Resources.minus;
            this.picDegreesMinus.Location = new System.Drawing.Point(490, 3);
            this.picDegreesMinus.Name = "picDegreesMinus";
            this.picDegreesMinus.Size = new System.Drawing.Size(64, 64);
            this.picDegreesMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDegreesMinus.TabIndex = 18;
            this.picDegreesMinus.TabStop = false;
            this.picDegreesMinus.Click += new System.EventHandler(this.picDegreesMinus_Click);
            // 
            // picDegreesAdd
            // 
            this.picDegreesAdd.BackColor = System.Drawing.Color.White;
            this.picDegreesAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDegreesAdd.Image = global::Library.Properties.Resources.add;
            this.picDegreesAdd.Location = new System.Drawing.Point(359, 5);
            this.picDegreesAdd.Name = "picDegreesAdd";
            this.picDegreesAdd.Size = new System.Drawing.Size(64, 64);
            this.picDegreesAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDegreesAdd.TabIndex = 17;
            this.picDegreesAdd.TabStop = false;
            this.picDegreesAdd.Click += new System.EventHandler(this.picDegreesAdd_Click);
            // 
            // printDegrees
            // 
            this.printDegrees.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDegrees_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DegreeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DegreeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 410;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DegreeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DegreeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 502;
            // 
            // ucDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picDegreesExcel);
            this.Controls.Add(this.picDegreesPrint);
            this.Controls.Add(this.picDegreesSave);
            this.Controls.Add(this.tbDegreesSearch);
            this.Controls.Add(this.picDegreesMinus);
            this.Controls.Add(this.picDegreesAdd);
            this.Controls.Add(this.DegreeNameLabel);
            this.Controls.Add(this.DegreeIDLabel);
            this.Controls.Add(this.DegreeIDTextBox);
            this.Controls.Add(this.DegreeNameTextBox);
            this.Controls.Add(this.degreesMetroGrid);
            this.Name = "ucDegrees";
            this.Size = new System.Drawing.Size(970, 409);
            this.Load += new System.EventHandler(this.ucDegrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDegreesAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource degreesBindingSource;
        private LibraryDBDataSetTableAdapters.DegreesTableAdapter degreesTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid degreesMetroGrid;
        private System.Windows.Forms.TextBox DegreeIDTextBox;
        private System.Windows.Forms.TextBox DegreeNameTextBox;
        private MetroFramework.Controls.MetroLabel DegreeIDLabel;
        private MetroFramework.Controls.MetroLabel DegreeNameLabel;
        private System.Windows.Forms.PictureBox picDegreesExcel;
        private System.Windows.Forms.PictureBox picDegreesPrint;
        private System.Windows.Forms.PictureBox picDegreesSave;
        private System.Windows.Forms.TextBox tbDegreesSearch;
        private System.Windows.Forms.PictureBox picDegreesMinus;
        private System.Windows.Forms.PictureBox picDegreesAdd;
        private System.Drawing.Printing.PrintDocument printDegrees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
