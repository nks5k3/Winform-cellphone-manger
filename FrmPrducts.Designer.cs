namespace DoAnWinformBanDienThoai
{
    partial class FrmSearchDeleteEdit
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
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.PalScroll = new System.Windows.Forms.Panel();
            this.palSearch = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.FindBrand = new System.Windows.Forms.RadioButton();
            this.FindName = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PalInput = new System.Windows.Forms.Panel();
            this.DtProduction = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.palBrand = new System.Windows.Forms.Panel();
            this.palKindOfProduct = new System.Windows.Forms.Panel();
            this.palPrice = new System.Windows.Forms.Panel();
            this.palGuarantee = new System.Windows.Forms.Panel();
            this.palTime = new System.Windows.Forms.Panel();
            this.palName = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddNewPPrice = new System.Windows.Forms.TextBox();
            this.txtAddNewPDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddNewPGuarantee = new System.Windows.Forms.TextBox();
            this.cbxAddNewPBrand = new System.Windows.Forms.ComboBox();
            this.cbxAddNewPKind = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddNewPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.PalScroll.SuspendLayout();
            this.palSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PalInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // errCheck
            // 
            this.errCheck.ContainerControl = this;
            // 
            // PalScroll
            // 
            this.PalScroll.Controls.Add(this.palSearch);
            this.PalScroll.Controls.Add(this.groupBox1);
            this.PalScroll.Controls.Add(this.PalInput);
            this.PalScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalScroll.Location = new System.Drawing.Point(20, 20);
            this.PalScroll.Name = "PalScroll";
            this.PalScroll.Size = new System.Drawing.Size(1160, 710);
            this.PalScroll.TabIndex = 2;
            // 
            // palSearch
            // 
            this.palSearch.Controls.Add(this.groupBox2);
            this.palSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palSearch.Location = new System.Drawing.Point(0, 418);
            this.palSearch.Name = "palSearch";
            this.palSearch.Size = new System.Drawing.Size(1160, 292);
            this.palSearch.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(1160, 292);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV.ColumnHeadersHeight = 29;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 20);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1160, 272);
            this.DGV.TabIndex = 1;
            this.DGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.FindBrand);
            this.groupBox1.Controls.Add(this.FindName);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sản phẩm";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_add_new_30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(128, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 94;
            this.btnAdd.Tag = "Added";
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(233, 121);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(753, 36);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_save_30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(711, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // FindBrand
            // 
            this.FindBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FindBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindBrand.Location = new System.Drawing.Point(659, 91);
            this.FindBrand.Name = "FindBrand";
            this.FindBrand.Size = new System.Drawing.Size(148, 24);
            this.FindBrand.TabIndex = 1;
            this.FindBrand.Text = "Thương hiệu";
            this.FindBrand.UseVisualStyleBackColor = true;
            this.FindBrand.CheckedChanged += new System.EventHandler(this.FindBrand_CheckedChanged);
            // 
            // FindName
            // 
            this.FindName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FindName.Checked = true;
            this.FindName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindName.Location = new System.Drawing.Point(440, 91);
            this.FindName.Name = "FindName";
            this.FindName.Size = new System.Drawing.Size(178, 24);
            this.FindName.TabIndex = 0;
            this.FindName.TabStop = true;
            this.FindName.Text = "Tên sản phẩm";
            this.FindName.UseVisualStyleBackColor = true;
            this.FindName.CheckedChanged += new System.EventHandler(this.FindName_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_create_30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(323, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 50);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Tag = "Edited";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_delete_30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(517, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_undo_30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(907, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PalInput
            // 
            this.PalInput.BackColor = System.Drawing.Color.White;
            this.PalInput.Controls.Add(this.DtProduction);
            this.PalInput.Controls.Add(this.label12);
            this.PalInput.Controls.Add(this.label13);
            this.PalInput.Controls.Add(this.palBrand);
            this.PalInput.Controls.Add(this.palKindOfProduct);
            this.PalInput.Controls.Add(this.palPrice);
            this.PalInput.Controls.Add(this.palGuarantee);
            this.PalInput.Controls.Add(this.palTime);
            this.PalInput.Controls.Add(this.palName);
            this.PalInput.Controls.Add(this.label11);
            this.PalInput.Controls.Add(this.label9);
            this.PalInput.Controls.Add(this.txtAddNewPPrice);
            this.PalInput.Controls.Add(this.txtAddNewPDescription);
            this.PalInput.Controls.Add(this.label7);
            this.PalInput.Controls.Add(this.panel4);
            this.PalInput.Controls.Add(this.txtAddNewPGuarantee);
            this.PalInput.Controls.Add(this.cbxAddNewPBrand);
            this.PalInput.Controls.Add(this.cbxAddNewPKind);
            this.PalInput.Controls.Add(this.label5);
            this.PalInput.Controls.Add(this.label4);
            this.PalInput.Controls.Add(this.label3);
            this.PalInput.Controls.Add(this.label2);
            this.PalInput.Controls.Add(this.txtAddNewPName);
            this.PalInput.Controls.Add(this.label1);
            this.PalInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.PalInput.Enabled = false;
            this.PalInput.Location = new System.Drawing.Point(0, 0);
            this.PalInput.Name = "PalInput";
            this.PalInput.Size = new System.Drawing.Size(1160, 254);
            this.PalInput.TabIndex = 1;
            // 
            // DtProduction
            // 
            this.DtProduction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtProduction.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DtProduction.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.DtProduction.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.DtProduction.CustomFormat = "dd/MM/yyyy";
            this.DtProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtProduction.Location = new System.Drawing.Point(207, 171);
            this.DtProduction.Name = "DtProduction";
            this.DtProduction.Size = new System.Drawing.Size(301, 27);
            this.DtProduction.TabIndex = 93;
            this.DtProduction.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtProduction_KeyUp_1);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1070, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 27);
            this.label12.TabIndex = 58;
            this.label12.Text = "VNĐ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1069, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 27);
            this.label13.TabIndex = 57;
            this.label13.Text = "Tháng";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palBrand
            // 
            this.palBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palBrand.BackColor = System.Drawing.Color.Black;
            this.palBrand.Location = new System.Drawing.Point(207, 147);
            this.palBrand.Name = "palBrand";
            this.palBrand.Size = new System.Drawing.Size(301, 1);
            this.palBrand.TabIndex = 54;
            // 
            // palKindOfProduct
            // 
            this.palKindOfProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palKindOfProduct.BackColor = System.Drawing.Color.Black;
            this.palKindOfProduct.Location = new System.Drawing.Point(207, 98);
            this.palKindOfProduct.Name = "palKindOfProduct";
            this.palKindOfProduct.Size = new System.Drawing.Size(301, 1);
            this.palKindOfProduct.TabIndex = 53;
            // 
            // palPrice
            // 
            this.palPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palPrice.BackColor = System.Drawing.Color.Black;
            this.palPrice.Location = new System.Drawing.Point(812, 98);
            this.palPrice.Name = "palPrice";
            this.palPrice.Size = new System.Drawing.Size(301, 1);
            this.palPrice.TabIndex = 56;
            // 
            // palGuarantee
            // 
            this.palGuarantee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palGuarantee.BackColor = System.Drawing.Color.Black;
            this.palGuarantee.Location = new System.Drawing.Point(812, 55);
            this.palGuarantee.Name = "palGuarantee";
            this.palGuarantee.Size = new System.Drawing.Size(301, 1);
            this.palGuarantee.TabIndex = 54;
            // 
            // palTime
            // 
            this.palTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palTime.BackColor = System.Drawing.Color.Black;
            this.palTime.Location = new System.Drawing.Point(207, 200);
            this.palTime.Name = "palTime";
            this.palTime.Size = new System.Drawing.Size(301, 1);
            this.palTime.TabIndex = 53;
            // 
            // palName
            // 
            this.palName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palName.BackColor = System.Drawing.Color.Black;
            this.palName.Location = new System.Drawing.Point(207, 55);
            this.palName.Name = "palName";
            this.palName.Size = new System.Drawing.Size(301, 1);
            this.palName.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(813, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 33);
            this.label11.TabIndex = 51;
            this.label11.Text = "Ghi chú : (*) Bắt buộc phải nhập dữ liệu";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(645, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 27);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mô tả : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddNewPPrice
            // 
            this.txtAddNewPPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddNewPPrice.BackColor = System.Drawing.Color.White;
            this.txtAddNewPPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewPPrice.ForeColor = System.Drawing.Color.Black;
            this.txtAddNewPPrice.Location = new System.Drawing.Point(812, 72);
            this.txtAddNewPPrice.Name = "txtAddNewPPrice";
            this.txtAddNewPPrice.Size = new System.Drawing.Size(302, 20);
            this.txtAddNewPPrice.TabIndex = 39;
            this.txtAddNewPPrice.Tag = "firstForcus";
            this.txtAddNewPPrice.TextChanged += new System.EventHandler(this.txtAddNewPPrice_TextChanged_1);
            this.txtAddNewPPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddNewPPrice_KeyUp_1);
            // 
            // txtAddNewPDescription
            // 
            this.txtAddNewPDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddNewPDescription.BackColor = System.Drawing.Color.White;
            this.txtAddNewPDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewPDescription.ForeColor = System.Drawing.Color.Black;
            this.txtAddNewPDescription.Location = new System.Drawing.Point(811, 117);
            this.txtAddNewPDescription.Multiline = true;
            this.txtAddNewPDescription.Name = "txtAddNewPDescription";
            this.txtAddNewPDescription.Size = new System.Drawing.Size(302, 43);
            this.txtAddNewPDescription.TabIndex = 41;
            this.txtAddNewPDescription.Tag = "firstForcus";
            this.txtAddNewPDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddNewPDescription_KeyUp_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(645, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "Giá (*):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(580, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 200);
            this.panel4.TabIndex = 42;
            // 
            // txtAddNewPGuarantee
            // 
            this.txtAddNewPGuarantee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddNewPGuarantee.BackColor = System.Drawing.Color.White;
            this.txtAddNewPGuarantee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewPGuarantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewPGuarantee.ForeColor = System.Drawing.Color.Black;
            this.txtAddNewPGuarantee.Location = new System.Drawing.Point(812, 29);
            this.txtAddNewPGuarantee.Name = "txtAddNewPGuarantee";
            this.txtAddNewPGuarantee.Size = new System.Drawing.Size(301, 20);
            this.txtAddNewPGuarantee.TabIndex = 37;
            this.txtAddNewPGuarantee.Tag = "firstForcus";
            this.txtAddNewPGuarantee.TextChanged += new System.EventHandler(this.txtAddNewPGuarantee_TextChanged_1);
            this.txtAddNewPGuarantee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddNewPGuarantee_KeyUp_1);
            // 
            // cbxAddNewPBrand
            // 
            this.cbxAddNewPBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAddNewPBrand.DisplayMember = "BrandID";
            this.cbxAddNewPBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddNewPBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddNewPBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAddNewPBrand.FormattingEnabled = true;
            this.cbxAddNewPBrand.Location = new System.Drawing.Point(207, 120);
            this.cbxAddNewPBrand.Name = "cbxAddNewPBrand";
            this.cbxAddNewPBrand.Size = new System.Drawing.Size(301, 28);
            this.cbxAddNewPBrand.TabIndex = 33;
            this.cbxAddNewPBrand.ValueMember = "BrandID";
            this.cbxAddNewPBrand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxAddNewPBrand_KeyUp_1);
            // 
            // cbxAddNewPKind
            // 
            this.cbxAddNewPKind.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbxAddNewPKind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAddNewPKind.DisplayMember = "KindOfProductID";
            this.cbxAddNewPKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddNewPKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddNewPKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAddNewPKind.FormattingEnabled = true;
            this.cbxAddNewPKind.Location = new System.Drawing.Point(207, 71);
            this.cbxAddNewPKind.Name = "cbxAddNewPKind";
            this.cbxAddNewPKind.Size = new System.Drawing.Size(301, 28);
            this.cbxAddNewPKind.TabIndex = 31;
            this.cbxAddNewPKind.ValueMember = "KindOfProductID";
            this.cbxAddNewPKind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxAddNewPKind_KeyUp_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(640, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Thời gian bảo hành (*):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Thời gian ra mắt (*):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "Thương hiệu (*):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "Loại mặt hàng (*):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddNewPName
            // 
            this.txtAddNewPName.AllowDrop = true;
            this.txtAddNewPName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddNewPName.BackColor = System.Drawing.Color.White;
            this.txtAddNewPName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewPName.ForeColor = System.Drawing.Color.Black;
            this.txtAddNewPName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddNewPName.Location = new System.Drawing.Point(207, 29);
            this.txtAddNewPName.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtAddNewPName.Name = "txtAddNewPName";
            this.txtAddNewPName.Size = new System.Drawing.Size(301, 19);
            this.txtAddNewPName.TabIndex = 29;
            this.txtAddNewPName.Tag = "firstForcus";
            this.txtAddNewPName.UseWaitCursor = true;
            this.txtAddNewPName.WordWrap = false;
            this.txtAddNewPName.TextChanged += new System.EventHandler(this.txtAddNewPName_TextChanged_1);
            this.txtAddNewPName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddNewPName_KeyUp_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên sản phẩm (*):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSearchDeleteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.PalScroll);
            this.Name = "FrmSearchDeleteEdit";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmSearchDeleteEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.PalScroll.ResumeLayout(false);
            this.palSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PalInput.ResumeLayout(false);
            this.PalInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errCheck;
        private System.Windows.Forms.Panel PalScroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton FindBrand;
        private System.Windows.Forms.RadioButton FindName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel PalInput;
        private System.Windows.Forms.DateTimePicker DtProduction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel palBrand;
        private System.Windows.Forms.Panel palKindOfProduct;
        private System.Windows.Forms.Panel palPrice;
        private System.Windows.Forms.Panel palGuarantee;
        private System.Windows.Forms.Panel palTime;
        private System.Windows.Forms.Panel palName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddNewPPrice;
        private System.Windows.Forms.TextBox txtAddNewPDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAddNewPGuarantee;
        private System.Windows.Forms.ComboBox cbxAddNewPBrand;
        private System.Windows.Forms.ComboBox cbxAddNewPKind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddNewPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel palSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV;
    }
}