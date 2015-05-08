using System;
using System.Collections.Generic;
using System.Text;
using MSMQReservation;
using Reservation;
using System.EnterpriseServices;

namespace TestServicedComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            clsReservationQueue resaQueue = new clsReservationQueue();
            for (var i = 1; i < 11; i++)
            {
                resaQueue.addResaToQueue("test@test.com", i, 10-i, new DateTime(2015, i, i), new DateTime(2015, i, i + 4));
            }

            for (var i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                clsReservation resaServ = new clsReservation();
                resaServ.readReservationQueue();
                Console.WriteLine("Read message i");
            }
        }
    }
}
