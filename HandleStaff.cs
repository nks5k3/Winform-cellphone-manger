using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinformBanDienThoai
{
    internal class HandleStaff : ParentsProperties
    {
        private string account;
        private string password;
        private string passwordOld;
        private string Role;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public string Role1 { get => Role; set => Role = value; }
        public int CCCD1 { get => CCCD; set => CCCD = value; }
        public string PasswordOld { get => passwordOld; set => passwordOld = value; }

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
            string query = $"EXEC PR_insert{table} @Account,@Password , @name ,@phone ,@cccd ,@address, @Email ,@Birthday ,@Role ,@Description , @check OUT";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@Account", SqlDbType.VarChar , 30).Value = account;
                    command.Parameters.Add("@Password", SqlDbType.VarChar , 30).Value = password;
                    command.Parameters.Add("@name", SqlDbType.NVarChar , 50).Value = name;
                    command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                    command.Parameters.Add("@cccd", SqlDbType.Int).Value = CCCD;
                    command.Parameters.Add("@address", SqlDbType.NVarChar , 50).Value = address;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@Role", SqlDbType.NVarChar, 50).Value = Role;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar , 100).Value = description;
                    command.Parameters.Add("@check", SqlDbType.Int).Direction  = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    int.TryParse(command.Parameters["@check"].Value.ToString(), out int check);
                    if (check == 0) 
                    { 
                        All.messageBox ("Tài khoản này đã tồn tại !", MessageBoxButtons.OK);
                        return false;
                    }
                }
                catch (Exception e) {All.messageBox($"Lỗi {e.Message}!", MessageBoxButtons.OK);}
                finally{connect.Close();}
                return true;
            }
        }
        public bool update(string table)
        {
            string query = $"EXEC PR_update{table} @Account,@Password ,@name ,@phone ,@cccd ,@address, @Email ,@Birthday ,@Role ,@Description";
            using (SqlConnection conect = Connection.getConnect())
            {
                try
                {
                    conect.Open();
                    command = new SqlCommand(query, conect);
                    command.Parameters.Add("@Account", SqlDbType.VarChar).Value = account;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                    command.Parameters.Add("@cccd", SqlDbType.Int).Value = CCCD;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = Role;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description;
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    All.messageBox($"Lỗi {e.Message}!", MessageBoxButtons.OK);
                    return false;
                }
                finally { conect.Close(); }
            }
            return true;
        }
        public void delete(string table)
        {
            string query = $"EXEC PR_delete{table} @Account";
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@Account", SqlDbType.VarChar).Value = account;
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    All.messageBox($"Lỗi {e.Message}", MessageBoxButtons.OK);
                }
                finally { connect.Close(); }
            }
        }
        public bool OnChangePassword()
        {
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    string query = "EXEC PR_OnChangePassWord @account , @passwordOld , @passwordNew , @check OUT";
                    connect.Open();
                    command = new SqlCommand(query, connect);
                    command.Parameters.Add("@account", SqlDbType.VarChar ).Value = account;
                    command.Parameters.Add("@passwordOld", SqlDbType.VarChar).Value = PasswordOld;
                    command.Parameters.Add("@passwordNew", SqlDbType.VarChar).Value = password;
                    command.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();

                    int.TryParse(command.Parameters["@check"].Value.ToString(), out int check);
                    if (check == 1) return true;
                    else if(check == 0) return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Lỗi {e.Message}");
                    All.messageBox($"Lỗi {e.Message}" , MessageBoxButtons.OK);
                    return false;
                }
                finally { connect.Close (); }
            }
            return false;
        }
    }
}
