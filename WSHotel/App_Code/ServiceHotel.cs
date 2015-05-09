using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using lib_LireHotels;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
// [System.Web.Script.Services.ScriptService]

public class ServiceHotel : System.Web.Services.WebService
{
    public ServiceHotel () {

        //Supprimez les marques de commentaire dans la ligne suivante si vous utilisez des composants conçus 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<clsHotel> rechercheHotels(String ville)
    {
        clsLireHotel clsLH = new clsLireHotel();
        List<clsHotel> hotels = clsLH.listerHotelsParVille(ville);
        return hotels;
    }

    [WebMethod]
    public List<clsHotel> rechercheHotelsAvecDate(String ville, DateTime debut, DateTime fin)
    {
        clsLireHotel clsLH = new clsLireHotel();
        List<clsHotel> hotels = clsLH.listerHotelsParVille(ville);
        return hotels;
    }
}