Imports MySql.Data.MySqlClient
Public Class Administrador
    Inherits Usuario
    Public Sub New(usuario As String, nombre As String, contraseña As String)
        MyBase.New(usuario, nombre, contraseña)
    End Sub
    Public Overrides Sub AgregarProducto(producto As Producto)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "INSERT INTO productos (codigo, nombre, marca, precio, cantidad, fk_categorias) VALUES (@codigo, @nombre, @marca, @precio, @cantidad, @fk_categorias)"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@codigo", producto._codigo)
        cmd.Parameters.AddWithValue("@nombre", producto._nombre)
        cmd.Parameters.AddWithValue("@marca", producto._marca)
        cmd.Parameters.AddWithValue("@precio", producto._precio)
        cmd.Parameters.AddWithValue("@cantidad", producto._cantidad)
        cmd.Parameters.AddWithValue("@fk_categorias", producto._categoria)
        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Public Overrides Sub EliminarProducto(codigoProducto As Integer)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "DELETE FROM productos WHERE codigo = @codigo"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@codigo", codigoProducto)
        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub
    Public Sub EditarProducto(producto As Producto)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "UPDATE productos SET nombre = @nombre, marca = @marca, precio = @precio, cantidad = @cantidad, fk_categorias = @fk_categorias WHERE codigo = @codigo"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@codigo", producto._codigo)
        cmd.Parameters.AddWithValue("@nombre", producto._nombre)
        cmd.Parameters.AddWithValue("@marca", producto._marca)
        cmd.Parameters.AddWithValue("@precio", producto._precio)
        cmd.Parameters.AddWithValue("@cantidad", producto._cantidad)
        cmd.Parameters.AddWithValue("@fk_categorias", producto._categoria)

        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub
    Public Sub Restockear(producto As Producto)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "UPDATE productos SET cantidad = @cantidad WHERE codigo = @codigo"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@codigo", producto._codigo)
        cmd.Parameters.AddWithValue("@cantidad", producto._cantidad)

        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub
    Public Sub AgregarCategoria(categoria As Categoria)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "INSERT INTO categorias (id, nombre) VALUES (@id, @nombre)"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@id", categoria._id)
        cmd.Parameters.AddWithValue("@nombre", categoria._nombre)
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Public Sub EliminarCategoria(categoria As Categoria)
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "DELETE FROM categorias WHERE id = @id"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        cmd = New MySqlCommand(query, conexion)
        conexion.Open()

        cmd.Parameters.AddWithValue("@id", categoria._id)
        cmd.ExecuteNonQuery()

        conexion.Close()
    End Sub
End Class