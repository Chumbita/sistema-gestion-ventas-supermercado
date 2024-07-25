Public Class Supermercado
    Public Property _nombre As String
    Public Property _usuarios As List(Of Usuario)
    Public Property _categorias As List(Of Categoria)

    Public Sub New(nombre As String)
        _nombre = nombre
        _usuarios = New List(Of Usuario)
        _categorias = New List(Of Categoria)
    End Sub
    Public Sub AgregarUsuario(usuario As Usuario)
        _usuarios.Add(usuario)
    End Sub
    Public Sub EliminarUsuario(usuario As String, contraseña As String)
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
    Public Sub EditarUsuario(id_usuario As Integer)
    End Sub
    Public Sub AgregarProducto(categoria As Categoria, producto As Producto)
        'For Each cat As Categoria In Me._categorias
        '    If cat._nombre = categoria._nombre Then
        '        cat._productos.Add(producto)
        '        Exit For
        '    End If
        'Next
    End Sub
    Public Sub EliminarProducto(categoria As Categoria, producto As Producto)
        categoria._productos.Remove(producto)
    End Sub
    Public Sub EditarProduccto(id_usuario As Integer)
    End Sub
    Public Sub Restockear(categoria As Categoria, producto As Producto, cantidad As Integer)

    End Sub
    Public Sub AgregarCategoria(categoria As Categoria)
        Me._categorias.Add(categoria)
    End Sub
End Class
