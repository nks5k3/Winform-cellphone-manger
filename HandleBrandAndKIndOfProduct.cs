using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnWinformBanDienThoai
{
    internal class HandleBrandAndKIndOfProduct : ParentsProperties
    {
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        public DataTable render(string table)
        {
            DataTable dataTable = new DataTable();
            string query = $"select * from {table}";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(dataTable);
                connect.Close();
            }
            return dataTable;
        }
        public bool insert( string table)
        {
            SqlConnection connect = Connection.getConnect();
            string query = $"EXEC PR_insert{table} @Name , @Description ,@check OUT";
            try
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@Name", SqlDbType.NVarChar , 50).Value = name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar , 100).Value = description;
                command.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                int check = Convert.ToInt32(command.Parameters["@check"].Value.ToString());
                if (check == 0) 
                { 
                    All.messageBox("Tên này đã tồn tại !", MessageBoxButtons.OK);
                    return false;
                } 
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return true ;
        }
        public void update( string table)
        {
            SqlConnection connect = Connection.getConnect();
            string query = $"EXEC PR_update{table} @ID, @Name , @Description ";
            try
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description;
                command.ExecuteNonQuery();
            }
            catch(Exception e) { All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);}
            finally {connect.Close(); }
        }
        public void delete(string table)
        {
            SqlConnection connect = Connection.getConnect();
            string query = $"EXEC PR_delete{table} @ID ";
            try
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = Id;
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
            }
            finally
            {
                connect.Close();
            }
        }


    }

}
