using System;
using System.Collections.Generic;
using System.Text;
using System.EnterpriseServices;
using lib_ResaHotels;
using lib_ResaVols;

namespace Reservation
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsReservation : ServicedComponent
    {
        [AutoComplete]
        public Boolean reservation(String mail, int idVol, int idHotel, DateTime debutResa, DateTime finResa)
        {
            clsResaHotels resaHotel = new clsResaHotels();
            resaHotel.sqlServeurURL = "WIN8\\SQLEXPRESS";

            clsResaVols resaVols = new clsResaVols();
            resaVols.sqlServeurURL = "WIN8\\SQLEXPRESS";

            // Todo : check values
            resaVols.reserverVol(mail, idVol);
            resaHotel.reserverHotel(mail, idHotel, debutResa, finResa);

            return true;
        }

    }
}
