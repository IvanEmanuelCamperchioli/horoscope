Imports System.Net
Imports System.IO
Imports predicciones.Location
Imports Newtonsoft.Json

Public Class FormAstrologicalChart
    Const URL_LOCATIONS = "http://apis.datos.gob.ar/georef/api/provincias"
    Dim locations As Location

    Private Sub OnFormLoad(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBoxItems()
    End Sub

    Private Sub OnLocationSelected(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles LocationsSelect.SelectedIndexChanged
        Label4.Text = "Usted a seleccionado: " + LocationsSelect.SelectedItem.ToString()
    End Sub

    Private Function DoGetRequest(ByVal URL As String) As String
        Dim data As String
        Try
            Dim req As HttpWebRequest = DirectCast(HttpWebRequest.Create(URL), HttpWebRequest)
            req.Method = "GET"
            req.Accept = "*/*"
            req.ContentType = "application/json"
            req.KeepAlive = True
            req.Timeout = 10000
            req.Referer = URL
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            Using res As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Console.WriteLine(CType(res, HttpWebResponse).StatusDescription)
                Using responseStream As Stream = res.GetResponseStream()
                    If responseStream IsNot Nothing Then
                        Using reader As New StreamReader(responseStream)
                            data = reader.ReadToEnd()
                            Return data
                        End Using
                    Else
                        Throw New ApplicationException("Flujo de respuesta está vacío.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Ocurrió un error: " + ex.Message())
        End Try
    End Function

    Private Sub LoadComboBoxItems()
        locations = JsonConvert _
            .DeserializeAnonymousType(Of Location)(DoGetRequest(URL_LOCATIONS), New Location)
        For Each province As Province In locations.provincias
            LocationsSelect.Items.Add(province.nombre)
        Next
    End Sub

    Private Sub OnSubmit(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If MsgBox("¿Va a obtener la información de su carta astral, desea continuar?", 1) = MsgBoxResult.Ok Then
            ' implementar
        End If
    End Sub
End Class

