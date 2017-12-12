namespace Library
{
    partial class ucRoomRead
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
            this.roomReadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomReadingTableAdapter = new Library.LibraryDBDataSetTableAdapters.RoomReadingTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.roomReadingMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.RoomIDTextBox = new System.Windows.Forms.TextBox();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.RoomIDLabel = new MetroFramework.Controls.MetroLabel();
            this.RoomNameLabel = new MetroFramework.Controls.MetroLabel();
            this.picRoomReadExcel = new System.Windows.Forms.PictureBox();
            this.picRoomReadPrint = new System.Windows.Forms.PictureBox();
            this.picRoomReadSave = new System.Windows.Forms.PictureBox();
            this.tbRoomReadSearch = new System.Windows.Forms.TextBox();
            this.picRoomReadMinus = new System.Windows.Forms.PictureBox();
            this.picRoomReadAdd = new System.Windows.Forms.PictureBox();
            this.printRoomRead = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReadingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReadingMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomReadingBindingSource
            // 
            this.roomReadingBindingSource.DataMember = "RoomReading";
            this.roomReadingBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // roomReadingTableAdapter
            // 
            this.roomReadingTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RoomReadingTableAdapter = this.roomReadingTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomReadingMetroGrid
            // 
            this.roomReadingMetroGrid.AllowUserToOrderColumns = true;
            this.roomReadingMetroGrid.AllowUserToResizeRows = false;
            this.roomReadingMetroGrid.AutoGenerateColumns = false;
            this.roomReadingMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roomReadingMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomReadingMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomReadingMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomReadingMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomReadingMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomReadingMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.roomReadingMetroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomReadingMetroGrid.DataSource = this.roomReadingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomReadingMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomReadingMetroGrid.EnableHeadersVisualStyles = false;
            this.roomReadingMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roomReadingMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roomReadingMetroGrid.Location = new System.Drawing.Point(0, 75);
            this.roomReadingMetroGrid.Name = "roomReadingMetroGrid";
            this.roomReadingMetroGrid.ReadOnly = true;
            this.roomReadingMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomReadingMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomReadingMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.roomReadingMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomReadingMetroGrid.Size = new System.Drawing.Size(970, 188);
            this.roomReadingMetroGrid.TabIndex = 1;
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomReadingBindingSource, "RoomID", true));
            this.RoomIDTextBox.Location = new System.Drawing.Point(117, 298);
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(311, 20);
            this.RoomIDTextBox.TabIndex = 2;
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomReadingBindingSource, "RoomName", true));
            this.RoomNameTextBox.Location = new System.Drawing.Point(504, 298);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(434, 20);
            this.RoomNameTextBox.TabIndex = 4;
            // 
            // RoomIDLabel
            // 
            this.RoomIDLabel.AutoSize = true;
            this.RoomIDLabel.Location = new System.Drawing.Point(45, 298);
            this.RoomIDLabel.Name = "RoomIDLabel";
            this.RoomIDLabel.Size = new System.Drawing.Size(64, 19);
            this.RoomIDLabel.TabIndex = 5;
            this.RoomIDLabel.Text = "Room ID:";
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(450, 298);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(48, 19);
            this.RoomNameLabel.TabIndex = 6;
            this.RoomNameLabel.Text = "Name:";
            // 
            // picRoomReadExcel
            // 
            this.picRoomReadExcel.BackColor = System.Drawing.Color.White;
            this.picRoomReadExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomReadExcel.Image = global::Library.Properties.Resources.excel;
            this.picRoomReadExcel.Location = new System.Drawing.Point(752, 3);
            this.picRoomReadExcel.Name = "picRoomReadExcel";
            this.picRoomReadExcel.Size = new System.Drawing.Size(64, 64);
            this.picRoomReadExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRoomReadExcel.TabIndex = 28;
            this.picRoomReadExcel.TabStop = false;
            this.picRoomReadExcel.Click += new System.EventHandler(this.picRoomReadExcel_Click);
            // 
            // picRoomReadPrint
            // 
            this.picRoomReadPrint.BackColor = System.Drawing.Color.White;
            this.picRoomReadPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomReadPrint.Image = global::Library.Properties.Resources.printer;
            this.picRoomReadPrint.Location = new System.Drawing.Point(883, 3);
            this.picRoomReadPrint.Name = "picRoomReadPrint";
            this.picRoomReadPrint.Size = new System.Drawing.Size(64, 64);
            this.picRoomReadPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRoomReadPrint.TabIndex = 27;
            this.picRoomReadPrint.TabStop = false;
            this.picRoomReadPrint.Click += new System.EventHandler(this.picRoomReadPrint_Click);
            // 
            // picRoomReadSave
            // 
            this.picRoomReadSave.BackColor = System.Drawing.Color.White;
            this.picRoomReadSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomReadSave.Image = global::Library.Properties.Resources.accept;
            this.picRoomReadSave.Location = new System.Drawing.Point(621, 5);
            this.picRoomReadSave.Name = "picRoomReadSave";
            this.picRoomReadSave.Size = new System.Drawing.Size(64, 64);
            this.picRoomReadSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRoomReadSave.TabIndex = 26;
            this.picRoomReadSave.TabStop = false;
            this.picRoomReadSave.Click += new System.EventHandler(this.picRoomReadSave_Click);
            // 
            // tbRoomReadSearch
            // 
            this.tbRoomReadSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRoomReadSearch.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRoomReadSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbRoomReadSearch.Location = new System.Drawing.Point(3, 3);
            this.tbRoomReadSearch.Name = "tbRoomReadSearch";
            this.tbRoomReadSearch.Size = new System.Drawing.Size(305, 66);
            this.tbRoomReadSearch.TabIndex = 25;
            this.tbRoomReadSearch.TabStop = false;
            this.tbRoomReadSearch.Text = "Search";
            this.tbRoomReadSearch.Click += new System.EventHandler(this.tbRoomReadSearch_Click);
            this.tbRoomReadSearch.TextChanged += new System.EventHandler(this.tbRoomReadSearch_TextChanged);
            this.tbRoomReadSearch.Leave += new System.EventHandler(this.tbRoomReadSearch_Leave);
            // 
            // picRoomReadMinus
            // 
            this.picRoomReadMinus.BackColor = System.Drawing.Color.White;
            this.picRoomReadMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomReadMinus.Image = global::Library.Properties.Resources.minus;
            this.picRoomReadMinus.Location = new System.Drawing.Point(490, 3);
            this.picRoomReadMinus.Name = "picRoomReadMinus";
            this.picRoomReadMinus.Size = new System.Drawing.Size(64, 64);
            this.picRoomReadMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRoomReadMinus.TabIndex = 24;
            this.picRoomReadMinus.TabStop = false;
            this.picRoomReadMinus.Click += new System.EventHandler(this.picRoomReadMinus_Click);
            // 
            // picRoomReadAdd
            // 
            this.picRoomReadAdd.BackColor = System.Drawing.Color.White;
            this.picRoomReadAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomReadAdd.Image = global::Library.Properties.Resources.add;
            this.picRoomReadAdd.Location = new System.Drawing.Point(359, 5);
            this.picRoomReadAdd.Name = "picRoomReadAdd";
            this.picRoomReadAdd.Size = new System.Drawing.Size(64, 64);
            this.picRoomReadAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRoomReadAdd.TabIndex = 23;
            this.picRoomReadAdd.TabStop = false;
            this.picRoomReadAdd.Click += new System.EventHandler(this.picRoomReadAdd_Click);
            // 
            // printRoomRead
            // 
            this.printRoomRead.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printRoomRead_PrintPage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 410;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoomName";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoomName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 502;
            // 
            // ucRoomRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picRoomReadExcel);
            this.Controls.Add(this.picRoomReadPrint);
            this.Controls.Add(this.picRoomReadSave);
            this.Controls.Add(this.tbRoomReadSearch);
            this.Controls.Add(this.picRoomReadMinus);
            this.Controls.Add(this.picRoomReadAdd);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.RoomIDLabel);
            this.Controls.Add(this.RoomIDTextBox);
            this.Controls.Add(this.RoomNameTextBox);
            this.Controls.Add(this.roomReadingMetroGrid);
            this.Name = "ucRoomRead";
            this.Size = new System.Drawing.Size(970, 368);
            this.Load += new System.EventHandler(this.ucRoomRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReadingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomReadingMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomReadAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource roomReadingBindingSource;
        private LibraryDBDataSetTableAdapters.RoomReadingTableAdapter roomReadingTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid roomReadingMetroGrid;
        private System.Windows.Forms.TextBox RoomIDTextBox;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private MetroFramework.Controls.MetroLabel RoomIDLabel;
        private MetroFramework.Controls.MetroLabel RoomNameLabel;
        private System.Windows.Forms.PictureBox picRoomReadExcel;
        private System.Windows.Forms.PictureBox picRoomReadPrint;
        private System.Windows.Forms.PictureBox picRoomReadSave;
        private System.Windows.Forms.TextBox tbRoomReadSearch;
        private System.Windows.Forms.PictureBox picRoomReadMinus;
        private System.Windows.Forms.PictureBox picRoomReadAdd;
        private System.Drawing.Printing.PrintDocument printRoomRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
