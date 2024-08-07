Public Class Carrito
    Public Sub New(cliente As Cliente)
        _cliente = cliente
        _productos = New List(Of Producto)
    End Sub
    Public Property _cliente As Usuario
    Public Property _productos As List(Of Producto)
    Public Sub MostrarCarrito(dgv As DataGridView)
        dgv.Rows.Clear()
        For Each producto As Producto In _productos
            dgv.Rows.Add(producto._codigo, producto._nombre, producto._marca, producto._precio, producto._cantidad, producto._categoria, producto._ruta)
        Next
    End Sub
    Public Sub EliminarProducto(producto As String)
        For Each p As Producto In _productos
            If p._nombre = producto Then
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
        Dim text As String = ""
        For Each producto As Producto In _productos
            total += (producto._precio * producto._cantidad)
            text = text & producto._nombre & producto._marca & producto._cantidad & "$" & producto._precio & vbCrLf
        Next
        text = text & "Total             $" & total
        Return text
    End Function
End Class
