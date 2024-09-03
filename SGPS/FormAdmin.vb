Public Class FormAdmin
    Private operacion As String
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se cargan los productos de la base de datos al supermercado
        cargadorDatos.CargaDeProductos()
        'Se cargan los productos del supermercado en el Data Grid View
        cargadorDatos.MostrarProductos(DGVAdmin)
        'Se cargan las categorias al combobox
        cargadorDatos.MostrarCategorias(cbPorCategoria)
        cargadorDatos.MostrarCategorias(adCBCategoria)
        cargadorDatos.MostrarCategorias(cbCategoria)
        'Se instancia el Administrador
        DGVAdmin.ClearSelection()
    End Sub
    Private Sub DGVAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAdmin.CellClick
        ResetearTextBox()
        Dim fila As DataGridViewRow = DGVAdmin.SelectedRows(0)
        adTbNombre.Text = fila.Cells("Column2").Value.ToString()
        adTbCodigo.Text = fila.Cells("Column1").Value.ToString()
        adTbMarca.Text = fila.Cells("Column3").Value.ToString()
        adTbPrecio.Text = fila.Cells("Column4").Value.ToString()
        adTbCantidad.Text = fila.Cells("Column5").Value.ToString()
        adCBCategoria.Text = fila.Cells("Column6").Value.ToString()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ResetearTextBox()
        operacion = "Agregar"
        PrepararFormulario(operacion)
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "Eliminar"
            PrepararFormulario(operacion)
        End If
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "Editar"
            PrepararFormulario(operacion)
        End If
    End Sub
    Private Sub btnRestockear_Click(sender As Object, e As EventArgs) Handles btnRestockear.Click
        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "Restockear"
            PrepararFormulario(operacion)
        End If
    End Sub
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        If Not String.IsNullOrEmpty(cbCategoria.Text) Then
            AgregarCategoria()
            cbCategoria.Text = ""
            ActualizarFormulario()
        End If
    End Sub
    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarCategoria.Click
        If Not String.IsNullOrEmpty(cbCategoria.Text) Then
            EliminarCategoria()
            cbCategoria.Text = ""
            cbPorCategoria.Text = ""
            adCBCategoria.Text = ""
            ActualizarFormulario()
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case operacion
            Case "Agregar"
                Agregar()
                MsgBox("Producto agregado con éxito.", MsgBoxStyle.OkOnly, miSupermercado._nombre)
            Case "Eliminar"
                Eliminar()
                MsgBox("Producto eliminado con éxito.", MsgBoxStyle.OkOnly, miSupermercado._nombre)
            Case "Editar"
                Editar()
                MsgBox("Producto modificado con éxito.", MsgBoxStyle.OkOnly, miSupermercado._nombre)
            Case "Restockear"
                Restockear()
                MsgBox("Producto restockeado con éxito.", MsgBoxStyle.OkOnly, miSupermercado._nombre)
        End Select
        ResetearTextBox()
        ActualizarFormulario()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ResetearTextBox()
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim formLogin = New FormLogin()
        Me.Close()
        formLogin.Show()
    End Sub
    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        FiltrarProductos()
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbPorCodigo.CheckedChanged
        FiltrarProductos()
    End Sub

    Private Sub cbPorCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPorCategoria.SelectedIndexChanged
        FiltrarProductos()
    End Sub
    Private Sub tbStockMinimo_TextChanged(sender As Object, e As EventArgs) Handles tbStockMinimo.TextChanged
        FiltrarProductos()
    End Sub
    Public Sub ResetearTextBox()
        adTbNombre.Text = ""
        adTbCodigo.Text = ""
        adTbMarca.Text = ""
        adTbPrecio.Text = ""
        adTbCantidad.Text = ""
        adCBCategoria.Text = ""
        adTbNombre.Enabled = False
        adTbCodigo.Enabled = False
        adTbMarca.Enabled = False
        adTbPrecio.Enabled = False
        adTbCantidad.Enabled = False
        adCBCategoria.Enabled = False
        btnAgregar.Enabled = True
        btnEliminar.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnRestockear.Enabled = True
    End Sub

    Private Sub PrepararFormulario(operacionSeleccionada As String)
        Select Case operacionSeleccionada
            Case "Agregar"
                btnEliminar.Enabled = False
                btnEditar.Enabled = False
                btnRestockear.Enabled = False

                adTbNombre.Enabled = True
                adTbCodigo.Enabled = True
                adTbMarca.Enabled = True
                adTbPrecio.Enabled = True
                adTbCantidad.Enabled = True
                adCBCategoria.Enabled = True
            Case "Eliminar"
                btnAgregar.Enabled = False
                btnEditar.Enabled = False
                btnRestockear.Enabled = False
            Case "Editar"
                btnAgregar.Enabled = False
                btnEliminar.Enabled = False
                btnRestockear.Enabled = False

                adTbNombre.Enabled = True
                adTbMarca.Enabled = True
                adTbPrecio.Enabled = True
                adTbCantidad.Enabled = True
                adCBCategoria.Enabled = False
            Case "Restockear"
                btnAgregar.Enabled = False
                btnEliminar.Enabled = False
                btnEditar.Enabled = False

                adTbCantidad.Enabled = True
                adTbCantidad.Text = 0
        End Select

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Public Sub Agregar()
        Dim idCategoria As Integer
        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre = adCBCategoria.Text Then
                idCategoria = categoria._id
                Exit For
            End If
        Next
        Dim producto As Producto = New Producto(adTbCodigo.Text, adTbNombre.Text, adTbMarca.Text, adTbPrecio.Text, adTbCantidad.Text, idCategoria)
        _administrador.AgregarProducto(producto)
        miSupermercado.AgregarProducto(adCBCategoria.Text, producto)
    End Sub
    Public Sub Eliminar()
        Dim codigoProducto As String = adTbCodigo.Text
        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre = adCBCategoria.Text Then
                For Each producto As Producto In categoria._productos
                    If producto._codigo = codigoProducto Then
                        miSupermercado.EliminarProducto(categoria, producto)
                        _administrador.EliminarProducto(producto._codigo)
                        DGVAdmin.Rows.RemoveAt(DGVAdmin.SelectedRows(0).Index)
                        Exit For
                    End If
                Next
                Exit For
            End If
        Next
    End Sub
    Public Sub Editar()
        Dim codigoProducto As String = adTbCodigo.Text
        Dim rowIndex As Integer = DGVAdmin.CurrentCell.RowIndex

        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre = adCBCategoria.Text Then
                For Each producto As Producto In categoria._productos
                    If producto._codigo = codigoProducto Then
                        producto._nombre = adTbNombre.Text
                        producto._marca = adTbMarca.Text
                        producto._precio = adTbPrecio.Text
                        producto._cantidad = adTbCantidad.Text
                        _administrador.EditarProducto(producto)
                        DGVAdmin.Rows(rowIndex).Cells("Column2").Value = adTbNombre.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column3").Value = adTbMarca.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column4").Value = adTbPrecio.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column5").Value = adTbCantidad.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column6").Value = adCBCategoria.Text
                        Exit For
                    End If
                Next
                Exit For
            End If
        Next

    End Sub
    Public Sub Restockear()
        Dim codigoProducto As String = adTbCodigo.Text
        Dim rowIndex As Integer = DGVAdmin.CurrentCell.RowIndex

        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre = adCBCategoria.Text Then
                For Each producto As Producto In categoria._productos
                    If producto._codigo = codigoProducto Then
                        producto._cantidad = producto._cantidad + Integer.Parse(adTbCantidad.Text)
                        _administrador.Restockear(producto)
                        DGVAdmin.Rows(rowIndex).Cells("Column5").Value = producto._cantidad
                        ResetearTextBox()
                        Exit For
                    End If
                Next
                Exit For
            End If
        Next
    End Sub
    Public Sub AgregarCategoria()
        Dim existeCategoria As Boolean = False
        Dim textoCategoria As String = cbCategoria.Text
        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre.ToLower() = textoCategoria.ToLower() Then
                existeCategoria = True
            End If
        Next

        If Not existeCategoria Then
            Dim idCategoria As Integer = miSupermercado._categorias(miSupermercado._categorias.Count - 1)._id + 1
            Dim nuevaCategoria = New Categoria(idCategoria, textoCategoria)
            miSupermercado.AgregarCategoria(nuevaCategoria)
            _administrador.AgregarCategoria(nuevaCategoria)
            MsgBox("Nueva categoria agregada con éxito", MsgBoxStyle.Information, miSupermercado._nombre)
        Else
            MsgBox("La categoria que deseas crear ya existe", MsgBoxStyle.Information, miSupermercado._nombre)
        End If

    End Sub
    Public Sub EliminarCategoria()
        Dim textoCategoria As String = cbCategoria.Text
        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre.ToLower() = textoCategoria.ToLower() Then
                miSupermercado.EliminarCategoria(categoria)
                _administrador.EliminarCategoria(categoria)
                MsgBox("Categoria eliminada con éxito", MsgBoxStyle.Information, miSupermercado._nombre)
                Exit For
            End If
        Next
    End Sub
    Public Sub ActualizarFormulario()
        cbPorCategoria.Items.Clear()
        adCBCategoria.Items.Clear()
        cbCategoria.Items.Clear()
        cargadorDatos.MostrarProductos(DGVAdmin)
        cargadorDatos.MostrarCategorias(cbPorCategoria)
        cargadorDatos.MostrarCategorias(adCBCategoria)
        cargadorDatos.MostrarCategorias(cbCategoria)

    End Sub
    Private Sub FiltrarProductos()
        Dim buscarTexto As String = tbBuscar.Text.ToLower()
        Dim categoriaTexto As String = cbPorCategoria.Text.ToLower()
        Dim stockMinimo As Integer
        Dim filtrarPorStock As Boolean = Integer.TryParse(tbStockMinimo.Text, stockMinimo)

        For Each fila As DataGridViewRow In DGVAdmin.Rows
            If fila.IsNewRow Then Continue For

            ' Inicializa la visibilidad como True
            Dim mostrarFila As Boolean = True

            ' Filtrar por categoría
            If Not String.IsNullOrEmpty(categoriaTexto) Then
                Dim celdaCategoria As DataGridViewCell = fila.Cells("Column6")
                mostrarFila = mostrarFila AndAlso celdaCategoria.Value IsNot Nothing AndAlso celdaCategoria.Value.ToString().ToLower().Contains(categoriaTexto)
            End If

            ' Filtrar por código o nombre
            If mostrarFila AndAlso Not String.IsNullOrEmpty(buscarTexto) Then
                If rbPorCodigo.Checked Then
                    Dim celdaCodigo As DataGridViewCell = fila.Cells("Column1")
                    mostrarFila = mostrarFila AndAlso celdaCodigo.Value IsNot Nothing AndAlso celdaCodigo.Value.ToString().ToLower().Equals(buscarTexto)
                ElseIf rbPorNombre.Checked Then
                    Dim celdaNombre As DataGridViewCell = fila.Cells("Column2")
                    mostrarFila = mostrarFila AndAlso celdaNombre.Value IsNot Nothing AndAlso celdaNombre.Value.ToString().ToLower().Contains(buscarTexto)
                End If
            End If

            ' Filtrar por stock mínimo
            If mostrarFila AndAlso filtrarPorStock Then
                Dim celdaCantidad As DataGridViewCell = fila.Cells("Column5")
                If celdaCantidad.Value IsNot Nothing Then
                    mostrarFila = mostrarFila AndAlso Convert.ToInt32(celdaCantidad.Value) < stockMinimo
                End If
            End If

            fila.Visible = mostrarFila
        Next
    End Sub

End Class