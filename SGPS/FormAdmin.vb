Imports System.Data.Common
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class FormAdmin
    'Modificación del constructor de FormAdmin para hacer uso de la instancia supermercado
    Private _cargadorDeDatos As CargadorDeDatos
    Private _supermercado As Supermercado
    Private operacion As String
    Public Sub New(supermercado As Supermercado)
        InitializeComponent()
        Me._cargadorDeDatos = New CargadorDeDatos(supermercado)
        Me._supermercado = supermercado
    End Sub
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se cargan los productos de la base de datos al supermercado
        _cargadorDeDatos.CargaDeProductos()
        'Se cargan los productos del supermercado en el Data Grid View
        _cargadorDeDatos.MostrarProductos(DGVAdmin)
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
                MsgBox("Producto modificado con éxito.", MsgBoxStyle.OkOnly, _supermercado._nombre)
            Case "restockear"
                MsgBox("Producto restockeado con éxito.", MsgBoxStyle.OkOnly, _supermercado._nombre)
            Case Else

        End Select
        ResetearTextBox()
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
        Dim adm As Administrador = _supermercado._usuarios(0)

        Dim nombre As String = adTbNombre.Text
        Dim codigo As Integer = adTbCodigo.Text
        Dim marca As String = adTbMarca.Text
        Dim precio As Double = adTbPrecio.Text
        Dim cantidad As String = adTbCantidad.Text
        Dim ruta As String = adTbRuta.Text
        Dim categoria As String = adCBCategoria.Text

        Dim producto As Producto = New Producto(codigo, nombre, marca, precio, cantidad, ruta, categoria)
        adm.AgregarProducto(producto)
        DGVAdmin.Rows.Add(producto._codigo, producto._nombre, producto._marca, producto._precio, producto._cantidad)
        ResetearTextBox()
    End Sub

    Public Sub Eliminar()
        Dim adm As Administrador = _supermercado._usuarios(0)
        Dim codigoProducto As String = adTbCodigo.Text
        For Each c As Categoria In _supermercado._categorias
            If c._nombre = adCBCategoria.Text Then
                For Each p As Producto In c._productos
                    If p._codigo = codigoProducto Then
                        _supermercado.EliminarProducto(c, p)
                        adm.EliminarProducto(p)
                        DGVAdmin.Rows.RemoveAt(DGVAdmin.SelectedRows(0).Index)
                    End If
                    Exit For
                Next
            End If
            Exit For
        Next

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
        btnAgregar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False

        If DGVAdmin.SelectedRows.Count > 0 Then
            operacion = "restockear"
            adTbCantidad.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        operacion = "eliminar"
        btnAgregar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnRestockear.Enabled = False
        btnEditar.Enabled = False

        If DGVAdmin.SelectedRows.Count > 0 Then

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ResetearTextBox()
        End If
    End Sub
End Class