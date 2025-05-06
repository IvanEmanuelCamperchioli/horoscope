Public Class FormSubscriptions
    Private subscriptionFree As Boolean
    Private subscriptionBalance As Boolean
    Private subscriptionStar As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If subscriptionFree = True Then
            MsgBox("Ya esta subscrito a este plan, ¡puede seleccionar otro si lo desea!")
            Return
        End If
        MsgBox("¡Se ha subscrito con éxito!.")
        subscriptionFree = True
        MyBase.Hide()
    End Sub

    Private Sub OnHoverButton1(sender As Object, e As EventArgs) Handles Button1.MouseHover, Button1.Click
        ToolTipFreeSubscription.SetToolTip(Button1, "¡Gratis!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If subscriptionBalance = True Then
            MsgBox("Ya esta subscrito a este plan, ¡puede seleccionar otro si lo desea!")
            Return
        End If
        MsgBox("¡Se ha subscrito con éxito!.")
        subscriptionBalance = True
        MyBase.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If subscriptionStar = True Then
            MsgBox("Ya esta subscrito a este plan, ¡puede seleccionar otro si lo desea!")
            Return
        End If
        MsgBox("¡Se ha subscrito con éxito!.")
        subscriptionStar = True
        MyBase.Hide()
    End Sub
End Class