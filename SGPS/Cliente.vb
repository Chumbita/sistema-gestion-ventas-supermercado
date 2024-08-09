Public Class Cliente
    Inherits Usuario
    Property _carrito As Carrito
    Public Sub New(usuario As String, nombre As String, contraseña As String)
        MyBase.New(usuario, nombre, contraseña)
        _carrito = New Carrito()
    End Sub

    Public Overrides Sub AgregarProducto(producto As Producto)
    End Sub

    Public Overrides Sub EliminarProducto(producto As Producto)

    End Sub
End Class
