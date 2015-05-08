<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TakeMeAway.aspx.cs" Inherits="SearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>VOLOLO | Réservation de vols et d'hôtels en ligne</title>
        <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
        <link rel="stylesheet" type="text/css" href="css/page.css" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    </head>

    <body>

        <div class="container">

            <form runat="server">
                
                <!-- HEADER -->

                <div class="row">

                    <div class="header">
                        <h1><strong>Vololo</strong> <span class="glyphicon glyphicon-tree-deciduous" aria-hidden="true"></span> Réservation de vols et d'hôtels en ligne</h1>
                    </div>
            
                </div>
                
                <br />    

                <!-- DESTINATION -->

                <div class="row">

                    <div class="destination">
                     
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label for="ville_depart">Ville de départ</label>
                                <asp:TextBox ID="ville_depart" runat="server" CssClass="form-control" Text="Pyongyang"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group">
                                <label for="ville_arrivee">Ville d'arrivée</label>
                                <asp:TextBox ID="ville_arrivee" runat="server" CssClass="form-control" Text="Oulan-Bator"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group">
                                <label for="date_depart">Date de départ</label>
                                <asp:TextBox ID="date_depart" runat="server" CssClass="form-control" Text="15/12/1993"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group">
                                <label for="date_retour">Date de retour</label>
                                <asp:TextBox ID="date_retour" runat="server" CssClass="form-control" Text="23/12/1993"></asp:TextBox>
                            </div>
                        </div>

                        <br />

                        <div class="col-lg-12">
                            <asp:Button ID="faites_moi_rever" runat="server" Text="Faites-moi rêver !" CssClass="btn btn-success" OnClick="faites_moi_rever_Click" />
                        </div>

                    </div>

                </div>

                <br /><br /><br />

                <!-- RESULTAT -->

                <% if (recherche) { %>

                    <!-- VOLS ALLER -->

                    <div class="row" >

                        <h4>Vols allers de <asp:Label ID="aller_ville_depart" runat="server" Text=""></asp:Label> à <asp:Label ID="aller_ville_arrivee" runat="server" Text=""></asp:Label></h4>

                        <div class="panel panel-default results">

                            <div class="panel-body">

                                <% if (volsAllers.Count == 0) { %> 

                                    <span>Aucun vol ne nous permet de vous amener là-bas...</span>
                                    
                                <% } else if (hotels.Count == 0) { %>

                                    <span>Nous ne pouvons pas vous amener dans un endroit sans hôtel disponible...</span>

                                <% } %>

                            </div>

                        </div>

                    </div>
 
                    <!-- VOLS RETOUR -->

                    <div class="row">

                        <h4>Vols retours de <asp:Label ID="retour_ville_depart" runat="server" Text=""></asp:Label> à <asp:Label ID="retour_ville_arrivee" runat="server" Text=""></asp:Label></h4>

                        <div class="panel panel-default results">

                            <div class="panel-body">

                                <% if (volsAllers.Count == 0 || hotels.Count == 0) { %> 

                                    <span>Sans vol aller, pas de vol retour !</span>
                                    
                                <% } else if (volsRetours.Count == 0) { %>

                                    <span>Nous ne pouvons pas vous ramener chez vous, prenez un aller simple ;)</span>

                                <% } %>

                            </div>

                        </div>

                    </div>

                    <!-- HOTEL -->

                    <div class="row">

                        <h4>Hôtel pour les nuits du <asp:Label ID="date_arrivee_hotel" runat="server" Text=""></asp:Label> au <asp:Label ID="date_depart_hotel" runat="server" Text=""></asp:Label></h4>

                        <div class="panel panel-default results">

                            <div class="panel-body">

                                <% if (volsAllers.Count == 0) { %> 

                                    <span>Sans vol aller, pas d'hôtel grande classe !</span>
                                    
                                <% } else if (hotels.Count == 0) { %>

                                    <span>Nous n'avons malheureusement pas trouvé d'hôtel pour vous loger là-bas...</span>

                                <% } else { %>

                                    

                                <% } %>

                            </div>

                        </div>

                    </div>

                <% } %>

            </form>

        </div>

    </body>

</html>
