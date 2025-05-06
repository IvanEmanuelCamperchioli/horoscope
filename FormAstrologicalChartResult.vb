Imports System.Threading
Imports Newtonsoft.Json

Public Class FormAstrologicalChartResult
    Private HttpService As HTTPService = New HTTPService
    Dim birthDataObj As BirthDataObj
    Dim astrologicalReport As AstrologicalReport
    Public firstName As String
    Public lastName As String
    Private Const URL_ASTRO = "https://authorityastrology.com/api/astro-gpt"

    Private Sub FormAstrologicalChartResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerProcessing.Start()
        TableLayoutProcessing.Show()
    End Sub

    Private Sub OnTickTimerProcessing() Handles TimerProcessing.Tick
        GetAstrologicalReport()
    End Sub

    Public Sub SetBirthDataObj(
        ByRef date_ As String,
        ByRef time As String,
        ByRef lat As Single,
        ByRef lon As Single,
        ByRef place As String)
        Me.birthDataObj = New BirthDataObj
        birthDataObj.birthData = New BirthData
        birthDataObj.birthData.birthDate = date_
        birthDataObj.birthData.birthTime = time
        birthDataObj.birthData.birthLatitude = lat
        birthDataObj.birthData.birthLongitude = lon
        birthDataObj.birthData.placeOfBirth = place
    End Sub

    Private Sub GetAstrologicalReport()
        Dim jsonBody As String = JsonConvert.SerializeObject(Me.birthDataObj)
        astrologicalReport = JsonConvert _
           .DeserializeAnonymousType(Of AstrologicalReport) _
        (HttpService.SendPostRequest(URL_ASTRO, jsonBody), New AstrologicalReport)
        OnLoadAstrologicalChartResult()
    End Sub

    Private Sub OnLoadAstrologicalChartResult()
        LoadGroupBoxUserData()
        LoadAstrologicalChart()
        GetAstrologicalChartInterpretations()
        TimerProcessing.Stop()
        TimerProcessing.Dispose()
    End Sub

    Private Sub LoadAstrologicalChart()
        LblSunSign.Text = GetSignName(astrologicalReport.Planets.Sun.sign)
        LblMoonSign.Text = GetSignName(astrologicalReport.Planets.Moon.sign)
        LblAscendant.Text = GetSignName(astrologicalReport.Planets.Ascendant.sign)
        LblDescendant.Text = GetSignName(astrologicalReport.Planets.Descendant.sign)
        LblMidheaven.Text = GetSignName(astrologicalReport.Planets.Midheaven.sign)
        LblMethod.Text = astrologicalReport.HouseSystem
    End Sub

    Private Sub LoadGroupBoxUserData()
        LblUserName.Text = firstName + " " + lastName
        LblCurrentDate.Text = Date.Now.ToLongDateString()
        LblBirthDate.Text = birthDataObj.birthData.birthTime.ToString()
        LblUserLocation.Text = birthDataObj.birthData.placeOfBirth.ToString()
        LblCoordinates.Text = birthDataObj.birthData.birthLatitude.ToString() _
            + " " _
            + birthDataObj.birthData.birthLongitude.ToString()
    End Sub

    Private Sub GetAstrologicalChartInterpretations()
        Dim astrologicalChartInterpretationMock = New AstrologicalChartInterpretationMock
        Dim sunInterpretation = astrologicalChartInterpretationMock.GetSunInterpretation(astrologicalReport.Planets.Sun.sign)
        Dim moonInterpretation = astrologicalChartInterpretationMock.GetMoonInterpretation(astrologicalReport.Planets.Moon.sign)
        LblSunOnSign.Text = LblSunOnSign.Text + GetSignName(astrologicalReport.Planets.Sun.sign)
        LblMoonOnSign.Text = LblMoonOnSign.Text + GetSignName(astrologicalReport.Planets.Moon.sign)
        LblSunInterpretation.Text = sunInterpretation
        LblMoonInterpretation.Text = moonInterpretation
    End Sub

    Private Sub TimerProcessing_Disposed(
        sender As Object,
        e As EventArgs) Handles TimerProcessing.Disposed
        TableLayoutProcessing.Hide()
        LblAstrologicalReportTitle.Show()
        FlowLayoutAstrologicalReportIntro.Show()
        GroupBoxUserData.Show()
        TableLayoutReport.Show()
        TableLayoutReportSignInterpretations.Show()
    End Sub

    Private Function GetSignName(ByRef sign As String) As String
        Select Case sign
            Case "Taurus"
                Return "Tauro"
            Case "Gemini"
                Return "Geminis"
            Case "Scorpio"
                Return "Escorpio"
            Case "Sagittarius"
                Return "Sagitario"
            Case "Capricorn"
                Return "Capricornio"
            Case "Aquarius"
                Return "Acuario"
            Case "Pisces"
                Return "Piscis"
            Case Else
                Return sign
        End Select
    End Function
End Class