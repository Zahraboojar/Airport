namespace ManageAirportApp
{
    partial class FrmEditFlight
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
            this.dpDTime = new System.Windows.Forms.DateTimePicker();
            this.dpDDate = new System.Windows.Forms.DateTimePicker();
            this.dpATime = new System.Windows.Forms.DateTimePicker();
            this.dpADate = new System.Windows.Forms.DateTimePicker();
            this.dpSDTime = new System.Windows.Forms.DateTimePicker();
            this.dpSDDate = new System.Windows.Forms.DateTimePicker();
            this.dpSATime = new System.Windows.Forms.DateTimePicker();
            this.dpSADate = new System.Windows.Forms.DateTimePicker();
            this.combStatus = new System.Windows.Forms.ComboBox();
            this.combGate = new System.Windows.Forms.ComboBox();
            this.combDAirport = new System.Windows.Forms.ComboBox();
            this.combAAirport = new System.Windows.Forms.ComboBox();
            this.combAircraft = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.dpDTime);
            this.panel1.Controls.Add(this.dpDDate);
            this.panel1.Controls.Add(this.dpATime);
            this.panel1.Controls.Add(this.dpADate);
            this.panel1.Controls.Add(this.dpSDTime);
            this.panel1.Controls.Add(this.dpSDDate);
            this.panel1.Controls.Add(this.dpSATime);
            this.panel1.Controls.Add(this.dpSADate);
            this.panel1.Controls.Add(this.combStatus);
            this.panel1.Controls.Add(this.combGate);
            this.panel1.Controls.Add(this.combDAirport);
            this.panel1.Controls.Add(this.combAAirport);
            this.panel1.Controls.Add(this.combAircraft);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 483);
            this.panel1.TabIndex = 3;
            // 
            // dpDTime
            // 
            this.dpDTime.CalendarForeColor = System.Drawing.Color.Black;
            this.dpDTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpDTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpDTime.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpDTime.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpDTime.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpDTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpDTime.Location = new System.Drawing.Point(12, 328);
            this.dpDTime.Name = "dpDTime";
            this.dpDTime.Size = new System.Drawing.Size(206, 31);
            this.dpDTime.TabIndex = 13;
            this.dpDTime.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpDDate
            // 
            this.dpDDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dpDDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpDDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpDDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpDDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpDDate.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpDDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDDate.Location = new System.Drawing.Point(12, 291);
            this.dpDDate.Name = "dpDDate";
            this.dpDDate.Size = new System.Drawing.Size(206, 31);
            this.dpDDate.TabIndex = 12;
            this.dpDDate.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpATime
            // 
            this.dpATime.CalendarForeColor = System.Drawing.Color.Black;
            this.dpATime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpATime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpATime.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpATime.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpATime.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpATime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpATime.Location = new System.Drawing.Point(12, 220);
            this.dpATime.Name = "dpATime";
            this.dpATime.Size = new System.Drawing.Size(206, 31);
            this.dpATime.TabIndex = 11;
            this.dpATime.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpADate
            // 
            this.dpADate.CalendarForeColor = System.Drawing.Color.Black;
            this.dpADate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpADate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpADate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpADate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpADate.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpADate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpADate.Location = new System.Drawing.Point(12, 183);
            this.dpADate.Name = "dpADate";
            this.dpADate.Size = new System.Drawing.Size(206, 31);
            this.dpADate.TabIndex = 10;
            this.dpADate.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpSDTime
            // 
            this.dpSDTime.CalendarForeColor = System.Drawing.Color.Black;
            this.dpSDTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSDTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSDTime.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpSDTime.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpSDTime.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpSDTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpSDTime.Location = new System.Drawing.Point(392, 328);
            this.dpSDTime.Name = "dpSDTime";
            this.dpSDTime.Size = new System.Drawing.Size(206, 31);
            this.dpSDTime.TabIndex = 6;
            this.dpSDTime.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpSDDate
            // 
            this.dpSDDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dpSDDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSDDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSDDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpSDDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpSDDate.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpSDDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSDDate.Location = new System.Drawing.Point(392, 291);
            this.dpSDDate.Name = "dpSDDate";
            this.dpSDDate.Size = new System.Drawing.Size(206, 31);
            this.dpSDDate.TabIndex = 5;
            this.dpSDDate.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpSATime
            // 
            this.dpSATime.CalendarForeColor = System.Drawing.Color.Black;
            this.dpSATime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSATime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSATime.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpSATime.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpSATime.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpSATime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpSATime.Location = new System.Drawing.Point(392, 220);
            this.dpSATime.Name = "dpSATime";
            this.dpSATime.Size = new System.Drawing.Size(206, 31);
            this.dpSATime.TabIndex = 4;
            this.dpSATime.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // dpSADate
            // 
            this.dpSADate.CalendarForeColor = System.Drawing.Color.Black;
            this.dpSADate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSADate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.dpSADate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dpSADate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dpSADate.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.dpSADate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSADate.Location = new System.Drawing.Point(392, 183);
            this.dpSADate.Name = "dpSADate";
            this.dpSADate.Size = new System.Drawing.Size(206, 31);
            this.dpSADate.TabIndex = 3;
            this.dpSADate.Value = new System.DateTime(2026, 5, 11, 12, 0, 0, 0);
            // 
            // combStatus
            // 
            this.combStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combStatus.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combStatus.FormattingEnabled = true;
            this.combStatus.Location = new System.Drawing.Point(12, 68);
            this.combStatus.Name = "combStatus";
            this.combStatus.Size = new System.Drawing.Size(206, 32);
            this.combStatus.TabIndex = 8;
            // 
            // combGate
            // 
            this.combGate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combGate.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combGate.FormattingEnabled = true;
            this.combGate.Location = new System.Drawing.Point(12, 129);
            this.combGate.Name = "combGate";
            this.combGate.Size = new System.Drawing.Size(206, 32);
            this.combGate.TabIndex = 9;
            // 
            // combDAirport
            // 
            this.combDAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combDAirport.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combDAirport.FormattingEnabled = true;
            this.combDAirport.Location = new System.Drawing.Point(392, 93);
            this.combDAirport.Name = "combDAirport";
            this.combDAirport.Size = new System.Drawing.Size(206, 32);
            this.combDAirport.TabIndex = 2;
            // 
            // combAAirport
            // 
            this.combAAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combAAirport.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combAAirport.FormattingEnabled = true;
            this.combAAirport.Location = new System.Drawing.Point(392, 38);
            this.combAAirport.Name = "combAAirport";
            this.combAAirport.Size = new System.Drawing.Size(206, 32);
            this.combAAirport.TabIndex = 1;
            // 
            // combAircraft
            // 
            this.combAircraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combAircraft.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combAircraft.FormattingEnabled = true;
            this.combAircraft.Location = new System.Drawing.Point(12, 9);
            this.combAircraft.Name = "combAircraft";
            this.combAircraft.Size = new System.Drawing.Size(206, 32);
            this.combAircraft.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnSubmit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.Location = new System.Drawing.Point(218, 384);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 49);
            this.btnSubmit.TabIndex = 14;
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
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Tag = "close";
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(261, 306);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "زمان رسیدن :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(611, 306);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(192, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "زمان برنامه ریزی شده رسیدن :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(261, 129);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(47, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "گیت :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(259, 202);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(77, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "زمان پرواز :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(617, 202);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "زمان برنامه ریزی شده پرواز :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(261, 73);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "وضعیت پرواز :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(666, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "فرودگاه مقصد :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(261, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "هواپیما :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(666, 42);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "فرودگاه مبدا :";
            // 
            // FrmEditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditFlight";
            this.Text = "FrmEditGate";
            this.Load += new System.EventHandler(this.FrmEditFlight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControl menuControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combStatus;
        private System.Windows.Forms.ComboBox combAircraft;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpDTime;
        private System.Windows.Forms.DateTimePicker dpDDate;
        private System.Windows.Forms.DateTimePicker dpATime;
        private System.Windows.Forms.DateTimePicker dpADate;
        private System.Windows.Forms.DateTimePicker dpSDTime;
        private System.Windows.Forms.DateTimePicker dpSDDate;
        private System.Windows.Forms.DateTimePicker dpSATime;
        private System.Windows.Forms.DateTimePicker dpSADate;
        private System.Windows.Forms.ComboBox combGate;
        private System.Windows.Forms.ComboBox combDAirport;
        private System.Windows.Forms.ComboBox combAAirport;
    }
}