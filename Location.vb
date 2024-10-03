Public Class Location
    Public cantidad As Integer
    Public inicio As Integer
    Public parametros As Parameters
    Public provincias As List(Of Province)
    Public total As Integer

    Public Class Parameters
    End Class

    Public Class Province
        Public centroide As Coords
        Public id As String
        Public nombre As String

    End Class

    Public Class Coords
        Public lat As Single
        Public lon As Single
    End Class
End Class

