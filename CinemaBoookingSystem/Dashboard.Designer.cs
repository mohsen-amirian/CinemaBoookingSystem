namespace CinemaBoookingSystem
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgvMovies = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            dgvScreening = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            btnBook = new Button();
            label3 = new Label();
            lstbSeats = new ListBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            btnCancelBooking = new Button();
            dgvBookings = new DataGridView();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dgvManageCustomers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            txtNewCustomerYOB = new TextBox();
            label12 = new Label();
            txtNewCustomerEmail = new TextBox();
            label13 = new Label();
            txtNewCustomerLastName = new TextBox();
            label14 = new Label();
            txtNewCustomerName = new TextBox();
            btnCreateNewCustomer = new Button();
            gbCustomerEdit = new GroupBox();
            btnCustomerEditCancel = new Button();
            label10 = new Label();
            txtEditCustomerYOB = new TextBox();
            label9 = new Label();
            txtEditCustomerEmail = new TextBox();
            label8 = new Label();
            txtEditCustomerLastName = new TextBox();
            label7 = new Label();
            txtEditCustomerName = new TextBox();
            btnCustomerEditSave = new Button();
            btnDeleteCustomer = new Button();
            btnEditCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScreening).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageCustomers).BeginInit();
            groupBox3.SuspendLayout();
            gbCustomerEdit.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvCustomers.Location = new Point(97, 12);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(797, 190);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 109;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.DataPropertyName = "LastName";
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 108;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "YearOfBirth";
            Column3.HeaderText = "YearOfBirth";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 113;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.DataPropertyName = "Email";
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 75;
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.AllowUserToResizeColumns = false;
            dgvMovies.AllowUserToResizeRows = false;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dgvMovies.Location = new Point(97, 219);
            dgvMovies.MultiSelect = false;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.Size = new Size(797, 178);
            dgvMovies.TabIndex = 1;
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.DataPropertyName = "Title";
            Column5.HeaderText = "Title";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 67;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.DataPropertyName = "Genre";
            Column6.HeaderText = "Genre";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 77;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.DataPropertyName = "Rating";
            Column7.HeaderText = "Rating";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 81;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.DataPropertyName = "Year";
            Column8.HeaderText = "Year";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 66;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.DataPropertyName = "Director";
            Column9.HeaderText = "Director";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 92;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 803);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvCustomers);
            tabPage1.Controls.Add(dgvMovies);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 770);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reservation";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvScreening);
            groupBox1.Controls.Add(btnBook);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lstbSeats);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(97, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 335);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Ticket";
            // 
            // dgvScreening
            // 
            dgvScreening.AllowUserToAddRows = false;
            dgvScreening.AllowUserToDeleteRows = false;
            dgvScreening.AllowUserToResizeColumns = false;
            dgvScreening.AllowUserToResizeRows = false;
            dgvScreening.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScreening.Columns.AddRange(new DataGridViewColumn[] { Column10, Column11 });
            dgvScreening.Location = new Point(14, 78);
            dgvScreening.MultiSelect = false;
            dgvScreening.Name = "dgvScreening";
            dgvScreening.ReadOnly = true;
            dgvScreening.RowHeadersWidth = 51;
            dgvScreening.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScreening.Size = new Size(377, 239);
            dgvScreening.TabIndex = 4;
            dgvScreening.SelectionChanged += dgvScreening_SelectionChanged;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.DataPropertyName = "ScreenName";
            Column10.HeaderText = "Screen Name";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 126;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column11.DataPropertyName = "DateTime";
            Column11.HeaderText = "Time";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 71;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(548, 273);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(122, 44);
            btnBook.TabIndex = 11;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 39);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Screening";
            // 
            // lstbSeats
            // 
            lstbSeats.DisplayMember = "Number";
            lstbSeats.FormattingEnabled = true;
            lstbSeats.Location = new Point(502, 78);
            lstbSeats.Name = "lstbSeats";
            lstbSeats.Size = new Size(168, 164);
            lstbSeats.TabIndex = 10;
            lstbSeats.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 39);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 7;
            label4.Text = "Available Seat Numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 219);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Movies";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Customers";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnCancelBooking);
            tabPage2.Controls.Add(dgvBookings);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(947, 770);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Bookings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 30);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 3;
            label5.Text = "Bookings";
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Location = new Point(737, 703);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(165, 43);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = true;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeColumns = false;
            dgvBookings.AllowUserToResizeRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column17 });
            dgvBookings.Location = new Point(33, 69);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(869, 610);
            dgvBookings.TabIndex = 0;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column12.DataPropertyName = "CustomerName";
            Column12.HeaderText = "Customer";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 101;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column13.DataPropertyName = "MovieName";
            Column13.HeaderText = "Movie";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 79;
            // 
            // Column14
            // 
            Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column14.DataPropertyName = "ScreenName";
            Column14.HeaderText = "Screen";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 82;
            // 
            // Column15
            // 
            Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column15.DataPropertyName = "SeatNumber";
            Column15.HeaderText = "Seat Number";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 125;
            // 
            // Column16
            // 
            Column16.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column16.DataPropertyName = "ScreeningDate";
            Column16.HeaderText = "Screening Date";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 139;
            // 
            // Column17
            // 
            Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column17.DataPropertyName = "BookingDate";
            Column17.HeaderText = "Booking Date";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 129;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvManageCustomers);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(gbCustomerEdit);
            tabPage3.Controls.Add(btnDeleteCustomer);
            tabPage3.Controls.Add(btnEditCustomer);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(947, 770);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Customers";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvManageCustomers
            // 
            dgvManageCustomers.AllowUserToAddRows = false;
            dgvManageCustomers.AllowUserToDeleteRows = false;
            dgvManageCustomers.AllowUserToResizeColumns = false;
            dgvManageCustomers.AllowUserToResizeRows = false;
            dgvManageCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageCustomers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvManageCustomers.Location = new Point(33, 45);
            dgvManageCustomers.MultiSelect = false;
            dgvManageCustomers.Name = "dgvManageCustomers";
            dgvManageCustomers.ReadOnly = true;
            dgvManageCustomers.RowHeadersWidth = 51;
            dgvManageCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageCustomers.Size = new Size(874, 338);
            dgvManageCustomers.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "First Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 109;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 108;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "YearOfBirth";
            dataGridViewTextBoxColumn3.HeaderText = "YearOfBirth";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 113;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 12);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 5;
            label6.Text = "Customers";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtNewCustomerYOB);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtNewCustomerEmail);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtNewCustomerLastName);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtNewCustomerName);
            groupBox3.Controls.Add(btnCreateNewCustomer);
            groupBox3.Location = new Point(507, 439);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 323);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Create New Customer";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 215);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 21;
            label11.Text = "Year of Birth";
            // 
            // txtNewCustomerYOB
            // 
            txtNewCustomerYOB.Location = new Point(152, 211);
            txtNewCustomerYOB.Name = "txtNewCustomerYOB";
            txtNewCustomerYOB.Size = new Size(94, 27);
            txtNewCustomerYOB.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 156);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 19;
            label12.Text = "Email";
            // 
            // txtNewCustomerEmail
            // 
            txtNewCustomerEmail.Location = new Point(152, 153);
            txtNewCustomerEmail.Name = "txtNewCustomerEmail";
            txtNewCustomerEmail.Size = new Size(206, 27);
            txtNewCustomerEmail.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(43, 99);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 17;
            label13.Text = "Last Name";
            // 
            // txtNewCustomerLastName
            // 
            txtNewCustomerLastName.Location = new Point(152, 96);
            txtNewCustomerLastName.Name = "txtNewCustomerLastName";
            txtNewCustomerLastName.Size = new Size(206, 27);
            txtNewCustomerLastName.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(43, 48);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 15;
            label14.Text = "Name";
            // 
            // txtNewCustomerName
            // 
            txtNewCustomerName.Location = new Point(152, 45);
            txtNewCustomerName.Name = "txtNewCustomerName";
            txtNewCustomerName.Size = new Size(206, 27);
            txtNewCustomerName.TabIndex = 14;
            // 
            // btnCreateNewCustomer
            // 
            btnCreateNewCustomer.Location = new Point(152, 278);
            btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            btnCreateNewCustomer.Size = new Size(94, 29);
            btnCreateNewCustomer.TabIndex = 2;
            btnCreateNewCustomer.Text = "Create";
            btnCreateNewCustomer.UseVisualStyleBackColor = true;
            btnCreateNewCustomer.Click += btnCreateNewCustomer_Click;
            // 
            // gbCustomerEdit
            // 
            gbCustomerEdit.Controls.Add(btnCustomerEditCancel);
            gbCustomerEdit.Controls.Add(label10);
            gbCustomerEdit.Controls.Add(txtEditCustomerYOB);
            gbCustomerEdit.Controls.Add(label9);
            gbCustomerEdit.Controls.Add(txtEditCustomerEmail);
            gbCustomerEdit.Controls.Add(label8);
            gbCustomerEdit.Controls.Add(txtEditCustomerLastName);
            gbCustomerEdit.Controls.Add(label7);
            gbCustomerEdit.Controls.Add(txtEditCustomerName);
            gbCustomerEdit.Controls.Add(btnCustomerEditSave);
            gbCustomerEdit.Enabled = false;
            gbCustomerEdit.Location = new Point(32, 439);
            gbCustomerEdit.Name = "gbCustomerEdit";
            gbCustomerEdit.Size = new Size(400, 323);
            gbCustomerEdit.TabIndex = 3;
            gbCustomerEdit.TabStop = false;
            gbCustomerEdit.Text = "Edit";
            // 
            // btnCustomerEditCancel
            // 
            btnCustomerEditCancel.Location = new Point(261, 278);
            btnCustomerEditCancel.Name = "btnCustomerEditCancel";
            btnCustomerEditCancel.Size = new Size(94, 29);
            btnCustomerEditCancel.TabIndex = 13;
            btnCustomerEditCancel.Text = "Cancel";
            btnCustomerEditCancel.UseVisualStyleBackColor = true;
            btnCustomerEditCancel.Click += btnCustomerEditCancel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 211);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 12;
            label10.Text = "Year of Birth";
            // 
            // txtEditCustomerYOB
            // 
            txtEditCustomerYOB.Location = new Point(149, 207);
            txtEditCustomerYOB.Name = "txtEditCustomerYOB";
            txtEditCustomerYOB.Size = new Size(94, 27);
            txtEditCustomerYOB.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 152);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 10;
            label9.Text = "Email";
            // 
            // txtEditCustomerEmail
            // 
            txtEditCustomerEmail.Location = new Point(149, 149);
            txtEditCustomerEmail.Name = "txtEditCustomerEmail";
            txtEditCustomerEmail.Size = new Size(206, 27);
            txtEditCustomerEmail.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 95);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 8;
            label8.Text = "Last Name";
            // 
            // txtEditCustomerLastName
            // 
            txtEditCustomerLastName.Location = new Point(149, 92);
            txtEditCustomerLastName.Name = "txtEditCustomerLastName";
            txtEditCustomerLastName.Size = new Size(206, 27);
            txtEditCustomerLastName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 44);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Name";
            // 
            // txtEditCustomerName
            // 
            txtEditCustomerName.Location = new Point(149, 41);
            txtEditCustomerName.Name = "txtEditCustomerName";
            txtEditCustomerName.Size = new Size(206, 27);
            txtEditCustomerName.TabIndex = 4;
            // 
            // btnCustomerEditSave
            // 
            btnCustomerEditSave.Location = new Point(149, 278);
            btnCustomerEditSave.Name = "btnCustomerEditSave";
            btnCustomerEditSave.Size = new Size(94, 29);
            btnCustomerEditSave.TabIndex = 3;
            btnCustomerEditSave.Text = "Save";
            btnCustomerEditSave.UseVisualStyleBackColor = true;
            btnCustomerEditSave.Click += btnCustomerEditSave_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(149, 389);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(94, 29);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(32, 389);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(94, 29);
            btnEditCustomer.TabIndex = 1;
            btnEditCustomer.Text = "Edit";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 803);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Dashboard";
            Text = "Cinema Booking Dashboard";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScreening).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageCustomers).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbCustomerEdit.ResumeLayout(false);
            gbCustomerEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomers;
        private DataGridView dgvMovies;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private DataGridView dgvScreening;
        private ListBox lstbSeats;
        private Button btnBook;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private Button btnCancelBooking;
        private Label label5;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private Button btnCreateNewCustomer;
        private GroupBox gbCustomerEdit;
        private Button btnCustomerEditSave;
        private Button btnDeleteCustomer;
        private Button btnEditCustomer;
        private Label label6;
        private Label label8;
        private TextBox txtEditCustomerLastName;
        private Label label7;
        private TextBox txtEditCustomerName;
        private Label label11;
        private TextBox txtNewCustomerYOB;
        private Label label12;
        private TextBox txtNewCustomerEmail;
        private Label label13;
        private TextBox txtNewCustomerLastName;
        private Label label14;
        private TextBox txtNewCustomerName;
        private Label label10;
        private TextBox txtEditCustomerYOB;
        private Label label9;
        private TextBox txtEditCustomerEmail;
        private DataGridView dgvManageCustomers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnCustomerEditCancel;
    }
}
