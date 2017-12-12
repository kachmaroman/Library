namespace Library
{
    partial class ucEdition
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
            this.editionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editionsTableAdapter = new Library.LibraryDBDataSetTableAdapters.EditionsTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.editionsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.EditionIDTextBox = new System.Windows.Forms.TextBox();
            this.EditionNameTextBox = new System.Windows.Forms.TextBox();
            this.EditionIDLabel = new MetroFramework.Controls.MetroLabel();
            this.EditionNameLabel = new MetroFramework.Controls.MetroLabel();
            this.picEditionExcel = new System.Windows.Forms.PictureBox();
            this.picEditionPrint = new System.Windows.Forms.PictureBox();
            this.picEditionSave = new System.Windows.Forms.PictureBox();
            this.tbEditionSearch = new System.Windows.Forms.TextBox();
            this.picEditionMinus = new System.Windows.Forms.PictureBox();
            this.picEditionAdd = new System.Windows.Forms.PictureBox();
            this.printEdition = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editionsBindingSource
            // 
            this.editionsBindingSource.DataMember = "Editions";
            this.editionsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // editionsTableAdapter
            // 
            this.editionsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EditionsTableAdapter = this.editionsTableAdapter;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.GiveBookTableAdapter = null;
            this.tableAdapterManager.OtherReadersTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.RoomReadingTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editionsMetroGrid
            // 
            this.editionsMetroGrid.AllowUserToOrderColumns = true;
            this.editionsMetroGrid.AllowUserToResizeRows = false;
            this.editionsMetroGrid.AutoGenerateColumns = false;
            this.editionsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editionsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editionsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.editionsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editionsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.editionsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editionsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.editionsMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editionsMetroGrid.DataSource = this.editionsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.editionsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.editionsMetroGrid.EnableHeadersVisualStyles = false;
            this.editionsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.editionsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editionsMetroGrid.Location = new System.Drawing.Point(0, 85);
            this.editionsMetroGrid.Name = "editionsMetroGrid";
            this.editionsMetroGrid.ReadOnly = true;
            this.editionsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editionsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.editionsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.editionsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.editionsMetroGrid.Size = new System.Drawing.Size(970, 243);
            this.editionsMetroGrid.TabIndex = 1;
            // 
            // EditionIDTextBox
            // 
            this.EditionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editionsBindingSource, "EditionID", true));
            this.EditionIDTextBox.Location = new System.Drawing.Point(113, 352);
            this.EditionIDTextBox.Name = "EditionIDTextBox";
            this.EditionIDTextBox.Size = new System.Drawing.Size(318, 20);
            this.EditionIDTextBox.TabIndex = 2;
            // 
            // EditionNameTextBox
            // 
            this.EditionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editionsBindingSource, "EditionName", true));
            this.EditionNameTextBox.Location = new System.Drawing.Point(509, 352);
            this.EditionNameTextBox.Name = "EditionNameTextBox";
            this.EditionNameTextBox.Size = new System.Drawing.Size(436, 20);
            this.EditionNameTextBox.TabIndex = 4;
            // 
            // EditionIDLabel
            // 
            this.EditionIDLabel.AutoSize = true;
            this.EditionIDLabel.Location = new System.Drawing.Point(39, 352);
            this.EditionIDLabel.Name = "EditionIDLabel";
            this.EditionIDLabel.Size = new System.Drawing.Size(68, 19);
            this.EditionIDLabel.TabIndex = 5;
            this.EditionIDLabel.Text = "Edition ID:";
            // 
            // EditionNameLabel
            // 
            this.EditionNameLabel.AutoSize = true;
            this.EditionNameLabel.Location = new System.Drawing.Point(455, 352);
            this.EditionNameLabel.Name = "EditionNameLabel";
            this.EditionNameLabel.Size = new System.Drawing.Size(48, 19);
            this.EditionNameLabel.TabIndex = 6;
            this.EditionNameLabel.Text = "Name:";
            // 
            // picEditionExcel
            // 
            this.picEditionExcel.BackColor = System.Drawing.Color.White;
            this.picEditionExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditionExcel.Image = global::Library.Properties.Resources.excel;
            this.picEditionExcel.Location = new System.Drawing.Point(752, 3);
            this.picEditionExcel.Name = "picEditionExcel";
            this.picEditionExcel.Size = new System.Drawing.Size(64, 64);
            this.picEditionExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditionExcel.TabIndex = 28;
            this.picEditionExcel.TabStop = false;
            this.picEditionExcel.Click += new System.EventHandler(this.picEditionExcel_Click);
            // 
            // picEditionPrint
            // 
            this.picEditionPrint.BackColor = System.Drawing.Color.White;
            this.picEditionPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditionPrint.Image = global::Library.Properties.Resources.printer;
            this.picEditionPrint.Location = new System.Drawing.Point(883, 3);
            this.picEditionPrint.Name = "picEditionPrint";
            this.picEditionPrint.Size = new System.Drawing.Size(64, 64);
            this.picEditionPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditionPrint.TabIndex = 27;
            this.picEditionPrint.TabStop = false;
            this.picEditionPrint.Click += new System.EventHandler(this.picEditionPrint_Click);
            // 
            // picEditionSave
            // 
            this.picEditionSave.BackColor = System.Drawing.Color.White;
            this.picEditionSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditionSave.Image = global::Library.Properties.Resources.accept;
            this.picEditionSave.Location = new System.Drawing.Point(621, 5);
            this.picEditionSave.Name = "picEditionSave";
            this.picEditionSave.Size = new System.Drawing.Size(64, 64);
            this.picEditionSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditionSave.TabIndex = 26;
            this.picEditionSave.TabStop = false;
            this.picEditionSave.Click += new System.EventHandler(this.picEditionSave_Click);
            // 
            // tbEditionSearch
            // 
            this.tbEditionSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEditionSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEditionSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbEditionSearch.Location = new System.Drawing.Point(3, 3);
            this.tbEditionSearch.Name = "tbEditionSearch";
            this.tbEditionSearch.Size = new System.Drawing.Size(305, 66);
            this.tbEditionSearch.TabIndex = 25;
            this.tbEditionSearch.TabStop = false;
            this.tbEditionSearch.Text = "Search";
            this.tbEditionSearch.Click += new System.EventHandler(this.tbEditionSearch_Click);
            this.tbEditionSearch.TextChanged += new System.EventHandler(this.tbEditionSearch_TextChanged);
            this.tbEditionSearch.Leave += new System.EventHandler(this.tbEditionSearch_Leave);
            // 
            // picEditionMinus
            // 
            this.picEditionMinus.BackColor = System.Drawing.Color.White;
            this.picEditionMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditionMinus.Image = global::Library.Properties.Resources.minus;
            this.picEditionMinus.Location = new System.Drawing.Point(490, 3);
            this.picEditionMinus.Name = "picEditionMinus";
            this.picEditionMinus.Size = new System.Drawing.Size(64, 64);
            this.picEditionMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditionMinus.TabIndex = 24;
            this.picEditionMinus.TabStop = false;
            this.picEditionMinus.Click += new System.EventHandler(this.picEditionMinus_Click);
            // 
            // picEditionAdd
            // 
            this.picEditionAdd.BackColor = System.Drawing.Color.White;
            this.picEditionAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditionAdd.Image = global::Library.Properties.Resources.add;
            this.picEditionAdd.Location = new System.Drawing.Point(359, 5);
            this.picEditionAdd.Name = "picEditionAdd";
            this.picEditionAdd.Size = new System.Drawing.Size(64, 64);
            this.picEditionAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditionAdd.TabIndex = 23;
            this.picEditionAdd.TabStop = false;
            this.picEditionAdd.Click += new System.EventHandler(this.picEditionAdd_Click);
            // 
            // printEdition
            // 
            this.printEdition.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printEdition_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EditionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EditionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 410;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EditionName";
            this.dataGridViewTextBoxColumn2.HeaderText = "EditionName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 502;
            // 
            // ucEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picEditionExcel);
            this.Controls.Add(this.picEditionPrint);
            this.Controls.Add(this.picEditionSave);
            this.Controls.Add(this.tbEditionSearch);
            this.Controls.Add(this.picEditionMinus);
            this.Controls.Add(this.picEditionAdd);
            this.Controls.Add(this.EditionNameLabel);
            this.Controls.Add(this.EditionIDLabel);
            this.Controls.Add(this.EditionIDTextBox);
            this.Controls.Add(this.EditionNameTextBox);
            this.Controls.Add(this.editionsMetroGrid);
            this.Name = "ucEdition";
            this.Size = new System.Drawing.Size(970, 400);
            this.Load += new System.EventHandler(this.ucEdition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionsMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditionAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource editionsBindingSource;
        private LibraryDBDataSetTableAdapters.EditionsTableAdapter editionsTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid editionsMetroGrid;
        private System.Windows.Forms.TextBox EditionIDTextBox;
        private System.Windows.Forms.TextBox EditionNameTextBox;
        private MetroFramework.Controls.MetroLabel EditionIDLabel;
        private MetroFramework.Controls.MetroLabel EditionNameLabel;
        private System.Windows.Forms.PictureBox picEditionExcel;
        private System.Windows.Forms.PictureBox picEditionPrint;
        private System.Windows.Forms.PictureBox picEditionSave;
        private System.Windows.Forms.TextBox tbEditionSearch;
        private System.Windows.Forms.PictureBox picEditionMinus;
        private System.Windows.Forms.PictureBox picEditionAdd;
        private System.Drawing.Printing.PrintDocument printEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
