Public Class Location
    Public Property cantidad As Integer
    Public Property inicio As Integer
    Public Property parametros As Parameters
    Public Property provincias As List(Of Province)
    Public Property total As Integer

    Public Class Parameters
    End Class

    Public Class Province
        Public Property centroide As Coords
        Public Property id As String
        Public Property nombre As String

    End Class

    Public Class Coords
        Public Property lat As Single
        Public Property lon As Single
    End Class
End Class

