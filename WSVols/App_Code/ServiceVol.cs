using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using lib_LireVols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
// [System.Web.Script.Services.ScriptService]

public class ServiceVol : System.Web.Services.WebService
{
    public ServiceVol()
    {

        //Supprimez les marques de commentaire dans la ligne suivante si vous utilisez des composants conçus 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<clsVol> rechercheVols(String villeDepart, String villeArrivee)
    {
        clsLireVols clsLV = new clsLireVols("KILLIAN\\SQLEXPRESS");
        List<clsVol> vols = clsLV.listerVolsParItinéraire(villeDepart, villeArrivee);
        return vols;
    }

    [WebMethod]
    public List<clsVol> rechercheVolsAvecDate(String villeDepart, String villeArrivee, DateTime dateDepart)
    {
        clsLireVols clsLV = new clsLireVols("KILLIAN\\SQLEXPRESS");
        List<clsVol> vols = clsLV.listerVolParItineraireEtDate(villeDepart, villeArrivee, dateDepart);
        return vols;
    }
}