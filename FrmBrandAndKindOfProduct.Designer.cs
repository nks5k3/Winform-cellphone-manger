namespace DoAnWinformBanDienThoai
{
    partial class FrmBrandAndKindOfProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrandAndKindOfProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioKindOfProduct = new System.Windows.Forms.RadioButton();
            this.radioBrand = new System.Windows.Forms.RadioButton();
            this.grboxBrand = new System.Windows.Forms.GroupBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.palName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbName = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.errCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grboxBrand.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grboxBrand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 355);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(181)))), ((int)(((byte)(184)))));
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.radioKindOfProduct);
            this.panel3.Controls.Add(this.radioBrand);
            this.panel3.Location = new System.Drawing.Point(353, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 53);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(276, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 61);
            this.panel10.TabIndex = 5;
            // 
            // radioKindOfProduct
            // 
            this.radioKindOfProduct.AutoSize = true;
            this.radioKindOfProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioKindOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKindOfProduct.ForeColor = System.Drawing.Color.White;
            this.radioKindOfProduct.Location = new System.Drawing.Point(370, 12);
            this.radioKindOfProduct.Name = "radioKindOfProduct";
            this.radioKindOfProduct.Size = new System.Drawing.Size(173, 29);
            this.radioKindOfProduct.TabIndex = 4;
            this.radioKindOfProduct.Text = "Loại Mặt Hàng";
            this.radioKindOfProduct.UseVisualStyleBackColor = true;
            this.radioKindOfProduct.CheckedChanged += new System.EventHandler(this.radioKindOfProduct_CheckedChanged);
            // 
            // radioBrand
            // 
            this.radioBrand.AutoSize = true;
            this.radioBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBrand.ForeColor = System.Drawing.Color.White;
            this.radioBrand.Location = new System.Drawing.Point(21, 12);
            this.radioBrand.Name = "radioBrand";
            this.radioBrand.Size = new System.Drawing.Size(157, 29);
            this.radioBrand.TabIndex = 3;
            this.radioBrand.Text = "Thương Hiệu";
            this.radioBrand.UseVisualStyleBackColor = true;
            this.radioBrand.CheckedChanged += new System.EventHandler(this.radioBrand_CheckedChanged);
            // 
            // grboxBrand
            // 
            this.grboxBrand.BackColor = System.Drawing.Color.White;
            this.grboxBrand.Controls.Add(this.TxtID);
            this.grboxBrand.Controls.Add(this.palName);
            this.grboxBrand.Controls.Add(this.txtName);
            this.grboxBrand.Controls.Add(this.panel9);
            this.grboxBrand.Controls.Add(this.lblName);
            this.grboxBrand.Controls.Add(this.btnCancel);
            this.grboxBrand.Controls.Add(this.btnSave);
            this.grboxBrand.Controls.Add(this.btnDelete);
            this.grboxBrand.Controls.Add(this.btnEdit);
            this.grboxBrand.Controls.Add(this.btnAdd);
            this.grboxBrand.Controls.Add(this.label9);
            this.grboxBrand.Controls.Add(this.txtDescription);
            this.grboxBrand.Controls.Add(this.lable);
            this.grboxBrand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grboxBrand.Location = new System.Drawing.Point(0, 70);
            this.grboxBrand.Name = "grboxBrand";
            this.grboxBrand.Size = new System.Drawing.Size(1274, 285);
            this.grboxBrand.TabIndex = 1;
            this.grboxBrand.TabStop = false;
            this.grboxBrand.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.AllowDrop = true;
            this.TxtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtID.BackColor = System.Drawing.Color.White;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.ForeColor = System.Drawing.Color.Black;
            this.TxtID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtID.Location = new System.Drawing.Point(328, 27);
            this.TxtID.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(124, 26);
            this.TxtID.TabIndex = 65;
            this.TxtID.Tag = "firstForcus";
            this.TxtID.UseWaitCursor = true;
            this.TxtID.WordWrap = false;
            // 
            // palName
            // 
            this.palName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palName.BackColor = System.Drawing.Color.Black;
            this.palName.Location = new System.Drawing.Point(231, 82);
            this.palName.Name = "palName";
            this.palName.Size = new System.Drawing.Size(301, 1);
            this.palName.TabIndex = 58;
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.Location = new System.Drawing.Point(231, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 19);
            this.txtName.TabIndex = 57;
            this.txtName.Tag = "firstForcus";
            this.txtName.UseWaitCursor = true;
            this.txtName.WordWrap = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(699, 82);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(60, 68);
            this.panel9.TabIndex = 64;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 27);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Tên thương hiệu (*):";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCancel.Location = new System.Drawing.Point(938, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(745, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(555, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Tag = "Deleted";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(368, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 50);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Tag = "Edited";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(178, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Tag = "Added";
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(65, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 37);
            this.label9.TabIndex = 57;
            this.label9.Text = "Mô tả : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(228, 103);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(303, 79);
            this.txtDescription.TabIndex = 56;
            this.txtDescription.Tag = "";
            this.txtDescription.Text = "...";
            this.txtDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyUp);
            // 
            // lable
            // 
            this.lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lable.BackColor = System.Drawing.Color.White;
            this.lable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(63, 19);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(141, 27);
            this.lable.TabIndex = 53;
            this.lable.Text = "Mã (*):";
            this.lable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grbName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 375);
            this.panel2.TabIndex = 1;
            // 
            // grbName
            // 
            this.grbName.Controls.Add(this.DGV);
            this.grbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbName.Location = new System.Drawing.Point(0, 0);
            this.grbName.Name = "grbName";
            this.grbName.Size = new System.Drawing.Size(1274, 375);
            this.grbName.TabIndex = 0;
            this.grbName.TabStop = false;
            this.grbName.Text = "Danh sách";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersHeight = 29;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 23);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1268, 349);
            this.DGV.TabIndex = 1;
            this.DGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_RowEnter);
            // 
            // errCheck
            // 
            this.errCheck.ContainerControl = this;
            // 
            // FrmBrandAndKindOfProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBrandAndKindOfProduct";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Text = "BrandAndKindOfProduct";
            this.Load += new System.EventHandler(this.FrmBrandAndKindOfProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grboxBrand.ResumeLayout(false);
            this.grboxBrand.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grbName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grboxBrand;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioKindOfProduct;
        private System.Windows.Forms.RadioButton radioBrand;
        private System.Windows.Forms.ErrorProvider errCheck;
        private System.Windows.Forms.GroupBox grbName;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel palName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtID;
    }
}