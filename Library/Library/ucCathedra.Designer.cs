namespace Library
{
    partial class ucCathedra
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
            this.cathedraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cathedraTableAdapter = new Library.LibraryDBDataSetTableAdapters.CathedraTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.cathedraMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dateMinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateMinTableAdapter = new Library.LibraryDBDataSetTableAdapters.DateMinTableAdapter();
            this.CathedraIDTextBox = new System.Windows.Forms.TextBox();
            this.CathedraNameTextBox = new System.Windows.Forms.TextBox();
            this.CathedraIDLabel = new MetroFramework.Controls.MetroLabel();
            this.CathedraNameLabel = new MetroFramework.Controls.MetroLabel();
            this.picCathedraExcel = new System.Windows.Forms.PictureBox();
            this.picCathedraPrint = new System.Windows.Forms.PictureBox();
            this.picCathedraSave = new System.Windows.Forms.PictureBox();
            this.tbCathedraSearch = new System.Windows.Forms.TextBox();
            this.picCathedraMinus = new System.Windows.Forms.PictureBox();
            this.picCathedraAdd = new System.Windows.Forms.PictureBox();
            this.printCathedra = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedraMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cathedraBindingSource
            // 
            this.cathedraBindingSource.DataMember = "Cathedra";
            this.cathedraBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // cathedraTableAdapter
            // 
            this.cathedraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CathedraTableAdapter = this.cathedraTableAdapter;
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
            // cathedraMetroGrid
            // 
            this.cathedraMetroGrid.AllowUserToOrderColumns = true;
            this.cathedraMetroGrid.AllowUserToResizeRows = false;
            this.cathedraMetroGrid.AutoGenerateColumns = false;
            this.cathedraMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cathedraMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cathedraMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cathedraMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cathedraMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cathedraMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cathedraMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cathedraMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cathedraMetroGrid.DataSource = this.cathedraBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cathedraMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.cathedraMetroGrid.EnableHeadersVisualStyles = false;
            this.cathedraMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cathedraMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cathedraMetroGrid.Location = new System.Drawing.Point(0, 73);
            this.cathedraMetroGrid.Name = "cathedraMetroGrid";
            this.cathedraMetroGrid.ReadOnly = true;
            this.cathedraMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cathedraMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cathedraMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cathedraMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cathedraMetroGrid.Size = new System.Drawing.Size(970, 219);
            this.cathedraMetroGrid.TabIndex = 1;
            // 
            // dateMinBindingSource
            // 
            this.dateMinBindingSource.DataMember = "DateMin";
            this.dateMinBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // dateMinTableAdapter
            // 
            this.dateMinTableAdapter.ClearBeforeFill = true;
            // 
            // CathedraIDTextBox
            // 
            this.CathedraIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cathedraBindingSource, "CathedraID", true));
            this.CathedraIDTextBox.Location = new System.Drawing.Point(131, 335);
            this.CathedraIDTextBox.Name = "CathedraIDTextBox";
            this.CathedraIDTextBox.Size = new System.Drawing.Size(303, 20);
            this.CathedraIDTextBox.TabIndex = 2;
            // 
            // CathedraNameTextBox
            // 
            this.CathedraNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cathedraBindingSource, "CathedraName", true));
            this.CathedraNameTextBox.Location = new System.Drawing.Point(511, 335);
            this.CathedraNameTextBox.Name = "CathedraNameTextBox";
            this.CathedraNameTextBox.Size = new System.Drawing.Size(424, 20);
            this.CathedraNameTextBox.TabIndex = 4;
            // 
            // CathedraIDLabel
            // 
            this.CathedraIDLabel.AutoSize = true;
            this.CathedraIDLabel.Location = new System.Drawing.Point(43, 335);
            this.CathedraIDLabel.Name = "CathedraIDLabel";
            this.CathedraIDLabel.Size = new System.Drawing.Size(82, 19);
            this.CathedraIDLabel.TabIndex = 5;
            this.CathedraIDLabel.Text = "Cathedra ID:";
            // 
            // CathedraNameLabel
            // 
            this.CathedraNameLabel.AutoSize = true;
            this.CathedraNameLabel.Location = new System.Drawing.Point(457, 335);
            this.CathedraNameLabel.Name = "CathedraNameLabel";
            this.CathedraNameLabel.Size = new System.Drawing.Size(48, 19);
            this.CathedraNameLabel.TabIndex = 6;
            this.CathedraNameLabel.Text = "Name:";
            // 
            // picCathedraExcel
            // 
            this.picCathedraExcel.BackColor = System.Drawing.Color.White;
            this.picCathedraExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCathedraExcel.Image = global::Library.Properties.Resources.excel;
            this.picCathedraExcel.Location = new System.Drawing.Point(752, 3);
            this.picCathedraExcel.Name = "picCathedraExcel";
            this.picCathedraExcel.Size = new System.Drawing.Size(64, 64);
            this.picCathedraExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCathedraExcel.TabIndex = 22;
            this.picCathedraExcel.TabStop = false;
            this.picCathedraExcel.Click += new System.EventHandler(this.picCathedraExcel_Click);
            // 
            // picCathedraPrint
            // 
            this.picCathedraPrint.BackColor = System.Drawing.Color.White;
            this.picCathedraPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCathedraPrint.Image = global::Library.Properties.Resources.printer;
            this.picCathedraPrint.Location = new System.Drawing.Point(883, 3);
            this.picCathedraPrint.Name = "picCathedraPrint";
            this.picCathedraPrint.Size = new System.Drawing.Size(64, 64);
            this.picCathedraPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCathedraPrint.TabIndex = 21;
            this.picCathedraPrint.TabStop = false;
            this.picCathedraPrint.Click += new System.EventHandler(this.picCathedraPrint_Click);
            // 
            // picCathedraSave
            // 
            this.picCathedraSave.BackColor = System.Drawing.Color.White;
            this.picCathedraSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCathedraSave.Image = global::Library.Properties.Resources.accept;
            this.picCathedraSave.Location = new System.Drawing.Point(621, 5);
            this.picCathedraSave.Name = "picCathedraSave";
            this.picCathedraSave.Size = new System.Drawing.Size(64, 64);
            this.picCathedraSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCathedraSave.TabIndex = 20;
            this.picCathedraSave.TabStop = false;
            this.picCathedraSave.Click += new System.EventHandler(this.picCathedraSave_Click);
            // 
            // tbCathedraSearch
            // 
            this.tbCathedraSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCathedraSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCathedraSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbCathedraSearch.Location = new System.Drawing.Point(3, 3);
            this.tbCathedraSearch.Name = "tbCathedraSearch";
            this.tbCathedraSearch.Size = new System.Drawing.Size(305, 66);
            this.tbCathedraSearch.TabIndex = 19;
            this.tbCathedraSearch.TabStop = false;
            this.tbCathedraSearch.Text = "Search";
            this.tbCathedraSearch.Click += new System.EventHandler(this.tbCathedraSearch_Click);
            this.tbCathedraSearch.TextChanged += new System.EventHandler(this.tbCathedraSearch_TextChanged);
            this.tbCathedraSearch.Leave += new System.EventHandler(this.tbCathedraSearch_Leave);
            // 
            // picCathedraMinus
            // 
            this.picCathedraMinus.BackColor = System.Drawing.Color.White;
            this.picCathedraMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCathedraMinus.Image = global::Library.Properties.Resources.minus;
            this.picCathedraMinus.Location = new System.Drawing.Point(490, 3);
            this.picCathedraMinus.Name = "picCathedraMinus";
            this.picCathedraMinus.Size = new System.Drawing.Size(64, 64);
            this.picCathedraMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCathedraMinus.TabIndex = 18;
            this.picCathedraMinus.TabStop = false;
            this.picCathedraMinus.Click += new System.EventHandler(this.picCathedraMinus_Click);
            // 
            // picCathedraAdd
            // 
            this.picCathedraAdd.BackColor = System.Drawing.Color.White;
            this.picCathedraAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCathedraAdd.Image = global::Library.Properties.Resources.add;
            this.picCathedraAdd.Location = new System.Drawing.Point(359, 5);
            this.picCathedraAdd.Name = "picCathedraAdd";
            this.picCathedraAdd.Size = new System.Drawing.Size(64, 64);
            this.picCathedraAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCathedraAdd.TabIndex = 17;
            this.picCathedraAdd.TabStop = false;
            this.picCathedraAdd.Click += new System.EventHandler(this.picCathedraAdd_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CathedraID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CathedraID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 410;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CathedraName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CathedraName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 503;
            // 
            // ucCathedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picCathedraExcel);
            this.Controls.Add(this.picCathedraPrint);
            this.Controls.Add(this.picCathedraSave);
            this.Controls.Add(this.tbCathedraSearch);
            this.Controls.Add(this.picCathedraMinus);
            this.Controls.Add(this.picCathedraAdd);
            this.Controls.Add(this.CathedraNameLabel);
            this.Controls.Add(this.CathedraIDLabel);
            this.Controls.Add(this.CathedraIDTextBox);
            this.Controls.Add(this.CathedraNameTextBox);
            this.Controls.Add(this.cathedraMetroGrid);
            this.Name = "ucCathedra";
            this.Size = new System.Drawing.Size(970, 397);
            this.Load += new System.EventHandler(this.ucCathedra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathedraMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCathedraAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource cathedraBindingSource;
        private LibraryDBDataSetTableAdapters.CathedraTableAdapter cathedraTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid cathedraMetroGrid;
        private System.Windows.Forms.BindingSource dateMinBindingSource;
        private LibraryDBDataSetTableAdapters.DateMinTableAdapter dateMinTableAdapter;
        private System.Windows.Forms.TextBox CathedraIDTextBox;
        private System.Windows.Forms.TextBox CathedraNameTextBox;
        private MetroFramework.Controls.MetroLabel CathedraIDLabel;
        private MetroFramework.Controls.MetroLabel CathedraNameLabel;
        private System.Windows.Forms.PictureBox picCathedraExcel;
        private System.Windows.Forms.PictureBox picCathedraPrint;
        private System.Windows.Forms.PictureBox picCathedraSave;
        private System.Windows.Forms.TextBox tbCathedraSearch;
        private System.Windows.Forms.PictureBox picCathedraMinus;
        private System.Windows.Forms.PictureBox picCathedraAdd;
        private System.Drawing.Printing.PrintDocument printCathedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
