Public Class Producto
    Public Property _codigo As String
    Public Property _nombre As String
    Public Property _marca As String
    Public Property _precio As Double
    Public Property _cantidad As Integer
    Public Property _categoria As Integer
    Public Sub New(codigo As String, nombre As String, marca As String, precio As Double, cantidad As Integer, categoria As Integer)
        _codigo = codigo
        _nombre = nombre
        _marca = marca
        _precio = precio
        _cantidad = cantidad
        _categoria = categoria
    End Sub
End Class
