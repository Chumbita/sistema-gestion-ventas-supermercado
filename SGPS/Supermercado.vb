Imports System.Data.Common
Imports System.Drawing.Text
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
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
    'Public Sub EliminarUsuario(usuario As String, contraseña As String)
    '    Dim flag As Boolean = False
    '    For Each u As Usuario In Me._usuarios
    '        If u._usuario = usuario AndAlso u._contraseña = contraseña Then
    '            _usuarios.Remove(u)
    '            flag = True
    '            Exit For
    '        End If
    '    Next

    '    If flag = False Then
    '        MsgBox("No se encontró el usuario : " & usuario, MsgBoxStyle.Critical, "Error")
    '    Else
    '        MsgBox("Usuario elminado del sistema correctamente", MsgBoxStyle.OkOnly)
    '    End If
    'End Sub
    'Public Sub EditarUsuario(id_usuario As Integer)
    'End Sub
    Public Sub AgregarProducto(categoria As String, producto As Producto)
        For Each cat As Categoria In Me._categorias
            If cat._nombre.ToLower() = categoria.ToLower() Then
                cat._productos.Add(producto)
                Exit For
            End If
        Next
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
    Public Sub EliminarCategoria(categoria As Categoria)
        Me._categorias.Remove(categoria)
    End Sub
    Public Sub RegistrarUsuario(usuario As Usuario)
        _usuarios.Add(usuario)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "INSERT INTO usuarios (nombre, usuario, contraseña) VALUES (@nombre, @usuario, @contraseña)"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@nombre", usuario._nombre)
        cmd.Parameters.AddWithValue("@usuario", usuario._usuario)
        cmd.Parameters.AddWithValue("@contraseña", usuario._contraseña)
        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub
End Class
