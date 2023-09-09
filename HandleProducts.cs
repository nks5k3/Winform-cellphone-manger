using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinformBanDienThoai
{
    internal class HandleProducts:ParentsProperties
    {
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        private string kindOf;
        private string brand;
        private int guarantee;

        public string KindOf { get => kindOf; set => kindOf = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Guarantee { get => guarantee; set => guarantee = value; }

        public DataTable render(string table )
        {
            DataTable datatable = new DataTable();
            string query = $"select * from ViewPRODUCTS";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(datatable);
                connect.Close();
            }
            return datatable;
        }
        public DataTable render1(string table)
        {
            DataTable datatable = new DataTable();
            string query = $"select ProductID , Name from PRODUCTS";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(datatable);
                connect.Close();
            }
            return datatable;
        }
        /*public static DataTable ReturnNameProducts(string table)
        {
            SqlDataAdapter dataAdapter;
            DataTable datatable = new DataTable();
            string query = $"select p.Name  from {table} p";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(datatable);
                connect.Close();
            }
            return datatable;
        }*/
        public bool insert(string table)
        {
            string query = $"EXEC PR_insert{table} @name , @kindOf , @brand , @dateOfProduction , @guarantee , @price , @des , @check out";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query , connect);
                    command.Parameters.Add("@name", SqlDbType.NVarChar , 50).Value = name;
                    command.Parameters.Add("@kindOf", SqlDbType.VarChar , 6).Value = kindOf;
                    command.Parameters.Add("@brand", SqlDbType.VarChar,6).Value = brand;
                    command.Parameters.Add("@dateOfProduction", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@guarantee", SqlDbType.Int).Value = guarantee;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = Price;
                    command.Parameters.Add("@des", SqlDbType.NVarChar , 100).Value = description;
                    command.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    int.TryParse(command.Parameters["@check"].Value.ToString(), out int check);
                    if (check == 0)
                    {
                        All.messageBox("Tên sản phẩm đã tồn tại !", MessageBoxButtons.OK);
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                finally { connect.Close(); }
            }
            return true;
        }
        public bool update(string table)
        {
            string query = $"EXEC PR_update{table} @id , @name , @kindOf , @brand , @dateOfProduction , @guarantee , @price , @des";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@kindOf", SqlDbType.VarChar).Value = kindOf;
                    command.Parameters.Add("@brand", SqlDbType.VarChar).Value = brand;
                    command.Parameters.Add("@dateOfProduction", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@guarantee", SqlDbType.Int).Value = guarantee;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = Price;
                    command.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
                    Console.WriteLine( e.Message);
                    return false;
                }
                finally { connect.Close(); }
            }
            return true;
        }
        public void delete(string table)
        {
            string query = $"EXEC PR_delete{table} @ID";
            using(SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
                }
                finally { connect.Close(); }
            }
        }
    }
}
