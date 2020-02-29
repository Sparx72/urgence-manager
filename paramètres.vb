Public Class paramètres

    Private Sub paramètres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'résolution
        ComboBox1.Text = Screen.PrimaryScreen.Bounds.Width.ToString() & "x" & Screen.PrimaryScreen.Bounds.Height.ToString()
        ComboBox2.Text = Screen.PrimaryScreen.DeviceName
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class