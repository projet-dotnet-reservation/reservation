using System;
using System.Collections.Generic;
using System.Text;
using System.Messaging;

namespace MSMQReservation
{
    public class clsReservationQueue
    {
        public void addResaToQueue(String mail, int idHotel, int idVol, DateTime debutResa, DateTime finResa)
        {
            ResaItem resa = new ResaItem();
            resa.mail = mail;

            resa.idVol = idVol;
            

            MessageQueue msmq = new MessageQueue(@".\private$\reservation2015");
            msmq.Send(resa, "Reservation client : " + resa.mail);
            msmq.Close();
        }
    }

    public class ResaItem {
        public String mail { get; set; }
        public int idHotel { get; set; }
        public int idVol { get; set; }
        public DateTime debutResa { get; set; }
        public DateTime finResa { get; set; }
    }
}
