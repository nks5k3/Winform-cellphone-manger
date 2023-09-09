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
    public partial class FrmBillAll : Form
    {
        HandleAllBill handle = new HandleAllBill();
        private string Import = "Import";
        private string Export = "Export";
        Color rgbDefault1 = Color.Silver;
        public FrmBillAll()
        {
            InitializeComponent();
        }
        private void FrmBillAll_Load(object sender, EventArgs e)
        {
            All.handleRender(handle, DGV, Export);
        }

        private void HandleFind(string table , TextBox txt)
        {
                if (TxtFind.Text == "")
                {
                    DGV.DataSource = handle.render(table);
                }
                else if (FindID.Checked)
                {
                    DGV.DataSource = handle.searchList($"Bill{table}", FindID.Text, txt.Text.ToUpper());
                }
                else if (FindCustomer.Checked)
                {
                    DGV.DataSource = handle.searchList($"Bill{table}", FindCustomer.Text, txt.Text);
                }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            All.handleRender(handle, DGV, Export);
            FindCustomer.Text = "Tên khách hàng";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            All.handleRender(handle, DGV, Import);
            FindCustomer.Text = "Tên Công ty";
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (rdoExport.Checked)
            {
                HandleFind(Export, TxtFind);
            }
            else if (RdoImport.Checked)
            {
                HandleFind(Import, TxtFind);
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            if (rdoExport.Checked)
            {
                DGV.DataSource = handle.render("Export");
            }
            else if (RdoImport.Checked)
            {
                DGV.DataSource = handle.render("Import");
            }

        }
        private void TxtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if(TxtFind.Focus() && TxtFind.Text != "" && e.KeyValue == 13)
            {
                if (rdoExport.Checked)
                {
                    HandleFind(Export, TxtFind);
                }else if (RdoImport.Checked)
                {
                    HandleFind(Import, TxtFind);
                }
            }
        }

        private void DGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                foreach(DataGridViewRow row in DGV.Rows)
                {
                    int check = Convert.ToInt32(row.Cells[1].Value.ToString().Substring(2, 4));
                    if(check %2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = rgbDefault1;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
