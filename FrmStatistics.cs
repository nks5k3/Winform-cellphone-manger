using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using all = DoAnWinformBanDienThoai.All;

namespace DoAnWinformBanDienThoai
{
    public partial class FrmStatistics : Form
    {
        HandleStatistics handle =  new HandleStatistics();
        DateTime dateNow = DateTime.Now;
        public FrmStatistics()
        {
            InitializeComponent();
        }
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            handle.HandleGraphicslable(PalGraphics, dateNow.Date, dateNow);
        }

        private void HandleRenderData(DateTime start , DateTime end)
        {
            LblTImer.Text = $" từ ngày: {start} -- đến ngày: {end}";
            int k = handle.HandleGraphicslable(PalGraphics, start, end);
            LblWidthScroll.Size = new Size(k, 5);

            DGVMost.DataSource = handle.BestSellingProduct(start, end);
            DGVLittle.DataSource = handle.LittleSellingProduct(start, end);

            Txtprofit.Text =  handle.Profit(start, end).ToString();
            TxtTotalMoney.Text = handle.Statistics(start  , end).ToString();
            all.VNĐ(Txtprofit);
            all.VNĐ(TxtTotalMoney);

            handle.Parameter(start, end);
            LblQuantity.Text = handle.QuantityProduct1;
            LblQuantityCustomer.Text = handle.QuantityCustomer1;
            lblTotalC.Text = handle.TotalC;
            lblTotalQ.Text = handle.TotalQ;
            LblProducts.Text = handle.QuantityProduct1; 
            lblCustomer.Text = handle.QuantityCustomer1;
        }
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DateTime start = DTStart.Value;
            DateTime end = DTEnd.Value;
            HandleRenderData(start, end);
        }
        private void BtnMenuDown_Click(object sender, EventArgs e)
        {
            if(PalMenuDown.Visible == false) PalMenuDown.Visible = true;
            else PalMenuDown.Visible = false;
        }
        private void BtnToday_Click(object sender, EventArgs e)
        {
            DateTime today = dateNow.Date;
            HandleRenderData(today, dateNow);
        }
        private void BtnLast30day_Click(object sender, EventArgs e)
        {
            DateTime dateLast30 = dateNow.AddDays(-30);
            HandleRenderData(dateLast30, dateNow);
        }
        private void BtnThisMonth_Click(object sender, EventArgs e)
        {
            DateTime monthNow = new DateTime(dateNow.Year, dateNow.Month, 1);
            HandleRenderData(monthNow, dateNow);
        }
        private void BtnThisYear_Click(object sender, EventArgs e)
        {
            DateTime yearNow = new DateTime(dateNow.Year, 1, 1);
            HandleRenderData(yearNow, dateNow);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
