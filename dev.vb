Imports System.IO
Public Class dev


    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        End
    End Sub

    Private Sub FlatCheckBox1_CheckedChanged(ByVal sender As System.Object) Handles FlatCheckBox1.CheckedChanged
        If FlatCheckBox1.Checked = True Then
            FlatButton2.Visible = True
        Else
            FlatButton2.Visible = False
        End If
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        Me.Close()
    End Sub
End Class