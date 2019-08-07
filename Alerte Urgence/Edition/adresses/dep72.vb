Module dep72

    Public Sub adresses72()



        'Intervention dans habitation

        If typeAdresseAppel = "maison" Then



            Randomize()
            Dim random As New Random(), rndnbr As Integer
            rndnbr = random.Next(1, 2)


            If rndnbr = 1 Then
                villeAppel = "Ruaudin"
                adresseAppel = "13 Rue des Fauvettes"
                latitudeAppel = "47.946534"
                longitudeAppel = "0.269412"
            End If

        End If

    End Sub


End Module
