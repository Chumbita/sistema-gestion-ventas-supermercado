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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Label1 = New Label()
        tbBuscar = New TextBox()
        cbPorCategoria = New ComboBox()
        DGVAdmin = New DataGridView()
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
        adCBCategoria = New ComboBox()
        Label8 = New Label()
        btnCancelar = New Button()
        Label10 = New Label()
        btnEliminarCategoria = New Button()
        cbCategoria = New ComboBox()
        btnAgregarCategoria = New Button()
        btnSalir = New Button()
        GroupBox2 = New GroupBox()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        CType(DGVAdmin, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 53)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "Buscar Producto:"
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(169, 50)
        tbBuscar.Margin = New Padding(2, 3, 2, 3)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(277, 27)
        tbBuscar.TabIndex = 1
        ' 
        ' cbPorCategoria
        ' 
        cbPorCategoria.FormattingEnabled = True
        cbPorCategoria.Items.AddRange(New Object() {" "})
        cbPorCategoria.Location = New Point(169, 90)
        cbPorCategoria.Margin = New Padding(2, 3, 2, 3)
        cbPorCategoria.Name = "cbPorCategoria"
        cbPorCategoria.Size = New Size(277, 28)
        cbPorCategoria.TabIndex = 2
        ' 
        ' DGVAdmin
        ' 
        DGVAdmin.AllowUserToAddRows = False
        DGVAdmin.AllowUserToDeleteRows = False
        DGVAdmin.AllowUserToResizeColumns = False
        DGVAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVAdmin.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DGVAdmin.Location = New Point(21, 137)
        DGVAdmin.Margin = New Padding(2, 3, 2, 3)
        DGVAdmin.Name = "DGVAdmin"
        DGVAdmin.ReadOnly = True
        DGVAdmin.RowHeadersWidth = 51
        DGVAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVAdmin.Size = New Size(678, 353)
        DGVAdmin.TabIndex = 3
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), Image)
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(21, 514)
        btnAgregar.Margin = New Padding(2, 3, 2, 3)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(119, 44)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 93)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 20)
        Label3.TabIndex = 6
        Label3.Text = "Filtrar por categoría:"
        ' 
        ' rbPorCodigo
        ' 
        rbPorCodigo.AutoSize = True
        rbPorCodigo.Location = New Point(469, 53)
        rbPorCodigo.Margin = New Padding(2, 3, 2, 3)
        rbPorCodigo.Name = "rbPorCodigo"
        rbPorCodigo.Size = New Size(104, 24)
        rbPorCodigo.TabIndex = 7
        rbPorCodigo.TabStop = True
        rbPorCodigo.Text = "Por Código"
        rbPorCodigo.UseVisualStyleBackColor = True
        ' 
        ' rbPorNombre
        ' 
        rbPorNombre.AutoSize = True
        rbPorNombre.Checked = True
        rbPorNombre.Location = New Point(580, 53)
        rbPorNombre.Margin = New Padding(2, 3, 2, 3)
        rbPorNombre.Name = "rbPorNombre"
        rbPorNombre.Size = New Size(110, 24)
        rbPorNombre.TabIndex = 8
        rbPorNombre.TabStop = True
        rbPorNombre.Text = "Por Nombre"
        rbPorNombre.UseVisualStyleBackColor = True
        ' 
        ' btnRestockear
        ' 
        btnRestockear.Image = CType(resources.GetObject("btnRestockear.Image"), Image)
        btnRestockear.ImageAlign = ContentAlignment.MiddleRight
        btnRestockear.Location = New Point(580, 514)
        btnRestockear.Margin = New Padding(2, 3, 2, 3)
        btnRestockear.Name = "btnRestockear"
        btnRestockear.Size = New Size(119, 44)
        btnRestockear.TabIndex = 9
        btnRestockear.Text = "Restockear"
        btnRestockear.TextAlign = ContentAlignment.MiddleLeft
        btnRestockear.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(202, 514)
        btnEliminar.Margin = New Padding(2, 3, 2, 3)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(119, 44)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextAlign = ContentAlignment.MiddleLeft
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(389, 514)
        btnEditar.Margin = New Padding(2, 3, 2, 3)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(119, 44)
        btnEditar.TabIndex = 11
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' adTbPrecio
        ' 
        adTbPrecio.Enabled = False
        adTbPrecio.Location = New Point(129, 159)
        adTbPrecio.Margin = New Padding(2, 3, 2, 3)
        adTbPrecio.Name = "adTbPrecio"
        adTbPrecio.Size = New Size(198, 27)
        adTbPrecio.TabIndex = 15
        ' 
        ' adTbMarca
        ' 
        adTbMarca.Enabled = False
        adTbMarca.Location = New Point(129, 123)
        adTbMarca.Margin = New Padding(2, 3, 2, 3)
        adTbMarca.Name = "adTbMarca"
        adTbMarca.Size = New Size(198, 27)
        adTbMarca.TabIndex = 14
        ' 
        ' adTbCodigo
        ' 
        adTbCodigo.Enabled = False
        adTbCodigo.Location = New Point(129, 87)
        adTbCodigo.Margin = New Padding(2, 3, 2, 3)
        adTbCodigo.Name = "adTbCodigo"
        adTbCodigo.Size = New Size(198, 27)
        adTbCodigo.TabIndex = 13
        ' 
        ' adTbNombre
        ' 
        adTbNombre.Enabled = False
        adTbNombre.Location = New Point(129, 51)
        adTbNombre.Margin = New Padding(2, 3, 2, 3)
        adTbNombre.Name = "adTbNombre"
        adTbNombre.Size = New Size(198, 27)
        adTbNombre.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 160)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 19
        Label6.Text = "Precio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 127)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 18
        Label5.Text = "Marca:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 89)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 17
        Label4.Text = "Código:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 56)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 16
        Label2.Text = "Nombre:"
        ' 
        ' adTbCantidad
        ' 
        adTbCantidad.Enabled = False
        adTbCantidad.Location = New Point(129, 196)
        adTbCantidad.Margin = New Padding(2, 3, 2, 3)
        adTbCantidad.Name = "adTbCantidad"
        adTbCantidad.Size = New Size(198, 27)
        adTbCantidad.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 196)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 21
        Label7.Text = "Cantidad:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Enabled = False
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(736, 446)
        btnGuardar.Margin = New Padding(2, 3, 2, 3)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(119, 44)
        btnGuardar.TabIndex = 22
        btnGuardar.Text = "Guardar"
        btnGuardar.TextAlign = ContentAlignment.MiddleLeft
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
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
        GroupBox1.Location = New Point(716, 126)
        GroupBox1.Margin = New Padding(2, 3, 2, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 3, 2, 3)
        GroupBox1.Size = New Size(361, 296)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Producto"
        ' 
        ' adCBCategoria
        ' 
        adCBCategoria.Enabled = False
        adCBCategoria.FormattingEnabled = True
        adCBCategoria.Location = New Point(129, 229)
        adCBCategoria.Margin = New Padding(2, 3, 2, 3)
        adCBCategoria.Name = "adCBCategoria"
        adCBCategoria.Size = New Size(198, 28)
        adCBCategoria.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(33, 232)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 20)
        Label8.TabIndex = 23
        Label8.Text = "Categoria:"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Enabled = False
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(938, 446)
        btnCancelar.Margin = New Padding(2, 3, 2, 3)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(119, 44)
        btnCancelar.TabIndex = 24
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextAlign = ContentAlignment.MiddleLeft
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1119, 98)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 20)
        Label10.TabIndex = 0
        ' 
        ' btnEliminarCategoria
        ' 
        btnEliminarCategoria.Image = CType(resources.GetObject("btnEliminarCategoria.Image"), Image)
        btnEliminarCategoria.ImageAlign = ContentAlignment.MiddleRight
        btnEliminarCategoria.Location = New Point(51, 129)
        btnEliminarCategoria.Name = "btnEliminarCategoria"
        btnEliminarCategoria.Size = New Size(117, 44)
        btnEliminarCategoria.TabIndex = 25
        btnEliminarCategoria.Text = "Eliminar"
        btnEliminarCategoria.TextAlign = ContentAlignment.MiddleLeft
        btnEliminarCategoria.UseVisualStyleBackColor = True
        ' 
        ' cbCategoria
        ' 
        cbCategoria.FormattingEnabled = True
        cbCategoria.Location = New Point(12, 34)
        cbCategoria.Margin = New Padding(2, 3, 2, 3)
        cbCategoria.Name = "cbCategoria"
        cbCategoria.Size = New Size(199, 28)
        cbCategoria.TabIndex = 2
        ' 
        ' btnAgregarCategoria
        ' 
        btnAgregarCategoria.Image = CType(resources.GetObject("btnAgregarCategoria.Image"), Image)
        btnAgregarCategoria.ImageAlign = ContentAlignment.MiddleRight
        btnAgregarCategoria.Location = New Point(51, 78)
        btnAgregarCategoria.Name = "btnAgregarCategoria"
        btnAgregarCategoria.Size = New Size(119, 44)
        btnAgregarCategoria.TabIndex = 25
        btnAgregarCategoria.Text = "Agregar"
        btnAgregarCategoria.TextAlign = ContentAlignment.MiddleLeft
        btnAgregarCategoria.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.Location = New Point(1259, 25)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(48, 48)
        btnSalir.TabIndex = 26
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnEliminarCategoria)
        GroupBox2.Controls.Add(cbCategoria)
        GroupBox2.Controls.Add(btnAgregarCategoria)
        GroupBox2.Location = New Point(1096, 126)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(216, 195)
        GroupBox2.TabIndex = 27
        GroupBox2.TabStop = False
        GroupBox2.Text = "Categoría"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Código"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nombre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Marca"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Precio"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Cantidad"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Categoria"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Ruta"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Visible = False
        Column7.Width = 125
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 585)
        Controls.Add(GroupBox2)
        Controls.Add(btnSalir)
        Controls.Add(btnCancelar)
        Controls.Add(Label10)
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
        Controls.Add(cbPorCategoria)
        Controls.Add(tbBuscar)
        Controls.Add(Label1)
        Margin = New Padding(2, 3, 2, 3)
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(DGVAdmin, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
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
    Friend WithEvents adCBCategoria As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEliminarCategoria As Button
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
