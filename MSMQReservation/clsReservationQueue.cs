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
            ResaInfo resa = new ResaInfo();
            resa.mail = mail;
            resa.idVol = Convert.ToString(idVol);
            resa.idHotel = Convert.ToString(idHotel);
            resa.debutResa = debutResa.ToShortDateString();
            resa.finResa = finResa.ToShortDateString();

            MessageQueue msmq = new MessageQueue(@".\private$\reservation2015");
            msmq.Send(resa, "Reservation client : " + resa.mail);
            msmq.Close();
        }
    }

    public class ResaInfo {
        public String mail { get; set; }
        public String idHotel { get; set; }
        public String idVol { get; set; }
        public String debutResa { get; set; }
        public String finResa { get; set; }
    }
}
