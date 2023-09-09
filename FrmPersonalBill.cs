using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmPersonalBill : Form
    {
        HandleStaff handle = new HandleStaff();
        Color rgbDefault1 = Color.Silver;

        public FrmPersonalBill()
        {
            InitializeComponent();
        }

        private void TxtpassOld_KeyUp(object sender, KeyEventArgs e)
        {
            All.enterTextBox(e, TxtpassNew, null);
        }
        private void TxtpassNew_KeyUp(object sender, KeyEventArgs e)
        {
            All.enterTextBox(e, TxtPassNew2, TxtpassOld);
        }
        private void TxtPassNew2_KeyUp(object sender, KeyEventArgs e)
        {
            All.enterTextBox(e, btnSave, TxtpassNew);
        }
        private void TxtpassOld_TextChanged(object sender, EventArgs e)
        {
            All.checkError(TxtpassOld, errCheck, PalPassOld);
        }
        private void TxtpassNew_TextChanged(object sender, EventArgs e)
        {
            All.checkError(TxtpassNew , errCheck, PalPassNew);
        }
        private void TxtPassNew2_TextChanged(object sender, EventArgs e)
        {
            All.checkError(TxtPassNew2, errCheck, PalPassNew2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            All.HidenTextPassword(TxtpassOld);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            All.HidenTextPassword(TxtpassNew);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            All.HidenTextPassword(TxtPassNew2);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = All.errorPanel(PalPassOld, PalPassNew2, PalPassNew);
            bool checkPass = (TxtpassNew.Text == TxtPassNew2.Text) ? true : false;
            if(check )
            {
                if( checkPass)
                {
                    handle.Account = FrmLogIn.Acount1;
                    handle.PasswordOld = TxtpassOld.Text;
                    handle.Password = TxtPassNew2.Text;
                    if (handle.OnChangePassword() && All.messageBox("Bạn có muốn thay đổi mật khẩu không" ,MessageBoxButtons.YesNo))
                    {
                        All.clearTextBox(TxtpassOld, TxtPassNew2, TxtpassNew);
                        if (this.ParentForm is FrmManageProducts frm)
                        {
                            frm.MessessSucced("Đổi mật khẩu thành công!", Color.Green);
                        }
                    }
                    else
                    {
                        if (this.ParentForm is FrmManageProducts frm)
                        {
                            frm.MessessSucced("Mật khẩu không đúng!", Color.Red);
                        }
                    }
                }
                else
                {
                    if (this.ParentForm is FrmManageProducts frm)
                    {
                        frm.MessessSucced("Mật khẩu không trùng khớp!", Color.Orange);
                    }
                }
            }
            else
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Vui lòng nhập đủ thông tin!", Color.Orange);
                }
            }
        }

        private void FrmPersonalBill_Load(object sender, EventArgs e)
        {
            DGV.DataSource = handle.searchList("PersonallBill", "Tài khoản nhân viên", FrmLogIn.Acount1);
        }

        private void DGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    int check = Convert.ToInt32(row.Cells[1].Value.ToString().Substring(2, 4));
                    if (check % 2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = rgbDefault1;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
