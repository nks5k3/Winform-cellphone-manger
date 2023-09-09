using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using all = DoAnWinformBanDienThoai.All;
namespace DoAnWinformBanDienThoai
{
    public partial class FrmLogIn : Form
    {
        private static string staffName;
        private static string Acount;
        private static string Role;
        public static string StaffName { get => staffName;  }
        public static string Acount1 { get => Acount; }
        public static string Role1 { get => Role; }
        public FrmLogIn()
        {
            InitializeComponent();
        }
        private void frmLogIn_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')txtPassword.PasswordChar = char.MinValue;
            else txtPassword.PasswordChar = '*';
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(All.messageBox("Bạn có muốn thoát không" , MessageBoxButtons.YesNo))
            {
                Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string tk = txtAccount.Text.ToString();
            string mk = txtPassword.Text.ToString();
            string query = "EXEC PR_checkLogin @Account , @Password  , @name OUT ,@role OUT";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.Add("@Account", SqlDbType.VarChar).Value = tk;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = mk;
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@role", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    staffName = command.Parameters["@name"].Value.ToString();
                    Role = command.Parameters["@role"].Value.ToString();
                    Acount = tk;
                    if (!string.IsNullOrEmpty(staffName))
                    {
                        FrmManageProducts frm = new FrmManageProducts();
                        frm.Show();
                        this.Visible = false;
                        all.messageNoticationShow("Đăng nhập thành công", frm.share(), Color.Green);
                    }
                    else{all.messageNoticationShow("Sai tài khoản hoặc mật khẩu!", palLogIn, Color.Red);}
                }
                catch{all.messageNoticationShow("Không thể kết nối server!", palLogIn, Color.Red);}
                finally { connect.Close(); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            all.checkError(txtAccount, errCheck, palAccount);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            all.checkError(txtPassword, errCheck, palPassword);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void txtAccount_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, txtPassword, null);
        }
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            all.enterTextBox(e, btnLogin, txtAccount);
        }
        private void FrmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (All.messageBox("Bạn có muốn thoát không", MessageBoxButtons.YesNo) == true)
            {
                // Ngăn chặn việc đóng form nếu người dùng không muốn
                Console.WriteLine("Form đang được đóng...");
                this.Dispose();
            }
            else
            {
                // Thực hiện các xử lý cần thiết trước khi form được đóng
                e.Cancel = true;
                Console.WriteLine("Form chuea dong");
            }
        }
    }
}
