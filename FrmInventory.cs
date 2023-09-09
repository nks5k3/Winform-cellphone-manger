using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmInventory : Form
    {
        HandleInventory handle = new HandleInventory ();
        private string table = "Inventory";
        public FrmInventory()
        {
            InitializeComponent();
        }
        private void FrmInventory_Load(object sender, EventArgs e)
        {
            CbxKindOfProducts.DataSource = new HandleBrandAndKIndOfProduct().render("KINDOFPRODUCT");
            CbxBrand.DataSource = new HandleBrandAndKIndOfProduct().render("BRAND");
            CbxBrand.DisplayMember = "BName";
            CbxKindOfProducts.DisplayMember = "KName";
            CbxBrand.ValueMember = "BrandID";
            CbxKindOfProducts.ValueMember = "KindOfProductID";

            All.handleRender(handle, DGV, table); 
        }

        private void FrmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void BtnFilter_Click_1(object sender, EventArgs e)
        {
            DGV.DataSource = handle.InventoryFilter(CbxBrand.SelectedValue.ToString(), CbxKindOfProducts.SelectedValue.ToString());

        }
        private void BtnShowAll_Click_1(object sender, EventArgs e)
        {
            All.handleRender(handle, DGV, table);
        }
        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtStart.Text , out int number))
            {
                btnQuantity.Enabled = true;
            }
            else
            {
                btnQuantity.Enabled = false;
            }
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtEnd.Text, out int number))
            {
                btnQuantity.Enabled = true;
            }
            else
            {
                btnQuantity.Enabled = false;
            }
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            DGV.DataSource = handle.InventoryFilterQuantity(Convert.ToInt32(txtStart.Text) , Convert.ToInt32(txtEnd.Text) );
        }
    }
}
