using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinformBanDienThoai
{
    internal class HandleAllBill : ParentsProperties
    {
        SqlDataAdapter dataAdapter;
        /*SqlCommand Command;*/
        private string query;
        public DataTable render(string table)
        {
            DataTable dt = new DataTable();
            query = $"Select * from ViewBill{table} order by ViewBill{table}.[Mã hóa đơn] DESC";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(dt);
                connect.Close();
            }
            return dt;
        }
    }
}
