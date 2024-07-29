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
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        DGVAdmin = New DataGridView()
        Button1 = New Button()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
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
        Button5 = New Button()
        GroupBox1 = New GroupBox()
        adTbRuta = New TextBox()
        Label9 = New Label()
        adCBCategoria = New ComboBox()
        Label8 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(DGVAdmin, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "Buscar Producto:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(187, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 27)
        TextBox1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(187, 125)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(180, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' DGVAdmin
        ' 
        DGVAdmin.AllowUserToAddRows = False
        DGVAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVAdmin.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DGVAdmin.Location = New Point(38, 172)
        DGVAdmin.Name = "DGVAdmin"
        DGVAdmin.RowHeadersWidth = 51
        DGVAdmin.Size = New Size(633, 188)
        DGVAdmin.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(38, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 37)
        Button1.TabIndex = 4
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 20)
        Label3.TabIndex = 6
        Label3.Text = "Filtrar por categoría:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(383, 89)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(104, 24)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Por Código"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(493, 89)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 24)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Por Nombre"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(498, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 37)
        Button2.TabIndex = 9
        Button2.Text = "Restockear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(187, 377)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 37)
        Button3.TabIndex = 10
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(345, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 37)
        Button4.TabIndex = 11
        Button4.Text = "Editar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' adTbPrecio
        ' 
        adTbPrecio.Location = New Point(127, 155)
        adTbPrecio.Name = "adTbPrecio"
        adTbPrecio.Size = New Size(199, 27)
        adTbPrecio.TabIndex = 15
        ' 
        ' adTbMarca
        ' 
        adTbMarca.Location = New Point(127, 119)
        adTbMarca.Name = "adTbMarca"
        adTbMarca.Size = New Size(199, 27)
        adTbMarca.TabIndex = 14
        ' 
        ' adTbCodigo
        ' 
        adTbCodigo.Location = New Point(127, 83)
        adTbCodigo.Name = "adTbCodigo"
        adTbCodigo.Size = New Size(199, 27)
        adTbCodigo.TabIndex = 13
        ' 
        ' adTbNombre
        ' 
        adTbNombre.Location = New Point(127, 47)
        adTbNombre.Name = "adTbNombre"
        adTbNombre.Size = New Size(199, 27)
        adTbNombre.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 19
        Label6.Text = "Precio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 18
        Label5.Text = "Marca:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 17
        Label4.Text = "Código:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 16
        Label2.Text = "Nombre:"
        ' 
        ' adTbCantidad
        ' 
        adTbCantidad.Location = New Point(127, 191)
        adTbCantidad.Name = "adTbCantidad"
        adTbCantidad.Size = New Size(199, 27)
        adTbCantidad.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 21
        Label7.Text = "Cantidad:"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(1002, 432)
        Button5.Name = "Button5"
        Button5.Size = New Size(105, 37)
        Button5.TabIndex = 22
        Button5.Text = "Guardar"
        Button5.UseVisualStyleBackColor = True
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
        GroupBox1.Location = New Point(875, 125)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 317)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Producto"
        ' 
        ' adTbRuta
        ' 
        adTbRuta.Location = New Point(127, 262)
        adTbRuta.Name = "adTbRuta"
        adTbRuta.Size = New Size(199, 27)
        adTbRuta.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(31, 260)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 20)
        Label9.TabIndex = 25
        Label9.Text = "Ruta:"
        ' 
        ' adCBCategoria
        ' 
        adCBCategoria.FormattingEnabled = True
        adCBCategoria.Items.AddRange(New Object() {"Lacteos"})
        adCBCategoria.Location = New Point(127, 225)
        adCBCategoria.Name = "adCBCategoria"
        adCBCategoria.Size = New Size(199, 28)
        adCBCategoria.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(31, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 20)
        Label8.TabIndex = 23
        Label8.Text = "Categoria:"
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
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1299, 491)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(DGVAdmin)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "FormAdmin"
        Text = "FormAdmin"
        CType(DGVAdmin, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DGVAdmin As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
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
    Friend WithEvents Button5 As Button
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
End Class
