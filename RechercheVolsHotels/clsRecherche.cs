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

        public static void rechercheHotels()
        {
            clsLireHotel clsLH = new clsLireHotel("LAPTOP\\SQLEXPRESS");
            List<clsHotel> hotels = clsLH.lireHotels("Nantes");


            foreach (var h in hotels)
                Console.WriteLine(h.ToString());
            while (true) { }
        }
    }
}
