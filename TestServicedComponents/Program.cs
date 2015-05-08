using System;
using System.Collections.Generic;
using System.Text;
using MSMQReservation;
using System.EnterpriseServices;

namespace TestServicedComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            clsReservationQueue resaQueue = new clsReservationQueue();
            resaQueue.addResaToQueue("test@test.com", 2, 2, new DateTime(2015, 1, 1), new DateTime(2015, 1, 12));
        }
    }
}
