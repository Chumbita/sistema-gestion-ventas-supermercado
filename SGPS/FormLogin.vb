Public Class FormLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instancias del supermercado y el cargadorDeDatos
        miSupermercado = New Supermercado("Marito SA")
        cargadorDatos = New CargadorDeDatos()
        'Se cargan los usuarios registrados en la base de datos en el supermercado.
        cargadorDatos.CargaDeUsuarios()
        _administrador = New Administrador(0, "admin", "Administrador", "admin")
        miSupermercado.AgregarUsuario(_administrador)
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nombreUsuario As String = lgTbUsuario.Text
        Dim contraseña As String = lgTbContraseña.Text
        Dim usuarioEncontrado As Boolean = False

        For Each usuario As Usuario In miSupermercado._usuarios
            If nombreUsuario = usuario._usuario AndAlso contraseña = usuario._contraseña Then
                usuarioEncontrado = True

                If usuario._usuario = "admin" Then
                    Dim formAdmin = New FormAdmin()
                    formAdmin.Show()
                Else
                    Dim formUser As New FormUser()
                    formUser.Show()
                    _cliente = usuario
                End If

                Me.Hide()

                Exit For
            End If
        Next

        If Not usuarioEncontrado Then
            MsgBox("Usuario o contraseña incorrectos. Intente nuevamente", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim puedeRegistrarse As Boolean = True
        Dim nombreUsuarioNuevo As String = rgTbUsuario.Text
        Dim nombreCompleto As String = rgTbNombre.Text & " " & rgTbApellido.Text
        Dim contrasenaNueva As String = rgTbContraseña.Text

        For Each usuario As Usuario In miSupermercado._usuarios
            If usuario._usuario = nombreUsuarioNuevo Then
                puedeRegistrarse = False
                Exit For
            End If
        Next

        If puedeRegistrarse Then
            Dim idUsuario As Integer = miSupermercado._usuarios(miSupermercado._usuarios.Count - 1)._id + 1
            Dim nuevoUsuario As New Cliente(idUsuario, nombreUsuarioNuevo, nombreCompleto, contrasenaNueva)
            miSupermercado.RegistrarUsuario(nuevoUsuario)
            MsgBox("Usuario creado con éxito", MsgBoxStyle.Information, miSupermercado._nombre)

            rgTbUsuario.Text = " "
            rgTbNombre.Text = " "
            rgTbApellido.Text = " "
            rgTbContraseña.Text = " "
        Else
            MsgBox("El nombre de usuario ya existe. Elija uno diferente.", MsgBoxStyle.Information, miSupermercado._nombre)
        End If
    End Sub
End Class
