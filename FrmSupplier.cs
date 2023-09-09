using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using all = DoAnWinformBanDienThoai.All;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmSupplier : Form
    {
        HandleSupplier handle = new HandleSupplier();
        private string NameTable = "SUPPLIER";
        private string id;
        private string name;    
        public FrmSupplier()
        {
            InitializeComponent();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            all.handleRender(handle, DGV, NameTable);
            Form ownerForm = this.Owner;
            if (ownerForm != null && ownerForm.GetType() == typeof(FrmImportBill)) 
                btnBill.Visible = true;
        }
        private void txtNameCompany_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palNameCompany);
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palPhone , true);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            all.checkError(txtEmail, errCheck, palEmail);
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palAddress);
        }
        private void txtNameHead_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palNameHead);
        }
        private void txtNameCompany_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtPhone, null);
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtAddress, txtNameCompany);
        }
        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtNameHead, txtPhone);
        }
        private void txtNameHead_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtEmail, txtAddress);
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtdescription, txtNameHead);
        }
        private void txtdescription_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, btnSave, txtEmail);
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            int rowindex = DGV.CurrentRow.Index;
            id = DGV.Rows[rowindex].Cells[0].Value.ToString();
            name = DGV.Rows[rowindex].Cells[1].Value.ToString();
            this.Close();
        }
        public string getID(){return id;}
        public string getName(){ return name;}
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            all.TurnOnButton(btnSave , PalInput);
            all.TurnOffButton(btnDelete, btnEdit);
            all.clearTextBox(txtNameCompany, txtAddress, txtNameHead, txtPhone, txtEmail, txtdescription);
            all.ForeColorBlack(txtNameCompany, txtAddress, txtNameHead, txtPhone, txtEmail, txtdescription);
            txtNameCompany.Focus();
            btnAdd.Tag = "Adding";
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            all.TurnOnButton(btnSave, btnEdit , PalInput);
            all.TurnOffButton(btnAdd, btnDelete);
            all.ForeColorBlack(txtNameCompany, txtAddress, txtNameHead, txtPhone, txtEmail, txtdescription);
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
            if (all.errorPanel(palNameCompany, palPhone, palAddress, palNameHead, palEmail))
            {
                handle.Id = id;
                handle.Name = txtNameCompany.Text;
                int.TryParse(txtPhone.Text, out int phone);
                handle.Phone = phone;
                handle.Address = txtAddress.Text;
                handle.Representative1 = txtNameHead.Text;
                handle.Email = txtEmail.Text;
                handle.Description = txtdescription.Text;
                if ((string)btnAdd.Tag == "Adding" && handle.insert(NameTable))
                {
                    btnAdd.Tag = "Added";
                    all.handleRender(handle, DGV, NameTable);
                    all.TurnOnButton(btnAdd, btnDelete, btnEdit);
                    all.TurnOffButton(btnSave , PalInput);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Thêm thành công!", Color.Green);
                    }
                }
                else if ((string)btnEdit.Tag == "Editing"
                    && all.messageBox("Bạn muốn cập nhật không!", MessageBoxButtons.YesNo)
                    && handle.update(NameTable))
                {
                    btnEdit.Tag = "Edited";
                    all.handleRender(handle, DGV, NameTable);
                    all.TurnOnButton(btnAdd, btnDelete, btnEdit);
                    all.TurnOffButton(btnSave , PalInput);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Cập nhật thành công!", Color.Green);
                    }
                }
            }
            else all.messageBox("Vui lòng nhập đủ thông tin!", MessageBoxButtons.OK);
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            all.ForeColorGray(txtNameCompany, txtAddress, txtNameHead, txtPhone, txtEmail, txtdescription);
            all.TurnOnButton(btnAdd, btnEdit, btnDelete);
            all.TurnOffButton(btnSave, PalInput);
            btnEdit.Tag = "Edited";
            btnAdd.Tag = "Added";
        }
        private void DGV_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
                all.ForeColorGray(txtNameCompany, txtAddress, txtNameHead, txtPhone, txtEmail, txtdescription);
                int rowindex = e.RowIndex;
                    id = DGV.Rows[rowindex].Cells[0].Value.ToString();
                    txtNameCompany.Text = DGV.Rows[rowindex].Cells[1].Value.ToString();
                    txtPhone.Text = DGV.Rows[rowindex].Cells[2].Value.ToString();
                    txtAddress.Text = DGV.Rows[rowindex].Cells[3].Value.ToString();
                    txtNameHead.Text = DGV.Rows[rowindex].Cells[4].Value.ToString();
                    txtEmail.Text = DGV.Rows[rowindex].Cells[5].Value.ToString();
                    txtdescription.Text = DGV.Rows[rowindex].Cells[6].Value.ToString();
        }
        private void DGV_DoubleClick_1(object sender, EventArgs e)
        {
            if (btnBill.Enabled == true)
            {
                int rowindex = DGV.CurrentRow.Index;
                id = DGV.Rows[rowindex].Cells[0].Value.ToString();
                name = DGV.Rows[rowindex].Cells[1].Value.ToString();
                this.Dispose();
                this.Close();
            }
        }
        private void FrmSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            bool check = txtSearch.Text.Length > 0;
            if( check )
            {
                DGV.DataSource = handle.searchList(NameTable, "Tên công ty", txtSearch.Text);
            }
            else
            {
                all.handleRender(handle, DGV, NameTable);
            }
        }
    }
}
