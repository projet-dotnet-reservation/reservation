using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace lib_ResaHotels
{
    public class clsResaHotels
    {
        private String sqlServeurURL;

        public clsResaHotels(String url)
        {
            this.sqlServeurURL = url;
        }

        public void reserverHotel(String email, int idHotel, DateTime dateDeDebut, DateTime dateDeFin)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = "Data Source=" + this.sqlServeurURL + ";Initial Catalog=ResHotel;Integrated Security=True";
            co.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandText = "sp_storeReservation";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mail", SqlDbType.NChar);
            cmd.Parameters["@mail"].Value = email;

            cmd.Parameters.Add("@idHotel", SqlDbType.Int);
            cmd.Parameters["@idHotel"].Value = idHotel;

            cmd.Parameters.Add("@startDate", SqlDbType.DateTime);
            cmd.Parameters["@startDate"].Value = idHotel;

            cmd.Parameters.Add("@endDate", SqlDbType.DateTime);
            cmd.Parameters["@endDate"].Value = idHotel;

            String res = Convert.ToString(cmd.ExecuteScalar());
            if (!res.Equals(email)) throw new Exception();
        }
    }
}
