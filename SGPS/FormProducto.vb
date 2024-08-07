Public Class FormProducto
    Dim _producto As Producto
    Dim _carrito As Carrito
    Dim _dgv As DataGridView
    Public Sub New(producto As Producto, carrito As Carrito, dgv As DataGridView)
        InitializeComponent()
        Me._producto = producto
        Me._carrito = carrito
        Me._dgv = dgv
    End Sub
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNombre.Text = _producto._nombre
        tbMarca.Text = _producto._marca
        tbPrecio.Text = _producto._precio
        cbCantidad.Text = _producto._cantidad
        tbCategoria.Text = _producto._categoria
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        _producto._cantidad = cbCantidad.Text
        _carrito._productos.Add(_producto)
        Me.Close()
        _carrito.MostrarCarrito(_dgv)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class