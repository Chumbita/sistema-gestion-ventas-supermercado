Imports System.Text
Public Class Carrito
    Public Property _productos As List(Of Producto)
    Public Sub New()
        _productos = New List(Of Producto)
    End Sub
    Public Sub MostrarCarrito(dgv As DataGridView)
        dgv.Rows.Clear()
        For Each producto As Producto In _productos
            dgv.Rows.Add(producto._codigo, producto._nombre, producto._marca, producto._precio, producto._cantidad, producto._categoria)
        Next
    End Sub
End Class
