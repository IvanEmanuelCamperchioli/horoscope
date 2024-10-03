Public Class FormMain

    Private Sub GetWeeklyPrediction(sender As Object, e As EventArgs) Handles LblWeeklyPrediction.Click
        ' implementar
    End Sub

    Private Sub OnLblMouseHover(sender As Object, e As EventArgs) Handles LblWeeklyPrediction.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub OnLblMouseLeave(sender As Object, e As EventArgs) Handles LblWeeklyPrediction.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub subscribe(sender As Object, e As EventArgs) Handles BtnSubscribe.Click
        ' Mostrar quizas cartel de que se ha subscrito con éxito
    End Sub

    Private Sub openAstralChart(sender As Object, e As EventArgs) Handles BtnAstralChart.Click
        FormAstrologicalChart.Show()
    End Sub

End Class