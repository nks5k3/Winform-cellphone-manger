namespace DoAnWinformBanDienThoai
{
    partial class FrmInventory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxKindOfProducts = new System.Windows.Forms.ComboBox();
            this.CbxBrand = new System.Windows.Forms.ComboBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuantity);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.BtnShowAll);
            this.panel1.Controls.Add(this.BtnFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CbxKindOfProducts);
            this.panel1.Controls.Add(this.CbxBrand);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 160);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnExcel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1045, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 160);
            this.panel4.TabIndex = 1;
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.White;
            this.BtnExcel.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_excel_30;
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.Location = new System.Drawing.Point(29, 105);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(230, 44);
            this.BtnExcel.TabIndex = 0;
            this.BtnExcel.Text = "Xuất Excel";
            this.BtnExcel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 506);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1319, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sản sản phẩm trong kho";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 22);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1313, 481);
            this.DGV.TabIndex = 0;
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAll.ForeColor = System.Drawing.Color.White;
            this.BtnShowAll.Location = new System.Drawing.Point(70, 105);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(197, 36);
            this.BtnShowAll.TabIndex = 14;
            this.BtnShowAll.Text = "Hiển thị tất cả";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click_1);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilter.ForeColor = System.Drawing.Color.White;
            this.BtnFilter.Location = new System.Drawing.Point(356, 105);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(164, 36);
            this.BtnFilter.TabIndex = 9;
            this.BtnFilter.Text = "Lọc";
            this.BtnFilter.UseVisualStyleBackColor = false;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thương Hiệu";
            // 
            // CbxKindOfProducts
            // 
            this.CbxKindOfProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxKindOfProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxKindOfProducts.FormattingEnabled = true;
            this.CbxKindOfProducts.Location = new System.Drawing.Point(290, 54);
            this.CbxKindOfProducts.Name = "CbxKindOfProducts";
            this.CbxKindOfProducts.Size = new System.Drawing.Size(230, 24);
            this.CbxKindOfProducts.TabIndex = 11;
            // 
            // CbxBrand
            // 
            this.CbxBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBrand.FormattingEnabled = true;
            this.CbxBrand.Location = new System.Drawing.Point(290, 14);
            this.CbxBrand.Name = "CbxBrand";
            this.CbxBrand.Size = new System.Drawing.Size(230, 24);
            this.CbxBrand.TabIndex = 10;
            // 
            // txtStart
            // 
            this.txtStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(792, 14);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(125, 27);
            this.txtStart.TabIndex = 17;
            this.txtStart.Text = "0";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(564, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 100);
            this.panel5.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số lượng tồn kho từ : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(682, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đến : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(792, 52);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(125, 27);
            this.txtEnd.TabIndex = 27;
            this.txtEnd.Text = "0";
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // btnQuantity
            // 
            this.btnQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnQuantity.Enabled = false;
            this.btnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantity.ForeColor = System.Drawing.Color.White;
            this.btnQuantity.Location = new System.Drawing.Point(792, 105);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(125, 36);
            this.btnQuantity.TabIndex = 28;
            this.btnQuantity.Text = "Lọc";
            this.btnQuantity.UseVisualStyleBackColor = false;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInventory";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Tồn kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInventory_FormClosing);
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxKindOfProducts;
        private System.Windows.Forms.ComboBox CbxBrand;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}