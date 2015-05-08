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
            clsResaHotels resaHotel = new clsResaHotels("ServURL");
            clsResaVols resaVols = new clsResaVols("ServURL");

            // Todo : check values
            resaVols.reserverVol(mail, idVol);
            resaHotel.reserverHotel(mail, idHotel, debutResa, finResa);

            return true;
        }

    }
}
