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
    public partial class FrmStaff : Form
    {
        HandleStaff handle = new HandleStaff();
        private string Nametable = "STAFF";
        public FrmStaff()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            all.handleRender(handle, DGV, Nametable);
        }
        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palAccount);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palPassword);
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palName);
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palPhone , true);
        }
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palCCCD, true);
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palAddress);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palEmail);
        }
        private void txtAccount_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtPassword, null);
        }
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtName, txtAccount);
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtPhone, txtPassword);
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtCCCD, txtName);
        }
        private void txtCCCD_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtAddress, txtPhone);
        }
        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtEmail, txtCCCD);
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, dtBrithday, txtAddress);
        }
        private void dateTimeBrithday_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtDescription, txtEmail);
        }
        private void cbxPosition_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtDescription, dtBrithday);
        }
        private void txtDescription_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, btnSave, cbxPosition, true);
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            all.TurnOnButton(btnSave , PalInput);
            all.TurnOffButton(btnAdd, btnDelete, btnEdit);
            all.clearTextBox(txtPassword, txtAccount, txtName, txtEmail, txtPhone, txtDescription, txtAddress, txtCCCD);
            all.ForeColorBlack(txtPassword, txtAccount, txtName, txtEmail, txtPhone, txtDescription, txtAddress, txtCCCD);
            txtAccount.Focus();
            btnAdd.Tag = "Adding";
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            all.TurnOnButton(btnSave, btnEdit , PalInput);
            all.TurnOffButton(btnAdd, btnDelete);
            all.ForeColorBlack(txtPassword, txtAccount, txtName, txtEmail, txtPhone, txtDescription, txtAddress, txtCCCD);
            btnEdit.Tag = "Editing";
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int select = DGV.SelectedRows.Count;
            if (select > 0 && all.messageBox("Bạn có muốn xóa không!", MessageBoxButtons.YesNo))
            {
                handle.Account = DGV.Rows[DGV.SelectedRows[0].Index].Cells[0].Value.ToString();
                handle.delete(Nametable);
                all.handleRender(handle, DGV, Nametable);
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Xóa thành công !", Color.Green);
                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool check = all.errorPanel(palAccount, palPassword, palName, palPhone, palCCCD, palAddress, palEmail, palPosition, palBirthday);
            if (check)
            {
                handle.Account = txtAccount.Text;
                handle.Password = txtPassword.Text;
                handle.Name = txtName.Text;
                int.TryParse(txtPhone.Text, out int phone);
                int.TryParse(txtPhone.Text, out int CCCD);
                handle.Phone = phone;
                handle.CCCD1 = CCCD;
                handle.Address = txtAddress.Text;
                handle.Email = txtEmail.Text;
                handle.Date = dtBrithday.Value;
                handle.Role1 = cbxPosition.Text;
                handle.Description = txtDescription.Text;
                if ((string)btnAdd.Tag == "Adding" && handle.insert(Nametable))
                {
                    btnAdd.Tag = "Added";
                    all.handleRender(handle, DGV, Nametable);
                    all.TurnOnButton(btnAdd, btnEdit, btnDelete);
                    all.TurnOffButton(btnSave);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Đã thêm thành công!", Color.Green);
                    }
                }
                else if ((string)btnEdit.Tag == "Editing"
                    && all.messageBox("Bạn có muốn cập nhật không!", MessageBoxButtons.YesNo)
                    && handle.update(Nametable))
                {
                    btnEdit.Tag = "Edited";
                    all.handleRender(handle, DGV, Nametable);
                    all.TurnOnButton(btnAdd, btnEdit, btnDelete);
                    all.TurnOffButton(btnSave);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Đã cập nhật thành công!", Color.Green);
                    }
                }
            }
            else if (check == false)
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Vui lòng nhập đầy đủ thông tin!", Color.Red);
                }
            }
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            all.TurnOffButton(btnSave , PalInput);
            all.TurnOnButton(btnAdd, btnEdit, btnDelete);
            all.ForeColorGray(txtPassword, txtAccount, txtName, txtEmail, txtPhone, txtDescription, txtAddress, txtCCCD);
            btnEdit.Tag = "Edited";
            btnAdd.Tag = "Added";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            bool check = txtSearch.Text.Length > 0;
            if (FindName.Checked && check)
            {
                DGV.DataSource =  handle.searchList(Nametable, FindName.Text, txtSearch.Text);
            }else if (FindAccount.Checked && check)
            {
                DGV.DataSource =  handle.searchList(Nametable, FindAccount.Text, txtSearch.Text);
            }
            else if(!check)
            {
                all.handleRender(handle, DGV, Nametable);
            }
        }

        private void DGV_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            all.ForeColorGray(txtPassword, txtAccount, txtName, txtEmail, txtPhone, txtDescription, txtAddress, txtCCCD);
            int rowindex = e.RowIndex;
            txtAccount.Text = DGV.Rows[rowindex].Cells[0].Value.ToString();
            txtPassword.Text = DGV.Rows[rowindex].Cells[1].Value.ToString();
            txtName.Text = DGV.Rows[rowindex].Cells[2].Value.ToString();
            txtPhone.Text = DGV.Rows[rowindex].Cells[3].Value.ToString();
            txtCCCD.Text = DGV.Rows[rowindex].Cells[4].Value.ToString();
            txtAddress.Text = DGV.Rows[rowindex].Cells[5].Value.ToString();
            txtEmail.Text = DGV.Rows[rowindex].Cells[6].Value.ToString();
            dtBrithday.Text = DGV.Rows[rowindex].Cells[7].Value.ToString();
            cbxPosition.Text = DGV.Rows[rowindex].Cells[8].Value.ToString();
            txtDescription.Text = DGV.Rows[rowindex].Cells[9].Value.ToString();
        }
    }
}
