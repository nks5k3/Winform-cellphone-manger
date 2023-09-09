using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using all = DoAnWinformBanDienThoai.All;
using System.Runtime.CompilerServices;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmBrandAndKindOfProduct : Form
    {
        HandleBrandAndKIndOfProduct handle = new HandleBrandAndKIndOfProduct();
        private string Brand = "BRAND";
        private string KindOf = "KINDOFPRODUCT";
        public FrmBrandAndKindOfProduct()
        {
            InitializeComponent();
        }
        private void FrmBrandAndKindOfProduct_Load(object sender, EventArgs e)
        {
            radioBrand.Checked = true;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palName);
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtDescription, null);
        }
        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, btnSave, txtName);
        }
        private void radioBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBrand.Checked)
            {
                grboxBrand.Visible = true;
                lblName.Text = "Tên thương hiệu (*):";
                txtName.Text = "Apple";
                grbName.Text = "Danh sách thương hiệu";
                all.handleRender(handle, DGV, Brand);
            }
        }
        private void radioKindOfProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKindOfProduct.Checked)
            {
                lblName.Text = "Tên loại mặt hàng(*):";
                txtName.Text = "Điện thoại ";
                grbName.Text = "Danh sách loại mặt hàng";
                all.handleRender(handle, DGV, KindOf);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool check = all.errorPanel(palName);
            if (check)
            {
                handle.Id = TxtID.Text;
                handle.Name = txtName.Text;
                handle.Description = txtDescription.Text;
                if (radioBrand.Checked)
                {
                    if ((string)btnAdd.Tag == "Adding" && handle.insert(Brand))
                    {
                        btnAdd.Tag = "Added";
                        if (this.ParentForm is FrmManageProducts frm) frm.MessessSucced("Thêm thành công!", Color.Green);
                    }
                    else if ((string)btnEdit.Tag == "Editing" && all.messageBox("Bạn muốn cập nhật không !" , MessageBoxButtons.YesNo))
                    {
                        handle.update(Brand);
                        if (this.ParentForm is FrmManageProducts frm) frm.MessessSucced("Cập nhật thành công!", Color.Green);
                    }
                    all.handleRender(handle, DGV, Brand);
                }
                else if (radioKindOfProduct.Checked)
                {
                    if ((string)btnAdd.Tag == "Adding" && handle.insert(KindOf))
                    {
                        if (this.ParentForm is FrmManageProducts frm) frm.MessessSucced("Thêm thành công!", Color.Green);
                        btnAdd.Tag = "Added";
                    }
                    else if ((string)btnEdit.Tag == "Editing" && all.messageBox("Bạn muốn cập nhật không !", MessageBoxButtons.YesNo))
                    {
                        handle.update(KindOf);
                        if (this.ParentForm is FrmManageProducts frm) frm.MessessSucced("Cập nhật thành công!", Color.Green);
                        btnEdit.Tag = "Edited";
                    }
                    all.handleRender(handle, DGV, KindOf);
                }
                all.TurnOnButton(btnAdd, btnEdit, btnDelete);
                txtName.Text = "";
                btnSave.Enabled = false;
            }
            else
            {
                if (this.ParentForm is FrmManageProducts frm) frm.MessessSucced("Vui lòng nhập đầy đủ thông tin!", Color.Green);
                all.messageBox("Vui lòng nhập đầy đủ thông tin!", MessageBoxButtons.OK);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            all.ForeColorBlack(TxtID, txtName, txtDescription);
            all.TurnOffButton(btnAdd, btnDelete);
            all.TurnOnButton(btnSave, btnEdit);
            btnEdit.Tag = "Editing";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            TxtID.Text = "";
            btnAdd.Tag = "Adding";
            all.ForeColorBlack(TxtID, txtName, txtDescription);
            all.TurnOffButton(btnAdd,btnDelete, btnEdit);
            all.TurnOnButton(btnSave);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radioBrand.Checked)
            {
                all.handleDelete(handle, DGV, Brand);
            }
            else if (radioKindOfProduct.Checked)
            {
                all.handleDelete(handle, DGV, KindOf);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            all.TurnOffButton(btnSave);
            all.TurnOnButton(btnAdd, btnDelete, btnEdit);
            all.ForeColorGray(TxtID, txtName, txtDescription);
        }
       
        private void DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            all.ForeColorGray(TxtID, txtName, txtDescription);
            int rowindex = e.RowIndex;
            if (DGV.Rows.Count - 1 != rowindex)
            {
                TxtID.Text = DGV.Rows[rowindex].Cells[0].Value.ToString();
                txtName.Text = DGV.Rows[rowindex].Cells[1].Value.ToString();
                txtDescription.Text = DGV.Rows[rowindex].Cells[2].Value.ToString();
            }
        }

        
    }
}
