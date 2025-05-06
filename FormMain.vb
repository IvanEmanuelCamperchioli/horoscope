Public Class FormMain

    Private emails As String() = {"gmail.com", "hotmail.com", "outlook.com", "yahoo.com"}
    Private TextBoxEmailPristine = True
    Private subscribed As Boolean

    Private Sub GetWeeklyPrediction(sender As Object, e As EventArgs) Handles LblWeeklyPrediction.Click
        ValidateThenOpenForm(FormSubscriptions)
    End Sub

    Private Sub OpenAstralChart(sender As Object, e As EventArgs) Handles BtnAstralChart.Click
        ValidateThenOpenForm(FormAstrologicalChart)
    End Sub

    Private Sub ValidateThenOpenForm(ByRef form As Object)
        If subscribed = False Then
            MsgBox("Por favor, ingrese su correo electrónico primero para personalizar sus intereses")
        Else
            form.Show()
        End If
    End Sub

    Private Sub OnLblMouseHover(sender As Object, e As EventArgs) Handles LblWeeklyPrediction.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub OnLblMouseLeave(sender As Object, e As EventArgs) Handles LblWeeklyPrediction.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub subscribe(sender As Object, e As EventArgs) Handles BtnSubscribe.Click
        If validEmail() = True Then
            MsgBox("¡Se ha subscrito con éxito! Recibirá las últimas novedades y noticias sobre astrología")
            subscribed = True
        Else
            MsgBox("El texto proporsionado no cumple las condiciones de un correo electrónico.")
        End If
    End Sub

    Private Function validEmail()
        Return TextBoxEmail.Text.Contains("@") AndAlso emails.Contains(TextBoxEmail.Text.Split("@")(1))
    End Function

    Private Sub OnTextBoxEmailClicked(sender As Object, e As EventArgs) Handles TextBoxEmail.Click
        If TextBoxEmailPristine = True Then
            TextBoxEmail.Text = ""
            TextBoxEmail.ForeColor = Color.Black
            TextBoxEmailPristine = False
        End If
    End Sub
End Class