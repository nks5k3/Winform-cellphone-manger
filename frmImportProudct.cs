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
    public partial class frmImportProudct : Form
    {
        private string _pName;
        private string _pKindOfProduct;
        private string _pBrand;
        private string _pNewTime;
        private int _pGuarantee;
        private string _pMake;
        private string _pPrice;
        private string _pDescription;
        private string _pColor;
        public frmImportProudct()
        {
            InitializeComponent();
        }
        public frmImportProudct(string names)
        {
           
            Console.WriteLine(names);
        }
       

        private void frmImportProudcts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(_pName );
        }
    }
}
