﻿using System;
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

            cmd.Parameters.Add("@hotelId", SqlDbType.Int);
            cmd.Parameters["@hotelId"].Value = idHotel;

            cmd.Parameters.Add("@mail", SqlDbType.NChar);
            cmd.Parameters["@mail"].Value = email;

            cmd.Parameters.Add("@startDate", SqlDbType.DateTime);
            cmd.Parameters["@startDate"].Value = dateDeDebut;

            cmd.Parameters.Add("@endDate", SqlDbType.DateTime);
            cmd.Parameters["@endDate"].Value = dateDeFin;

            cmd.ExecuteScalar();
        }
    }
}