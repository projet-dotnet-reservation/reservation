using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using RechercheVolsHotels.wsVol;
using RechercheVolsHotels.wsHotel;
using lib_Config;


namespace RechercheVolsHotels
{
    public class clsRecherche
    {

        public static List<clsVol> rechercheVols(String villeDepart, String villeArrivee)
        {
            ServiceVol sv = new ServiceVol();
            clsVol[] liste = sv.rechercheVols(villeDepart, villeArrivee);
            return new List<clsVol>(liste);
        }

        public static List<clsVol> rechercheVolsAvecDate(String villeDepart, String villeArrivee, DateTime dateDepart)
        {
            ServiceVol sv = new ServiceVol();
            clsVol[] liste = sv.rechercheVolsAvecDate(villeDepart, villeArrivee, dateDepart);
            return new List<clsVol>(liste);
        }


        public static List<clsHotel> rechercheHotels(String ville)
        {
            ServiceHotel sh = new ServiceHotel();
            clsHotel[] liste  = sh.rechercheHotels(ville);
            return new List<clsHotel>(liste);
        }

        public static List<clsHotel> rechercheHotelsAvecDate(String ville, DateTime debut, DateTime fin)
        {
            ServiceHotel sh = new ServiceHotel();
            clsHotel[] liste = sh.rechercheHotelsAvecDate(ville, debut, fin);
            return new List<clsHotel>(liste);
        }

    }
}
