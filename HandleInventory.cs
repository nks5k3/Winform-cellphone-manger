using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinformBanDienThoai
{
    internal class HandleInventory
    {
        SqlDataAdapter dataAdapter;/*
        SqlCommand command;*/
        private string query;
        public DataTable render(string table)
        {
            DataTable dt = new DataTable();
            query = $"Select * from View{table}";
            using(SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(dt);
                connect.Close();
            }
            return dt;
        }

        public DataTable InventoryFilter(string brand , string kindofproduct)
        {
            DataTable dt = new DataTable();
            query = $"Select * from FN_InventoryFilter('{brand}' , '{kindofproduct}')";
            using(SqlConnection connect =  Connection.getConnect()) 
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(dt);
                connect.Close();
            }
            return dt;
        }
        public DataTable InventoryFilterQuantity(int start , int end)
        {
            DataTable dt = new DataTable();
            query = $"Select * from FN_InventoryFilterQuantity('{start}' , '{end}')";
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
