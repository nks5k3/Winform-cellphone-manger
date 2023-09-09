using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using all = DoAnWinformBanDienThoai.All;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace DoAnWinformBanDienThoai
{
    internal class HandleStatistics
    {
        SqlCommand command = new SqlCommand();
        private DateTime dateStart;
        private DateTime dateEnd;
        private string quantityProduct;
        private string quantityCustomer;
        private string totalQ;
        private string totalC;
        Color rgbDefault1 = Color.FromArgb(7, 181, 184);
        Color rgbDefault2 = Color.FromArgb(7, 105, 184);
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
        public string QuantityProduct1 { get => quantityProduct;}
        public string QuantityCustomer1 { get => quantityCustomer; }
        public string TotalC { get => totalC; }
        public string TotalQ { get => totalQ;}

        public DataTable BestSellingProduct(DateTime start, DateTime end)
        {
            DataTable tb= new DataTable();
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                string query = $"select * from FN_BestSellingProduct(@dateStart, @dateEnd)";
                command = new SqlCommand(query, connect);
                command.Parameters.Add("@dateStart", SqlDbType.DateTime).Value = start;
                command.Parameters.Add("@dateEnd", SqlDbType.DateTime).Value = end;
                SqlDataAdapter datafter = new SqlDataAdapter(command);
                datafter.Fill(tb);
                connect.Close();
            }
            return tb;
        }
        public DataTable LittleSellingProduct(DateTime start, DateTime end)
        {
            DataTable tb = new DataTable();
            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                string query = $"select * from FN_LittleSellingProduct(@dateStart,@dateEnd)";
                command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@dateStart", start);
                command.Parameters.AddWithValue("@dateEnd", end);
                command.ExecuteNonQuery();
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(tb);
                connect.Close();
            }
            return tb;
        }

        public int HandleGraphicslable(Panel PalGraphics, DateTime start , DateTime end)
        {
            int View = 0;
            // mỗi lần render ra đều phải giải phong các label cũ để tranh nó bị nằm đè lên nhau
            foreach (Control control in PalGraphics.Controls)
            {
                if (control is Label)
                {
                    PalGraphics.Controls.Clear() ;
                        control.Dispose();
                }
            }
            using (SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    string query = $"select * from FN_FilterProductBill(@startDate , @endDate)";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.Add("@startDate", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@endDate", SqlDbType.DateTime).Value = end;
                    SqlDataReader reader = command.ExecuteReader();
                    int SizeX = 40 , LocationX = 0 , LocationYQuantity , LocationYInventory ,SizeYQuantity = 0, SizeYInventory = 0;
                    while (reader.Read())
                    {
                        View += 100;
                        string name = (string)reader["Name"];
                        int quatity = (int)reader["Quantity"];
                        int inventory = (int)reader["Inventory"];

                        SizeYQuantity = (quatity);
                        SizeYInventory = (inventory);
                        LocationX += 100;
                        LocationYQuantity = PalGraphics.Size.Height - SizeYQuantity - 50;
                        LocationYInventory = PalGraphics.Size.Height - SizeYInventory - 50;
                        all.Graphicslable($"{View/100}-{name}", PalGraphics, rgbDefault1, Color.White, LocationX, PalGraphics.Size.Height - 49);
                        all.Graphicslable($"{quatity}", PalGraphics, rgbDefault2, Color.White, LocationX, LocationYQuantity, SizeX, SizeYQuantity);
                        all.Graphicslable($"{inventory}", PalGraphics, rgbDefault1, Color.White, LocationX + 40, LocationYInventory, SizeX, SizeYInventory);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    all.messageBox($"Lỗi {ex.Message}", MessageBoxButtons.OK);
                    Console.WriteLine(ex.Message);
                }
                finally { connect.Close(); }
            }
            return View;
        }


        public decimal Profit(DateTime start, DateTime end)
        {
            decimal profit = 0;
            string query = "select dbo.FN_Profit(@dateStart , @dateEnd)";

            using (SqlConnection connect = Connection.getConnect())
            {
                    connect.Open();
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.Add("@dateStart", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@dateEnd", SqlDbType.DateTime).Value = end;
                    object result = command.ExecuteScalar();
                    connect.Close();
                    profit = Convert.ToDecimal(result);
            }
                return profit; 
        }

        public decimal Statistics(DateTime start, DateTime end)
        {
            decimal Statistics = 0;
            string query = "select dbo.FN_Statistics(@dateStart , @dateEnd)";

            using (SqlConnection connect = Connection.getConnect())
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.Add("@dateStart", SqlDbType.DateTime).Value = start;
                command.Parameters.Add("@dateEnd", SqlDbType.DateTime).Value = end;
                object result = command.ExecuteScalar();
                connect.Close();
                try { 
                        Statistics = Convert.ToDecimal(result);
                }
                catch
                {
                    Statistics = 0;
                }
            }
            return Statistics;
        }

        public void Parameter(DateTime start, DateTime end)
        {
            string query = "exec PR_parameter @dateStart , @dateEnd , @qP out ,@cP out , @TotalQ out , @TotalC out ";
            using(SqlConnection connect = Connection.getConnect())
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.Add("@dateStart", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@dateEnd", SqlDbType.DateTime).Value = end;
                    command.Parameters.Add("@qP", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@cP", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@TotalQ", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@TotalC", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    quantityProduct = command.Parameters["@qP"].Value.ToString();
                    quantityCustomer = command.Parameters["@cP"].Value.ToString();
                    totalQ = command.Parameters["@TotalQ"].Value.ToString();
                    totalC = command.Parameters["@TotalC"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"loic ,{ ex.Message}");
                }finally { connect.Close(); }
            }
        }


    }
}
