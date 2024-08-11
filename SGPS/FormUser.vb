Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargadorDatos.CargaDeProductos()
        cargadorDatos.MostrarProductos(DGVProductos)
        cargadorDatos.MostrarCategorias(cbPorCategoria)
        DGVProductos.ClearSelection()
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If DGVProductos.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVProductos.SelectedRows(0)
            Dim codigoProducto As String = filaSeleccionada.Cells("Column1").Value.ToString()
            Dim nombreProducto As String = filaSeleccionada.Cells("Column2").Value.ToString()
            Dim marcaProducto As String = filaSeleccionada.Cells("Column3").Value.ToString()
            Dim precioProducto As String = filaSeleccionada.Cells("Column4").Value.ToString()
            Dim cantidadProducto As String = filaSeleccionada.Cells("Column5").Value.ToString
            Dim categoriaProducto As String = filaSeleccionada.Cells("Column6").Value.ToString()

            Dim productoSeleccionado = New Producto(codigoProducto, nombreProducto, marcaProducto, precioProducto, cantidadProducto, categoriaProducto)
            Dim formProducto = New FormProducto(productoSeleccionado, DGVCarrito)
            formProducto.Show()
        End If
    End Sub
    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If DGVCarrito.SelectedRows.Count > 0 AndAlso MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim filaSeleccionada As DataGridViewRow = DGVProductos.SelectedRows(0)
            Dim codigoProducto = filaSeleccionada.Cells("Column1").Value.ToString()
            _cliente.EliminarProducto(codigoProducto)
            _cliente._carrito.MostrarCarrito(DGVCarrito)
        End If
    End Sub
    Private Sub btnVaciarCarrito_Click(sender As Object, e As EventArgs) Handles btnVaciarCarrito.Click
        If MessageBox.Show("¿Está seguro que desea vaciar el carrito?", "Vaciar Carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _cliente.VaciarCarrito()
            _cliente._carrito.MostrarCarrito(DGVCarrito)
        End If
    End Sub
    Private Sub btnFinalizarCompra_Click(sender As Object, e As EventArgs) Handles btnFinalizarCompra.Click
        Dim resumenCompra As String
        If MessageBox.Show("¿Finalizar Compra?", "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            resumenCompra = _cliente.FinalizarCompra()
            MsgBox(resumenCompra)
            _cliente.VaciarCarrito()
            _cliente._carrito.MostrarCarrito(DGVCarrito)
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

        For Each fila As DataGridViewRow In DGVProductos.Rows
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
        Dim forLogin = New FormLogin()
        Me.Close()
        forLogin.Show()
    End Sub
End Class