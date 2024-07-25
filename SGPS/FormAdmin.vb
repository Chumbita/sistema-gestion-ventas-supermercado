Imports System.Data.Common
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class FormAdmin
    'Modificación del constructor de FormAdmin para hacer uso de la instancia supermercado
    Private _supermercado As Supermercado
    Public Sub New(supermercado As Supermercado)
        InitializeComponent()
        Me._supermercado = supermercado
    End Sub

    Dim miConexion As MySqlConnection
    Dim query As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub CargaDeProductos()
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

    'Prueba de que la función CargaDeProductos funciona correctamente.
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    CargaDeProductos()
    '    For Each c As Categoria In _supermercado._categorias
    '        For Each p As Producto In c._productos
    '            MsgBox(p._nombre & " " & c._nombre)
    '        Next
    '    Next
    'End Sub
End Class