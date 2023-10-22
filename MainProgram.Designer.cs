namespace IT_PROJECT
{
    partial class MainProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label publicationDateLabel;
            System.Windows.Forms.Label availabilityLabel;
            System.Windows.Forms.Label borrowerIDLabel;
            System.Windows.Forms.Label dateBorrowedLabel;
            System.Windows.Forms.Label dateDueLabel;
            System.Windows.Forms.Label dateReturnedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.libraEase = new IT_PROJECT.LibraEase();
            this.libraryManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementTableAdapter = new IT_PROJECT.LibraEaseTableAdapters.LibraryManagementTableAdapter();
            this.tableAdapterManager = new IT_PROJECT.LibraEaseTableAdapters.TableAdapterManager();
            this.libraryManagementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.PlusLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.libraryManagementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.SaveLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpLabel = new System.Windows.Forms.ToolStripLabel();
            this.libraryManagementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.publicationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.availabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.borrowerIDTextBox = new System.Windows.Forms.TextBox();
            this.dateBorrowedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LibraEaseLabel = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            bookIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            publicationDateLabel = new System.Windows.Forms.Label();
            availabilityLabel = new System.Windows.Forms.Label();
            borrowerIDLabel = new System.Windows.Forms.Label();
            dateBorrowedLabel = new System.Windows.Forms.Label();
            dateDueLabel = new System.Windows.Forms.Label();
            dateReturnedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraEase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementBindingNavigator)).BeginInit();
            this.libraryManagementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bookIDLabel.Location = new System.Drawing.Point(67, 121);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(60, 16);
            bookIDLabel.TabIndex = 2;
            bookIDLabel.Text = "Book ID:";
            bookIDLabel.Click += new System.EventHandler(this.bookIDLabel_Click);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(90, 150);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(37, 16);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title:";
            titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorLabel.Location = new System.Drawing.Point(73, 179);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(54, 16);
            authorLabel.TabIndex = 6;
            authorLabel.Text = "Author:";
            authorLabel.Click += new System.EventHandler(this.authorLabel_Click);
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genreLabel.Location = new System.Drawing.Point(76, 210);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(51, 16);
            genreLabel.TabIndex = 8;
            genreLabel.Text = "Genre:";
            genreLabel.Click += new System.EventHandler(this.genreLabel_Click);
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publisherLabel.Location = new System.Drawing.Point(57, 239);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(70, 16);
            publisherLabel.TabIndex = 10;
            publisherLabel.Text = "Publisher:";
            publisherLabel.Click += new System.EventHandler(this.publisherLabel_Click);
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publicationDateLabel.Location = new System.Drawing.Point(9, 268);
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new System.Drawing.Size(118, 16);
            publicationDateLabel.TabIndex = 12;
            publicationDateLabel.Text = "Publication Date:";
            publicationDateLabel.Click += new System.EventHandler(this.publicationDateLabel_Click);
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            availabilityLabel.Location = new System.Drawing.Point(457, 123);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new System.Drawing.Size(87, 16);
            availabilityLabel.TabIndex = 14;
            availabilityLabel.Text = "Availability:";
            availabilityLabel.Click += new System.EventHandler(this.availabilityLabel_Click);
            // 
            // borrowerIDLabel
            // 
            borrowerIDLabel.AutoSize = true;
            borrowerIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            borrowerIDLabel.Location = new System.Drawing.Point(457, 152);
            borrowerIDLabel.Name = "borrowerIDLabel";
            borrowerIDLabel.Size = new System.Drawing.Size(85, 16);
            borrowerIDLabel.TabIndex = 16;
            borrowerIDLabel.Text = "Borrower ID:";
            borrowerIDLabel.Click += new System.EventHandler(this.borrowerIDLabel_Click);
            // 
            // dateBorrowedLabel
            // 
            dateBorrowedLabel.AutoSize = true;
            dateBorrowedLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateBorrowedLabel.Location = new System.Drawing.Point(438, 181);
            dateBorrowedLabel.Name = "dateBorrowedLabel";
            dateBorrowedLabel.Size = new System.Drawing.Size(106, 16);
            dateBorrowedLabel.TabIndex = 18;
            dateBorrowedLabel.Text = "Date Borrowed:";
            dateBorrowedLabel.Click += new System.EventHandler(this.dateBorrowedLabel_Click);
            // 
            // dateDueLabel
            // 
            dateDueLabel.AutoSize = true;
            dateDueLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDueLabel.Location = new System.Drawing.Point(472, 210);
            dateDueLabel.Name = "dateDueLabel";
            dateDueLabel.Size = new System.Drawing.Size(70, 16);
            dateDueLabel.TabIndex = 20;
            dateDueLabel.Text = "Date Due:";
            dateDueLabel.Click += new System.EventHandler(this.dateDueLabel_Click);
            // 
            // dateReturnedLabel
            // 
            dateReturnedLabel.AutoSize = true;
            dateReturnedLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateReturnedLabel.Location = new System.Drawing.Point(439, 239);
            dateReturnedLabel.Name = "dateReturnedLabel";
            dateReturnedLabel.Size = new System.Drawing.Size(103, 16);
            dateReturnedLabel.TabIndex = 22;
            dateReturnedLabel.Text = "Date Returned:";
            dateReturnedLabel.Click += new System.EventHandler(this.dateReturnedLabel_Click);
            // 
            // libraEase
            // 
            this.libraEase.DataSetName = "LibraEase";
            this.libraEase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryManagementBindingSource
            // 
            this.libraryManagementBindingSource.DataMember = "LibraryManagement";
            this.libraryManagementBindingSource.DataSource = this.libraEase;
            // 
            // libraryManagementTableAdapter
            // 
            this.libraryManagementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibraryManagementTableAdapter = this.libraryManagementTableAdapter;
            this.tableAdapterManager.UpdateOrder = IT_PROJECT.LibraEaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // libraryManagementBindingNavigator
            // 
            this.libraryManagementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.libraryManagementBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(184)))), ((int)(((byte)(177)))));
            this.libraryManagementBindingNavigator.BindingSource = this.libraryManagementBindingSource;
            this.libraryManagementBindingNavigator.CountItem = null;
            this.libraryManagementBindingNavigator.DeleteItem = null;
            this.libraryManagementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.PlusLabel,
            this.toolStripSeparator1,
            this.libraryManagementBindingNavigatorSaveItem,
            this.SaveLabel,
            this.toolStripSeparator2,
            this.HelpLabel});
            this.libraryManagementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.libraryManagementBindingNavigator.MoveFirstItem = null;
            this.libraryManagementBindingNavigator.MoveLastItem = null;
            this.libraryManagementBindingNavigator.MoveNextItem = null;
            this.libraryManagementBindingNavigator.MovePreviousItem = null;
            this.libraryManagementBindingNavigator.Name = "libraryManagementBindingNavigator";
            this.libraryManagementBindingNavigator.PositionItem = null;
            this.libraryManagementBindingNavigator.Size = new System.Drawing.Size(859, 25);
            this.libraryManagementBindingNavigator.TabIndex = 0;
            this.libraryManagementBindingNavigator.Text = "bindingNavigator1";
            this.libraryManagementBindingNavigator.RefreshItems += new System.EventHandler(this.libraryManagementBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // PlusLabel
            // 
            this.PlusLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(105, 22);
            this.PlusLabel.Text = "Add New Book";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // libraryManagementBindingNavigatorSaveItem
            // 
            this.libraryManagementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libraryManagementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("libraryManagementBindingNavigatorSaveItem.Image")));
            this.libraryManagementBindingNavigatorSaveItem.Name = "libraryManagementBindingNavigatorSaveItem";
            this.libraryManagementBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.libraryManagementBindingNavigatorSaveItem.Text = "Save Data";
            this.libraryManagementBindingNavigatorSaveItem.Click += new System.EventHandler(this.libraryManagementBindingNavigatorSaveItem_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(101, 22);
            this.SaveLabel.Text = "Save / Update";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpLabel
            // 
            this.HelpLabel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLabel.IsLink = true;
            this.HelpLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(136, 22);
            this.HelpLabel.Text = "Need Help? Click Me!";
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // libraryManagementDataGridView
            // 
            this.libraryManagementDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryManagementDataGridView.AutoGenerateColumns = false;
            this.libraryManagementDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(175)))), ((int)(((byte)(160)))));
            this.libraryManagementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryManagementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.libraryManagementDataGridView.DataSource = this.libraryManagementBindingSource;
            this.libraryManagementDataGridView.Location = new System.Drawing.Point(0, 344);
            this.libraryManagementDataGridView.Name = "libraryManagementDataGridView";
            this.libraryManagementDataGridView.ReadOnly = true;
            this.libraryManagementDataGridView.Size = new System.Drawing.Size(859, 189);
            this.libraryManagementDataGridView.TabIndex = 1;
            this.libraryManagementDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.libraryManagementDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn5.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PublicationDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "PublicationDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Availability";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Availability";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BorrowerID";
            this.dataGridViewTextBoxColumn7.HeaderText = "BorrowerID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateBorrowed";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateBorrowed";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateDue";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateDue";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DateReturned";
            this.dataGridViewTextBoxColumn10.HeaderText = "DateReturned";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryManagementBindingSource, "BookID", true));
            this.bookIDTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDTextBox.Location = new System.Drawing.Point(133, 114);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(256, 23);
            this.bookIDTextBox.TabIndex = 3;
            this.bookIDTextBox.TextChanged += new System.EventHandler(this.bookIDTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryManagementBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(133, 143);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(256, 23);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryManagementBindingSource, "Author", true));
            this.authorTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(133, 172);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(256, 23);
            this.authorTextBox.TabIndex = 7;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryManagementBindingSource, "Publisher", true));
            this.publisherTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextBox.Location = new System.Drawing.Point(133, 232);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(256, 23);
            this.publisherTextBox.TabIndex = 11;
            this.publisherTextBox.TextChanged += new System.EventHandler(this.publisherTextBox_TextChanged);
            // 
            // publicationDateDateTimePicker
            // 
            this.publicationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryManagementBindingSource, "PublicationDate", true));
            this.publicationDateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationDateDateTimePicker.Location = new System.Drawing.Point(133, 261);
            this.publicationDateDateTimePicker.Name = "publicationDateDateTimePicker";
            this.publicationDateDateTimePicker.Size = new System.Drawing.Size(256, 23);
            this.publicationDateDateTimePicker.TabIndex = 13;
            this.publicationDateDateTimePicker.ValueChanged += new System.EventHandler(this.publicationDateDateTimePicker_ValueChanged);
            // 
            // availabilityCheckBox
            // 
            this.availabilityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.libraryManagementBindingSource, "Availability", true));
            this.availabilityCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.availabilityCheckBox.Location = new System.Drawing.Point(550, 118);
            this.availabilityCheckBox.Name = "availabilityCheckBox";
            this.availabilityCheckBox.Size = new System.Drawing.Size(200, 24);
            this.availabilityCheckBox.TabIndex = 15;
            this.availabilityCheckBox.UseVisualStyleBackColor = true;
            this.availabilityCheckBox.CheckedChanged += new System.EventHandler(this.availabilityCheckBox_CheckedChanged);
            // 
            // borrowerIDTextBox
            // 
            this.borrowerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryManagementBindingSource, "BorrowerID", true));
            this.borrowerIDTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.borrowerIDTextBox.Location = new System.Drawing.Point(550, 145);
            this.borrowerIDTextBox.Name = "borrowerIDTextBox";
            this.borrowerIDTextBox.Size = new System.Drawing.Size(256, 23);
            this.borrowerIDTextBox.TabIndex = 17;
            this.borrowerIDTextBox.TextChanged += new System.EventHandler(this.borrowerIDTextBox_TextChanged);
            // 
            // dateBorrowedDateTimePicker
            // 
            this.dateBorrowedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryManagementBindingSource, "DateBorrowed", true));
            this.dateBorrowedDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateBorrowedDateTimePicker.Location = new System.Drawing.Point(550, 174);
            this.dateBorrowedDateTimePicker.Name = "dateBorrowedDateTimePicker";
            this.dateBorrowedDateTimePicker.Size = new System.Drawing.Size(256, 23);
            this.dateBorrowedDateTimePicker.TabIndex = 19;
            this.dateBorrowedDateTimePicker.ValueChanged += new System.EventHandler(this.dateBorrowedDateTimePicker_ValueChanged);
            // 
            // dateDueDateTimePicker
            // 
            this.dateDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryManagementBindingSource, "DateDue", true));
            this.dateDueDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateDueDateTimePicker.Location = new System.Drawing.Point(550, 203);
            this.dateDueDateTimePicker.Name = "dateDueDateTimePicker";
            this.dateDueDateTimePicker.Size = new System.Drawing.Size(256, 23);
            this.dateDueDateTimePicker.TabIndex = 21;
            this.dateDueDateTimePicker.ValueChanged += new System.EventHandler(this.dateDueDateTimePicker_ValueChanged);
            // 
            // dateReturnedDateTimePicker
            // 
            this.dateReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryManagementBindingSource, "DateReturned", true));
            this.dateReturnedDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateReturnedDateTimePicker.Location = new System.Drawing.Point(550, 232);
            this.dateReturnedDateTimePicker.Name = "dateReturnedDateTimePicker";
            this.dateReturnedDateTimePicker.Size = new System.Drawing.Size(256, 23);
            this.dateReturnedDateTimePicker.TabIndex = 23;
            this.dateReturnedDateTimePicker.ValueChanged += new System.EventHandler(this.dateReturnedDateTimePicker_ValueChanged);
            // 
            // BorrowButton
            // 
            this.BorrowButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowButton.Location = new System.Drawing.Point(441, 315);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(75, 23);
            this.BorrowButton.TabIndex = 24;
            this.BorrowButton.Text = "Borrow";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(522, 315);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 25;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryManagementBindingSource, "Genre", true));
            this.genreComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Mystery",
            "Science Fiction",
            "Fantasy",
            "Romance",
            "Thriller",
            "Horror",
            "Historical Fiction",
            "Adventure",
            "Biography",
            "Self-Help",
            "Science",
            "Fantasy",
            "Dystopian",
            "Comedy",
            "Drama",
            "Crime",
            "Poetry",
            "Travel",
            "Non-Fiction",
            "Graphic Novel"});
            this.genreComboBox.Location = new System.Drawing.Point(133, 201);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(256, 25);
            this.genreComboBox.TabIndex = 26;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(675, 314);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 27;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(756, 315);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 28;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(12, 315);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(215, 23);
            this.SearchBox.TabIndex = 29;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(233, 314);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 30;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(314, 314);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LibraEaseLabel
            // 
            this.LibraEaseLabel.AutoSize = true;
            this.LibraEaseLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraEaseLabel.Location = new System.Drawing.Point(93, 43);
            this.LibraEaseLabel.Name = "LibraEaseLabel";
            this.LibraEaseLabel.Size = new System.Drawing.Size(592, 44);
            this.LibraEaseLabel.TabIndex = 32;
            this.LibraEaseLabel.Text = "Libra-Ease Management System";
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(12, 28);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(75, 75);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 33;
            this.LogoPicture.TabStop = false;
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(441, 261);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(256, 23);
            this.CopyButton.TabIndex = 34;
            this.CopyButton.Text = "Copy Details to Clipboard";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(703, 261);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 35;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(859, 533);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.LibraEaseLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(bookIDLabel);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(publicationDateLabel);
            this.Controls.Add(this.publicationDateDateTimePicker);
            this.Controls.Add(availabilityLabel);
            this.Controls.Add(this.availabilityCheckBox);
            this.Controls.Add(borrowerIDLabel);
            this.Controls.Add(this.borrowerIDTextBox);
            this.Controls.Add(dateBorrowedLabel);
            this.Controls.Add(this.dateBorrowedDateTimePicker);
            this.Controls.Add(dateDueLabel);
            this.Controls.Add(this.dateDueDateTimePicker);
            this.Controls.Add(dateReturnedLabel);
            this.Controls.Add(this.dateReturnedDateTimePicker);
            this.Controls.Add(this.libraryManagementDataGridView);
            this.Controls.Add(this.libraryManagementBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libra-Ease";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraEase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementBindingNavigator)).EndInit();
            this.libraryManagementBindingNavigator.ResumeLayout(false);
            this.libraryManagementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraEase libraEase;
        private System.Windows.Forms.BindingSource libraryManagementBindingSource;
        private LibraEaseTableAdapters.LibraryManagementTableAdapter libraryManagementTableAdapter;
        private LibraEaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator libraryManagementBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton libraryManagementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView libraryManagementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.DateTimePicker publicationDateDateTimePicker;
        private System.Windows.Forms.CheckBox availabilityCheckBox;
        private System.Windows.Forms.TextBox borrowerIDTextBox;
        private System.Windows.Forms.DateTimePicker dateBorrowedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateDueDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnedDateTimePicker;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label LibraEaseLabel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.ToolStripLabel PlusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel SaveLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel HelpLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button Cancel;
    }
}

