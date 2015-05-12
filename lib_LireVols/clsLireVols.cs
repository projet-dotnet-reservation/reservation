using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using lib_Config;

namespace lib_LireVols
{
    public class clsLireVols
    {

        public List<clsVol> listerVolsParItinéraire(String villeDepart, String villeArrivee)
        {
            SqlConnection co = new SqlConnection();
            //co.ConnectionString = ConfigurationManager.ConnectionStrings["connecBaseVol"].ConnectionString;
            co.ConnectionString = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=VOL;Integrated Security=True";//clsConfig.readConfigString("connectBDVol");
            co.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandText = "sp_findByRoute";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@departure", SqlDbType.NChar);
            cmd.Parameters["@departure"].Value = villeDepart;

            cmd.Parameters.Add("@arrival", SqlDbType.NChar);
            cmd.Parameters["@arrival"].Value = villeArrivee;

            SqlDataReader reader = cmd.ExecuteReader();
            return clsVol.fromReader(reader);
        }

        public List<clsVol> listerVolParItineraireEtDate(String villeDepart, String villeArrivee, DateTime dateDepart)
        {
            SqlConnection co = new SqlConnection();
            //co.ConnectionString = ConfigurationManager.ConnectionStrings["connecBaseVol"].ConnectionString;
            co.ConnectionString = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=VOL;Integrated Security=True"; //clsConfig.readConfigString("connectBDVol");
            co.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandText = "sp_findByRouteAndDeparture";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@departure", SqlDbType.NChar);
            cmd.Parameters["@departure"].Value = villeDepart;

            cmd.Parameters.Add("@arrival", SqlDbType.NChar);
            cmd.Parameters["@arrival"].Value = villeArrivee;

            cmd.Parameters.Add("@date", SqlDbType.DateTime);
            cmd.Parameters["@date"].Value = dateDepart;

            SqlDataReader reader = cmd.ExecuteReader();
            return clsVol.fromReader(reader);
        }
    }

    public class clsVol 
    {
        public int id;
        public String villeDepart;
        public String villeArrivee;
        public DateTime dateDepart;
        public DateTime dateArrivee;

         public static List<clsVol> fromReader(SqlDataReader reader) 
         {
            List<clsVol> liste = new List<clsVol>();

            while (reader.Read())
            {
                Object[] values = new Object[reader.FieldCount];
                reader.GetValues(values);
                clsVol v = new clsVol();

                v.id = Convert.ToInt16(values[0]);
                v.villeDepart = values[1].ToString();
                v.villeArrivee = values[2].ToString();
                if (!(values[3] is DBNull))
                    v.dateDepart = Convert.ToDateTime(values[3]);
                if (!(values[4] is DBNull))
                   v.dateArrivee = Convert.ToDateTime(values[4]);

                liste.Add(v);
            }
 
            return liste;
        }

        override
         public String ToString()
         {
             return "Vols : " + this.id + " - " + this.villeDepart + " - " + this.villeArrivee + " - " + this.dateDepart + " - " + this.dateArrivee + System.Environment.NewLine;
         }
    }
}
