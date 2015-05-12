using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.EnterpriseServices;

namespace lib_ResaVols
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsResaVols : ServicedComponent
    {
        //public String sqlServeurURL;

        [AutoComplete]
        public void reserverVol(String email, int idVol)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=ResVol;Integrated Security=True";
            co.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandText = "sp_storeReservation";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mail", SqlDbType.NChar);
            cmd.Parameters["@mail"].Value = email;

            cmd.Parameters.Add("@idVol", SqlDbType.Int);
            cmd.Parameters["@idVol"].Value = idVol;

            cmd.ExecuteScalar();
        }
    }
}
