Public MustInherit Class Usuario
    Public Sub New()
    End Sub
    Public Sub New(id As Integer, usuario As String, nombre As String, contraseña As String)
        _id = id
        _usuario = usuario
        _nombre = nombre
        _contraseña = contraseña
    End Sub
    Public Property _usuario As String
    Public Property _nombre As String
    Public Property _contraseña As String
    Public Property _id As Integer

    Public MustOverride Sub AgregarProducto(producto As Producto)
    Public MustOverride Sub EliminarProducto(codigoProducto As Integer)
End Class
