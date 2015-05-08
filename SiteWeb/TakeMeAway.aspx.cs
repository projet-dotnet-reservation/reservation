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
    private RechercheVolsHotels.wsHotel.clsHotel hotelSelectionne;
    protected List<RechercheVolsHotels.wsVol.clsVol> volsAllers = new List<RechercheVolsHotels.wsVol.clsVol>();
    private RechercheVolsHotels.wsVol.clsVol volAllerSelectionne;
    protected List<RechercheVolsHotels.wsVol.clsVol> volsRetours = new List<RechercheVolsHotels.wsVol.clsVol>();
    private RechercheVolsHotels.wsVol.clsVol volRetourSelectionne;

    protected int check = 10;

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
        /* volsAllers = RechercheVolsHotels.clsRecherche.rechercheVolsAvecDate(villeDepart, villeArrivee, dateDepart);
        if (volsAllers.Count != 0)
        {
            // Liste des vols allers
            foreach (var volAller in volsAllers) {
                ListItem item = new ListItem();
                item.Value = "vol_aller_" + volAller.id;
                item.Selected = volsAllers.IndexOf(volAller) == 0;
                item.Text = "Départ le " + String.Format("{0:d/M/yyyy à HH:mm}", volAller.dateDepart) + "<br />"
                    + "Arrivée le " + String.Format("{0:d/M/yyyy à HH:mm}", volAller.dateArrivee);
                vols_allers.Items.Add(item);
            }
            // Liste des vols retours
            volsRetours = RechercheVolsHotels.clsRecherche.rechercheVolsAvecDate(villeArrivee, villeDepart, dateDepart.AddDays(1));
            foreach (var volRetour in volsRetours)
            {
                ListItem item = new ListItem();
                item.Value = "vol_retour_" + volRetour.id;
                item.Selected = volsRetours.IndexOf(volRetour) == 0;
                item.Text = "Départ le " + String.Format("{0:d/M/yyyy à HH:mm}", volRetour.dateDepart) + "<br />"
                    + "Arrivée le " + String.Format("{0:d/M/yyyy à HH:mm}", volRetour.dateArrivee);
                vols_retours.Items.Add(item);
            }
            // Liste des hôtels
            hotels = RechercheVolsHotels.clsRecherche.rechercheHotels(villeArrivee);
            foreach (var hotel in hotels)
            {
                ListItem item = new ListItem();
                item.Value = "vol_aller_" + hotel.id;
                item.Selected = hotels.IndexOf(hotel) == 0;
                item.Text = hotel.nom;
                vols_retours.Items.Add(item);
            }
        } */
    }

    protected void emmenez_moi_Click(object sender, EventArgs e)
    {
        
    }
}