using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using all = DoAnWinformBanDienThoai.All;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmCustomer : Form
    {
        HandleCustomer handle = new HandleCustomer();
        private string NameTable = "CUSTOMER";
        private string id;
        private string name;
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            all.handleRender(handle, DGV, NameTable);
            Form ownerForm = this.Owner;
            if (ownerForm != null && ownerForm.GetType() == typeof(FrmExportBill))
            {
                btnBill.Visible = true;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palName);
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palAddress);
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palPhone , true);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palEmail);
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtPhone, null);
        }
        private void txtCCCD_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtEmail, txtAddress);
        }
        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtEmail, txtPhone);
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtAddress, txtName);
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtdescription, txtAddress);
        }
        private void txtdescription_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, btnSave, txtEmail , true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = DGV.CurrentRow.Index;
            id = DGV.Rows[rowindex].Cells[0].Value.ToString();
            name = DGV.Rows[rowindex].Cells[1].Value.ToString();
            this.Dispose();
            this.Close();
        }
        public string getID(){return id;}
        public string getName(){return name;}
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            all.TurnOnButton(btnSave , PalInput);
            all.TurnOffButton(btnDelete, btnAdd, btnEdit);
            all.clearTextBox(txtName, txtEmail, txtAddress, txtPhone, txtdescription);
            all.ForeColorBlack(txtName, txtEmail, txtAddress, txtPhone, txtdescription);
            txtName.Focus();
            btnAdd.Tag = "Adding";
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            all.TurnOnButton(btnEdit, btnSave , PalInput);
            all.TurnOffButton(btnAdd, btnDelete);
            all.ForeColorBlack(txtName, txtEmail, txtAddress, txtPhone, txtdescription);
            btnEdit.Tag = "Editing";
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (all.handleDelete(handle, DGV, NameTable))
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Xóa thành công !", Color.Green);
                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool check = all.errorPanel(palName, palAddress, palPhone);
            if (check)
            {
                handle.Id = id;
                handle.Name = txtName.Text;
                handle.Phone = Convert.ToInt32(txtPhone.Text);
                handle.Address = txtAddress.Text;
                handle.Email = txtEmail.Text;
                handle.Description = txtdescription.Text;
                if ((string)btnAdd.Tag == "Adding" && handle.insert(NameTable))
                {
                    btnAdd.Tag = "Added";
                    all.handleRender(handle, DGV, NameTable);
                    all.TurnOnButton(btnAdd, btnEdit, btnDelete);
                    all.TurnOffButton(btnSave, PalInput);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Đã thêm thành công!", Color.Green);
                    }
                }
                else if ((string)btnEdit.Tag == "Editing"
                    && all.messageBox("Bạn có muốn cập nhật không!", MessageBoxButtons.YesNo)
                    && handle.update(NameTable))
                {
                    btnAdd.Tag = "Edited";
                    all.handleRender(handle, DGV, NameTable);
                    all.TurnOnButton(btnAdd, btnEdit, btnDelete);
                    all.TurnOffButton(btnSave , PalInput);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Đã cập nhật thành công!", Color.Green);
                    }
                }
            }
            else
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Vui lòng nhập đầy đủ thông tin!", Color.Green);
                }
                all.messageBox("Vui lòng nhập đầy đủ thông tin!", MessageBoxButtons.OK);
            }
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            all.ForeColorGray(txtName, txtEmail, txtAddress, txtPhone, txtdescription);
            all.TurnOnButton(btnAdd, btnEdit, btnDelete);
            all.TurnOffButton(btnSave , PalInput);
            btnAdd.Tag = "Added";
            btnEdit.Tag = "Edited";
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            bool check = txtSearch.Text.Length > 0;
            if (check)
            {
                DGV.DataSource = handle.searchList(NameTable , "Tên khách hàng" , txtSearch.Text);
            }
            else
            {
                all.handleRender(handle, DGV, NameTable);
            }
        }
       
        private void DGV_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            all.ForeColorGray(txtName, txtEmail, txtAddress, txtPhone, txtdescription);
            int rowindex = e.RowIndex;
            
                id = DGV.Rows[rowindex].Cells[0].Value.ToString();
                txtName.Text = DGV.Rows[rowindex].Cells[1].Value.ToString();
                txtPhone.Text = DGV.Rows[rowindex].Cells[2].Value.ToString();
                txtAddress.Text = DGV.Rows[rowindex].Cells[3].Value.ToString();
                txtEmail.Text = DGV.Rows[rowindex].Cells[4].Value.ToString();
                txtdescription.Text = DGV.Rows[rowindex].Cells[5].Value.ToString();
            
        }

        private void DGV_DoubleClick_1(object sender, EventArgs e)
        {
            if (btnBill.Enabled == true)
            {
                int rowindex = DGV.CurrentRow.Index;
                id = DGV.Rows[rowindex].Cells[0].Value.ToString();
                name = DGV.Rows[rowindex].Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
