Public Class TeisendiAken
    Const KM2MI = 1.609344
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox("Easter egg")
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

    Private Sub timerKell_Tick(sender As Object, e As EventArgs) Handles timerKell.Tick
        lblKell.Text = DateTime.Now()
    End Sub

    Private Sub TeisendiAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerKell.Interval = 2000
        timerKell.Enabled = True
        ' timerKell.Start()
    End Sub

    Private Sub SulgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SulgeToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
