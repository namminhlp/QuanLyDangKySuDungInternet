using System;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class dbConnection
    {
        /*
       // protected SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database\QLDKSDI.mdf"";Integrated Security=True");
        // protected SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\namminhlp\Documents\Visual Studio 2015\Projects\QuanLyDangKySuDungInternet\DAO\QLDKSDI.mdf;Integrated Security = True; Connect Timeout = 30");
        public static object QLDKSDI { get; private set; }

        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSVI41J\SQLEXPRESS;Initial Catalog=QLDKSDI;Integrated Security=True;");   

        protected void openConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        protected void closeConnection()
        {
            conn.Close();
        }
        public DataTable getData(string sqlCommand)
        {
            DataTable dt = new DataTable();

            // Khỏi tạo adapter để kết nối bảng dữ liệu và truy vấn câu lệnh
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, conn); 

            //Mở kết nối
            openConnection();

            //Lấy dữ liệu vào bảng (biến dt)
            adapter.Fill(dt);

            closeConnection();
            return dt;
        }
        */
    }
}
