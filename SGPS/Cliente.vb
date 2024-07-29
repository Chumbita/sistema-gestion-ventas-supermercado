Public Class Cliente
    Inherits Usuario
    Public Sub New(usuario As String, nombre As String, contraseña As String)
        MyBase.New(usuario, nombre, contraseña)
    End Sub

    Public Overrides Sub AgregarProducto(producto As Producto)
    End Sub

    Public Overrides Sub EliminarProducto()

    End Sub

End Class
