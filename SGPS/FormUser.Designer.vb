<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        DGVProductos = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        tbBuscar = New TextBox()
        cbPorCategoria = New ComboBox()
        btnAgregarProducto = New Button()
        Label2 = New Label()
        btnEliminarProducto = New Button()
        btnVaciarCarrito = New Button()
        btnFinalizarCompra = New Button()
        Label3 = New Label()
        DGVCarrito = New DataGridView()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        btnSalir = New Button()
        lbCarrito = New Label()
        CType(DGVProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVCarrito, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVProductos
        ' 
        DGVProductos.AllowUserToAddRows = False
        DGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVProductos.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DGVProductos.Location = New Point(27, 118)
        DGVProductos.Name = "DGVProductos"
        DGVProductos.RowHeadersWidth = 51
        DGVProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVProductos.Size = New Size(553, 339)
        DGVProductos.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Código"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Visible = False
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nombre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Marca"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Precio"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Cantidad"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Visible = False
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Categoría"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 1
        Label1.Text = "Buscar producto:"
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(27, 76)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(213, 27)
        tbBuscar.TabIndex = 2
        ' 
        ' cbPorCategoria
        ' 
        cbPorCategoria.FormattingEnabled = True
        cbPorCategoria.Location = New Point(367, 76)
        cbPorCategoria.Name = "cbPorCategoria"
        cbPorCategoria.Size = New Size(213, 28)
        cbPorCategoria.TabIndex = 3
        ' 
        ' btnAgregarProducto
        ' 
        btnAgregarProducto.Image = CType(resources.GetObject("btnAgregarProducto.Image"), Image)
        btnAgregarProducto.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarProducto.Location = New Point(186, 471)
        btnAgregarProducto.Name = "btnAgregarProducto"
        btnAgregarProducto.Size = New Size(168, 43)
        btnAgregarProducto.TabIndex = 4
        btnAgregarProducto.Text = "Agregar al carrito"
        btnAgregarProducto.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarProducto.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(367, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 20)
        Label2.TabIndex = 5
        Label2.Text = "Filtrar por categoría:"
        ' 
        ' btnEliminarProducto
        ' 
        btnEliminarProducto.Image = CType(resources.GetObject("btnEliminarProducto.Image"), Image)
        btnEliminarProducto.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarProducto.Location = New Point(638, 471)
        btnEliminarProducto.Name = "btnEliminarProducto"
        btnEliminarProducto.Size = New Size(168, 43)
        btnEliminarProducto.TabIndex = 7
        btnEliminarProducto.Text = "Eliminar producto"
        btnEliminarProducto.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' btnVaciarCarrito
        ' 
        btnVaciarCarrito.Image = CType(resources.GetObject("btnVaciarCarrito.Image"), Image)
        btnVaciarCarrito.ImageAlign = ContentAlignment.MiddleRight
        btnVaciarCarrito.Location = New Point(831, 471)
        btnVaciarCarrito.Name = "btnVaciarCarrito"
        btnVaciarCarrito.Size = New Size(168, 43)
        btnVaciarCarrito.TabIndex = 8
        btnVaciarCarrito.Text = "Vaciar carrito"
        btnVaciarCarrito.TextAlign = ContentAlignment.MiddleLeft
        btnVaciarCarrito.UseVisualStyleBackColor = True
        ' 
        ' btnFinalizarCompra
        ' 
        btnFinalizarCompra.Image = CType(resources.GetObject("btnFinalizarCompra.Image"), Image)
        btnFinalizarCompra.ImageAlign = ContentAlignment.MiddleRight
        btnFinalizarCompra.Location = New Point(1023, 471)
        btnFinalizarCompra.Name = "btnFinalizarCompra"
        btnFinalizarCompra.Size = New Size(168, 43)
        btnFinalizarCompra.TabIndex = 9
        btnFinalizarCompra.Text = "Finalizar compra"
        btnFinalizarCompra.TextAlign = ContentAlignment.MiddleLeft
        btnFinalizarCompra.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(638, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 10
        ' 
        ' DGVCarrito
        ' 
        DGVCarrito.AllowUserToAddRows = False
        DGVCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVCarrito.Columns.AddRange(New DataGridViewColumn() {Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        DGVCarrito.Location = New Point(638, 118)
        DGVCarrito.Name = "DGVCarrito"
        DGVCarrito.RowHeadersWidth = 51
        DGVCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVCarrito.Size = New Size(553, 339)
        DGVCarrito.TabIndex = 11
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Código"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Visible = False
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Nombre"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Marca"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Precio"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Cantidad"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Width = 125
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Categoría"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.Visible = False
        Column12.Width = 125
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Ruta"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.Visible = False
        Column13.Width = 125
        ' 
        ' btnSalir
        ' 
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.Location = New Point(1140, 17)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(51, 55)
        btnSalir.TabIndex = 12
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lbCarrito
        ' 
        lbCarrito.AutoSize = True
        lbCarrito.Location = New Point(638, 84)
        lbCarrito.Name = "lbCarrito"
        lbCarrito.Size = New Size(57, 20)
        lbCarrito.TabIndex = 13
        lbCarrito.Text = "Carrito:"
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1217, 554)
        Controls.Add(lbCarrito)
        Controls.Add(btnSalir)
        Controls.Add(DGVCarrito)
        Controls.Add(Label3)
        Controls.Add(btnFinalizarCompra)
        Controls.Add(btnVaciarCarrito)
        Controls.Add(btnEliminarProducto)
        Controls.Add(Label2)
        Controls.Add(btnAgregarProducto)
        Controls.Add(cbPorCategoria)
        Controls.Add(tbBuscar)
        Controls.Add(Label1)
        Controls.Add(DGVProductos)
        Name = "FormUser"
        Text = "FormUser"
        CType(DGVProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVCarrito, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents cbPorCategoria As ComboBox
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnVaciarCarrito As Button
    Friend WithEvents btnFinalizarCompra As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVCarrito As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents lbCarrito As Label
End Class
