Public Class FormUser
    Private _cargadorDeDatos As CargadorDeDatos
    Private _supermercado As Supermercado
    Public Sub New(supermercado As Supermercado)
        InitializeComponent()
        Me._cargadorDeDatos = New CargadorDeDatos(supermercado)
        Me._supermercado = supermercado
    End Sub
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cargadorDeDatos.CargaDeProductos()
        _cargadorDeDatos.MostrarProductos(DGVUser)
    End Sub
End Class