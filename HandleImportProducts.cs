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
    internal class HandleImportProducts : ParentsProperties
    {
        SqlCommand command;
        private string account;
        private string customer;
        private string bill;
        private int idsp;
        private decimal totalBill;
        public string Account { get => account; set => account = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Bill { get => bill; set => bill = value; }
        public int Idsp { get => idsp; set => idsp = value; }
        public decimal TotalBill { get => totalBill; set => totalBill = value; }
        public void insert()
        {
            // insert order
            string query = $"EXEC PR_insertIMPORT @Account , @Supplier ,@BillID OUT";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@Account", SqlDbType.VarChar).Value = account;
                    command.Parameters.Add("@Supplier", SqlDbType.VarChar).Value = customer;
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
        /*public void deleteBIll(string table , string ID ,string id)
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
        public void insertBillIMPORT()
        {
            string query = $"Exec PR_insertIMPORTDETAIL @id , @idsp , @quantity , @price , @totalbill";
            using(SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    command.Parameters.Add("@idsp", SqlDbType.Int).Value = idsp;
                    command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@totalbill", SqlDbType.Decimal).Value = totalBill;
                    command.ExecuteReader();
                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
                }finally { connect.Close(); }
            }
        }

        public void insertEXPORTDETAIL()
        {
            string query = $"Exec PR_insertEXPORTDETAIL @id , @idsp , @quantity , @price , @totalbill";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    command.Parameters.Add("@idsp", SqlDbType.Int).Value = idsp;
                    command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                    command.Parameters.Add("@totalbill", SqlDbType.Decimal).Value = totalBill;
                    command.ExecuteReader();
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
