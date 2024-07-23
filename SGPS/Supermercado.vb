Imports System.Net

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
    Public Sub eliminar_usuario(id_usuario As Integer)
        Dim flag As Boolean = False
        For Each usuario As Usuario In _usuarios
            If usuario._id = id_usuario Then
                _usuarios.Remove(usuario)
                flag = True
                Exit For
            End If
        Next

        If flag = False Then
            MsgBox("No se encontró el usuario con el id: " & id_usuario, MsgBoxStyle.Critical, "Error")
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
