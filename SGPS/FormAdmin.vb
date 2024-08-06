Imports System.Data.Common
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class FormAdmin
    'Modificación del constructor de FormAdmin para hacer uso de la instancia supermercado
    Private _cargadorDeDatos As CargadorDeDatos
    Private _supermercado As Supermercado
    Private operacion As String
    Dim adm As Administrador
    Public Sub New(supermercado As Supermercado)
        InitializeComponent()
        Me._cargadorDeDatos = New CargadorDeDatos(supermercado)
        Me._supermercado = supermercado
        adm = _supermercado._usuarios(0)
    End Sub
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se cargan los productos de la base de datos al supermercado
        _cargadorDeDatos.CargaDeProductos()
        'Se cargan los productos del supermercado en el Data Grid View
        _cargadorDeDatos.MostrarProductos(DGVAdmin)
        'Se cargan las categorias al combobox
        _cargadorDeDatos.MostrarCategorias(cbPorCategoria)
        _cargadorDeDatos.MostrarCategorias(adCBCategoria)
        _cargadorDeDatos.MostrarCategorias(cbCategoria)

    End Sub

    Public Sub ResetearTextBox()
        adTbNombre.Text = " "
        adTbCodigo.Text = " "
        adTbMarca.Text = " "
        adTbPrecio.Text = " "
        adTbCantidad.Text = " "
        adTbRuta.Text = " "
        adCBCategoria.Text = " "
        adTbNombre.Enabled = False
        adTbCodigo.Enabled = False
        adTbMarca.Enabled = False
        adTbPrecio.Enabled = False
        adTbRuta.Enabled = False
        adTbCantidad.Enabled = False
        adCBCategoria.Enabled = False
        btnAgregar.Enabled = True
        btnEliminar.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnRestockear.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case operacion
            Case "agregar"
                Agregar()
                MsgBox("Producto agregado con éxito.", MsgBoxStyle.OkOnly, _supermercado._nombre)
            Case "eliminar"
                Eliminar()
                MsgBox("Producto eliminado con éxito.", MsgBoxStyle.OkOnly, _supermercado._nombre)
            Case "editar"
                Editar()
                MsgBox("Producto modificado con éxito.", MsgBoxStyle.OkOnly, _supermercado._nombre)
            Case "restockear"
                Restockear()
                MsgBox("Producto restockeado con éxito.", MsgBoxStyle.OkOnly, _supermercado._nombre)
            Case Else

        End Select
        ResetearTextBox()
        ActualizarFormulario()
    End Sub

    'Prueba de que la función CargaDeProductos funciona correctamente.
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    _cargadorDeDatos.CargaDeProductos()
    '    For Each c As Categoria In _supermercado._categorias
    '        For Each p As Producto In c._productos
    '            MsgBox(p._nombre & " " & c._nombre)
    '        Next
    '    Next
    'End Sub
    Public Sub Agregar()
        Dim nombre As String = adTbNombre.Text
        Dim codigo As Integer = adTbCodigo.Text
        Dim marca As String = adTbMarca.Text
        Dim precio As Double = adTbPrecio.Text
        Dim cantidad As String = adTbCantidad.Text
        Dim ruta As String = adTbRuta.Text
        Dim categoria As String = adCBCategoria.Text

        Dim producto As Producto = New Producto(codigo, nombre, marca, precio, cantidad, ruta, categoria)
        adm.AgregarProducto(producto)
        _supermercado.AgregarProducto(adCBCategoria.Text, producto)
        ResetearTextBox()
    End Sub
    Public Sub Eliminar()
        Dim codigoProducto As String = adTbCodigo.Text
        For Each c As Categoria In _supermercado._categorias
            If c._nombre = adCBCategoria.Text Then
                For Each p As Producto In c._productos
                    If p._codigo = codigoProducto Then
                        _supermercado.EliminarProducto(c, p)
                        adm.EliminarProducto(p)
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
        For Each c As Categoria In _supermercado._categorias
            If c._nombre = adCBCategoria.Text Then
                For Each p As Producto In c._productos
                    If p._codigo = codigoProducto Then
                        p._nombre = adTbNombre.Text
                        p._marca = adTbMarca.Text
                        p._precio = adTbPrecio.Text
                        p._cantidad = adTbCantidad.Text
                        If p._categoria IsNot adCBCategoria.Text Then
                            For Each nc As Categoria In _supermercado._categorias
                                If nc._nombre = adCBCategoria.Text Then
                                    nc._productos.Add(p)
                                    c._productos.Remove(p)
                                    Exit For
                                End If
                            Next
                        End If
                        p._categoria = adCBCategoria.Text
                        p._ruta = adTbRuta.Text
                        adm.EditarProducto(p)
                        DGVAdmin.Rows(rowIndex).Cells("Column2").Value = adTbNombre.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column3").Value = adTbMarca.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column4").Value = adTbPrecio.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column5").Value = adTbCantidad.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column6").Value = adCBCategoria.Text
                        DGVAdmin.Rows(rowIndex).Cells("Column7").Value = adTbRuta.Text
                        ResetearTextBox()
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
        For Each c As Categoria In _supermercado._categorias
            If c._nombre = adCBCategoria.Text Then
                For Each p As Producto In c._productos
                    If p._codigo = codigoProducto Then
                        p._cantidad = adTbCantidad.Text
                        adm.Restockear(p)
                        DGVAdmin.Rows(rowIndex).Cells("Column5").Value = adTbCantidad.Text
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
        For Each c As Categoria In _supermercado._categorias
            If c._nombre.ToLower() = textoCategoria.ToLower() Then
                existeCategoria = True
            End If
        Next
        If Not existeCategoria Then
            Dim nuevaCategoria = New Categoria(textoCategoria)
            _supermercado.AgregarCategoria(nuevaCategoria)
            adm.AgregarCategoria(nuevaCategoria)
            MsgBox("Categoria agregada con éxito")
        Else
            MsgBox("La Categoria ya existe")
        End If

    End Sub
    Public Sub EliminarCategoria()
        Dim textoCategoria As String = cbCategoria.Text
        For Each c As Categoria In _supermercado._categorias
            If c._nombre.ToLower() = textoCategoria.ToLower() Then
                _supermercado.EliminarCategoria(c)
                adm.EliminarCategoria(c)
                MsgBox("Categoria eliminada con éxito")
                Exit For
            End If
        Next
    End Sub
    Public Sub ActualizarFormulario()
        cbPorCategoria.Items.Clear()
        adCBCategoria.Items.Clear()
        cbCategoria.Items.Clear()
        _cargadorDeDatos.MostrarProductos(DGVAdmin)
        _cargadorDeDatos.MostrarCategorias(cbPorCategoria)
        _cargadorDeDatos.MostrarCategorias(adCBCategoria)
        _cargadorDeDatos.MostrarCategorias(cbCategoria)

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ResetearTextBox()
        operacion = "agregar"
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRestockear.Enabled = False

        adTbNombre.Enabled = True
        adTbCodigo.Enabled = True
        adTbMarca.Enabled = True
        adTbPrecio.Enabled = True
        adTbRuta.Enabled = True
        adTbCantidad.Enabled = True
        adCBCategoria.Enabled = True
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
        adTbRuta.Text = fila.Cells("Column7").Value.ToString()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "editar"
            adTbNombre.Enabled = True
            adTbMarca.Enabled = True
            adTbPrecio.Enabled = True
            adTbRuta.Enabled = True
            adTbCantidad.Enabled = True
            adCBCategoria.Enabled = True
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnRestockear.Enabled = False
        End If
    End Sub

    Private Sub btnRestockear_Click(sender As Object, e As EventArgs) Handles btnRestockear.Click
        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "restockear"
            adTbCantidad.Enabled = True
            btnAgregar.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False
            btnEditar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "eliminar"
            btnAgregar.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnRestockear.Enabled = False
            btnEditar.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ResetearTextBox()
        End If
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
                        If celdaCodigo.Value Is Nothing OrElse Not celdaCodigo.Value.ToString().ToLower().Contains(buscarTexto) Then
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

    Private Sub btnAgregarC_Click(sender As Object, e As EventArgs) Handles btnAgregarC.Click
        If Not String.IsNullOrEmpty(cbCategoria.Text) Then
            AgregarCategoria()
            cbCategoria.Text = ""
            ActualizarFormulario()
        End If

    End Sub

    Private Sub btnEliminarC_Click(sender As Object, e As EventArgs) Handles btnEliminarC.Click
        If Not String.IsNullOrEmpty(cbCategoria.Text) Then
            EliminarCategoria()
            cbCategoria.Text = ""
            cbPorCategoria.Text = ""
            adCBCategoria.Text = ""
            ActualizarFormulario()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim formLogin = New Form1()
        Me.Close()
        formLogin.Show()
    End Sub
End Class