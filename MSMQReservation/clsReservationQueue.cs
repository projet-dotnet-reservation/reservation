using System;
using System.Collections.Generic;
using System.Text;
using System.Messaging;

namespace MSMQReservation
{
    public class clsReservationQueue
    {
        public static void addResaToQueue(String mail, int idVolAller, int idVolRetour, int idHotel, DateTime debutResa, DateTime finResa)
        {
            ResaInfo resa = new ResaInfo();
            resa.mail = mail;
            resa.idVolAller = Convert.ToString(idVolAller);
            resa.idVolRetour = idVolRetour == -1 ? null : Convert.ToString(idVolRetour);
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
        public String idVolAller { get; set; }
        public String idVolRetour { get; set; }
        public String idHotel { get; set; }
        public String debutResa { get; set; }
        public String finResa { get; set; }
    }
}
