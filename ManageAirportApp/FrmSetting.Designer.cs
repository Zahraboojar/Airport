namespace ManageAirportApp
{
    partial class FrmSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeLogo = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.combRegion = new System.Windows.Forms.ComboBox();
            this.combCity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtICAO_Code = new System.Windows.Forms.TextBox();
            this.txtIATA_Code = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.menuControl1 = new ManageAirportApp.MenuControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.combRegion);
            this.panel1.Controls.Add(this.combCity);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtICAO_Code);
            this.panel1.Controls.Add(this.txtIATA_Code);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 548);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.tableLayoutPanel2.Controls.Add(this.btnChangeLogo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picLogo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(124, 379);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 54);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // btnChangeLogo
            // 
            this.btnChangeLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnChangeLogo.Location = new System.Drawing.Point(71, 3);
            this.btnChangeLogo.Name = "btnChangeLogo";
            this.btnChangeLogo.Size = new System.Drawing.Size(43, 43);
            this.btnChangeLogo.TabIndex = 1;
            this.btnChangeLogo.Text = "تغییر ";
            this.btnChangeLogo.UseVisualStyleBackColor = false;
            this.btnChangeLogo.Click += new System.EventHandler(this.btnChangeLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picLogo.Image = global::ManageAirportApp.Properties.Resources.AirPlane;
            this.picLogo.Location = new System.Drawing.Point(120, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(120, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // combRegion
            // 
            this.combRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combRegion.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combRegion.FormattingEnabled = true;
            this.combRegion.Location = new System.Drawing.Point(172, 265);
            this.combRegion.Name = "combRegion";
            this.combRegion.Size = new System.Drawing.Size(206, 32);
            this.combRegion.TabIndex = 32;
            // 
            // combCity
            // 
            this.combCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combCity.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combCity.FormattingEnabled = true;
            this.combCity.Location = new System.Drawing.Point(172, 326);
            this.combCity.Name = "combCity";
            this.combCity.Size = new System.Drawing.Size(206, 32);
            this.combCity.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(525, 269);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "کشور :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(523, 214);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "کد چهر حرفی پیکائو :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(525, 390);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "لوگو :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(525, 325);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(44, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "شهر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(523, 159);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "کد سه حرفی یاتا :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(523, 109);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "عنوان :";
            // 
            // txtICAO_Code
            // 
            this.txtICAO_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtICAO_Code.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtICAO_Code.Location = new System.Drawing.Point(172, 214);
            this.txtICAO_Code.Name = "txtICAO_Code";
            this.txtICAO_Code.Size = new System.Drawing.Size(206, 31);
            this.txtICAO_Code.TabIndex = 24;
            // 
            // txtIATA_Code
            // 
            this.txtIATA_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtIATA_Code.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIATA_Code.Location = new System.Drawing.Point(172, 159);
            this.txtIATA_Code.Name = "txtIATA_Code";
            this.txtIATA_Code.Size = new System.Drawing.Size(206, 31);
            this.txtIATA_Code.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(172, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 31);
            this.txtName.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(477, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 49);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Tag = "close";
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnSet.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSet.Location = new System.Drawing.Point(209, 448);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(126, 49);
            this.btnSet.TabIndex = 20;
            this.btnSet.Text = "تایید";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(806, 65);
            this.menuControl1.TabIndex = 5;
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSetting";
            this.Text = "FrmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnChangeLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox combRegion;
        private System.Windows.Forms.ComboBox combCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtICAO_Code;
        private System.Windows.Forms.TextBox txtIATA_Code;
        private System.Windows.Forms.TextBox txtName;
        private MenuControl menuControl1;
    }
}