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
            MessageQueue msmq = new MessageQueue(@"FormatName:Direct=OS:WIN8\private$\reservation2015");
            //récupération sans vider la file d'un message, de type ResaInfo
            msmq.Formatter = new XmlMessageFormatter(new Type[] { typeof(ResaInfo) });
            
            ResaInfo resa = (ResaInfo)msmq.Peek().Body;
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
            //resaHotel.sqlServeurURL = urlServer;

            clsResaVols resaVols = new clsResaVols();
            //resaVols.sqlServeurURL = urlServer;

            // Todo : check values
            resaVols.reserverVol(resa.mail, Convert.ToInt16(resa.idVolAller));
            if (resa.idVolRetour != null)
                resaVols.reserverVol(resa.mail, Convert.ToInt16(resa.idVolRetour));
            resaHotel.reserverHotel(resa.mail, Convert.ToInt16(resa.idHotel), Convert.ToDateTime(resa.debutResa), Convert.ToDateTime(resa.finResa));
            
            return true;
        }

    }
    public class ResaInfo
    {
        public String mail { get; set; }
        public String idVolAller { get; set; }
        public String idVolRetour { get; set; }
        public String idHotel { get; set; }
        public String debutResa { get; set; }
        public String finResa { get; set; }
    }
}
