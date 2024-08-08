Public Class FormUser
    Private _cargadorDeDatos As CargadorDeDatos
    Private _supermercado As Supermercado
    Private _carrito As Carrito
    Private _usuario As Cliente
    Public Sub New(supermercado As Supermercado, usuario As Usuario)
        InitializeComponent()
        Me._cargadorDeDatos = New CargadorDeDatos(supermercado)
        Me._supermercado = supermercado
        Me._usuario = usuario
    End Sub
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cargadorDeDatos.CargaDeProductos()
        _cargadorDeDatos.MostrarProductos(DGVUser)
        _cargadorDeDatos.MostrarCategorias(cbPorCategoria)
        _carrito = New Carrito(_usuario)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DGVUser.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = DGVUser.SelectedRows(0)
            Dim codigo As String = fila.Cells("Column1").Value.ToString()
            Dim nombre As String = fila.Cells("Column2").Value.ToString()
            Dim marca As String = fila.Cells("Column3").Value.ToString()
            Dim precio As String = fila.Cells("Column4").Value.ToString()
            Dim cantidad As String = 1
            Dim categoria As String = fila.Cells("Column6").Value.ToString()

            Dim producto = New Producto(codigo, nombre, marca, precio, cantidad, categoria)
            Dim formProducto = New FormProducto(producto, _carrito, DGVCarrito)
            formProducto.Show()
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVCarrito.SelectedRows.Count > 0 AndAlso MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim fila As DataGridViewRow = DGVUser.SelectedRows(0)
            Dim producto = fila.Cells("Column2").Value.ToString()
            _carrito.EliminarProducto(producto)
            _carrito.MostrarCarrito(DGVCarrito)
        End If
    End Sub
    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        If MessageBox.Show("¿Está seguro que desea vaciar el carrito?", "Vaciar Carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _carrito.VaciarCarrito()
            _carrito.MostrarCarrito(DGVCarrito)
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim text As String
        If MessageBox.Show("¿Finalizar Compra?", "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            text = _carrito.FinalizarCompra()
            MsgBox(text)
            _carrito.VaciarCarrito()
            _carrito.MostrarCarrito(DGVCarrito)
        End If
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        FiltrarProductos()
    End Sub

    Private Sub cbPorCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPorCategoria.SelectedIndexChanged
        FiltrarProductos()
    End Sub
    Private Sub FiltrarProductos()
        Dim buscarTexto As String = tbBuscar.Text.ToLower()
        Dim categoriaTexto As String = cbPorCategoria.Text.ToLower()

        For Each fila As DataGridViewRow In DGVUser.Rows
            'no procesa la fila de nueva fila
            If Not fila.IsNewRow Then
                Dim mostrarFila As Boolean = True

                ' Filtra por categoría
                If Not String.IsNullOrEmpty(categoriaTexto) Then 'verifica si hay un texto de categoria por filtrar
                    Dim celdaCategoria As DataGridViewCell = fila.Cells("Column6")
                    If celdaCategoria.Value Is Nothing OrElse Not celdaCategoria.Value.ToString().ToLower().Contains(categoriaTexto) Then
                        mostrarFila = False
                    End If
                End If

                ' Filtra por código o nombre
                If mostrarFila AndAlso Not String.IsNullOrEmpty(buscarTexto) Then
                    Dim celdaNombre As DataGridViewCell = fila.Cells("Column2")
                    If celdaNombre.Value Is Nothing OrElse Not celdaNombre.Value.ToString().ToLower().Contains(buscarTexto) Then
                        mostrarFila = False
                    End If
                End If
                fila.Visible = mostrarFila
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim forLogin = New Form1()
        Me.Close()
        forLogin.Show()
    End Sub
End Class