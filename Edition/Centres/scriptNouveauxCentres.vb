Imports System.IO
Module scriptNouveauxCentres

    Public latAperçu As String
    Public lonAperçu As String

    Public Sub carteNouveauxCentres()

        Dim sw As New StreamWriter(appdata & "cache/" & "carteNouveauxCentres.html", False, System.Text.Encoding.UTF8)


        'entête
        sw.WriteLine("<!DOCTYPE html>")
        sw.WriteLine("<html>")
        sw.WriteLine("<head>")
        sw.WriteLine("<meta charset=""utf-8""/>")
        sw.WriteLine("<link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.css"" integrity=""sha512-Rksm5RenBEKSKFjgI3a41vrjkw4EVPlJ3+OiI65vTjIdo9brlAacEuKOiQ5OFh7cOI1bkDwLqdLw3Zg0cRJAAQ=="" crossorigin="""" />")
        sw.WriteLine("<script src=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.js"" integrity=""sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw=="" crossorigin=""""></script>")


        'centrer carte
        sw.WriteLine("<script type=""text/javascript"">")

        sw.WriteLine("var lat = " & latAperçu & ";")
        sw.WriteLine("var lon = " & lonAperçu & ";")


        sw.WriteLine("var macarte = null;")


        'initialisation carte
        sw.WriteLine("function initMap() {")
        sw.WriteLine("macarte = L.map('map').setView([lat, lon], 15);")


        If renduCarte = "OSM" Then
            sw.WriteLine("L.tileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {")
            sw.WriteLine("attribution: 'Données : © OpenStreetMap/ODbL - Rendu : OSM France',")
        End If

        If renduCarte = "sat" Then
            sw.WriteLine("L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiYW50cjcyIiwiYSI6ImNqdTVncXRpODBrYjUzeW81bnBpMHpydGwifQ.MjB953HsGxS6bicFwQuYHQ', {")
            sw.WriteLine("attribution: 'Données : © OpenStreetMap/ODbL - Rendu : Mapbox',")
            sw.WriteLine("id: 'mapbox.streets-satellite',")
        End If

        sw.WriteLine("minZoom: 1,")
        sw.WriteLine("maxZoom: 20")
        sw.WriteLine("}).addTo(macarte);")






        '//// AJOUT DES MARQUEURS

        'ajouter marqueur intervention
        If latAperçu <> "" Or lonAperçu <> "" Then
            sw.WriteLine("var marker = L.marker([" & latAperçu & ", " & lonAperçu & "]).addTo(macarte)")
        End If





        'suite
        sw.WriteLine("}")
        sw.WriteLine("window.onload = function(){")
        sw.WriteLine("initMap(); ")
        sw.WriteLine("};")
        sw.WriteLine("</script>")
        sw.WriteLine("<style type=""text/css"">")
        sw.WriteLine("#map{")
        sw.WriteLine("height: 181px;")
        sw.WriteLine("margin-left:-10px;")
        sw.WriteLine("margin-top:-15px;")
        sw.WriteLine("margin-right:-10px;")
        sw.WriteLine("margin-buttom:-10px;")
        sw.WriteLine("</style>")
        sw.WriteLine("<title>Carte</title>")
        sw.WriteLine("</head>")
        sw.WriteLine("<body>")
        sw.WriteLine("<div id=""map"">")
        sw.WriteLine("</div>")
        sw.WriteLine("</body>")
        sw.WriteLine("</html>")



        sw.Close()

    End Sub

End Module
