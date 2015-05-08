using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib_LireHotels;
using lib_LireVols;
using System.Configuration;


namespace RechercheVolsHotels
{
    public class clsRecherche
    {


        public static List<wsVol.clsVol> rechercheVols(String villeDepart, String villeArrivee)
        {
            wsVol.ServiceVol sv = new wsVol.ServiceVol();
            wsVol.clsVol[] liste = sv.rechercheVols(villeArrivee, villeArrivee);
            return new List<wsVol.clsVol>(liste);
        }

        public static List<wsVol.clsVol> rechercheVolsAvecDate(String villeDepart, String villeArrivee, DateTime dateDepart)
        {
            wsVol.ServiceVol sv = new wsVol.ServiceVol();
            wsVol.clsVol[] liste = sv.rechercheVolsAvecDate(villeArrivee, villeArrivee, dateDepart);
            return new List<wsVol.clsVol>(liste);
        }


        public static List<wsHotel.clsHotel> rechercheHotels(String ville)
        {
            wsHotel.ServiceHotel sh = new wsHotel.ServiceHotel();
            wsHotel.clsHotel[] liste  = sh.rechercheHotels(ville);
            return new List<wsHotel.clsHotel>(liste);
        }

        public static List<wsHotel.clsHotel> rechercheHotelsAvecDate(String ville, DateTime debut, DateTime fin)
        {
            wsHotel.ServiceHotel sh = new wsHotel.ServiceHotel();
            wsHotel.clsHotel[] liste = sh.rechercheHotelsAvecDate(ville, debut, fin);
            return new List<wsHotel.clsHotel>(liste);
        }

        private static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = Properties.Settings.Default.TEST ?? "Not Found";
                Console.WriteLine(result);
                while(true) {}
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                while (true) { }
            }
        }

    }
}
