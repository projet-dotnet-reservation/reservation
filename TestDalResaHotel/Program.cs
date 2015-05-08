using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib_ResaHotels;

namespace TestDalResaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            clsResaHotels resa = new clsResaHotels("WINDOWS\\MYSQLSERVER");
            resa.reserverHotel("remyferre@laposte.fr", 1, new DateTime(2015, 1, 1), new DateTime(2015, 1, 15));
            Console.WriteLine("done");
        }
    }
}
