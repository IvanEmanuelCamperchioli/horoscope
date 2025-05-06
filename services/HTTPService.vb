Imports System.IO
Imports System.Net

Public Class HTTPService
    Private Const timeout As Integer = 10000

    Public Function DoGetRequest(ByVal URL As String) As String
        Dim data As String
        Try
            Dim req As HttpWebRequest = DirectCast(HttpWebRequest.Create(URL), HttpWebRequest)
            req.Method = "GET"
            req.Accept = "*/*"
            req.ContentType = "application/json"
            req.Timeout = timeout
            req.Referer = URL
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType) 'TLS 1.2

            Using res As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Console.WriteLine(CType(res, HttpWebResponse).StatusDescription)
                Using responseStream As Stream = res.GetResponseStream()
                    If responseStream IsNot Nothing Then
                        Using reader As New StreamReader(responseStream)
                            data = reader.ReadToEnd()
                            Return data
                        End Using
                    Else
                        Throw New ApplicationException("Flujo de respuesta vacío.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Ocurrió un error: " + ex.Message())
        End Try
    End Function

    Public Function SendPostRequest(ByVal URL As String, ByRef body As String) As String
        Dim data As String
        Try
            Dim req As HttpWebRequest = DirectCast(HttpWebRequest.Create(URL), HttpWebRequest)
            req.Method = "POST"
            req.Accept = "*/*"
            req.ContentType = "application/json"
            req.Timeout = timeout
            req.KeepAlive = True
            req.Referer = URL

            Using streamWriter = New StreamWriter(req.GetRequestStream())
                streamWriter.Write(body)
            End Using

            Dim httpResponse = CType(req.GetResponse(), HttpWebResponse)

            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                data = streamReader.ReadToEnd()
            End Using
            Return data
        Catch ex As Exception
            Throw New ApplicationException("Ocurrió un error: " + ex.Message())
        End Try
    End Function

End Class
