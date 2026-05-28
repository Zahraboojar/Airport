namespace ManageAirportApp
{
    partial class FrmEditTicket
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
            this.menuControl1 = new ManageAirportApp.MenuControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.combFlightClass = new System.Windows.Forms.ComboBox();
            this.combSeatNum = new System.Windows.Forms.ComboBox();
            this.comFlights = new System.Windows.Forms.ComboBox();
            this.combType = new System.Windows.Forms.ComboBox();
            this.combPassengers = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(806, 65);
            this.menuControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.numericPrice);
            this.panel1.Controls.Add(this.combFlightClass);
            this.panel1.Controls.Add(this.combSeatNum);
            this.panel1.Controls.Add(this.comFlights);
            this.panel1.Controls.Add(this.combType);
            this.panel1.Controls.Add(this.combPassengers);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 483);
            this.panel1.TabIndex = 3;
            // 
            // numericPrice
            // 
            this.numericPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.numericPrice.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.numericPrice.Location = new System.Drawing.Point(194, 241);
            this.numericPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(206, 31);
            this.numericPrice.TabIndex = 22;
            // 
            // combFlightClass
            // 
            this.combFlightClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combFlightClass.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combFlightClass.FormattingEnabled = true;
            this.combFlightClass.Location = new System.Drawing.Point(194, 184);
            this.combFlightClass.Name = "combFlightClass";
            this.combFlightClass.Size = new System.Drawing.Size(206, 32);
            this.combFlightClass.TabIndex = 21;
            // 
            // combSeatNum
            // 
            this.combSeatNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combSeatNum.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combSeatNum.FormattingEnabled = true;
            this.combSeatNum.Location = new System.Drawing.Point(194, 131);
            this.combSeatNum.Name = "combSeatNum";
            this.combSeatNum.Size = new System.Drawing.Size(206, 32);
            this.combSeatNum.TabIndex = 21;
            // 
            // comFlights
            // 
            this.comFlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.comFlights.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.comFlights.FormattingEnabled = true;
            this.comFlights.Location = new System.Drawing.Point(194, 80);
            this.comFlights.Name = "comFlights";
            this.comFlights.Size = new System.Drawing.Size(206, 32);
            this.comFlights.TabIndex = 21;
            this.comFlights.SelectedIndexChanged += new System.EventHandler(this.comFlights_SelectedIndexChanged);
            // 
            // combType
            // 
            this.combType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combType.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(193, 295);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(206, 32);
            this.combType.TabIndex = 21;
            // 
            // combPassengers
            // 
            this.combPassengers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combPassengers.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combPassengers.FormattingEnabled = true;
            this.combPassengers.Location = new System.Drawing.Point(194, 30);
            this.combPassengers.Name = "combPassengers";
            this.combPassengers.Size = new System.Drawing.Size(206, 32);
            this.combPassengers.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnSubmit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.Location = new System.Drawing.Point(218, 384);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 49);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "تایید";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(472, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 49);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Tag = "close";
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(526, 241);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "قیمت  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(522, 188);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "کلاس پروازی :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(152, 244);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(36, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "ریال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(523, 135);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "شماره صندلی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(523, 80);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "پرواز :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(522, 295);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(39, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "نوع :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(523, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "مسافر :";
            // 
            // FrmEditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditTicket";
            this.Text = "FrmEditTicket";
            this.Load += new System.EventHandler(this.FrmEditTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControl menuControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combPassengers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.ComboBox combFlightClass;
        private System.Windows.Forms.ComboBox comFlights;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combSeatNum;
    }
}