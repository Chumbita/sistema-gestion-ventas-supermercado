Imports System.Data.Common
Imports System.Drawing.Text
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class Administrador
    Inherits Usuario
    Public Sub New(usuario As String, nombre As String, contraseña As String)
        MyBase.New(usuario, nombre, contraseña)
    End Sub
    Public Overrides Sub AgregarProducto(producto As Producto)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "INSERT INTO Productos (codigo, nombre, marca, precio, cantidad, ruta, categoria) VALUES (@codigo, @nombre, @marca, @precio, @cantidad, @ruta, @categoria)"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@codigo", producto._codigo)
        cmd.Parameters.AddWithValue("@nombre", producto._nombre)
        cmd.Parameters.AddWithValue("@marca", producto._marca)
        cmd.Parameters.AddWithValue("@precio", producto._precio)
        cmd.Parameters.AddWithValue("@cantidad", producto._cantidad)
        cmd.Parameters.AddWithValue("@ruta", producto._ruta)
        cmd.Parameters.AddWithValue("@categoria", producto._categoria)
        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Public Overrides Sub EliminarProducto(producto As Producto)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "DELETE FROM productos WHERE codigo = @codigo"


        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@codigo", producto._codigo)
        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub
End Class