using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using all = DoAnWinformBanDienThoai.All;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmImportBill : Form
    {
        HandleImportProducts handle = new HandleImportProducts();
        DataTable table = new HandleProducts().render1("PRODUCTS"); // Lấy bảng từ cơ sở dữ liệu
        List<Product> pr = new List<Product>();

        

        private void HandlePrice()
        {
           

            decimal totalMoney = 0;
            for (int i = 0; i < DGV.Rows.Count - 1; i++)
            {
                int id = Convert.ToInt32(DGV.Rows[i].Cells[0].Value);
                int count = 0;
                decimal cost = Convert.ToDecimal(DGV.Rows[i].Cells["Price"].Value);
                try
                {
                    count = ((int)Convert.ToInt32(DGV.Rows[i].Cells["quantity"].Value) == 0)
                            ? 1 : Convert.ToInt32(DGV.Rows[i].Cells["quantity"].Value);
                }
                catch
                {
                    all.messageBox("Vui lòng nhập số lượng!", MessageBoxButtons.OK);
                }

                totalMoney = totalMoney + cost * count;

            }
            TxtTotal.Text = totalMoney.ToString();
            all.VNĐ(TxtTotal);
        }
        public class Product
        {
            public int Id { get; set; }
            public decimal Price { get; set; }
        };
        public FrmImportBill()
        {
            InitializeComponent();
        }
        private void frmImportBill_Load(object sender, EventArgs e)
        {
            txtStaffName.Text = FrmLogIn.StaffName;
            DataGridViewComboBoxColumn comboBoxColumn = DGV.Columns["NameProducts"] as DataGridViewComboBoxColumn;
            comboBoxColumn.DataSource = table;
            comboBoxColumn.DisplayMember = "Name";
            comboBoxColumn.ValueMember = "ProductID";

            using(SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    string query = "select ProductID , Price from PRODUCTS";
                    SqlCommand command = new SqlCommand(query, connect);
                    connect.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = (int)reader["ProductID"];
                        decimal price = (decimal)reader["Price"];
                        Product product = new Product { Id= id , Price= price};
                        pr.Add(product);
                    }
                    reader.Close();
                }  catch  {  all.messageBox("Lỗi", MessageBoxButtons.OK);  }  finally { connect.Close();}
            }
        }
        
        private void txtcompany_TextChanged(object sender, EventArgs e)
        {
            all.checkError(txtcompany, errCheck, palCompany);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmSupplier sp = new FrmSupplier();
            sp.Owner = this;
            sp.ShowDialog();
            txtcompany.Text = sp.getName();
            handle.Customer = sp.getID();
            handle.Account = FrmLogIn.Acount1;
        }
        private void BtnHandle_Click(object sender, EventArgs e)
        {
            HandlePrice();
        }

        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            all.CheckDuplicateValues(DGV);
            int pos = e.RowIndex;
            dynamic s = DGV.Rows[pos].Cells["quantity"].Value;
            dynamic g = DGV.Rows[pos].Cells["price"].Value;
            try 
            {
                int.Parse(s);
                decimal.Parse(g);
                HandlePrice();
                DGV.Rows[pos].DefaultCellStyle.BackColor = Color.White;
            }
            catch
            {
                DGV.Rows[pos].DefaultCellStyle.BackColor = Color.Salmon;
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Vui lòng Số lượng/Giá", Color.Red);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
                int select = DGV.SelectedRows.Count;
                if (DGV.SelectedRows[DGV.SelectedRows.Count - 1].Index != DGV.Rows.Count - 1 &&
                    select > 0 &&
                    all.messageBox("Bạn có muốn xóa không!", MessageBoxButtons.YesNo))
                {
                    foreach (DataGridViewRow row in DGV.SelectedRows)
                    {
                        DGV.Rows.Remove(row);
                    }
                    HandlePrice();
                }
        }
       

        private void btnInBill_Click(object sender, EventArgs e)
        {
            bool check = all.errorPanel(palCompany);
            bool dgvCheck = all.errorDGV(DGV);
            int row = DGV.Rows.Count;
            if (dgvCheck && check && row >1 && all.messageBox("Bạn có muốn xuất hóa đơn không" , MessageBoxButtons.YesNo))
            {
                // handle create bill
                handle.insert();
                // nó sẽ trả về mã hóa đơn của bảng import
                LblPN2.Text = handle.Bill;
                // id của importDetail nhận id của import và xửa lý phần dưới
                    handle.Id = handle.Bill;
                for (int i = 0; i < row - 1; i++)
                {
                    handle.Idsp = Convert.ToInt32(DGV.Rows[i].Cells["NameProducts"].Value.ToString());
                    if (DGV.Rows[i].Cells[1].Value == null) handle.Quantity = 1;
                    else handle.Quantity = Convert.ToInt32(DGV.Rows[i].Cells[1].Value.ToString());
                    handle.TotalBill = Convert.ToDecimal(TxtTotal.Text);
                    handle.Price = Convert.ToDecimal(DGV.Rows[i].Cells[2].Value.ToString());
                    handle.insertBillIMPORT();
                }
                // handle create bill detail
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Thành công!", Color.Green);
                }
            }
            else
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Vui lòng nhập đầy đủ thông tin", Color.Red);
                }
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            all.clearTextBox(TxtTotal, txtcompany);
            LblPN2.Text = "";
        }
        private void BtnCancelBill_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            all.clearTextBox(TxtTotal, txtcompany);
            LblPN2.Text = "";
        }
    }
}
