Public Class CTeisendi
    Implements ITeisendi

    Const KM2MI = 1.609344

    Private miilid As Double = 0


    Public Function teisendaKilomeetridMiilideks(km As Double) As Double Implements ITeisendi.teisendaKilomeetridMiilideks
        teisendaKmMi(km)
        Return miilid
    End Function

    Private Sub teisendaKmMi(ByVal km As Double)
        miilid = km / KM2MI
    End Sub
End Class
