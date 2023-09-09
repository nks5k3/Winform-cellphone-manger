namespace DoAnWinformBanDienThoai
{
    partial class FrmSupplier
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
            this.PalInput = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.palEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.palPhone = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.palAddress = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.palNameHead = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameHead = new System.Windows.Forms.TextBox();
            this.palNameCompany = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.PalInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // errCheck
            // 
            this.errCheck.ContainerControl = this;
            // 
            // PalInput
            // 
            this.PalInput.Controls.Add(this.panel7);
            this.PalInput.Controls.Add(this.txtdescription);
            this.PalInput.Controls.Add(this.label6);
            this.PalInput.Controls.Add(this.palEmail);
            this.PalInput.Controls.Add(this.txtEmail);
            this.PalInput.Controls.Add(this.palPhone);
            this.PalInput.Controls.Add(this.label5);
            this.PalInput.Controls.Add(this.txtPhone);
            this.PalInput.Controls.Add(this.palAddress);
            this.PalInput.Controls.Add(this.label4);
            this.PalInput.Controls.Add(this.txtAddress);
            this.PalInput.Controls.Add(this.palNameHead);
            this.PalInput.Controls.Add(this.label3);
            this.PalInput.Controls.Add(this.txtNameHead);
            this.PalInput.Controls.Add(this.palNameCompany);
            this.PalInput.Controls.Add(this.label2);
            this.PalInput.Controls.Add(this.txtNameCompany);
            this.PalInput.Controls.Add(this.label1);
            this.PalInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.PalInput.Enabled = false;
            this.PalInput.Location = new System.Drawing.Point(0, 0);
            this.PalInput.Name = "PalInput";
            this.PalInput.Size = new System.Drawing.Size(1160, 194);
            this.PalInput.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(584, -3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 160);
            this.panel7.TabIndex = 117;
            // 
            // txtdescription
            // 
            this.txtdescription.AllowDrop = true;
            this.txtdescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdescription.BackColor = System.Drawing.Color.White;
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.ForeColor = System.Drawing.Color.Silver;
            this.txtdescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtdescription.Location = new System.Drawing.Point(842, 50);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(301, 61);
            this.txtdescription.TabIndex = 102;
            this.txtdescription.Tag = "firstForcus";
            this.txtdescription.Text = "...";
            this.txtdescription.UseWaitCursor = true;
            this.txtdescription.WordWrap = false;
            this.txtdescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdescription_KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(670, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 27);
            this.label6.TabIndex = 101;
            this.label6.Text = "Mô tả :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // palEmail
            // 
            this.palEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palEmail.BackColor = System.Drawing.Color.Black;
            this.palEmail.Location = new System.Drawing.Point(842, 35);
            this.palEmail.Name = "palEmail";
            this.palEmail.Size = new System.Drawing.Size(301, 1);
            this.palEmail.TabIndex = 100;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowDrop = true;
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(842, 11);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 19);
            this.txtEmail.TabIndex = 98;
            this.txtEmail.Tag = "firstForcus";
            this.txtEmail.Text = "nguyenkhanhsonzero@gmailcom";
            this.txtEmail.UseWaitCursor = true;
            this.txtEmail.WordWrap = false;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            // 
            // palPhone
            // 
            this.palPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palPhone.BackColor = System.Drawing.Color.Black;
            this.palPhone.Location = new System.Drawing.Point(190, 76);
            this.palPhone.Name = "palPhone";
            this.palPhone.Size = new System.Drawing.Size(301, 1);
            this.palPhone.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(670, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 27);
            this.label5.TabIndex = 96;
            this.label5.Text = "Email :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.AllowDrop = true;
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPhone.Location = new System.Drawing.Point(190, 52);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 19);
            this.txtPhone.TabIndex = 97;
            this.txtPhone.Tag = "firstForcus";
            this.txtPhone.Text = "0943217670";
            this.txtPhone.UseWaitCursor = true;
            this.txtPhone.WordWrap = false;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyUp);
            // 
            // palAddress
            // 
            this.palAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palAddress.BackColor = System.Drawing.Color.Black;
            this.palAddress.Location = new System.Drawing.Point(190, 116);
            this.palAddress.Name = "palAddress";
            this.palAddress.Size = new System.Drawing.Size(301, 1);
            this.palAddress.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 95;
            this.label4.Text = "Số điện thoại (*):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.AllowDrop = true;
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Silver;
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddress.Location = new System.Drawing.Point(190, 92);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 19);
            this.txtAddress.TabIndex = 92;
            this.txtAddress.Tag = "firstForcus";
            this.txtAddress.Text = "Thành phố Hà Tĩnh";
            this.txtAddress.UseWaitCursor = true;
            this.txtAddress.WordWrap = false;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyUp);
            // 
            // palNameHead
            // 
            this.palNameHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palNameHead.BackColor = System.Drawing.Color.Black;
            this.palNameHead.Location = new System.Drawing.Point(190, 156);
            this.palNameHead.Name = "palNameHead";
            this.palNameHead.Size = new System.Drawing.Size(301, 1);
            this.palNameHead.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 90;
            this.label3.Text = "Địa chỉ công ty (*) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNameHead
            // 
            this.txtNameHead.AllowDrop = true;
            this.txtNameHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameHead.BackColor = System.Drawing.Color.White;
            this.txtNameHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHead.ForeColor = System.Drawing.Color.Silver;
            this.txtNameHead.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNameHead.Location = new System.Drawing.Point(190, 132);
            this.txtNameHead.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtNameHead.Name = "txtNameHead";
            this.txtNameHead.Size = new System.Drawing.Size(301, 19);
            this.txtNameHead.TabIndex = 91;
            this.txtNameHead.Tag = "firstForcus";
            this.txtNameHead.Text = "Nguyễn Khánh Sơn";
            this.txtNameHead.UseWaitCursor = true;
            this.txtNameHead.WordWrap = false;
            this.txtNameHead.TextChanged += new System.EventHandler(this.txtNameHead_TextChanged);
            this.txtNameHead.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameHead_KeyUp);
            // 
            // palNameCompany
            // 
            this.palNameCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palNameCompany.BackColor = System.Drawing.Color.Black;
            this.palNameCompany.Location = new System.Drawing.Point(190, 35);
            this.palNameCompany.Name = "palNameCompany";
            this.palNameCompany.Size = new System.Drawing.Size(301, 1);
            this.palNameCompany.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 89;
            this.label2.Text = "Người đại diện : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNameCompany
            // 
            this.txtNameCompany.AllowDrop = true;
            this.txtNameCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameCompany.BackColor = System.Drawing.Color.White;
            this.txtNameCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCompany.ForeColor = System.Drawing.Color.Silver;
            this.txtNameCompany.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNameCompany.Location = new System.Drawing.Point(190, 11);
            this.txtNameCompany.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtNameCompany.Name = "txtNameCompany";
            this.txtNameCompany.Size = new System.Drawing.Size(301, 19);
            this.txtNameCompany.TabIndex = 87;
            this.txtNameCompany.Tag = "firstForcus";
            this.txtNameCompany.Text = "Nguyễn Khánh Sơn";
            this.txtNameCompany.UseWaitCursor = true;
            this.txtNameCompany.WordWrap = false;
            this.txtNameCompany.TextChanged += new System.EventHandler(this.txtNameCompany_TextChanged);
            this.txtNameCompany.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameCompany_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 86;
            this.label1.Text = "Tên công ty(*) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBill);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnBill
            // 
            this.btnBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.FlatAppearance.BorderSize = 3;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(979, 101);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(150, 50);
            this.btnBill.TabIndex = 121;
            this.btnBill.Tag = "Added";
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Visible = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_add_new_30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(21, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 126;
            this.btnAdd.Tag = "Added";
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_create_30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(208, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 50);
            this.btnEdit.TabIndex = 125;
            this.btnEdit.Tag = "Edited";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_delete_30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(400, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 124;
            this.btnDelete.Tag = "Deleted";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(190, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);
            this.groupBox3.Size = new System.Drawing.Size(820, 73);
            this.groupBox3.TabIndex = 123;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm công ty";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(20, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(780, 30);
            this.txtSearch.TabIndex = 103;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_save_30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(604, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::DoAnWinformBanDienThoai.Properties.Resources.icons8_undo_30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(793, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.PalInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 710);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 358);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách công ty";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersHeight = 29;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 23);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1154, 332);
            this.DGV.TabIndex = 0;
            this.DGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_RowEnter_1);
            this.DGV.DoubleClick += new System.EventHandler(this.DGV_DoubleClick_1);
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSupplier";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSupplier_FormClosing);
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.PalInput.ResumeLayout(false);
            this.PalInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel PalInput;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel palEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel palPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel palAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel palNameHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameHead;
        private System.Windows.Forms.Panel palNameCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
    }
}