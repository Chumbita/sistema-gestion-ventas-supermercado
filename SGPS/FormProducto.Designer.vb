<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProducto))
        tbNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        tbMarca = New TextBox()
        Label3 = New Label()
        tbPrecio = New TextBox()
        Label4 = New Label()
        tbCategoria = New TextBox()
        Label5 = New Label()
        btnAñadir = New Button()
        btnCancelar = New Button()
        GroupBox1 = New GroupBox()
        btnLess = New Button()
        btnMore = New Button()
        tbCantidad = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbNombre
        ' 
        tbNombre.Enabled = False
        tbNombre.Location = New Point(107, 30)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(235, 27)
        tbNombre.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 3
        Label2.Text = "Marca:"
        ' 
        ' tbMarca
        ' 
        tbMarca.Enabled = False
        tbMarca.Location = New Point(107, 63)
        tbMarca.Name = "tbMarca"
        tbMarca.Size = New Size(235, 27)
        tbMarca.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 5
        Label3.Text = "Precio:"
        ' 
        ' tbPrecio
        ' 
        tbPrecio.Enabled = False
        tbPrecio.Location = New Point(107, 96)
        tbPrecio.Name = "tbPrecio"
        tbPrecio.Size = New Size(235, 27)
        tbPrecio.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 7
        Label4.Text = "Cantidad:"
        ' 
        ' tbCategoria
        ' 
        tbCategoria.Enabled = False
        tbCategoria.Location = New Point(107, 162)
        tbCategoria.Name = "tbCategoria"
        tbCategoria.Size = New Size(235, 27)
        tbCategoria.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 20)
        Label5.TabIndex = 9
        Label5.Text = "Categoría:"
        ' 
        ' btnAñadir
        ' 
        btnAñadir.Image = CType(resources.GetObject("btnAñadir.Image"), Image)
        btnAñadir.ImageAlign = ContentAlignment.MiddleRight
        btnAñadir.Location = New Point(155, 291)
        btnAñadir.Name = "btnAñadir"
        btnAñadir.Size = New Size(109, 42)
        btnAñadir.TabIndex = 11
        btnAñadir.Text = "Añadir"
        btnAñadir.TextAlign = ContentAlignment.MiddleLeft
        btnAñadir.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(302, 291)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(109, 42)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextAlign = ContentAlignment.MiddleLeft
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnLess)
        GroupBox1.Controls.Add(btnMore)
        GroupBox1.Controls.Add(tbCantidad)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbCategoria)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(tbPrecio)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbMarca)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbNombre)
        GroupBox1.Location = New Point(88, 37)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(376, 214)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Producto"
        ' 
        ' btnLess
        ' 
        btnLess.Image = CType(resources.GetObject("btnLess.Image"), Image)
        btnLess.Location = New Point(222, 127)
        btnLess.Name = "btnLess"
        btnLess.Size = New Size(33, 32)
        btnLess.TabIndex = 13
        btnLess.UseVisualStyleBackColor = True
        ' 
        ' btnMore
        ' 
        btnMore.Image = CType(resources.GetObject("btnMore.Image"), Image)
        btnMore.Location = New Point(183, 127)
        btnMore.Name = "btnMore"
        btnMore.Size = New Size(33, 32)
        btnMore.TabIndex = 12
        btnMore.UseVisualStyleBackColor = True
        ' 
        ' tbCantidad
        ' 
        tbCantidad.Location = New Point(107, 129)
        tbCantidad.Name = "tbCantidad"
        tbCantidad.Size = New Size(69, 27)
        tbCantidad.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(90, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(288, 20)
        Label6.TabIndex = 14
        Label6.Text = "Modifique la cantidad que desea comprar"
        ' 
        ' FormProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 356)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Controls.Add(btnCancelar)
        Controls.Add(btnAñadir)
        Name = "FormProducto"
        Text = "FormProducto"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnMore As Button
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents btnLess As Button
End Class
