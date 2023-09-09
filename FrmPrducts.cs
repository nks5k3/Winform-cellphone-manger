using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using all = DoAnWinformBanDienThoai.All;
namespace DoAnWinformBanDienThoai
{
    public partial class FrmSearchDeleteEdit : Form
    {
        HandleProducts handle = new HandleProducts();
        private string Nametable = "PRODUCTS";
        public FrmSearchDeleteEdit()
        {
            InitializeComponent();
        }
        private void frmSearchDeleteEdit_Load(object sender, EventArgs e)
        {
            all.handleRender(handle, DGV, Nametable);
            cbxAddNewPKind.DataSource = new HandleBrandAndKIndOfProduct().render("KINDOFPRODUCT");
            cbxAddNewPBrand.DataSource = new HandleBrandAndKIndOfProduct().render("BRAND");
            cbxAddNewPBrand.DisplayMember = "BName";
            cbxAddNewPKind.DisplayMember = "KName";
        }
        private void txtAddNewPName_TextChanged_1(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            all.checkError(txt, errCheck, palName);
        }
        private void txtAddNewPGuarantee_TextChanged_1(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            all.checkError(txt, errCheck, palGuarantee, true);
        }
        private void txtAddNewPPrice_TextChanged_1(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            all.checkError(txt, errCheck, palPrice, true);
            all.VNĐ(txt);
        }
        private void txtAddNewPName_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, cbxAddNewPKind, null);
        }
        private void cbxAddNewPKind_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, cbxAddNewPBrand, txtAddNewPName);
        }
        private void cbxAddNewPBrand_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, DtProduction, cbxAddNewPKind);
        }
        private void DtProduction_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtAddNewPGuarantee, cbxAddNewPBrand);
        }
        private void txtAddNewPGuarantee_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtAddNewPPrice, DtProduction);
        }
        private void txtAddNewPPrice_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtAddNewPDescription, txtAddNewPGuarantee);
        }
        private void txtAddNewPDescription_KeyUp_1(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, btnSave, txtAddNewPPrice);
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            all.TurnOnButton(PalInput, btnSave);
            all.TurnOffButton(btnAdd, btnDelete, btnEdit);
            all.clearTextBox(txtAddNewPName, txtAddNewPPrice, txtAddNewPGuarantee, txtAddNewPDescription);
            all.ForeColorBlack(txtAddNewPName,cbxAddNewPBrand , cbxAddNewPKind , txtAddNewPPrice, txtAddNewPGuarantee, txtAddNewPDescription);
            txtAddNewPName.Focus();
            btnAdd.Tag = "Adding";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            all.TurnOnButton(btnSave, btnEdit , PalInput);
            all.ForeColorBlack(txtAddNewPName, cbxAddNewPBrand, cbxAddNewPKind, txtAddNewPPrice, txtAddNewPGuarantee, txtAddNewPDescription);
            all.TurnOffButton(btnAdd, btnDelete);
            btnEdit.Tag = "Editing";
            btnSave.Enabled = true;
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (all.handleDelete(handle, DGV, Nametable))
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Đã xóa thành công!", Color.Green);
                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (all.errorPanel(palName, palPrice, palGuarantee))
            {
                handle.Name = txtAddNewPName.Text;
                handle.KindOf = cbxAddNewPKind.SelectedValue.ToString();
                handle.Brand = cbxAddNewPBrand.SelectedValue.ToString();
                handle.Date = DtProduction.Value;
                handle.Guarantee = Convert.ToInt32(txtAddNewPGuarantee.Text);
                handle.Price = Convert.ToDecimal(txtAddNewPPrice.Text);
                handle.Description = txtAddNewPDescription.Text;
                if ((string)btnAdd.Tag == "Adding" && handle.insert(Nametable))
                {
                    btnAdd.Tag = "Added";
                    all.handleRender(handle, DGV, Nametable);
                    all.TurnOnButton(btnAdd, btnDelete, btnEdit);
                    all.TurnOffButton(btnSave , PalInput);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Đã thêm thành công!", Color.Green);
                    }
                }
                else if ((string)btnEdit.Tag == "Editing"
                    && all.messageBox("Bạn có muốn cập nhật không " , MessageBoxButtons.YesNo)
                    && handle.update(Nametable))
                {
                    btnEdit.Tag = "Edited";
                    all.handleRender(handle, DGV, Nametable);
                    all.TurnOnButton(btnAdd, btnDelete, btnEdit);
                    all.TurnOffButton(btnSave , PalInput);
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Cập nhật thành công!", Color.Green);
                    }
                }
            } else all.messageBox("Vui lòng nhập đẩy đủ thông tin!", MessageBoxButtons.OK);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            all.ForeColorGray(txtAddNewPName, cbxAddNewPBrand, cbxAddNewPKind, txtAddNewPPrice, txtAddNewPGuarantee, txtAddNewPDescription);
            all.TurnOnButton(btnAdd, btnEdit, btnDelete);
            all.TurnOffButton(btnSave, PalInput);
            btnAdd.Tag = "Added";
            btnEdit.Tag = "Edited";
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            bool check = txtSearch.Text.Length > 0;

            if (FindName.Checked && check)
            {
                DGV.DataSource = handle.searchList(Nametable, FindName.Text , txtSearch.Text);
                txtSearch.Focus();
            }
            else if (FindBrand.Checked && check)
            {
                DGV.DataSource = handle.searchList(Nametable, FindBrand.Text, txtSearch.Text);
                txtSearch.Focus();
            }
            else if (!check)
            {
                all.handleRender(handle, DGV, Nametable);
            }
        }
        private void FindBrand_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Clear();
        }

        private void FindName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Clear();
        }
        private void DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            all.ForeColorGray(txtAddNewPName, txtAddNewPPrice, txtAddNewPGuarantee, txtAddNewPDescription);
            int rowindex = e.RowIndex;
                handle.Id = DGV.Rows[rowindex].Cells[0].Value.ToString();
                txtAddNewPName.Text = DGV.Rows[rowindex].Cells[1].Value.ToString();
                cbxAddNewPBrand.Text = DGV.Rows[rowindex].Cells[2].Value.ToString();
                cbxAddNewPKind.Text = DGV.Rows[rowindex].Cells[3].Value.ToString();
                txtAddNewPPrice.Text = DGV.Rows[rowindex].Cells[4].Value.ToString();
                DtProduction.Text = DGV.Rows[rowindex].Cells[5].Value.ToString();
                txtAddNewPGuarantee.Text = DGV.Rows[rowindex].Cells[6].Value.ToString();
                txtAddNewPDescription.Text = DGV.Rows[rowindex].Cells[7].Value.ToString();
        }
    }
}
