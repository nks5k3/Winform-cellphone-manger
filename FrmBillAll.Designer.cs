namespace DoAnWinformBanDienThoai
{
    partial class FrmBillAll
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.FindCustomer = new System.Windows.Forms.RadioButton();
            this.FindID = new System.Windows.Forms.RadioButton();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RdoImport = new System.Windows.Forms.RadioButton();
            this.rdoExport = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1462, 216);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.BtnAll);
            this.groupBox3.Controls.Add(this.BtnFind);
            this.groupBox3.Controls.Add(this.FindCustomer);
            this.groupBox3.Controls.Add(this.FindID);
            this.groupBox3.Controls.Add(this.TxtFind);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(429, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox3.Size = new System.Drawing.Size(1033, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_excel_30;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(823, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xuất file excel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BtnAll
            // 
            this.BtnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnAll.FlatAppearance.BorderSize = 0;
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.ForeColor = System.Drawing.Color.White;
            this.BtnAll.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_all_30;
            this.BtnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAll.Location = new System.Drawing.Point(625, 104);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(153, 30);
            this.BtnAll.TabIndex = 4;
            this.BtnAll.Text = "Tất cả";
            this.BtnAll.UseVisualStyleBackColor = false;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnFind.FlatAppearance.BorderSize = 0;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.ForeColor = System.Drawing.Color.White;
            this.BtnFind.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_search_30;
            this.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFind.Location = new System.Drawing.Point(431, 104);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(153, 30);
            this.BtnFind.TabIndex = 3;
            this.BtnFind.Text = "Tìm kiếm";
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // FindCustomer
            // 
            this.FindCustomer.AutoSize = true;
            this.FindCustomer.Location = new System.Drawing.Point(278, 42);
            this.FindCustomer.Name = "FindCustomer";
            this.FindCustomer.Size = new System.Drawing.Size(148, 24);
            this.FindCustomer.TabIndex = 2;
            this.FindCustomer.Text = "Tên khách hàng";
            this.FindCustomer.UseVisualStyleBackColor = true;
            // 
            // FindID
            // 
            this.FindID.AutoSize = true;
            this.FindID.Checked = true;
            this.FindID.Location = new System.Drawing.Point(18, 42);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(117, 24);
            this.FindID.TabIndex = 1;
            this.FindID.TabStop = true;
            this.FindID.Text = "Mã hóa đơn";
            this.FindID.UseVisualStyleBackColor = true;
            // 
            // TxtFind
            // 
            this.TxtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFind.Location = new System.Drawing.Point(18, 104);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(566, 30);
            this.TxtFind.TabIndex = 0;
            this.TxtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFind_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_all_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(158, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tất cả";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(158, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.panel3.Controls.Add(this.RdoImport);
            this.panel3.Controls.Add(this.rdoExport);
            this.panel3.Location = new System.Drawing.Point(429, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 54);
            this.panel3.TabIndex = 0;
            // 
            // RdoImport
            // 
            this.RdoImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoImport.ForeColor = System.Drawing.Color.White;
            this.RdoImport.Location = new System.Drawing.Point(380, 12);
            this.RdoImport.Name = "RdoImport";
            this.RdoImport.Size = new System.Drawing.Size(227, 32);
            this.RdoImport.TabIndex = 1;
            this.RdoImport.Text = "Hóa đơn nhập";
            this.RdoImport.UseVisualStyleBackColor = true;
            this.RdoImport.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoExport
            // 
            this.rdoExport.Checked = true;
            this.rdoExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExport.ForeColor = System.Drawing.Color.White;
            this.rdoExport.Location = new System.Drawing.Point(56, 12);
            this.rdoExport.Name = "rdoExport";
            this.rdoExport.Size = new System.Drawing.Size(230, 32);
            this.rdoExport.TabIndex = 0;
            this.rdoExport.TabStop = true;
            this.rdoExport.Text = "Hóa đơn bán";
            this.rdoExport.UseVisualStyleBackColor = true;
            this.rdoExport.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1462, 530);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1462, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng hóa đơn";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 22);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1456, 505);
            this.DGV.TabIndex = 0;
            this.DGV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DGV_RowPrePaint);
            // 
            // FrmBillAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1502, 766);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBillAll";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FrmBillAll_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RdoImport;
        private System.Windows.Forms.RadioButton rdoExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton FindCustomer;
        private System.Windows.Forms.RadioButton FindID;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button button3;
    }
}