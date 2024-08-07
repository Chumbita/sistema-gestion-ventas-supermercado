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
        tbNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        tbMarca = New TextBox()
        Label3 = New Label()
        tbPrecio = New TextBox()
        Label4 = New Label()
        tbCategoria = New TextBox()
        Label5 = New Label()
        cbCantidad = New ComboBox()
        btnAñadir = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' tbNombre
        ' 
        tbNombre.Enabled = False
        tbNombre.Location = New Point(287, 90)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(125, 27)
        tbNombre.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(208, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(208, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 3
        Label2.Text = "Marca:"
        ' 
        ' tbMarca
        ' 
        tbMarca.Enabled = False
        tbMarca.Location = New Point(287, 123)
        tbMarca.Name = "tbMarca"
        tbMarca.Size = New Size(125, 27)
        tbMarca.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(208, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 5
        Label3.Text = "Precio:"
        ' 
        ' tbPrecio
        ' 
        tbPrecio.Enabled = False
        tbPrecio.Location = New Point(287, 156)
        tbPrecio.Name = "tbPrecio"
        tbPrecio.Size = New Size(125, 27)
        tbPrecio.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(208, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 7
        Label4.Text = "Cantidad:"
        ' 
        ' tbCategoria
        ' 
        tbCategoria.Enabled = False
        tbCategoria.Location = New Point(287, 222)
        tbCategoria.Name = "tbCategoria"
        tbCategoria.Size = New Size(125, 27)
        tbCategoria.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(208, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 20)
        Label5.TabIndex = 9
        Label5.Text = "Categoría:"
        ' 
        ' cbCantidad
        ' 
        cbCantidad.FormattingEnabled = True
        cbCantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        cbCantidad.Location = New Point(287, 188)
        cbCantidad.Name = "cbCantidad"
        cbCantidad.Size = New Size(125, 28)
        cbCantidad.TabIndex = 10
        ' 
        ' btnAñadir
        ' 
        btnAñadir.Location = New Point(208, 273)
        btnAñadir.Name = "btnAñadir"
        btnAñadir.Size = New Size(94, 29)
        btnAñadir.TabIndex = 11
        btnAñadir.Text = "Añadir"
        btnAñadir.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(337, 273)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FormProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 386)
        Controls.Add(btnCancelar)
        Controls.Add(btnAñadir)
        Controls.Add(cbCantidad)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(tbCategoria)
        Controls.Add(Label3)
        Controls.Add(tbPrecio)
        Controls.Add(Label2)
        Controls.Add(tbMarca)
        Controls.Add(Label1)
        Controls.Add(tbNombre)
        Name = "FormProducto"
        Text = "FormProducto"
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
    Friend WithEvents cbCantidad As ComboBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnCancelar As Button
End Class
