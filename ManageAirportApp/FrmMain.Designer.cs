namespace ManageAirportApp
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl = new ManageAirportApp.MenuControl();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainDvg = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblPagination = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dBtnFlights = new ManageAirportApp.DashbordButton();
            this.dBtnTickets = new ManageAirportApp.DashbordButton();
            this.dBtnPassengers = new ManageAirportApp.DashbordButton();
            this.dBtnEmployees = new ManageAirportApp.DashbordButton();
            this.dBtnAirports = new ManageAirportApp.DashbordButton();
            this.dBtnAircrafts = new ManageAirportApp.DashbordButton();
            this.dBtnBaggages = new ManageAirportApp.DashbordButton();
            this.dBtnTerminals = new ManageAirportApp.DashbordButton();
            this.dBtnAirTraffic = new ManageAirportApp.DashbordButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDvg)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 65);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // menuControl
            // 
            this.menuControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.menuControl.Location = new System.Drawing.Point(3, 3);
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(800, 59);
            this.menuControl.TabIndex = 0;
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.pnlItems.Controls.Add(this.tableLayoutPanel2);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.ForeColor = System.Drawing.Color.Black;
            this.pnlItems.Location = new System.Drawing.Point(0, 65);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(498, 483);
            this.pnlItems.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.mainDvg, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 483);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // mainDvg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.mainDvg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDvg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.mainDvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDvg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainDvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDvg.DefaultCellStyle = dataGridViewCellStyle3;
            this.mainDvg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDvg.EnableHeadersVisualStyles = false;
            this.mainDvg.Location = new System.Drawing.Point(3, 46);
            this.mainDvg.Name = "mainDvg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDvg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mainDvg.Size = new System.Drawing.Size(492, 378);
            this.mainDvg.TabIndex = 10;
            this.mainDvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDvg_CellContentClick);
            this.mainDvg.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.mainDvg_RowPostPaint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.1F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.6F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3F));
            this.tableLayoutPanel5.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnTrash, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtSearch, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(492, 37);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnRefresh.BackgroundImage = global::ManageAirportApp.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(83, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnTrash.BackgroundImage = global::ManageAirportApp.Properties.Resources.trash;
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrash.ForeColor = System.Drawing.Color.Black;
            this.btnTrash.Location = new System.Drawing.Point(3, 3);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(34, 31);
            this.btnTrash.TabIndex = 2;
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnAdd.BackgroundImage = global::ManageAirportApp.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(43, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(426, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(264, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.button1.Location = new System.Drawing.Point(198, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.btnRight, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLeft, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPagination, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 430);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(492, 50);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::ManageAirportApp.Properties.Resources.right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.Location = new System.Drawing.Point(313, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(46, 51);
            this.btnRight.TabIndex = 5;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::ManageAirportApp.Properties.Resources.left;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.Location = new System.Drawing.Point(132, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(46, 51);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblPagination
            // 
            this.lblPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPagination.AutoSize = true;
            this.lblPagination.ForeColor = System.Drawing.Color.White;
            this.lblPagination.Location = new System.Drawing.Point(184, 0);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(123, 57);
            this.lblPagination.TabIndex = 2;
            this.lblPagination.Text = "10/5";
            this.lblPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.dBtnFlights, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dBtnTickets, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dBtnPassengers, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dBtnEmployees, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.dBtnAirports, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.dBtnAircrafts, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.dBtnBaggages, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.dBtnTerminals, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.dBtnAirTraffic, 0, 8);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(498, 65);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(308, 483);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // dBtnFlights
            // 
            this.dBtnFlights.BackgroundImage = global::ManageAirportApp.Properties.Resources.menuitemselected;
            this.dBtnFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnFlights.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnFlights.ForeColor = System.Drawing.Color.White;
            this.dBtnFlights.Location = new System.Drawing.Point(3, 3);
            this.dBtnFlights.Name = "dBtnFlights";
            this.dBtnFlights.Size = new System.Drawing.Size(302, 47);
            this.dBtnFlights.TabIndex = 7;
            this.dBtnFlights.Text = "پرواز ها";
            this.dBtnFlights.UseVisualStyleBackColor = true;
            this.dBtnFlights.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnTickets
            // 
            this.dBtnTickets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnTickets.BackgroundImage")));
            this.dBtnTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnTickets.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnTickets.ForeColor = System.Drawing.Color.Black;
            this.dBtnTickets.Location = new System.Drawing.Point(3, 56);
            this.dBtnTickets.Name = "dBtnTickets";
            this.dBtnTickets.Size = new System.Drawing.Size(302, 47);
            this.dBtnTickets.TabIndex = 8;
            this.dBtnTickets.Text = "بلیط ها";
            this.dBtnTickets.UseVisualStyleBackColor = true;
            this.dBtnTickets.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnPassengers
            // 
            this.dBtnPassengers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnPassengers.BackgroundImage")));
            this.dBtnPassengers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnPassengers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnPassengers.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnPassengers.ForeColor = System.Drawing.Color.Black;
            this.dBtnPassengers.Location = new System.Drawing.Point(3, 109);
            this.dBtnPassengers.Name = "dBtnPassengers";
            this.dBtnPassengers.Size = new System.Drawing.Size(302, 47);
            this.dBtnPassengers.TabIndex = 9;
            this.dBtnPassengers.Text = "مسافران";
            this.dBtnPassengers.UseVisualStyleBackColor = true;
            this.dBtnPassengers.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnEmployees
            // 
            this.dBtnEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnEmployees.BackgroundImage")));
            this.dBtnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnEmployees.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnEmployees.ForeColor = System.Drawing.Color.Black;
            this.dBtnEmployees.Location = new System.Drawing.Point(3, 162);
            this.dBtnEmployees.Name = "dBtnEmployees";
            this.dBtnEmployees.Size = new System.Drawing.Size(302, 47);
            this.dBtnEmployees.TabIndex = 10;
            this.dBtnEmployees.Text = "کارکنان";
            this.dBtnEmployees.UseVisualStyleBackColor = true;
            this.dBtnEmployees.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnAirports
            // 
            this.dBtnAirports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnAirports.BackgroundImage")));
            this.dBtnAirports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnAirports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnAirports.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnAirports.ForeColor = System.Drawing.Color.Black;
            this.dBtnAirports.Location = new System.Drawing.Point(3, 215);
            this.dBtnAirports.Name = "dBtnAirports";
            this.dBtnAirports.Size = new System.Drawing.Size(302, 47);
            this.dBtnAirports.TabIndex = 11;
            this.dBtnAirports.Text = "فرودگاه ها";
            this.dBtnAirports.UseVisualStyleBackColor = true;
            this.dBtnAirports.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnAircrafts
            // 
            this.dBtnAircrafts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnAircrafts.BackgroundImage")));
            this.dBtnAircrafts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnAircrafts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnAircrafts.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnAircrafts.ForeColor = System.Drawing.Color.Black;
            this.dBtnAircrafts.Location = new System.Drawing.Point(3, 268);
            this.dBtnAircrafts.Name = "dBtnAircrafts";
            this.dBtnAircrafts.Size = new System.Drawing.Size(302, 47);
            this.dBtnAircrafts.TabIndex = 12;
            this.dBtnAircrafts.Text = "هواپیما ها";
            this.dBtnAircrafts.UseVisualStyleBackColor = true;
            this.dBtnAircrafts.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnBaggages
            // 
            this.dBtnBaggages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnBaggages.BackgroundImage")));
            this.dBtnBaggages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnBaggages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnBaggages.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnBaggages.ForeColor = System.Drawing.Color.Black;
            this.dBtnBaggages.Location = new System.Drawing.Point(3, 321);
            this.dBtnBaggages.Name = "dBtnBaggages";
            this.dBtnBaggages.Size = new System.Drawing.Size(302, 47);
            this.dBtnBaggages.TabIndex = 13;
            this.dBtnBaggages.Text = "چمدان ها (بار)";
            this.dBtnBaggages.UseVisualStyleBackColor = true;
            this.dBtnBaggages.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnTerminals
            // 
            this.dBtnTerminals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnTerminals.BackgroundImage")));
            this.dBtnTerminals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnTerminals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnTerminals.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnTerminals.ForeColor = System.Drawing.Color.Black;
            this.dBtnTerminals.Location = new System.Drawing.Point(3, 374);
            this.dBtnTerminals.Name = "dBtnTerminals";
            this.dBtnTerminals.Size = new System.Drawing.Size(302, 47);
            this.dBtnTerminals.TabIndex = 14;
            this.dBtnTerminals.Text = "ترمینال ها";
            this.dBtnTerminals.UseVisualStyleBackColor = true;
            this.dBtnTerminals.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // dBtnAirTraffic
            // 
            this.dBtnAirTraffic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dBtnAirTraffic.BackgroundImage")));
            this.dBtnAirTraffic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtnAirTraffic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBtnAirTraffic.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.dBtnAirTraffic.ForeColor = System.Drawing.Color.Black;
            this.dBtnAirTraffic.Location = new System.Drawing.Point(3, 427);
            this.dBtnAirTraffic.Name = "dBtnAirTraffic";
            this.dBtnAirTraffic.Size = new System.Drawing.Size(302, 53);
            this.dBtnAirTraffic.TabIndex = 15;
            this.dBtnAirTraffic.Text = "کنترل ترافیک هوایی";
            this.dBtnAirTraffic.UseVisualStyleBackColor = true;
            this.dBtnAirTraffic.Click += new System.EventHandler(this.DashBoardBtn_ClickAsync);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDvg)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private MenuControl menuControl;
        private DashbordButton dBtnFlights;
        private DashbordButton dBtnTickets;
        private DashbordButton dBtnPassengers;
        private DashbordButton dBtnEmployees;
        private DashbordButton dBtnAirports;
        private DashbordButton dBtnAircrafts;
        private DashbordButton dBtnBaggages;
        private DashbordButton dBtnTerminals;
        private DashbordButton dBtnAirTraffic;
        private System.Windows.Forms.DataGridView mainDvg;
    }
}