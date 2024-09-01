Public Class Categoria
    Public Property _id As Integer
    Public Property _nombre As String
    Public Property _productos As List(Of Producto)
    Public Sub New(id As Integer, nombre As String)
        _id = id
        _nombre = nombre
        _productos = New List(Of Producto)
    End Sub
End Class
