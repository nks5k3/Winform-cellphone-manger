using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace DoAnWinformBanDienThoai
{
    internal class HandleExportProducts : ParentsProperties
    {
        SqlCommand command;
        private string account;
        private string customer;
        private string bill;
        private int idsp;
        private decimal totalBill;
        private decimal discount;
        private decimal VAT;

        public string Account { get => account; set => account = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Bill { get => bill; set => bill = value; }
        public int Idsp { get => idsp; set => idsp = value; }
        public decimal TotalBill { get => totalBill; set => totalBill = value; }
        public decimal Discount { get => discount; set => discount = value; }
        public decimal VAT1 { get => VAT; set => VAT = value; }

        public void insert()
        {
            string query = $"EXEC PR_insertBILL @Account , @CustomerID , @Total , @Discount , @Description  ,@BillID OUT";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@Account", SqlDbType.VarChar).Value = account;
                    command.Parameters.Add($"@CustomerID", SqlDbType.VarChar).Value = customer;
                    command.Parameters.Add($"@Total", SqlDbType.Decimal).Value = totalBill;
                    command.Parameters.Add($"@Discount", SqlDbType.Decimal).Value = discount;
                    command.Parameters.Add($"@Description", SqlDbType.NVarChar,100).Value = description;
                    command.Parameters.Add("@BillID", SqlDbType.VarChar, 6).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    bill = command.Parameters["@BillID"].Value.ToString();
                    if(bill == null)
                    {
                        All.messageBox("lỗi", MessageBoxButtons.OK);
                    }
                }
                catch (Exception e)
                {
                    All.messageBox($"Lỗi {e.Message}",MessageBoxButtons.OK);
                    Console.WriteLine(e.Message);
                }
                finally { connect.Close(); }
            }
        }
       /* public void deleteBIll(string table , string ID ,string id)
        {
            string query = $"delete {table} where {ID} = '{id}'";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
                }
            }
        }*/
        public void insertBillEXPORT()
        {
            string query = $"Exec PR_insertBILLDETAIL @BillID , @ProductID , @Quantity , @Price , @check out";
            using(SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@BillID", SqlDbType.VarChar).Value = id;
                    command.Parameters.Add("@ProductID", SqlDbType.Int).Value = idsp;
                    command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.ExecuteReader();

                    int.TryParse(command.Parameters["@check"].Value.ToString() , out int check);
                    if (check == 0)
                    {
                        All.messageBox("Số lượng trong kho không đủ", MessageBoxButtons.OK);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
                }
                finally { connect.Close(); }
            }
        }
    }
}
