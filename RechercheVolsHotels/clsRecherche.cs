using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib_LireHotels;
using lib_LireVols;


namespace RechercheVolsHotels
{
    public class clsRecherche
    {


        public static wsVol.clsVol[] rechercheVols(String villeDepart, String villeArrivee)
        {
            wsVol.ServiceVol sv = new wsVol.ServiceVol();
            wsVol.clsVol[] liste;
            liste = sv.rechercheVols(villeArrivee, villeArrivee);
            return liste;
        }

        public static wsVol.clsVol[] rechercheVolsAvecDate(String villeDepart, String villeArrivee, DateTime dateDepart)
        {
            wsVol.ServiceVol sv = new wsVol.ServiceVol();
            wsVol.clsVol[] liste;
            liste = sv.rechercheVolsAvecDate(villeArrivee, villeArrivee, dateDepart);
            return liste;
        }


        public static wsHotel.clsHotel[] rechercheHotels(String ville)
        {
            wsHotel.ServiceHotel sh = new wsHotel.ServiceHotel();
            RechercheVolsHotels.wsHotel.clsHotel[] liste;
            liste = sh.rechercheHotels(ville);
            return liste;
        }

        public static wsHotel.clsHotel[] rechercheHotelsAvecDate(String ville, DateTime debut, DateTime fin)
        {
            wsHotel.ServiceHotel sh = new wsHotel.ServiceHotel();
            RechercheVolsHotels.wsHotel.clsHotel[] liste;
            liste = sh.rechercheHotelsAvecDate(ville, debut, fin);
            return liste;
        }
    }
}
