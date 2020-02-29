Public Class chargementForm


    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Timer1.Enabled = False
        Me.Close()

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False
        Me.Close()
        home.TimerPlayerDown.Enabled = True

    End Sub
End Class