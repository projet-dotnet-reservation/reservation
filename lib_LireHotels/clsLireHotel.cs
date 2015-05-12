using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using lib_Config;

namespace lib_LireHotels
{
    public class clsLireHotel
    {

        public List<clsHotel> listerHotelsParVille(String ville)
        {

            SqlConnection co = new SqlConnection();
            co.ConnectionString = clsConfig.readConfigString("connectBDHotel");//"Data Source=LAPTOP\\SQLEXPRESS; Initial Catalog=HOTEL; Integrated Security=True";
            co.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandText = "sp_findByCity";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@city", SqlDbType.NChar);
            cmd.Parameters["@city"].Value = ville;

            SqlDataReader reader = cmd.ExecuteReader();
            return clsHotel.fromReader(reader);
        }

    }
    public class clsHotel
    {
        public int id;
        public String nom;
        public String ville;
        public DateTime debutDispo;
        public DateTime finDispo;

        public static List<clsHotel> fromReader(SqlDataReader reader)
        {
            List<clsHotel> liste = new List<clsHotel>();

            while (reader.Read())
            {
                Object[] values = new Object[reader.FieldCount];
                reader.GetValues(values);
                clsHotel h = new clsHotel();

                h.id = Convert.ToInt16(values[0]);
                h.nom = values[1].ToString();
                h.ville = values[2].ToString();
                if (!(values[3] is DBNull))
                    h.debutDispo = Convert.ToDateTime(values[3]);
                if (!(values[4] is DBNull))
                    h.finDispo = Convert.ToDateTime(values[4]);

                liste.Add(h);
            }
 
            return liste;
        }

        override
        public String ToString()
        {
            return "" + this.id + " - " + this.nom + " - " + this.ville + " - " + this.debutDispo + " - " + this.finDispo + System.Environment.NewLine;
        }
    }
}
