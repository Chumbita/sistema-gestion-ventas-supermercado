Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class CargadorDeDatos
    Private Property _supermercado As Supermercado
    Public Sub New(supermercado As Supermercado)
        _supermercado = supermercado
    End Sub

    Public Sub CargaDeUsuarios()
        Dim miConexion As MySqlConnection
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        miConexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        query = "SELECT * FROM usuarios"
        cmd = New MySqlCommand(query, miConexion)
        miConexion.Open()
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim usuario As String = reader.GetString(1)
            Dim nombre As String = reader.GetString(2)
            Dim contraseña As String = reader.GetString(3)

            Dim user As New Usuario(usuario, nombre, contraseña)
            _supermercado.AgregarUsuario(user)
        End While
    End Sub
    Public Sub CargaDeProductos()
        Dim miConexion As MySqlConnection
        Dim query As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        miConexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")
        query = "SELECT * FROM categoria"
        cmd = New MySqlCommand(query, miConexion)
        miConexion.Open()
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim nombreCategoria As String = reader.GetString(1)

            Dim categoria As New Categoria(nombreCategoria)
            _supermercado.AgregarCategoria(categoria)
        End While

        reader.Close()

        query = "SELECT * FROM productos"
        cmd = New MySqlCommand(query, miConexion)
        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim codigo As Integer = reader.GetInt32(0)
            Dim nombre As String = reader.GetString(1)
            Dim marca As String = reader.GetString(2)
            Dim precio As Double = reader.GetDouble(3)
            Dim cantidad As Integer = reader.GetInt32(4)
            Dim ruta As String = reader.GetString(5)
            Dim pCategoria As String = reader.GetString(6)

            Dim producto As New Producto(codigo, nombre, marca, precio, cantidad, ruta, pCategoria)

            For Each cat As Categoria In _supermercado._categorias
                If cat._nombre = producto._categoria Then
                    cat._productos.Add(producto)
                    Exit For
                End If
            Next
        End While

        reader.Close()
        cmd.Dispose()
        miConexion.Close()
    End Sub

    Public Sub MostrarProductos(dgv As DataGridView)
        dgv.Rows.Clear()

        For Each categoria As Categoria In _supermercado._categorias
            For Each producto As Producto In categoria._productos
                dgv.Rows.Add(producto._codigo, producto._nombre, producto._marca, producto._precio, producto._cantidad)
            Next
        Next
    End Sub
End Class
