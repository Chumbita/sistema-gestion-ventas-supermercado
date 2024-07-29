Public Class Usuario
    Public Sub New()
    End Sub
    Public Sub New(usuario As String, nombre As String, contraseña As String)
        _usuario = usuario
        _nombre = nombre
        _contraseña = contraseña
    End Sub
    Public Property _usuario As String
    Public Property _nombre As String
    Public Property _contraseña As String

    Public Overridable Sub AgregarProducto(producto As Producto)
    End Sub
    Public Overridable Sub EliminarProducto()
    End Sub
End Class
