namespace DoAnWinformBanDienThoai
{
    partial class FrmImportBill
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
            this.components = new System.ComponentModel.Container();
            this.palHead = new System.Windows.Forms.Panel();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.BtnCancelBill = new System.Windows.Forms.Button();
            this.BtnHandle = new System.Windows.Forms.Button();
            this.BtnDelele = new System.Windows.Forms.Button();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.palBrand = new System.Windows.Forms.Panel();
            this.palCompany = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NameCompany = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.NameProducts = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInBill = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LblPN2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.palHead.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // palHead
            // 
            this.palHead.Controls.Add(this.BtnAddNew);
            this.palHead.Controls.Add(this.label7);
            this.palHead.Controls.Add(this.label11);
            this.palHead.Controls.Add(this.txtcompany);
            this.palHead.Controls.Add(this.btnBill);
            this.palHead.Controls.Add(this.panel13);
            this.palHead.Controls.Add(this.BtnCancelBill);
            this.palHead.Controls.Add(this.BtnHandle);
            this.palHead.Controls.Add(this.BtnDelele);
            this.palHead.Controls.Add(this.txtStaffName);
            this.palHead.Controls.Add(this.palBrand);
            this.palHead.Controls.Add(this.palCompany);
            this.palHead.Controls.Add(this.label3);
            this.palHead.Controls.Add(this.NameCompany);
            this.palHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.palHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palHead.Location = new System.Drawing.Point(20, 20);
            this.palHead.Name = "palHead";
            this.palHead.Size = new System.Drawing.Size(1160, 212);
            this.palHead.TabIndex = 0;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddNew.FlatAppearance.BorderSize = 3;
            this.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNew.ForeColor = System.Drawing.Color.White;
            this.BtnAddNew.Location = new System.Drawing.Point(248, 92);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(130, 40);
            this.BtnAddNew.TabIndex = 140;
            this.BtnAddNew.Text = "Thêm mới";
            this.BtnAddNew.UseVisualStyleBackColor = false;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(379, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 23);
            this.label7.TabIndex = 139;
            this.label7.Text = "chú ý bạn nên kiểm tra trước khi xuất hóa đơn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(379, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(424, 23);
            this.label11.TabIndex = 138;
            this.label11.Text = "(*) chú ý không được để trống";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcompany
            // 
            this.txtcompany.AllowDrop = true;
            this.txtcompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcompany.BackColor = System.Drawing.Color.White;
            this.txtcompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompany.ForeColor = System.Drawing.Color.Black;
            this.txtcompany.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtcompany.Location = new System.Drawing.Point(204, 36);
            this.txtcompany.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(195, 19);
            this.txtcompany.TabIndex = 136;
            this.txtcompany.Tag = "firstForcus";
            this.txtcompany.UseWaitCursor = true;
            this.txtcompany.WordWrap = false;
            this.txtcompany.TextChanged += new System.EventHandler(this.txtcompany_TextChanged);
            // 
            // btnBill
            // 
            this.btnBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(425, 22);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(80, 35);
            this.btnBill.TabIndex = 135;
            this.btnBill.Text = "Chọn";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(580, 26);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 34);
            this.panel13.TabIndex = 77;
            // 
            // BtnCancelBill
            // 
            this.BtnCancelBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCancelBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnCancelBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelBill.FlatAppearance.BorderSize = 3;
            this.BtnCancelBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelBill.ForeColor = System.Drawing.Color.White;
            this.BtnCancelBill.Location = new System.Drawing.Point(793, 92);
            this.BtnCancelBill.Name = "BtnCancelBill";
            this.BtnCancelBill.Size = new System.Drawing.Size(130, 40);
            this.BtnCancelBill.TabIndex = 134;
            this.BtnCancelBill.Text = "Hủy đơn";
            this.BtnCancelBill.UseVisualStyleBackColor = false;
            this.BtnCancelBill.Click += new System.EventHandler(this.BtnCancelBill_Click);
            // 
            // BtnHandle
            // 
            this.BtnHandle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnHandle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHandle.FlatAppearance.BorderSize = 3;
            this.BtnHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHandle.ForeColor = System.Drawing.Color.White;
            this.BtnHandle.Location = new System.Drawing.Point(425, 92);
            this.BtnHandle.Name = "BtnHandle";
            this.BtnHandle.Size = new System.Drawing.Size(130, 40);
            this.BtnHandle.TabIndex = 133;
            this.BtnHandle.Text = "Kiểm tra";
            this.BtnHandle.UseVisualStyleBackColor = false;
            this.BtnHandle.Click += new System.EventHandler(this.BtnHandle_Click);
            // 
            // BtnDelele
            // 
            this.BtnDelele.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDelele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.BtnDelele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelele.FlatAppearance.BorderSize = 3;
            this.BtnDelele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelele.ForeColor = System.Drawing.Color.White;
            this.BtnDelele.Location = new System.Drawing.Point(610, 92);
            this.BtnDelele.Name = "BtnDelele";
            this.BtnDelele.Size = new System.Drawing.Size(130, 40);
            this.BtnDelele.TabIndex = 132;
            this.BtnDelele.Tag = "Added";
            this.BtnDelele.Text = "Xóa";
            this.BtnDelele.UseVisualStyleBackColor = false;
            this.BtnDelele.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.AllowDrop = true;
            this.txtStaffName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStaffName.BackColor = System.Drawing.Color.White;
            this.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.ForeColor = System.Drawing.Color.Black;
            this.txtStaffName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStaffName.Location = new System.Drawing.Point(818, 34);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(301, 19);
            this.txtStaffName.TabIndex = 126;
            this.txtStaffName.Tag = "firstForcus";
            this.txtStaffName.Text = "Nguyễn Khánh Sơn";
            this.txtStaffName.UseWaitCursor = true;
            this.txtStaffName.WordWrap = false;
            // 
            // palBrand
            // 
            this.palBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.palBrand.BackColor = System.Drawing.Color.Black;
            this.palBrand.Location = new System.Drawing.Point(818, 59);
            this.palBrand.Name = "palBrand";
            this.palBrand.Size = new System.Drawing.Size(301, 1);
            this.palBrand.TabIndex = 63;
            // 
            // palCompany
            // 
            this.palCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.palCompany.BackColor = System.Drawing.Color.Red;
            this.palCompany.Location = new System.Drawing.Point(204, 59);
            this.palCompany.Name = "palCompany";
            this.palCompany.Size = new System.Drawing.Size(301, 1);
            this.palCompany.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nhân viên tiếp nhận :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameCompany
            // 
            this.NameCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameCompany.BackColor = System.Drawing.Color.White;
            this.NameCompany.Location = new System.Drawing.Point(32, 33);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(141, 27);
            this.NameCompany.TabIndex = 57;
            this.NameCompany.Text = "Tên công ty (*):";
            this.NameCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 498);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 498);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV.ColumnHeadersHeight = 29;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProducts,
            this.quantity,
            this.Price});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 23);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(778, 472);
            this.DGV.TabIndex = 0;
            this.DGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellEndEdit);
            // 
            // NameProducts
            // 
            this.NameProducts.FillWeight = 15.83423F;
            this.NameProducts.HeaderText = "Tên sản phẩm";
            this.NameProducts.MinimumWidth = 6;
            this.NameProducts.Name = "NameProducts";
            // 
            // quantity
            // 
            this.quantity.FillWeight = 5.834229F;
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.FillWeight = 7.834229F;
            this.Price.HeaderText = "Giá sản phẩm";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(784, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 498);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.btnInBill);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LblPN2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 498);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết tổng thanh toán";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTotal.Location = new System.Drawing.Point(25, 209);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(264, 27);
            this.TxtTotal.TabIndex = 77;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(28, 260);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 1);
            this.panel7.TabIndex = 76;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(25, 164);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 1);
            this.panel6.TabIndex = 75;
            // 
            // btnInBill
            // 
            this.btnInBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnInBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBill.ForeColor = System.Drawing.Color.White;
            this.btnInBill.Location = new System.Drawing.Point(112, 299);
            this.btnInBill.Name = "btnInBill";
            this.btnInBill.Size = new System.Drawing.Size(177, 40);
            this.btnInBill.TabIndex = 74;
            this.btnInBill.Text = "In hóa đơn";
            this.btnInBill.UseVisualStyleBackColor = false;
            this.btnInBill.Click += new System.EventHandler(this.btnInBill_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 27);
            this.label8.TabIndex = 73;
            this.label8.Text = "VNĐ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPN2
            // 
            this.LblPN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPN2.BackColor = System.Drawing.Color.White;
            this.LblPN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPN2.Location = new System.Drawing.Point(129, 112);
            this.LblPN2.Name = "LblPN2";
            this.LblPN2.Size = new System.Drawing.Size(114, 27);
            this.LblPN2.TabIndex = 71;
            this.LblPN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tổng tiền thanh toán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "Mã phiếu nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errCheck
            // 
            this.errCheck.ContainerControl = this;
            // 
            // FrmImportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.palHead);
            this.Name = "FrmImportBill";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "frmImportBill";
            this.Load += new System.EventHandler(this.frmImportBill_Load);
            this.palHead.ResumeLayout(false);
            this.palHead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel palBrand;
        private System.Windows.Forms.Panel palCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameCompany;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblPN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button BtnCancelBill;
        private System.Windows.Forms.Button BtnHandle;
        private System.Windows.Forms.Button BtnDelele;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errCheck;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.DataGridViewComboBoxColumn NameProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}