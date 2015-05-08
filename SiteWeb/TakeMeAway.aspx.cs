using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RechercheVolsHotels;

public partial class SearchForm : System.Web.UI.Page
{

    protected Boolean recherche = false;
    protected List<RechercheVolsHotels.wsHotel.clsHotel> hotels = new List<RechercheVolsHotels.wsHotel.clsHotel>();
    protected List<RechercheVolsHotels.wsVol.clsVol> volsAllers = new List<RechercheVolsHotels.wsVol.clsVol>();
    protected List<RechercheVolsHotels.wsVol.clsVol> volsRetours = new List<RechercheVolsHotels.wsVol.clsVol>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void faites_moi_rever_Click(object sender, EventArgs e)
    {
        // Récupération des données saisies par l'utilisateur
        String villeDepart = ville_depart.Text;
        String villeArrivee = ville_arrivee.Text;
        DateTime dateDepart = Convert.ToDateTime(date_depart.Text);
        DateTime dateArrivee = Convert.ToDateTime(date_retour.Text);
        // Modification de la page
        recherche = true;
        aller_ville_depart.Text = villeDepart;
        aller_ville_arrivee.Text = villeArrivee;
        retour_ville_depart.Text = villeArrivee;
        retour_ville_arrivee.Text = villeDepart;
        date_arrivee_hotel.Text = date_depart.Text;
        date_depart_hotel.Text = date_retour.Text;
        // Récupération des données
    }
}