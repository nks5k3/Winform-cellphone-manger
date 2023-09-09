using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinformBanDienThoai
{
    internal class ParentsProperties
    {
        protected string id;
        protected string name;
        protected string address;
        protected string email;
        protected int phone;
        protected DateTime date;
        protected string description;
        protected int cCCD;
        protected decimal price;
        protected int quantity;
        public int Phone { get => phone; set => phone = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public int CCCD { get => cCCD; set => cCCD = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public DataTable searchList(string table, string condition, string key)
        {
            DataTable dataTable = new DataTable();
            string query = $"select * from View{table} where freetext( View{table}.[{condition}] , '{key}') or View{table}.[{condition}] like '%{key}%'";
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                SqlDataAdapter data = new SqlDataAdapter(query, connect);
                data.Fill(dataTable);
                connect.Close();
            }
            return dataTable;
        }
    }
}
