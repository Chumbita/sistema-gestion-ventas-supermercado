<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Label1 = New Label()
        tbBuscar = New TextBox()
        cbPorCategoria = New ComboBox()
        DGVAdmin = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        btnAgregar = New Button()
        Label3 = New Label()
        rbPorCodigo = New RadioButton()
        rbPorNombre = New RadioButton()
        btnRestockear = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        adTbPrecio = New TextBox()
        adTbMarca = New TextBox()
        adTbCodigo = New TextBox()
        adTbNombre = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        adTbCantidad = New TextBox()
        Label7 = New Label()
        btnGuardar = New Button()
        GroupBox1 = New GroupBox()
        adTbRuta = New TextBox()
        Label9 = New Label()
        adCBCategoria = New ComboBox()
        Label8 = New Label()
        btnCancelar = New Button()
        Label10 = New Label()
        btnEliminarC = New Button()
        cbCate = New ComboBox()
        btnGuardarC = New Button()
        CType(DGVAdmin, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 92)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 21)
        Label1.TabIndex = 0
        Label1.Text = "Buscar Producto:"
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(209, 89)
        tbBuscar.Margin = New Padding(2, 3, 2, 3)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(202, 29)
        tbBuscar.TabIndex = 1
        ' 
        ' cbPorCategoria
        ' 
        cbPorCategoria.FormattingEnabled = True
        cbPorCategoria.Items.AddRange(New Object() {""})
        cbPorCategoria.Location = New Point(209, 131)
        cbPorCategoria.Margin = New Padding(2, 3, 2, 3)
        cbPorCategoria.Name = "cbPorCategoria"
        cbPorCategoria.Size = New Size(202, 29)
        cbPorCategoria.TabIndex = 2
        ' 
        ' DGVAdmin
        ' 
        DGVAdmin.AllowUserToAddRows = False
        DGVAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVAdmin.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DGVAdmin.Location = New Point(43, 181)
        DGVAdmin.Margin = New Padding(2, 3, 2, 3)
        DGVAdmin.Name = "DGVAdmin"
        DGVAdmin.RowHeadersWidth = 51
        DGVAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVAdmin.Size = New Size(712, 197)
        DGVAdmin.TabIndex = 3
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
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Categoria"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Ruta"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Visible = False
        Column7.Width = 125
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(43, 396)
        btnAgregar.Margin = New Padding(2, 3, 2, 3)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(118, 39)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 134)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 21)
        Label3.TabIndex = 6
        Label3.Text = "Filtrar por categoría:"
        ' 
        ' rbPorCodigo
        ' 
        rbPorCodigo.AutoSize = True
        rbPorCodigo.Location = New Point(431, 92)
        rbPorCodigo.Margin = New Padding(2, 3, 2, 3)
        rbPorCodigo.Name = "rbPorCodigo"
        rbPorCodigo.Size = New Size(108, 25)
        rbPorCodigo.TabIndex = 7
        rbPorCodigo.TabStop = True
        rbPorCodigo.Text = "Por Código"
        rbPorCodigo.UseVisualStyleBackColor = True
        ' 
        ' rbPorNombre
        ' 
        rbPorNombre.AutoSize = True
        rbPorNombre.Checked = True
        rbPorNombre.Location = New Point(556, 92)
        rbPorNombre.Margin = New Padding(2, 3, 2, 3)
        rbPorNombre.Name = "rbPorNombre"
        rbPorNombre.Size = New Size(116, 25)
        rbPorNombre.TabIndex = 8
        rbPorNombre.TabStop = True
        rbPorNombre.Text = "Por Nombre"
        rbPorNombre.UseVisualStyleBackColor = True
        ' 
        ' btnRestockear
        ' 
        btnRestockear.Location = New Point(560, 396)
        btnRestockear.Margin = New Padding(2, 3, 2, 3)
        btnRestockear.Name = "btnRestockear"
        btnRestockear.Size = New Size(118, 39)
        btnRestockear.TabIndex = 9
        btnRestockear.Text = "Restockear"
        btnRestockear.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(209, 396)
        btnEliminar.Margin = New Padding(2, 3, 2, 3)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(118, 39)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(388, 396)
        btnEditar.Margin = New Padding(2, 3, 2, 3)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(118, 39)
        btnEditar.TabIndex = 11
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' adTbPrecio
        ' 
        adTbPrecio.Enabled = False
        adTbPrecio.Location = New Point(143, 163)
        adTbPrecio.Margin = New Padding(2, 3, 2, 3)
        adTbPrecio.Name = "adTbPrecio"
        adTbPrecio.Size = New Size(222, 29)
        adTbPrecio.TabIndex = 15
        ' 
        ' adTbMarca
        ' 
        adTbMarca.Enabled = False
        adTbMarca.Location = New Point(143, 125)
        adTbMarca.Margin = New Padding(2, 3, 2, 3)
        adTbMarca.Name = "adTbMarca"
        adTbMarca.Size = New Size(222, 29)
        adTbMarca.TabIndex = 14
        ' 
        ' adTbCodigo
        ' 
        adTbCodigo.Enabled = False
        adTbCodigo.Location = New Point(143, 87)
        adTbCodigo.Margin = New Padding(2, 3, 2, 3)
        adTbCodigo.Name = "adTbCodigo"
        adTbCodigo.Size = New Size(222, 29)
        adTbCodigo.TabIndex = 13
        ' 
        ' adTbNombre
        ' 
        adTbNombre.Enabled = False
        adTbNombre.Location = New Point(143, 49)
        adTbNombre.Margin = New Padding(2, 3, 2, 3)
        adTbNombre.Name = "adTbNombre"
        adTbNombre.Size = New Size(222, 29)
        adTbNombre.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 164)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 21)
        Label6.TabIndex = 19
        Label6.Text = "Precio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 129)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 21)
        Label5.TabIndex = 18
        Label5.Text = "Marca:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 89)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 21)
        Label4.TabIndex = 17
        Label4.Text = "Código:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 55)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 21)
        Label2.TabIndex = 16
        Label2.Text = "Nombre:"
        ' 
        ' adTbCantidad
        ' 
        adTbCantidad.Enabled = False
        adTbCantidad.Location = New Point(143, 202)
        adTbCantidad.Margin = New Padding(2, 3, 2, 3)
        adTbCantidad.Name = "adTbCantidad"
        adTbCantidad.Size = New Size(222, 29)
        adTbCantidad.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(35, 202)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 21)
        Label7.TabIndex = 21
        Label7.Text = "Cantidad:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Enabled = False
        btnGuardar.Location = New Point(823, 441)
        btnGuardar.Margin = New Padding(2, 3, 2, 3)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(118, 39)
        btnGuardar.TabIndex = 22
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(adTbRuta)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(adCBCategoria)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(adTbCantidad)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(adTbPrecio)
        GroupBox1.Controls.Add(adTbMarca)
        GroupBox1.Controls.Add(adTbCodigo)
        GroupBox1.Controls.Add(adTbNombre)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(776, 111)
        GroupBox1.Margin = New Padding(2, 3, 2, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 3, 2, 3)
        GroupBox1.Size = New Size(406, 324)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Producto"
        ' 
        ' adTbRuta
        ' 
        adTbRuta.Enabled = False
        adTbRuta.Location = New Point(143, 274)
        adTbRuta.Margin = New Padding(2, 3, 2, 3)
        adTbRuta.Name = "adTbRuta"
        adTbRuta.Size = New Size(222, 29)
        adTbRuta.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(35, 273)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 21)
        Label9.TabIndex = 25
        Label9.Text = "Ruta:"
        ' 
        ' adCBCategoria
        ' 
        adCBCategoria.Enabled = False
        adCBCategoria.FormattingEnabled = True
        adCBCategoria.Items.AddRange(New Object() {"Lacteos"})
        adCBCategoria.Location = New Point(143, 236)
        adCBCategoria.Margin = New Padding(2, 3, 2, 3)
        adCBCategoria.Name = "adCBCategoria"
        adCBCategoria.Size = New Size(222, 29)
        adCBCategoria.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(35, 239)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 21)
        Label8.TabIndex = 23
        Label8.Text = "Categoria:"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Enabled = False
        btnCancelar.Location = New Point(1023, 441)
        btnCancelar.Margin = New Padding(2, 3, 2, 3)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(118, 39)
        btnCancelar.TabIndex = 24
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1224, 157)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 21)
        Label10.TabIndex = 0
        Label10.Text = "Categoria:"
        ' 
        ' btnEliminarC
        ' 
        btnEliminarC.Location = New Point(1210, 229)
        btnEliminarC.Name = "btnEliminarC"
        btnEliminarC.Size = New Size(119, 40)
        btnEliminarC.TabIndex = 25
        btnEliminarC.Text = "Eliminar"
        btnEliminarC.UseVisualStyleBackColor = True
        ' 
        ' cbCate
        ' 
        cbCate.FormattingEnabled = True
        cbCate.Items.AddRange(New Object() {"Lacteos", "Bebidas", "Electrodomésticos", "Panaderia", "Mario"})
        cbCate.Location = New Point(1197, 194)
        cbCate.Margin = New Padding(2, 3, 2, 3)
        cbCate.Name = "cbCate"
        cbCate.Size = New Size(142, 29)
        cbCate.TabIndex = 2
        ' 
        ' btnGuardarC
        ' 
        btnGuardarC.Location = New Point(1210, 275)
        btnGuardarC.Name = "btnGuardarC"
        btnGuardarC.Size = New Size(119, 40)
        btnGuardarC.TabIndex = 25
        btnGuardarC.Text = "Guardar"
        btnGuardarC.UseVisualStyleBackColor = True
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1420, 548)
        Controls.Add(btnGuardarC)
        Controls.Add(btnEliminarC)
        Controls.Add(btnCancelar)
        Controls.Add(GroupBox1)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnEliminar)
        Controls.Add(btnRestockear)
        Controls.Add(rbPorNombre)
        Controls.Add(rbPorCodigo)
        Controls.Add(Label3)
        Controls.Add(btnAgregar)
        Controls.Add(DGVAdmin)
        Controls.Add(cbCate)
        Controls.Add(cbPorCategoria)
        Controls.Add(tbBuscar)
        Controls.Add(Label10)
        Controls.Add(Label1)
        Margin = New Padding(2, 3, 2, 3)
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(DGVAdmin, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents cbPorCategoria As ComboBox
    Friend WithEvents DGVAdmin As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents rbPorCodigo As RadioButton
    Friend WithEvents rbPorNombre As RadioButton
    Friend WithEvents btnRestockear As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents adTbPrecio As TextBox
    Friend WithEvents adTbMarca As TextBox
    Friend WithEvents adTbCodigo As TextBox
    Friend WithEvents adTbNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents adTbCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents adCBCategoria As ComboBox
    Friend WithEvents adTbRuta As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEliminarC As Button
    Friend WithEvents cbCate As ComboBox
    Friend WithEvents btnGuardarC As Button
End Class
