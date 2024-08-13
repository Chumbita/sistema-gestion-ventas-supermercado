Public Class FormAdmin
    Private operacion As String
    Dim adm As Administrador
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
        adm = miSupermercado._usuarios(0)
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
                adCBCategoria.Enabled = True
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
        Dim producto As Producto = New Producto(adTbCodigo.Text, adTbNombre.Text, adTbMarca.Text, adTbPrecio.Text, adTbCantidad.Text, adCBCategoria.Text)
        adm.AgregarProducto(producto)
        miSupermercado.AgregarProducto(adCBCategoria.Text, producto)
    End Sub
    Public Sub Eliminar()
        Dim codigoProducto As String = adTbCodigo.Text
        For Each categoria As Categoria In miSupermercado._categorias
            If categoria._nombre = adCBCategoria.Text Then
                For Each producto As Producto In categoria._productos
                    If producto._codigo = codigoProducto Then
                        miSupermercado.EliminarProducto(categoria, producto)
                        adm.EliminarProducto(producto._codigo)
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
                        If producto._categoria IsNot adCBCategoria.Text Then
                            For Each nuevaCategoria As Categoria In miSupermercado._categorias
                                If nuevaCategoria._nombre = adCBCategoria.Text Then
                                    nuevaCategoria._productos.Add(producto)
                                    categoria._productos.Remove(producto)
                                    Exit For
                                End If
                            Next
                        End If
                        producto._categoria = adCBCategoria.Text
                        adm.EditarProducto(producto)
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
                        adm.Restockear(producto)
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
            Dim nuevaCategoria = New Categoria(textoCategoria)
            miSupermercado.AgregarCategoria(nuevaCategoria)
            adm.AgregarCategoria(nuevaCategoria)
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
                adm.EliminarCategoria(categoria)
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

        For Each fila As DataGridViewRow In DGVAdmin.Rows
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
                    If rbPorCodigo.Checked Then
                        Dim celdaCodigo As DataGridViewCell = fila.Cells("Column1")
                        If celdaCodigo.Value Is Nothing OrElse Not celdaCodigo.Value.ToString().ToLower().Equals(buscarTexto) Then
                            mostrarFila = False
                        End If
                    ElseIf rbPorNombre.Checked Then
                        Dim celdaNombre As DataGridViewCell = fila.Cells("Column2")
                        If celdaNombre.Value Is Nothing OrElse Not celdaNombre.Value.ToString().ToLower().Contains(buscarTexto) Then
                            mostrarFila = False
                        End If
                    End If
                End If

                fila.Visible = mostrarFila
            End If
        Next
    End Sub
End Class