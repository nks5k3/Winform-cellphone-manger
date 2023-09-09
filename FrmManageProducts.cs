using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using all = DoAnWinformBanDienThoai.All;
namespace DoAnWinformBanDienThoai
{
    public partial class FrmManageProducts : Form
    {

        Color rgbDefault1 = Color.FromArgb(7, 181, 184);
        Color rgbDefault2 = Color.FromArgb(2, 135, 155);
        private Form currentFormChild;
        HandleStatistics handle = new HandleStatistics();
        List<Button> btns = new List<Button>();
        private void HandleTheMostBilling()
        {
            DateTime dateNow = DateTime.Now;
            DateTime monthNow = new DateTime(dateNow.Year, dateNow.Month, 1);
            // lấy các button trong panel để hightlight khi click
            GetAllButtons(this);
            // lấy tên của nhân viên khi đăng nhập
            btnHeadName.Text = FrmLogIn.StaffName;
            // render những sản phẩm bán chạy / ít nhất trong tháng
            DGVMost.DataSource = handle.BestSellingProduct(monthNow, dateNow);
            DGVLittle.DataSource = handle.LittleSellingProduct(monthNow, dateNow);
        }
        public FrmManageProducts()
        {
            InitializeComponent();
        }
        private void frmManageProducts_Load(object sender, EventArgs e)
        {
            
            // lấy các button trong panel để hightlight khi click
            GetAllButtons(this);
            // lấy tên của nhân viên khi đăng nhập
            btnHeadName.Text = FrmLogIn.StaffName;
            HandleTheMostBilling();
            // click để nó đc thu nhỏ phần ở tên khi đăng nhập
            btnHeadName_Click(sender, e);
            // phân quyền
            Console.WriteLine(FrmLogIn.Role1);
            if (FrmLogIn.Role1 == "Nhân viên")
            {
                BtnManagerStaff.Visible = false;
                btnImport.Visible = false;
                BtnStatistic.Visible = false;
                ShImport.Enabled = false;
                ShStatices.Enabled = false;
                ShStaff.Enabled = false;

            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FrmManageProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        private void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                {
                    btns.Add((Button)c);
                }
                else if (c.HasChildren)
                {
                    GetAllButtons(c);
                }
            }
        }
        private void checkClickBtn(Button btn)
        {
            foreach (Button button in btns)
            {
                if ((string)button.Tag == "btnCheck" && button.Enabled == false)
                {
                    button.BackColor = rgbDefault2;
                    button.Enabled = true;
                }
            }
            btn.Enabled = false;
            btn.BackColor = Color.White;
        }
        private void menuDropDownChildHeight(params Panel[] args )
        {
            for(int i = 1; i< args.Length; i++)
            {
                if(args[i] is Panel)
                {
                    args[i].Size = new Size(Width, 0);
                }
            }
        }
        private void LightHighlight(params Button[] args)
        {
            args[0].BackColor = Color.FromArgb(54, 209, 248);
            for(int i = 1;i< args.Length; i++)
            {
                args[i].BackColor = rgbDefault1;
            }
        }
        public Panel share()  { return palHeader; }
        public  void MessessSucced(string message , Color color)
        {
            all.messageNoticationShow(message, share(), color) ;
        }
        private Form AddFormToPanel(Form formChild , Panel panelParent)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Dispose();
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panelParent.Controls.Add(formChild);
            panelParent.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
            return formChild; 
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
        }
        private void btnManager_Click(object sender, EventArgs e)
        {
            if(palManagement.Size.Height == 0)
            {
                palManagement.Size = new Size(Width, 100);
                menuDropDownChildHeight(palManagement, palSell, palProducts, palImport, palEnd);
                LightHighlight((Button)sender ,btnSell, btnImport, btnManageProducts, btnEnd);
            }
            else palManagement.Size = new Size(Width, 0);
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (palEnd.Size.Height== 0)
            {
                palEnd.Size = new Size (Width, 150);
                menuDropDownChildHeight(palEnd, palManagement, palSell, palProducts, palImport);
                LightHighlight((Button)sender, btnSell, btnImport, btnManageProducts, btnManager );
            }
            else palEnd.Size=new Size(Width, 0);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) 
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState=FormWindowState.Normal;
        }
        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmStatistics(), palContent);
            lblHeader.Text = "Doanh thu";
        }
        private void BtnManagerStaff_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmStaff(), palContent);
            lblHeader.Text = "Quản lý nhân viên";
        }
        private void btnBillExport_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmExportBill(), palContent);
            lblHeader.Text = "Tạo hóa đơn bán hàng";
        }
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmCustomer(), palContent);
            lblHeader.Text = "Thêm/Sửa/Xóa khách hàng";
        }
        private void btnBillImport_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmImportBill(), palContent);
            lblHeader.Text = "Tạo hóa đơn nhập hàng";
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmSupplier(), palContent);
            lblHeader.Text = "Thêm/Sửa/Xóa Nhà cung cấp";
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmSearchDeleteEdit(), palContent);
            lblHeader.Text = "Sửa/Xóa/Tìm Sản phẩm";
        }
        private void BtnBrand_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmBrandAndKindOfProduct(), palContent);
            lblHeader.Text = "Loại sản phẩm / Thương hiệu";
        }
        private void PersonalBill_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmPersonalBill(), palContent);
            lblHeader.Text = "Hóa đơn cá nhân";
        }
        private void BtnInventory_Click_1(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmInventory(), palContent);
            lblHeader.Text = "Sản phẩm trong kho";
        }
        private void BtnBillAll_Click(object sender, EventArgs e)
        {
            checkClickBtn((Button)sender);
            AddFormToPanel(new FrmBillAll(), palContent);
            lblHeader.Text = "Tổng hóa đơn";
        }
        private void ShProduct_Click(object sender, EventArgs e)
        {
            checkClickBtn(btnProducts);
            AddFormToPanel(new FrmSearchDeleteEdit(), palContent);
            lblHeader.Text = "Sửa/Xóa/Tìm Sản phẩm";
        }
        private void ShStaff_Click(object sender, EventArgs e)
        {
            checkClickBtn(BtnManagerStaff);
            AddFormToPanel(new FrmStaff(), palContent);
            lblHeader.Text = "Quản lý nhân viên";
        }
        private void ShAllBill_Click(object sender, EventArgs e)
        {
            checkClickBtn(BtnBillAll);
            AddFormToPanel(new FrmBillAll(), palContent);
            lblHeader.Text = "Tổng hóa đơn";
        }
        private void ShStatices_Click(object sender, EventArgs e)
        {
            checkClickBtn(BtnStatistic);
            AddFormToPanel(new FrmStatistics(), palContent);
            lblHeader.Text = "Doanh thu";
        }
        private void ShInventory_Click(object sender, EventArgs e)
        {
            checkClickBtn(BtnInventory);
            AddFormToPanel(new FrmInventory(), palContent);
            lblHeader.Text = "Sản phẩm trong kho";
        }
        private void ShExport_Click(object sender, EventArgs e)
        {
            checkClickBtn(btnBillExport);
            AddFormToPanel(new FrmExportBill(), palContent);
            lblHeader.Text = "Tạo hóa đơn bán hàng";
        }
        private void ShImport_Click(object sender, EventArgs e)
        {
            checkClickBtn(btnBillImport);
            AddFormToPanel(new FrmImportBill(), palContent);
            lblHeader.Text = "Tạo hóa đơn nhập hàng";
        }
        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                lblHeader.Text = "HOME";
                HandleTheMostBilling();
            }
            menuDropDownChildHeight( palSell, palProducts, palManagement, palImport , palEnd);
            LightHighlight(btnImport, btnManageProducts, btnManager , btnEnd , btnBillExport);
            checkClickBtn((Button)sender);

        }
       
        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            /* panProductChild*/
            if (palProducts.Size.Height == 0)
            {
                palProducts.Size = new Size(Width, 100);
                menuDropDownChildHeight(palProducts, palManagement, palImport, palSell, palEnd);
                LightHighlight((Button)sender, btnImport, btnSell, btnManager, btnEnd);
            }
            else palProducts.Size = new Size(Width, 0);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            /*palimportProducts*/
            if (palImport.Size.Height == 0)
            {
                palImport.Size = new Size(Width, 100);
                menuDropDownChildHeight(palImport, palProducts, palManagement, palSell, palEnd);
                LightHighlight((Button)sender, btnManageProducts, btnEnd, btnSell, btnManager);
            }
            else palImport.Size = new Size(Width, 0);
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            if (palSell.Size.Height == 0)
            {
                palSell.Size = new Size(Width, 100);
                menuDropDownChildHeight(palSell, palProducts, palManagement, palImport, palEnd);
                LightHighlight((Button)sender, btnImport, btnManageProducts, btnManager, btnEnd);
            }
            else palSell.Size = new Size(Width, 0);
        }

        private void btnHeadName_Click(object sender, EventArgs e)
        {
             if(palHeader.Size.Height == 100)
            {
                palHeader.Size = new Size(Width, 220);
            }
            else
            {
                palHeader.Size = new Size(Width, 100);
            }
        }

        private void BtnChangePassWord_Click(object sender, EventArgs e)
        {
            checkClickBtn(PersonalBill);
            AddFormToPanel(new FrmPersonalBill(), palContent);
            lblHeader.Text = "Hóa đơn cá nhân";
            palHeader.Size = new Size(Width, 100);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (all.messageBox("Bạn có muốn đăng xuất không", MessageBoxButtons.YesNo))
            {
                this.Dispose();
                this.Close();
                new FrmLogIn().Visible = true;
            }
            palHeader.Size = new Size(Width, 100);
        }
    }
}
