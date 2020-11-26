using System.Data.SqlClient;
using System.Data;

namespace karaoke
{
    public class QuanLyKaraokeDB
    {
        static string strConnect = @"Data Source=.;Initial Catalog=QuanLyKARAOKE;Integrated Security=True";
        SqlConnection sqlCon;         
        SqlCommand sqlCom;
        DataTable dt;

        public void Connect()
        {
            sqlCon = new SqlConnection(strConnect);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        public void Close()
        {
            sqlCon.Close();
        }

        public void Execute(string strSQL)
        {
            Connect();
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            Close();

        }

        public DataTable GetData(string strSQL)
        {
            SqlDataAdapter DA;
            dt = new DataTable();
            Connect();
            DA = new SqlDataAdapter(strSQL, sqlCon);
            DA.Fill(dt);
            Close();
            return dt;
        }
    }
}