Public Class TeisendiAken
    Const KM2MI = 1.609344
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Try
            txtMiilid.Text = txtKilomeetrid.Text / KM2MI
        Catch ex As Exception
            MsgBox("Viga!")
        End Try


    End Sub
End Class
