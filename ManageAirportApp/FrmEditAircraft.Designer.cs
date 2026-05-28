namespace ManageAirportApp
{
    partial class FrmEditAircraft
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
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterationNum = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMenuFactorerName = new System.Windows.Forms.TextBox();
            this.menuControl1 = new ManageAirportApp.MenuControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.numCapacity);
            this.panel1.Controls.Add(this.txtSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRegisterationNum);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.txtMenuFactorerName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 483);
            this.panel1.TabIndex = 7;
            // 
            // numCapacity
            // 
            this.numCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.numCapacity.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.numCapacity.Location = new System.Drawing.Point(213, 183);
            this.numCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(206, 31);
            this.numCapacity.TabIndex = 21;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSubmit
            // 
            this.txtSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtSubmit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSubmit.Location = new System.Drawing.Point(218, 384);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(126, 49);
            this.txtSubmit.TabIndex = 20;
            this.txtSubmit.Text = "تایید";
            this.txtSubmit.UseVisualStyleBackColor = false;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(486, 236);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "شماره ثبت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(487, 183);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "ظرفیت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(487, 128);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "مدل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(487, 78);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "سازنده :";
            // 
            // txtRegisterationNum
            // 
            this.txtRegisterationNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtRegisterationNum.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRegisterationNum.Location = new System.Drawing.Point(213, 236);
            this.txtRegisterationNum.Name = "txtRegisterationNum";
            this.txtRegisterationNum.Size = new System.Drawing.Size(206, 31);
            this.txtRegisterationNum.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtModel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtModel.Location = new System.Drawing.Point(213, 128);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(206, 31);
            this.txtModel.TabIndex = 9;
            // 
            // txtMenuFactorerName
            // 
            this.txtMenuFactorerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.txtMenuFactorerName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMenuFactorerName.Location = new System.Drawing.Point(213, 78);
            this.txtMenuFactorerName.Name = "txtMenuFactorerName";
            this.txtMenuFactorerName.Size = new System.Drawing.Size(206, 31);
            this.txtMenuFactorerName.TabIndex = 10;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(806, 65);
            this.menuControl1.TabIndex = 6;
            // 
            // FrmEditAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditAircraft";
            this.Text = "FrmEditAircraft";
            this.Load += new System.EventHandler(this.FrmEditAircraft_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterationNum;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMenuFactorerName;
        private MenuControl menuControl1;
    }
}