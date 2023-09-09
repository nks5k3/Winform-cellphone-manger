using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnWinformBanDienThoai
{
    internal class HandleSupplier : ParentsProperties
    {
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        private string Representative;
        public string Representative1 { get => Representative; set => Representative = value; }
        public DataTable render(string table)
        {
            DataTable dataTable = new DataTable();
            string query = $"select * from View{table}";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(dataTable);
                connect.Close();
            }
            return dataTable;
        }
        public bool insert(string table)
        {
            SqlConnection connect = Connection.getConnect();
            string query = $"EXEC PR_insert{table} @NameCompany,@Phone , @Address ,@Representative ,@Email ,@Description , @check out ";
            try
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@NameCompany", SqlDbType.NVarChar , 50).Value = Name ;
                command.Parameters.Add("@Phone", SqlDbType.Int).Value = Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar , 50).Value = Address ;
                command.Parameters.Add("@Representative", SqlDbType.NVarChar , 50).Value = Representative ;
                command.Parameters.Add("@Email", SqlDbType.VarChar ,50).Value = Email;
                command.Parameters.Add("@Description", SqlDbType.NVarChar,100).Value = Description;
                command.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                int.TryParse(command.Parameters["@check"].Value.ToString(), out int check);
                if (check == 0)
                {
                    All.messageBox("Khách hàng này đã tồn tại !", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
                All.messageBox("Lỗi", MessageBoxButtons.OK);
            } finally { connect.Close();}
            return true;
        }
        public bool update(string table)
        {
            SqlConnection connect = Connection.getConnect();
            string query = $"EXEC PR_update{table} @ID,  @NameCompany,@Phone , @Address ,@Representative ,@Email ,@Description ";
            try
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@ID", SqlDbType.VarChar , 6).Value = id;
                command.Parameters.Add("@NameCompany", SqlDbType.NVarChar , 50).Value = Name;
                command.Parameters.Add("@Address", SqlDbType.NVarChar , 50).Value = Address;
                command.Parameters.Add("@Phone", SqlDbType.Int).Value = Phone;
                command.Parameters.Add("@Representative", SqlDbType.NVarChar , 50).Value = Representative;
                command.Parameters.Add("@Email", SqlDbType.VarChar , 50).Value = Email;
                command.Parameters.Add("@Description", SqlDbType.NVarChar , 100).Value = Description;
                command.ExecuteNonQuery();
            } catch (Exception e)
            {
                Console.WriteLine( e.Message);
                All.messageBox("Lỗi", MessageBoxButtons.OK); 
                return false;
            } finally { connect.Close(); }
            return true;
        }
        public void delete(string table)
        {
            SqlConnection connect = Connection.getConnect();
            string query = $"EXEC PR_delete{table} @ID ";
            try
            {
                connect.Open();
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();
            }
            catch { All.messageBox("Lỗi", MessageBoxButtons.OK); } finally { connect.Close(); }
        }

       
    }
}
