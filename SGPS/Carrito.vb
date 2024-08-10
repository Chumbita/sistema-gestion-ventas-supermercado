Imports System.Text
Public Class Carrito
    Public Sub New()
        _productos = New List(Of Producto)
    End Sub
    Public Property _productos As List(Of Producto)
    Public Sub MostrarCarrito(dgv As DataGridView)
        dgv.Rows.Clear()
        For Each producto As Producto In _productos
            dgv.Rows.Add(producto._codigo, producto._nombre, producto._marca, producto._precio, producto._cantidad, producto._categoria)
        Next
    End Sub
    Public Sub EliminarProducto(codProducto As Integer)
        For Each p As Producto In _productos
            If p._codigo = codProducto Then
                _productos.Remove(p)
                Exit For
            End If
        Next
    End Sub
    Public Sub VaciarCarrito()
        _productos.Clear()
    End Sub
    Public Function FinalizarCompra() As String
        Dim total As Double = 0
        Dim sb As New StringBuilder()

        ' Añadir encabezado de la factura
        sb.AppendLine("Nombre".PadRight(25) & "Marca".PadRight(35) & "Cantidad".PadRight(15) & "Precio")
        sb.AppendLine(New String("-"c, 60))  ' Línea separadora

        ' Añadir los productos a la factura
        For Each producto As Producto In _productos
            sb.AppendLine(producto._nombre.PadRight(25) &
                      producto._marca.PadRight(35) &
                      producto._cantidad.ToString().PadRight(15) &
                      "$" & (producto._precio * producto._cantidad).ToString("F2"))
            total += producto._precio * producto._cantidad
        Next

        ' Añadir el total
        sb.AppendLine(New String("-"c, 60))  ' Línea separadora
        sb.AppendLine("Total".PadRight(50) & "$" & total.ToString("F2"))

        Return sb.ToString()
    End Function

End Class
