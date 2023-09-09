using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static DoAnWinformBanDienThoai.FrmImportBill;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using all = DoAnWinformBanDienThoai.All;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmExportBill : Form
    {
        HandleExportProducts handle = new HandleExportProducts();   
        DataTable table = new HandleProducts().render1("PRODUCTS"); // Lấy bảng từ cơ sở dữ liệu
        List<Product> pr = new List<Product>();
        public class Product
        {
            public int Id { get; set; }
            public decimal Price { get; set; }
            public int Inventory { get; set; }
        };
        public FrmExportBill()
        {
            InitializeComponent();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            all.checkError(txtName, errCheck, palName);
        }
        private void txtFree_TextChanged(object sender, EventArgs e)
        {
            all.checkError((TextBox)sender, errCheck, palFree, true);
        }
        private void frmExportBill_Load(object sender, EventArgs e)
        {
            txtStaffName.Text = FrmLogIn.StaffName;
            DGV.Columns["quantity"].DefaultCellStyle.NullValue = "1";
            // add vao cbx cua datagridview
            DataGridViewComboBoxColumn comboBoxColumn = DGV.Columns["NameProducts"] as DataGridViewComboBoxColumn;
            comboBoxColumn.DataSource = table;
            comboBoxColumn.DisplayMember = "Name";
            comboBoxColumn.ValueMember = "ProductID";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    string query = "select ProductID , Price , Inventory from PRODUCTS";
                    SqlCommand command = new SqlCommand(query, connect);
                    connect.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = (int)reader["ProductID"];
                        decimal price = (decimal)reader["Price"];
                        int inventory = (int)reader["Inventory"];
                        Product product = new Product { Id = id, Price = price , Inventory = inventory };
                        pr.Add(product);
                    }
                    reader.Close();
                }
                catch{all.messageBox("Lỗi", MessageBoxButtons.OK);}finally{connect.Close();}
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCustomer cs = new FrmCustomer();
            cs.Owner = this;
            cs.ShowDialog();
            txtName.Text = cs.getName();
            handle.Customer = cs.getID();
            handle.Account = FrmLogIn.Acount1;
        }
        
        private void HandlePrice()
        {
            decimal totalMoney = 0;
            decimal discount = 0;
            decimal total = 0;
            for (int i = 0; i < DGV.Rows.Count - 1; i++)
            {
                int id = Convert.ToInt32(DGV.Rows[i].Cells[0].Value);

                decimal price = (from p in pr
                                 where p.Id == id
                                 select p.Price).FirstOrDefault();
                int inventory = (from p in pr
                                 where p.Id == id
                                 select p.Inventory).FirstOrDefault();
                
                DGV.Rows[i].Cells["Price"].Value = price;
                DGV.Rows[i].Cells["Inventory"].Value = inventory;
                int count = 0;
                try
                {
                    count = (Convert.ToInt32(DGV.Rows[i].Cells["quantity"].Value) == 0)
                            ? 1 : Convert.ToInt32(DGV.Rows[i].Cells["quantity"].Value);
                }
                catch
                {
                    all.messageBox("Vui lòng nhập số lượng!", MessageBoxButtons.OK);
                }
                if (inventory < count)
                {
                    all.messageBox("Số lượng trong kho không đủ", MessageBoxButtons.OK);
                    DGV.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;
                }
                    totalMoney += price * count;
            }
            discount = totalMoney * Convert.ToInt32(txtFree.Text) / 100;
            total = totalMoney - discount;

            TxtTotalView.Text = totalMoney.ToString();
            all.VNĐ(TxtTotalView);
            
            TxtDiscount.Text = (txtFree.Text == "0") ? "0" : discount.ToString();
            all.VNĐ(TxtDiscount);

            TxtTotal.Text = total.ToString();
            all.VNĐ(TxtTotal);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            HandlePrice();
        }
        private void DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            all.CheckDuplicateValues(DGV);
                HandlePrice();
            int pos = e.RowIndex;
            dynamic s = DGV.Rows[pos].Cells["quantity"].Value;
            try
            {
                int.Parse(s);
            }
            catch
            {
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Vui lòng số lượng", Color.Red);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnExportBill_Click(object sender, EventArgs e)
        {
            int row = DGV.Rows.Count;
            bool dgvCheck = all.errorDGV(DGV);
            if (dgvCheck && all.errorPanel(palName) && row > 1 && all.messageBox("Bạn có muốn lưu hóa đơn không" , MessageBoxButtons.YesNo))
            {
                handle.Discount = Convert.ToDecimal(TxtDiscount.Text);
                handle.TotalBill = Convert.ToDecimal(TxtTotal.Text);
                handle.Description = txtDescription.Text;
                handle.insert();

                LblPX1.Text = handle.Bill;
                handle.Id = handle.Bill;
                for (int i = 0; i < row - 1; i++)
                {
                    handle.Idsp = Convert.ToInt32(DGV.Rows[i].Cells["NameProducts"].Value.ToString());

                    if (DGV.Rows[i].Cells[1].Value == null) handle.Quantity = 1;
                    else handle.Quantity = Convert.ToInt32(DGV.Rows[i].Cells[1].Value.ToString());
                    handle.TotalBill = Convert.ToDecimal(TxtTotal.Text);

                    handle.Price = Convert.ToDecimal(DGV.Rows[i].Cells[2].Value.ToString());
                    handle.insertBillEXPORT();
                }
                if (this.ParentForm is FrmManageProducts frm)
                {
                    frm.MessessSucced("Thành công!", Color.Green);
                }

            }
            else all.messageBox("Vui lòng nhập đầy đủ thông tin", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            all.clearTextBox(TxtDiscount, TxtTotal, TxtTotalView , txtName , txtDescription);
        }
    }
}
