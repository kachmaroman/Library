namespace Library
{
    partial class ucCategories
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
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Library.LibraryDBDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.categoriesMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryIDLabel = new MetroFramework.Controls.MetroLabel();
            this.CategoryNameLabel = new MetroFramework.Controls.MetroLabel();
            this.picCategoryExcel = new System.Windows.Forms.PictureBox();
            this.picCategoryPrint = new System.Windows.Forms.PictureBox();
            this.picCategorySave = new System.Windows.Forms.PictureBox();
            this.tbCategorySearch = new System.Windows.Forms.TextBox();
            this.picCategoryMinus = new System.Windows.Forms.PictureBox();
            this.picCategoryAdd = new System.Windows.Forms.PictureBox();
            this.printCategory = new System.Drawing.Printing.PrintDocument();
            this.fKReadersCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Library.LibraryDBDataSetTableAdapters.ReadersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategorySave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReadersCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
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
            // categoriesMetroGrid
            // 
            this.categoriesMetroGrid.AllowUserToOrderColumns = true;
            this.categoriesMetroGrid.AllowUserToResizeRows = false;
            this.categoriesMetroGrid.AutoGenerateColumns = false;
            this.categoriesMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriesMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.categoriesMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriesMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoriesMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesMetroGrid.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesMetroGrid.EnableHeadersVisualStyles = false;
            this.categoriesMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoriesMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriesMetroGrid.Location = new System.Drawing.Point(0, 73);
            this.categoriesMetroGrid.Name = "categoriesMetroGrid";
            this.categoriesMetroGrid.ReadOnly = true;
            this.categoriesMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriesMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoriesMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoriesMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesMetroGrid.Size = new System.Drawing.Size(970, 157);
            this.categoriesMetroGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 410;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 502;
            // 
            // CategoryIDTextBox
            // 
            this.CategoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryID", true));
            this.CategoryIDTextBox.Location = new System.Drawing.Point(130, 262);
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.Size = new System.Drawing.Size(302, 20);
            this.CategoryIDTextBox.TabIndex = 2;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryName", true));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(507, 262);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(436, 20);
            this.CategoryNameTextBox.TabIndex = 4;
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Location = new System.Drawing.Point(41, 261);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(83, 19);
            this.CategoryIDLabel.TabIndex = 5;
            this.CategoryIDLabel.Text = "Category ID:";
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(453, 261);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(48, 19);
            this.CategoryNameLabel.TabIndex = 6;
            this.CategoryNameLabel.Text = "Name:";
            // 
            // picCategoryExcel
            // 
            this.picCategoryExcel.BackColor = System.Drawing.Color.White;
            this.picCategoryExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCategoryExcel.Image = global::Library.Properties.Resources.excel;
            this.picCategoryExcel.Location = new System.Drawing.Point(752, 3);
            this.picCategoryExcel.Name = "picCategoryExcel";
            this.picCategoryExcel.Size = new System.Drawing.Size(64, 64);
            this.picCategoryExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCategoryExcel.TabIndex = 22;
            this.picCategoryExcel.TabStop = false;
            this.picCategoryExcel.Click += new System.EventHandler(this.picCategoryExcel_Click);
            // 
            // picCategoryPrint
            // 
            this.picCategoryPrint.BackColor = System.Drawing.Color.White;
            this.picCategoryPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCategoryPrint.Image = global::Library.Properties.Resources.printer;
            this.picCategoryPrint.Location = new System.Drawing.Point(883, 3);
            this.picCategoryPrint.Name = "picCategoryPrint";
            this.picCategoryPrint.Size = new System.Drawing.Size(64, 64);
            this.picCategoryPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCategoryPrint.TabIndex = 21;
            this.picCategoryPrint.TabStop = false;
            this.picCategoryPrint.Click += new System.EventHandler(this.picCategoryPrint_Click);
            // 
            // picCategorySave
            // 
            this.picCategorySave.BackColor = System.Drawing.Color.White;
            this.picCategorySave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCategorySave.Enabled = false;
            this.picCategorySave.Image = global::Library.Properties.Resources.accept;
            this.picCategorySave.Location = new System.Drawing.Point(621, 5);
            this.picCategorySave.Name = "picCategorySave";
            this.picCategorySave.Size = new System.Drawing.Size(64, 64);
            this.picCategorySave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCategorySave.TabIndex = 20;
            this.picCategorySave.TabStop = false;
            this.picCategorySave.Click += new System.EventHandler(this.picCategorySave_Click);
            // 
            // tbCategorySearch
            // 
            this.tbCategorySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCategorySearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCategorySearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbCategorySearch.Location = new System.Drawing.Point(3, 3);
            this.tbCategorySearch.Name = "tbCategorySearch";
            this.tbCategorySearch.Size = new System.Drawing.Size(305, 66);
            this.tbCategorySearch.TabIndex = 19;
            this.tbCategorySearch.TabStop = false;
            this.tbCategorySearch.Text = "Search";
            this.tbCategorySearch.Click += new System.EventHandler(this.tbCategorySearch_Click);
            this.tbCategorySearch.TextChanged += new System.EventHandler(this.tbCategorySearch_TextChanged);
            this.tbCategorySearch.Leave += new System.EventHandler(this.tbCategorySearch_Leave);
            // 
            // picCategoryMinus
            // 
            this.picCategoryMinus.BackColor = System.Drawing.Color.White;
            this.picCategoryMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCategoryMinus.Enabled = false;
            this.picCategoryMinus.Image = global::Library.Properties.Resources.minus;
            this.picCategoryMinus.Location = new System.Drawing.Point(490, 3);
            this.picCategoryMinus.Name = "picCategoryMinus";
            this.picCategoryMinus.Size = new System.Drawing.Size(64, 64);
            this.picCategoryMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCategoryMinus.TabIndex = 18;
            this.picCategoryMinus.TabStop = false;
            this.picCategoryMinus.Click += new System.EventHandler(this.picCategoryMinus_Click);
            // 
            // picCategoryAdd
            // 
            this.picCategoryAdd.BackColor = System.Drawing.Color.White;
            this.picCategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCategoryAdd.Enabled = false;
            this.picCategoryAdd.Image = global::Library.Properties.Resources.add;
            this.picCategoryAdd.Location = new System.Drawing.Point(359, 5);
            this.picCategoryAdd.Name = "picCategoryAdd";
            this.picCategoryAdd.Size = new System.Drawing.Size(64, 64);
            this.picCategoryAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCategoryAdd.TabIndex = 17;
            this.picCategoryAdd.TabStop = false;
            this.picCategoryAdd.Click += new System.EventHandler(this.picCategoryAdd_Click);
            // 
            // fKReadersCategoriesBindingSource
            // 
            this.fKReadersCategoriesBindingSource.DataMember = "FK_Readers_Categories";
            this.fKReadersCategoriesBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // ucCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picCategoryExcel);
            this.Controls.Add(this.picCategoryPrint);
            this.Controls.Add(this.picCategorySave);
            this.Controls.Add(this.tbCategorySearch);
            this.Controls.Add(this.picCategoryMinus);
            this.Controls.Add(this.picCategoryAdd);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.CategoryIDLabel);
            this.Controls.Add(this.CategoryIDTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.categoriesMetroGrid);
            this.Name = "ucCategories";
            this.Size = new System.Drawing.Size(970, 320);
            this.Load += new System.EventHandler(this.ucCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategorySave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReadersCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readersDataGridViewTextBoxColumn;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private LibraryDBDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid categoriesMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox CategoryIDTextBox;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private MetroFramework.Controls.MetroLabel CategoryIDLabel;
        private MetroFramework.Controls.MetroLabel CategoryNameLabel;
        private System.Windows.Forms.PictureBox picCategoryExcel;
        private System.Windows.Forms.PictureBox picCategoryPrint;
        private System.Windows.Forms.PictureBox picCategorySave;
        private System.Windows.Forms.TextBox tbCategorySearch;
        private System.Windows.Forms.PictureBox picCategoryMinus;
        private System.Windows.Forms.PictureBox picCategoryAdd;
        private System.Drawing.Printing.PrintDocument printCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource fKReadersCategoriesBindingSource;
        private LibraryDBDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
    }
}
