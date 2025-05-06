Public Class Locality
    Public Property cantidad As Integer
    Public Property inicio As Integer
    Public Property localidades As List(Of Localities)
    Public Property parametros As Parametros
    Public Property total As Integer
End Class

Public Class Parametros
    Public Property campos As List(Of String)
    Public Property max As Integer
    Public Property provincia As String
End Class

Public Class Localities
    Public Property centroide As Centroide
    Public Property id As String
    Public Property nombre As String
End Class

Public Class Centroide
    Public Property lat As Single
    Public Property lon As Single
End Class

