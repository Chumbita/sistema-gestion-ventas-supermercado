Public Class Form1
    Dim supermercado As Supermercado
    Dim cargadorDeDatos As CargadorDeDatos

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciamos el supermercado
        supermercado = New Supermercado("Marito SA")
        cargadorDeDatos = New CargadorDeDatos(supermercado)
        'Se cargan los usuarios registrados en la base de datos en el supermercado.
        cargadorDeDatos.CargaDeUsuarios()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Botón "Registrarse" que hace aparecer u ocultar la sección de "Registrar Usuario"
        gbRegistrar.Visible = Not gbRegistrar.Visible
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = lgTbUsuario.Text
        Dim contraseña As String = lgTbContraseña.Text
        Dim flag As Boolean = False

        For Each user As Usuario In supermercado._usuarios
            If usuario = user._usuario AndAlso contraseña = user._contraseña Then
                If user._usuario = "admin" Then
                    Dim formAdmin = New FormAdmin(supermercado)
                    formAdmin.Show()
                    Me.Hide()
                    flag = True
                Else
                    Dim formUser As New FormUser(supermercado)
                    formUser.Show()
                    Me.Hide()
                    flag = True
                End If
                Exit For
            End If
        Next

        If Not flag Then
            MsgBox("El usuario o contraseña son incorrectos.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Registro de nuevo usuario en memoria
        Dim nuevoUsuario As Usuario
        Dim user As String = rgTbUsuario.Text
        Dim nombre As String = rgTbNombre.Text & " " & rgTbApellido.Text
        Dim contraseña As String = rgTbContraseña.Text

        'Usuario creado en memoria
        nuevoUsuario = New Usuario(user, nombre, contraseña)
        supermercado.AgregarUsuario(nuevoUsuario)
        MsgBox("Usuario creado con éxito")
        rgTbUsuario.Text = " "
        rgTbNombre.Text = " "
        rgTbApellido.Text = " "
        rgTbContraseña.Text = " "

        'Agregar funcionalidad para agregar el nuevo usuario en la Base de Datos
    End Sub
End Class
