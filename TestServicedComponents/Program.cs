using System;
using System.Collections.Generic;
using System.Text;
using MSMQReservation;
using Reservation;
using lib_LireHotels;
using lib_LireVols;
using System.EnterpriseServices;

namespace TestServicedComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            clsLireHotel lireHotels = new clsLireHotel();
            clsLireVols lireVols = new clsLireVols();
            if (lireHotels.listerHotelsParVille("Nantes").Count > 0) Console.WriteLine("Recherche Hotel : OK");
            if (lireVols.listerVolsParItinéraire("Nantes", "Montpellier").Count > 0) Console.WriteLine("Recherche Vol : OK");
            
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine("Ajout résa N°" + i + " à la message queue");
                clsReservationQueue.addResaToQueue("test@test.com", i, -1, 10 - i, new DateTime(2015, i, i), new DateTime(2015, i, i + 4));
            }

            for (var i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                clsReservation resaServ = new clsReservation();
                resaServ.readReservationQueue();
                Console.WriteLine("Enregistrement réservation N°"+i+ ": OK");
            }
        }
    }
}
