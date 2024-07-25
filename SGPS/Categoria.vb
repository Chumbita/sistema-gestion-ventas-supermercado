Public Class Categoria
    Public Property _nombre As String
    Public Property _productos As List(Of Producto)
    Public Sub New(nombre As String)
        _nombre = nombre
        _productos = New List(Of Producto)
    End Sub
End Class
