Public Class Form1
    ' Constants for mod prices
    Const EnginePrice As Double = 8000
    Const SuspensionPrice As Double = 2000
    Const ExhaustPrice As Double = 800
    Const WheelsPrice As Double = 1500

    ' Function to calculate total price based on selected mods
    Shared Function CalculateTotalPrice(ByVal engineMod As Boolean, ByVal suspensionMod As Boolean, ByVal exhaustMod As Boolean, ByVal wheelsMod As Boolean) As Double
        Dim totalPrice As Double = 0

        If engineMod Then
            totalPrice += EnginePrice
        End If

        If suspensionMod Then
            totalPrice += SuspensionPrice g
        End If

        If exhaustMod Then
            totalPrice += ExhaustPrice
        End If

        If wheelsMod Then
            totalPrice += WheelsPrice
        End If

        Return totalPrice
    End Function

    ' Event handler for when Calculate button is clicked
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs)
        ' Check which mods are selected
        Dim engineMod As Boolean = chkEngine.Checked
        Dim suspensionMod As Boolean = chkSuspension.Checked
        Dim exhaustMod As Boolean = chkExhaust.Checked
        Dim wheelsMod As Boolean = chkWheels.Checked

        ' Calculate total price
        Dim totalPrice As Double = CalculateTotalPrice(engineMod, suspensionMod, exhaustMod, wheelsMod)

        ' Display total price
        lblTotalPrice.Text = "Total Price: $" & totalPrice.ToString("0.00")
    End Sub
End Class
