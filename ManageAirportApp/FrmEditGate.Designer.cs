namespace ManageAirportApp
{
    partial class FrmEditGate
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
            this.menuControl2 = new ManageAirportApp.MenuControl();
            this.combTerminal = new System.Windows.Forms.ComboBox();
            this.numericCapacity = new System.Windows.Forms.NumericUpDown();
            this.bynSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGateNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.menuControl2);
            this.panel1.Controls.Add(this.combTerminal);
            this.panel1.Controls.Add(this.numericCapacity);
            this.panel1.Controls.Add(this.bynSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblGateNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 548);
            this.panel1.TabIndex = 3;
            // 
            // menuControl2
            // 
            this.menuControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.menuControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControl2.Location = new System.Drawing.Point(0, 0);
            this.menuControl2.Name = "menuControl2";
            this.menuControl2.Size = new System.Drawing.Size(806, 65);
            this.menuControl2.TabIndex = 24;
            // 
            // combTerminal
            // 
            this.combTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.combTerminal.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.combTerminal.FormattingEnabled = true;
            this.combTerminal.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.combTerminal.Location = new System.Drawing.Point(143, 192);
            this.combTerminal.Name = "combTerminal";
            this.combTerminal.Size = new System.Drawing.Size(206, 32);
            this.combTerminal.TabIndex = 1;
            // 
            // numericCapacity
            // 
            this.numericCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.numericCapacity.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.numericCapacity.Location = new System.Drawing.Point(143, 253);
            this.numericCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacity.Name = "numericCapacity";
            this.numericCapacity.Size = new System.Drawing.Size(206, 31);
            this.numericCapacity.TabIndex = 2;
            this.numericCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bynSubmit
            // 
            this.bynSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.bynSubmit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bynSubmit.Location = new System.Drawing.Point(218, 384);
            this.bynSubmit.Name = "bynSubmit";
            this.bynSubmit.Size = new System.Drawing.Size(126, 49);
            this.bynSubmit.TabIndex = 3;
            this.bynSubmit.Text = "تایید";
            this.bynSubmit.UseVisualStyleBackColor = false;
            this.bynSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(235)))));
            this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(472, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Tag = "close";
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(503, 253);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "ظرفیت :";
            // 
            // lblGateNumber
            // 
            this.lblGateNumber.AutoSize = true;
            this.lblGateNumber.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGateNumber.Location = new System.Drawing.Point(379, 106);
            this.lblGateNumber.Name = "lblGateNumber";
            this.lblGateNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGateNumber.Size = new System.Drawing.Size(0, 28);
            this.lblGateNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(503, 196);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "ترمینال مربوط به گیت :";
            // 
            // FrmEditGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditGate";
            this.Text = "FrmEditFlight";
            this.Load += new System.EventHandler(this.FrmEditGate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControl menuControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bynSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericCapacity;
        private MenuControl menuControl2;
        private System.Windows.Forms.ComboBox combTerminal;
        private System.Windows.Forms.Label lblGateNumber;
    }
}