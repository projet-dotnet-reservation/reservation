using System;
using System.Collections.Generic;
using System.Text;
using Reservation;
using System.EnterpriseServices;

namespace TestServicedComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            clsReservation resa = new clsReservation();
            resa.reservation("test@test.com", 2, 2, new DateTime(2015, 1, 1), new DateTime(2015, 1, 12));
        }
    }
}
