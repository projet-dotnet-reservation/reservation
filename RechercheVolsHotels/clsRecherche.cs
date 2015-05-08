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

        public static void rechercheHotelsAndVols()
        {
            clsLireHotel clsLH = new clsLireHotel("WIN8\\SQLEXPRESS");
            List<clsHotel> hotels = clsLH.listerHotelsParVille("Nantes");

            clsLireVols clsV = new clsLireVols("WIN8\\SQLEXPRESS");
            List<clsVol> vols = clsV.listerVolsParItinéraire("Nantes", "Montpellier");


            foreach (var h in hotels)
                Console.WriteLine(h.ToString());
            foreach (var v in vols)
                Console.WriteLine(v.ToString());
            while (true) { }
        }

        public static RechercheVolsHotels.wsHotel.clsHotel[] getListeVols()
        {
            wsHotel.ServiceHotel sh = new wsHotel.ServiceHotel();
            RechercheVolsHotels.wsHotel.clsHotel[] liste;
            liste = sh.rechercheHotels("Paris");
            return liste;
            foreach (var h in liste)
                Console.WriteLine(h.nom);
            while (true) { }
        }

        public static void getListeHotels()
        {
            wsHotel.ServiceHotel sh = new wsHotel.ServiceHotel();
            RechercheVolsHotels.wsHotel.clsHotel[] liste;
            liste = sh.rechercheHotels("Paris");
            foreach (var h in liste)
                Console.WriteLine(h.nom);
            while (true) { }
        }
        
    }
}
