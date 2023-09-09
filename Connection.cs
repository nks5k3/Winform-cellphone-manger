using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Drawing;

namespace DoAnWinformBanDienThoai
{
    internal class Connection
    {
        private static string connect = @"Data Source=NGUYENKHANHSON\SON2022;Initial Catalog=QLDIENTHOAI;Integrated Security=True";
        public static SqlConnection getConnect()
        {
            return new SqlConnection(connect);
        }
         
    }
}
