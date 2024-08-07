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
        DGVUser = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        tbBuscar = New TextBox()
        cbPorCategoria = New ComboBox()
        Button1 = New Button()
        Label2 = New Label()
        btnEliminar = New Button()
        btnVaciar = New Button()
        btnFinalizar = New Button()
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
        CType(DGVUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVCarrito, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVUser
        ' 
        DGVUser.AllowUserToAddRows = False
        DGVUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVUser.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DGVUser.Location = New Point(24, 133)
        DGVUser.Name = "DGVUser"
        DGVUser.RowHeadersWidth = 51
        DGVUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVUser.Size = New Size(469, 251)
        DGVUser.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Código"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
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
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 1
        Label1.Text = "Buscar producto:"
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(24, 91)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(194, 27)
        tbBuscar.TabIndex = 2
        ' 
        ' cbPorCategoria
        ' 
        cbPorCategoria.FormattingEnabled = True
        cbPorCategoria.Location = New Point(298, 91)
        cbPorCategoria.Name = "cbPorCategoria"
        cbPorCategoria.Size = New Size(194, 28)
        cbPorCategoria.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(183, 403)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 43)
        Button1.TabIndex = 4
        Button1.Text = "Agregar al carrito"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(295, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 20)
        Label2.TabIndex = 5
        Label2.Text = "Filtrar por categoría:"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(529, 403)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(149, 43)
        btnEliminar.TabIndex = 7
        btnEliminar.Text = "Eliminar producto"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnVaciar
        ' 
        btnVaciar.Location = New Point(683, 403)
        btnVaciar.Name = "btnVaciar"
        btnVaciar.Size = New Size(149, 43)
        btnVaciar.TabIndex = 8
        btnVaciar.Text = "Vaciar carrito"
        btnVaciar.UseVisualStyleBackColor = True
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.Location = New Point(839, 403)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(149, 43)
        btnFinalizar.TabIndex = 9
        btnFinalizar.Text = "Finalizar compra"
        btnFinalizar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(529, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 10
        Label3.Text = "Carrito:"
        ' 
        ' DGVCarrito
        ' 
        DGVCarrito.AllowUserToAddRows = False
        DGVCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVCarrito.Columns.AddRange(New DataGridViewColumn() {Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        DGVCarrito.Location = New Point(529, 133)
        DGVCarrito.Name = "DGVCarrito"
        DGVCarrito.RowHeadersWidth = 51
        DGVCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVCarrito.Size = New Size(437, 251)
        DGVCarrito.TabIndex = 11
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Código"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
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
        btnSalir.Location = New Point(943, 24)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 29)
        btnSalir.TabIndex = 12
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 521)
        Controls.Add(btnSalir)
        Controls.Add(DGVCarrito)
        Controls.Add(Label3)
        Controls.Add(btnFinalizar)
        Controls.Add(btnVaciar)
        Controls.Add(btnEliminar)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(cbPorCategoria)
        Controls.Add(tbBuscar)
        Controls.Add(Label1)
        Controls.Add(DGVUser)
        Name = "FormUser"
        Text = "FormUser"
        CType(DGVUser, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVCarrito, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVUser As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents cbPorCategoria As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DGVCarrito As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
End Class
