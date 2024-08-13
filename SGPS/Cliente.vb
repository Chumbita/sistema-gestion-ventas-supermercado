Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Cliente
    Inherits Usuario
    Property _carrito As Carrito
    Public Sub New(usuario As String, nombre As String, contraseña As String)
        MyBase.New(usuario, nombre, contraseña)
        _carrito = New Carrito()
    End Sub
    Public Overrides Sub AgregarProducto(producto As Producto)
        Me._carrito._productos.Add(producto)
    End Sub
    Public Overrides Sub EliminarProducto(codigoProducto As Integer)
        For Each producto As Producto In Me._carrito._productos
            If producto._codigo = codigoProducto Then
                For Each categoria As Categoria In miSupermercado._categorias
                    For Each productoEnSupermercado As Producto In categoria._productos
                        If productoEnSupermercado._codigo = codigoProducto Then
                            productoEnSupermercado._cantidad += producto._cantidad
                            Exit For
                            Exit For
                        End If
                    Next
                Next
                Me._carrito._productos.Remove(producto)
                Exit For
            End If
        Next
    End Sub
    Public Sub VaciarCarrito()
        For Each producto As Producto In Me._carrito._productos
            For Each categoria As Categoria In miSupermercado._categorias
                For Each productoEnSupermercado As Producto In categoria._productos
                    If productoEnSupermercado._codigo = producto._codigo Then
                        productoEnSupermercado._cantidad += producto._cantidad
                    End If
                Next
            Next
        Next
        Me._carrito._productos.Clear()
    End Sub
    Public Function FinalizarCompra() As String
        'Actualizar Base de Datos
        Dim conexion As MySqlConnection
        Dim cmd As MySqlCommand
        Dim query As String = "UPDATE productos SET cantidad = @cantidad WHERE codigo = @codigo"

        conexion = New MySqlConnection("Server=localhost;Database=supermercado;Uid=root;Pwd=;")

        conexion.Open()
        For Each producto As Producto In Me._carrito._productos
            For Each categoria As Categoria In miSupermercado._categorias
                For Each productoEnSupermercado As Producto In categoria._productos
                    If productoEnSupermercado._codigo = producto._codigo Then
                        cmd = New MySqlCommand(query, conexion)
                        cmd.Parameters.AddWithValue("@cantidad", productoEnSupermercado._cantidad)
                        cmd.Parameters.AddWithValue("@codigo", productoEnSupermercado._codigo)
                        cmd.ExecuteNonQuery()
                    End If
                Next
            Next
        Next
        conexion.Close()

        Dim total As Double = 0
        Dim sb As New StringBuilder()

        ' Añadir encabezado de la factura
        sb.AppendLine("Nombre" & vbTab & vbTab & "Marca" & vbTab & vbTab & "Cantidad" & vbTab & "Precio")
            sb.AppendLine(New String("-"c, 60))  ' Línea separadora

        ' Añadir los productos a la factura
        For Each producto As Producto In Me._carrito._productos
            sb.AppendLine(producto._nombre.PadRight(20) &
                          producto._marca.PadRight(20) &
                          producto._cantidad.ToString().PadRight(10) &
                          "$" & (producto._precio * producto._cantidad).ToString("F2").PadLeft(10))
            total += producto._precio * producto._cantidad
        Next

        ' Añadir el total
        sb.AppendLine(New String("-"c, 60))  ' Línea separadora
        sb.AppendLine("Total".PadRight(50) & "$" & total.ToString("F2"))

        Return sb.ToString()
    End Function
End Class
