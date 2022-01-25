Public Class TeisendiAken
    Const KM2MI = 1.609344
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Try
            txtMiilid.Text = KilometersToMiles(txtKilomeetrid.Text)
        Catch ex As Exception
            txtMiilid.Text = "Viga!"
        End Try
    End Sub
    Private Function KilometersToMiles(ByVal km As Double) As Double
        Return km / KM2MI
    End Function
End Class
