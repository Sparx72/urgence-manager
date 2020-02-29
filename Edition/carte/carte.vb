Imports System.IO
Module carte

    Public renduCarte As String = "Google"

    Public latInter As String
    Public lonInter As String
    Public zoom As Integer = 13

    Public lonSMURC15 As String
    Public latSMURC15 As String
    Public descriptionSMURC15 As String

    Public lonSMUR2 As String
    Public latSMUR2 As String
    Public descriptionSMUR2 As String

    Public lonSMUR3 As String
    Public latSMUR3 As String
    Public descriptionSMUR3 As String

    Public lonSMUR4 As String
    Public latSMUR4 As String
    Public descriptionSMUR4 As String

    Public lonSMUR5 As String
    Public latSMUR5 As String
    Public descriptionSMUR5 As String

    Public lonSMUR6 As String
    Public latSMUR6 As String
    Public descriptionSMUR6 As String

    Public lonSMUR7 As String
    Public latSMUR7 As String
    Public descriptionSMUR7 As String

    Public lonSMUR8 As String
    Public latSMUR8 As String
    Public descriptionSMUR8 As String

    Public lonSMUR9 As String
    Public latSMUR9 As String
    Public descriptionSMUR9 As String

    Public lonSMUR10 As String
    Public latSMUR10 As String
    Public descriptionSMUR10 As String

    Public Sub cartevide()









        Dim sw As New StreamWriter(appdata & "cache/" & "carte.html", False, System.Text.Encoding.UTF8)


        'entête
        sw.WriteLine("<!DOCTYPE html>")
        sw.WriteLine("<html>")
        sw.WriteLine("<head>")
        sw.WriteLine(<meta http-equiv="X-UA-Compatible" content="IE=edge"/>)
        sw.WriteLine("<meta charset=""utf-8""/>")
        sw.WriteLine("<link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.css"" integrity=""sha512-Rksm5RenBEKSKFjgI3a41vrjkw4EVPlJ3+OiI65vTjIdo9brlAacEuKOiQ5OFh7cOI1bkDwLqdLw3Zg0cRJAAQ=="" crossorigin="""" />")
        sw.WriteLine("<script src=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.js"" integrity=""sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw=="" crossorigin=""""></script>")
        sw.WriteLine("<script type=""text/javascript"" src=""https://maps.google.com/maps/api/js?key=AIzaSyCTIn22N0OJ6j4PjvTkqi8ROqN_XhKZUyQ""></script>")
        sw.WriteLine("<script type=""text/javascript"" src='https://unpkg.com/leaflet.gridlayer.googlemutant@latest/Leaflet.GoogleMutant.js'></script>")


        'centrer carte
        sw.WriteLine("<script type=""text/javascript"">")

        Dim latDefaut As String = "48.833"
        Dim lonDefaut As String = "2.333"

        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat") <> "" And Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon") <> "" Then

            latDefaut = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat")
            lonDefaut = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon")

        End If



        If latInter <> "" And lonInter <> "" Then
            sw.WriteLine("var lat = " & latInter & ";")
            sw.WriteLine("var lon = " & lonInter & ";")
            sw.WriteLine("var zoom = " & zoom & ";")
        Else
            sw.WriteLine("var lat = " & latDefaut & ";")
            sw.WriteLine("var lon = " & lonDefaut & ";")
            sw.WriteLine("var zoom = " & zoom & ";")
        End If


        sw.WriteLine("var macarte = null;")


        'initialisation carte
        sw.WriteLine("function initMap() {")
        sw.WriteLine("macarte = L.map('map').setView([lat, lon], zoom);")


        sw.WriteLine("var roads = L.gridLayer.googleMutant({ type: 'hybrid' }).addTo(macarte);")


        



        '//// AJOUT DES ICONES



        'icone appel
        sw.WriteLine("var iconeAppel = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/14/6/1554554988-emergencyphone.png',")
        sw.WriteLine("iconSize: [32, 37] });")





        If game.modeInter = True Then

            '//// AJOUT DES MARQUEURS

            'ajouter marqueur intervention
            If latInter <> "" Or lonInter <> "" Then
                sw.WriteLine("var marker = L.marker([" & latInter & ", " & lonInter & "]).addTo(macarte)")
                ',{icon: iconeAppel}
                sw.WriteLine(".bindPopup('<b>Appel</b>');")
            End If


        End If









        'script pour afficher les coordonnées
        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick") = "oui" Then
            sw.WriteLine("var popup = L.popup();")
            sw.WriteLine("function onMapClick(e) {")
            sw.WriteLine("popup")
            sw.WriteLine(".setLatLng(e.latlng)")
            sw.WriteLine(".setContent(""Coordonnées GPS : "" + e.latlng.toString())")
            sw.WriteLine(".openOn(macarte);")
            sw.WriteLine("}")
            sw.WriteLine("macarte.on('click', onMapClick);")
        End If







        'suite
        sw.WriteLine("}")
        sw.WriteLine("window.onload = function(){")
        sw.WriteLine("initMap(); ")
        sw.WriteLine("};")
        sw.WriteLine("</script>")
        sw.WriteLine("<style type=""text/css"">")
        sw.WriteLine("#map{")
        sw.WriteLine("height:" & game.WebBrowser1.Height + 7 & "px;")
        sw.WriteLine("margin-left:-10px;")
        sw.WriteLine("margin-top:-15px;")
        sw.WriteLine("margin-right:-10px;")
        sw.WriteLine("margin-buttom:-10px;")
        sw.WriteLine("background-color:black;")
        sw.WriteLine("</style>")
        sw.WriteLine("<title>Carte</title>")
        sw.WriteLine("</head>")
        sw.WriteLine("<body>")
        sw.WriteLine("<div id=""map"">")
        sw.WriteLine("</div>")
        sw.WriteLine("</body>")
        sw.WriteLine("</html>")



        sw.Close()

        game.WebBrowser1.Navigate(appdata & "cache/" & "carte.html")




    End Sub

End Module
