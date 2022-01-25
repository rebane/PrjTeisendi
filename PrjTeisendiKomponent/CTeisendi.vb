Public Class CTeisendi
    Implements ITeisendi

    Const KM2MI = 1.609344

    Private miilid As Double = 0


    Public Function teisendaKilomeetridMiilideks(km As Double) As Double Implements ITeisendi.teisendaKilomeetridMiilideks
        miilid = km / KM2MI
        Return miilid
    End Function
End Class
