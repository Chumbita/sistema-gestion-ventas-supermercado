Public Class Supermercado
    Public Property _nombre As String
    Public Property _usuarios As List(Of Usuario)
    Public Property _categorias As List(Of Categoria)

    Public Sub New(nombre As String)
        _nombre = nombre
        _usuarios = New List(Of Usuario)
        _categorias = New List(Of Categoria)
    End Sub

    Public Sub agregar_usuario(usuario As Usuario)
        _usuarios.Add(usuario)
    End Sub
    Public Sub eliminar_usuario(usuario As String, contraseña As String)
        Dim flag As Boolean = False
        For Each u As Usuario In Me._usuarios
            If u._usuario = usuario AndAlso u._contraseña = contraseña Then
                _usuarios.Remove(u)
                flag = True
                Exit For
            End If
        Next

        If flag = False Then
            MsgBox("No se encontró el usuario : " & usuario, MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("Usuario elminado del sistema correctamente", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Public Sub editar_usuario(id_usuario As Integer)
    End Sub
    Public Sub agregar_producto(categoria As Categoria, producto As Producto)
        categoria._productos.Add(producto)
    End Sub
    Public Sub eliminar_producto(categoria As Categoria, producto As Producto)
        categoria._productos.Remove(producto)
    End Sub
    Public Sub editar_producto(id_usuario As Integer)
    End Sub
    Public Sub restockear(categoria As Categoria, producto As Producto, cantidad As Integer)

    End Sub
End Class
