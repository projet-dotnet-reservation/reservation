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
    protected Boolean reservation = false;
    protected String villeDepart;
    protected String villeArrivee;
    protected DateTime dateDepart;
    protected DateTime dateRetour;
    protected List<RechercheVolsHotels.wsHotel.clsHotel> hotels = new List<RechercheVolsHotels.wsHotel.clsHotel>();
    protected List<RechercheVolsHotels.wsVol.clsVol> volsAllers = new List<RechercheVolsHotels.wsVol.clsVol>();
    protected List<RechercheVolsHotels.wsVol.clsVol> volsRetours = new List<RechercheVolsHotels.wsVol.clsVol>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void faites_moi_rever_Click(object sender, EventArgs e)
    {
        // Récupération des données saisies par l'utilisateur
        villeDepart = ville_depart.Text;
        villeArrivee = ville_arrivee.Text;
        Boolean datesCorrectes = true;
        try
        {
            dateDepart = Convert.ToDateTime(date_depart.Text);
            dateRetour = Convert.ToDateTime(date_retour.Text);
        }
        catch (Exception e)
        {
            datesCorrectes = false;
        }
        if (datesCorrectes)
        {
            // Modification de la page
            recherche = true;
            aller_ville_depart.Text = villeDepart;
            aller_ville_arrivee.Text = villeArrivee;
            retour_ville_depart.Text = villeArrivee;
            retour_ville_arrivee.Text = villeDepart;
            date_arrivee_hotel.Text = date_depart.Text;
            date_depart_hotel.Text = date_retour.Text;
            // Récupération des données
            volsAllers = RechercheVolsHotels.clsRecherche.rechercheVolsAvecDate(villeDepart, villeArrivee, dateDepart);
            if (volsAllers.Count != 0)
            {
                // Liste des vols allers
                vols_allers.Items.Clear();
                foreach (var volAller in volsAllers)
                {
                    ListItem item = new ListItem();
                    item.Value = "vol_aller_" + volAller.id;
                    item.Selected = volsAllers.IndexOf(volAller) == 0;
                    item.Text = "&nbsp; Départ le " + String.Format("{0:d/M/yyyy à HH:mm}", volAller.dateDepart) + " pour une arrivée le " + String.Format("{0:d/M/yyyy à HH:mm}", volAller.dateArrivee);
                    vols_allers.Items.Add(item);
                }
                // Liste des vols retours
                volsRetours = RechercheVolsHotels.clsRecherche.rechercheVolsAvecDate(villeArrivee, villeDepart, dateRetour);
                vols_retours.Items.Clear();
                if (dateRetour > dateDepart)
                {
                    foreach (var volRetour in volsRetours)
                    {
                        ListItem item = new ListItem();
                        item.Value = "vol_retour_" + volRetour.id;
                        item.Selected = volsRetours.IndexOf(volRetour) == 0;
                        item.Text = "&nbsp; Départ le " + String.Format("{0:d/M/yyyy à HH:mm}", volRetour.dateDepart) + " pour une arrivée le " + String.Format("{0:d/M/yyyy à HH:mm}", volRetour.dateArrivee);
                        vols_retours.Items.Add(item);
                    }
                }
                // Liste des hôtels
                hotels = RechercheVolsHotels.clsRecherche.rechercheHotels(villeArrivee);
                hotels_disponibles.Items.Clear();
                foreach (var hotel in hotels)
                {
                    ListItem item = new ListItem();
                    item.Value = "hotel_" + hotel.id;
                    item.Selected = hotels.IndexOf(hotel) == 0;
                    item.Text = "&nbsp; " + hotel.nom;
                    hotels_disponibles.Items.Add(item);
                }
            }
            ViewState["volsAllers"] = volsAllers;
            ViewState["volsRetours"] = volsRetours;
            ViewState["hotels"] = hotels;
            ViewState["recherche"] = recherche;
            ViewState["dateRetour"] = dateRetour;
        }
        else
        {
            erreur.Text = "Les dates doivent être au format JJ/MM/AAAA.";
        }
    }

    protected void emmenez_moi_Click(object sender, EventArgs e)
    {
        volsAllers = ((List<RechercheVolsHotels.wsVol.clsVol>)ViewState["volsAllers"]);
        volsRetours = ((List<RechercheVolsHotels.wsVol.clsVol>)ViewState["volsRetours"]);
        hotels = ((List<RechercheVolsHotels.wsHotel.clsHotel>)ViewState["hotels"]);
        dateRetour = (DateTime)ViewState["dateRetour"];

        int idVolAller = volsAllers[vols_allers.SelectedIndex].id;
        int idVolRetour = -1;
        if (volsRetours.Count != 0) idVolRetour = volsRetours[vols_retours.SelectedIndex].id;
        int idHotel = hotels[hotels_disponibles.SelectedIndex].id;
        MSMQReservation.clsReservationQueue.addResaToQueue(mail.Text, idVolAller, idVolRetour, idHotel, volsAllers[vols_allers.SelectedIndex].dateArrivee, dateRetour.AddDays(-1));
        reservation = true;
    }

}