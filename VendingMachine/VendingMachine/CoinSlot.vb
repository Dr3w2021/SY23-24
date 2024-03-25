Public Class CoinSlot
    Public Property Quarters As Integer
    Public Property Dimes As Integer
    Public Property Nickels As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Nickels * 0.05 + Dimes * 0.1 + Quarters * 0.25 + Dollars
        End Get
    End Property
    Public Sub InsertQuarter()
        Quarters += 1
    End Sub
    Public Sub InsertDime()
        Dimes += 1
    End Sub
    Public Sub InsertNickel()
        Nickels += 1
    End Sub
    Public Sub InsertDollar()
        Dollars += 1
    End Sub
End Class
