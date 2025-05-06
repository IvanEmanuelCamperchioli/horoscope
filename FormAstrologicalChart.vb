Imports Predicciones.Location
Imports Newtonsoft.Json

Public Class FormAstrologicalChart
    Private HttpService As HTTPService = New HTTPService
    Private Const URL_LOCATIONS = "http://apis.datos.gob.ar/georef/api/provincias"
    Private locations As Location
    Private Const URL_LOCALITIES = "http://apis.datos.gob.ar/georef/api/localidades?provincia="
    Private localities As Locality
    Private lat As Single
    Private lon As Single
    Private placeOfBirth As String
    Private Const localitiesReqParams As String = "&campos=nombre,centroide&max=1000"
    Private Const TxtBoxFirstNameTooltipCaption As String = "Mínimo 3 caracteres."
    Private Const TxtBoxLastNameTooltipCaption As String = "Solo letras y espacios."

    Private Sub OnFormLoad(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBoxLocationItems()
        LoadComboBoxHoursItems()
    End Sub

    Private Sub LoadComboBoxHoursItems()
        Dim hours = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

        For I As Integer = 0 To hours.Count - 1
            If I < 12 Then
                CBoxHours.Items.Add(GetHour(hours(I).ToString(), " am"))
            Else
                CBoxHours.Items.Add(GetHour(hours(I).ToString(), " pm"))
            End If
        Next
    End Sub

    Private Function GetHour(ByVal hour As String, ByVal sufix As String)
        If hour.Count() < 2 Then
            Return "0" + hour + sufix
        Else
            Return hour + sufix
        End If
    End Function

    Private Sub OnLocationSelected(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles CBoxLocations.SelectedIndexChanged
        LblLocationSelectedMsg.ResetText()
        LblLatLonMsg.ResetText()
        CBoxLocalities.ResetText()
        LoadLocalitiesByProvince(URL_LOCALITIES, CBoxLocations.SelectedItem.ToString())
        LblLocality.Show()
    End Sub

    Private Sub OnLocalitySelected(
        sender As Object,
        e As EventArgs) Handles CBoxLocalities.SelectedIndexChanged
        placeOfBirth = CBoxLocalities.SelectedItem.ToString() _
            + ", " _
            + CBoxLocations.SelectedItem.ToString()
        LblLocationSelectedMsg.Text = "Lugar de nacimiento seleccionado: " _
            + placeOfBirth

        For Each locality As Localities In localities.localidades
            If locality.nombre = CBoxLocalities.SelectedItem.ToString() Then
                lat = locality.centroide.lat
                lon = locality.centroide.lon
                LblLatLonMsg.Text = "Latitud / Longitud: " _
                    + locality.centroide.lat.ToString() _
                    + " " _
                    + locality.centroide.lon.ToString()
            End If
        Next
    End Sub

    Private Sub LoadComboBoxLocationItems()
        locations = JsonConvert _
            .DeserializeAnonymousType(Of Location)(HttpService.DoGetRequest(URL_LOCATIONS), New Location)
        locations.provincias = locations.provincias.OrderBy(Function(loc) loc.nombre).ToList()
        For Each province As Province In locations.provincias
            CBoxLocations.Items.Add(province.nombre)
        Next
    End Sub

    Private Sub LoadLocalitiesByProvince(ByRef BASE_URL As String, ByRef province As String)
        Dim URL As String = BASE_URL + province + localitiesReqParams
        If CBoxLocalities.Items.Count > 0 Then
            CBoxLocalities.Items.Clear()
        End If
        localities = JsonConvert _
           .DeserializeAnonymousType(Of Locality)(HttpService.DoGetRequest(URL), New Locality)
        localities.localidades = localities.localidades.OrderBy(Function(loc) loc.nombre).ToList()
        For Each locality As Localities In localities.localidades
            CBoxLocalities.Items.Add(locality.nombre)
        Next
        CBoxLocalities.Show()
    End Sub

    Private Sub OnSubmit(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If ValidForm() = True Then
            If MsgBox(
              "Se enviarán los datos proporcionados para obtener su carta astral",
              1) = MsgBoxResult.Ok Then
                MyClass.Hide()
                Dim date_ As String() = DateTimePicker.Text.Split("/")
                Dim hour_ As String = FormatTime(Hour(CBoxHours.Text).ToString())
                Dim minutes As String = NumericUpDown.Value.ToString()
                Dim time As String = hour_ + ":" + FormatTime(minutes)
                FormAstrologicalChartResult.SetBirthDataObj(FormatDate(date_), time, lat, lon, placeOfBirth)
                FormAstrologicalChartResult.firstName = TxtBoxFirstName.Text
                FormAstrologicalChartResult.lastName = TxtBoxLastName.Text
                FormAstrologicalChartResult.Show()
                OnCleanForm(Nothing, EventArgs.Empty)
            End If
        Else
            MsgBox("Por favor, verifique que todos los datos esten ingresados correctamente.")
        End If
    End Sub

    Private Function FormatTime(ByRef time As String) As String
        Return If(time.Length = 1, "0" + time, time)
    End Function

    Private Function FormatDate(ByRef date_ As String()) As String
        Dim dateStr As String = String.Empty
        For i As Integer = date_.Length - 1 To 0 Step -1
            If i > 0 Then
                dateStr &= If(date_(i).Length = 1, "0" + date_(i) + "-", date_(i) + "-")
            Else
                dateStr &= date_(i)
            End If
        Next
        Return dateStr
    End Function

    Private Function ValidForm() As Boolean
        Return TxtBoxFirstName.Text.Count() > 2 And
        TxtBoxLastName.Text.Count() > 2 And
        CBoxHours.SelectedItem IsNot Nothing And
        CBoxLocations.SelectedItem IsNot Nothing And
        CBoxLocalities.SelectedItem IsNot Nothing
    End Function

    Private Sub OnCleanForm(sender As Object, e As EventArgs) Handles BtnClean.Click
        TxtBoxFirstName.Clear()
        TxtBoxLastName.Clear()
        DateTimePicker.ResetText()
        CBoxHours.ResetText()
        NumericUpDown.ResetText()
        CBoxLocations.ResetText()
        CBoxLocalities.ResetText()
        CBoxLocalities.Hide()
        LblLocationSelectedMsg.ResetText()
        LblLocality.Hide()
        LblLatLonMsg.ResetText()
    End Sub

    Private Sub OnTxtBoxFirstNameClicked(
        sender As Object,
        e As EventArgs) Handles TxtBoxFirstName.Click
        TooltipFirstName.SetToolTip(TxtBoxFirstName, TxtBoxFirstNameTooltipCaption)
    End Sub

    Private Sub TxtBoxLastNameClicked(
        sender As Object,
        e As EventArgs) Handles TxtBoxLastName.Click
        TooltipLastName.SetToolTip(TxtBoxLastName, TxtBoxLastNameTooltipCaption)
    End Sub
End Class

