Imports System.Data.Common
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class FormAdmin
    'Modificación del constructor de FormAdmin para hacer uso de la instancia supermercado
    Private _cargadorDeDatos As CargadorDeDatos
    Private _supermercado As Supermercado
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        LimpiarTextBox()

    End Sub

    Public Sub LimpiarTextBox()
        adTbNombre.Text = " "
        adTbCodigo.Text = " "
        adTbMarca.Text = " "
        adTbPrecio.Text = " "
        adTbCantidad.Text = " "
        adTbRuta.Text = " "
        adCBCategoria.Text = " "
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
End Class