namespace ManageAirportApp
{
    partial class FrmEditAirport
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.combRegion = new System.Windows.Forms.ComboBox();
            this.combCity = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtICAO_Code = new System.Windows.Forms.TextBox();
            this.txtIATA_Code = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuControl2 = new ManageAirportApp.MenuControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.combRegion);
            this.panel1.Controls.Add(this.combCity);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtICAO_Code);
            this.panel1.Controls.Add(this.txtIATA_Code);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 548);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(479, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 49);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Tag = "close";
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // combRegion
            // 
            this.combRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combRegion.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combRegion.FormattingEnabled = true;
            this.combRegion.Location = new System.Drawing.Point(161, 262);
            this.combRegion.Name = "combRegion";
            this.combRegion.Size = new System.Drawing.Size(206, 32);
            this.combRegion.TabIndex = 21;
            this.combRegion.SelectedIndexChanged += new System.EventHandler(this.combRegion_SelectedIndexChanged);
            // 
            // combCity
            // 
            this.combCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combCity.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combCity.FormattingEnabled = true;
            this.combCity.Location = new System.Drawing.Point(161, 323);
            this.combCity.Name = "combCity";
            this.combCity.Size = new System.Drawing.Size(206, 32);
            this.combCity.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.button2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(220, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "تایید";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(514, 266);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "کشور :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(512, 211);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "کد چهر حرفی پیکائو :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(514, 322);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(44, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "شهر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(512, 156);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "کد سه حرفی یاتا :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(512, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "عنوان :";
            // 
            // txtICAO_Code
            // 
            this.txtICAO_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtICAO_Code.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtICAO_Code.Location = new System.Drawing.Point(161, 211);
            this.txtICAO_Code.Name = "txtICAO_Code";
            this.txtICAO_Code.Size = new System.Drawing.Size(206, 31);
            this.txtICAO_Code.TabIndex = 8;
            // 
            // txtIATA_Code
            // 
            this.txtIATA_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtIATA_Code.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIATA_Code.Location = new System.Drawing.Point(161, 156);
            this.txtIATA_Code.Name = "txtIATA_Code";
            this.txtIATA_Code.Size = new System.Drawing.Size(206, 31);
            this.txtIATA_Code.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(161, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 31);
            this.txtName.TabIndex = 10;
            // 
            // menuControl2
            // 
            this.menuControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.menuControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl2.Location = new System.Drawing.Point(0, 0);
            this.menuControl2.Name = "menuControl2";
            this.menuControl2.Size = new System.Drawing.Size(806, 65);
            this.menuControl2.TabIndex = 4;
            // 
            // FrmEditAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.menuControl2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditAirport";
            this.Text = "FrmEditAirport";
            this.Load += new System.EventHandler(this.FrmEditAirport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControl menuControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combRegion;
        private System.Windows.Forms.ComboBox combCity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtICAO_Code;
        private System.Windows.Forms.TextBox txtIATA_Code;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private MenuControl menuControl2;
    }
}