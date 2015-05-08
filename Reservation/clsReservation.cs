using System;
using System.Collections.Generic;
using System.Text;
using System.EnterpriseServices;
using lib_ResaHotels;
using lib_ResaVols;
using System.Messaging;

namespace Reservation
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsReservation : ServicedComponent
    {
        [AutoComplete]
        public void readReservationQueue()
        {
            MessageQueue msmq = new MessageQueue(@".\private$\reservation2015");
            //récupération sans vider la file d'un message, de type ResaInfo
            msmq.Formatter = new XmlMessageFormatter(new Type[] { typeof(ResaInfo) });

            var resa = (ResaInfo)msmq.Peek().Body;

            if (createReservation(resa))
            {
                // Todo : Receive dans un autre composant ? cf. note dans la correction du TP
                Console.WriteLine("Reservation OK");
                msmq.Receive();
            }
            else
            {
                Console.WriteLine("Reservation KO");
                msmq.Close();
            }
        }

        private Boolean createReservation(ResaInfo resa)
        {
            clsResaHotels resaHotel = new clsResaHotels();
            resaHotel.sqlServeurURL = "WIN8\\SQLEXPRESS";

            clsResaVols resaVols = new clsResaVols();
            resaVols.sqlServeurURL = "WIN8\\SQLEXPRESS";

            // Todo : check values
            resaVols.reserverVol(resa.mail, resa.idVol);
            resaHotel.reserverHotel(resa.mail, resa.idHotel, resa.debutResa, resa.finResa);
            
            return true;
        }

    }
    public class ResaInfo
    {
        public String mail { get; set; }
        public int idHotel { get; set; }
        public int idVol { get; set; }
        public DateTime debutResa { get; set; }
        public DateTime finResa { get; set; }
    }
}
