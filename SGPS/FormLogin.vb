Public Class Form1
    Dim supermercado As Supermercado
    Dim usuario1 As Usuario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Única Instancia de la clase supermercado
        supermercado = New Supermercado("Marito SA")

        'Usuario (Cliente) intanciado y agregado al supermercado para pruebas
        usuario1 = New Usuario("carlosolivera", "Carlos Olivera", "marioteamo")
        supermercado.AgregarUsuario(usuario1)
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Botón "Registrarse" que hace aparecer u ocultar la sección de "Registrar Usuario"
        gbRegistrar.Visible = Not gbRegistrar.Visible
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = lgTbUsuario.Text
        Dim contraseña As String = lgTbContraseña.Text
        Dim flag As Boolean = False

        If usuario = "admin" AndAlso contraseña = "admin" Then
            Dim formAdmin = New FormAdmin(supermercado)
            formAdmin.Show()
            Me.Hide()
            flag = True

        Else
            For Each u As Usuario In supermercado._usuarios
                If u._usuario = usuario AndAlso u._contraseña = contraseña Then
                    Dim formUser As New FormUser()
                    formUser.Show()
                    Me.Hide()
                    flag = True
                    Exit For
                End If
            Next

            If Not flag Then
                MsgBox("El usuario o contraseña son incorrectos.", MsgBoxStyle.OkOnly, "Error")
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Registro de nuevo usuario
        Dim nuevoUsuario As Usuario
        Dim user As String = rgTbUsuario.Text
        Dim nombre As String = rgTbNombre.Text & " " & rgTbApellido.Text
        Dim contraseña As String = rgTbContraseña.Text

        'Usuario creado en memoria
        nuevoUsuario = New Usuario(user, nombre, contraseña)
        supermercado.agregar_usuario(nuevoUsuario)
        MsgBox("Usuario creado con éxito")
        rgTbUsuario.Text = " "
        rgTbNombre.Text = " "
        rgTbApellido.Text = " "
        rgTbContraseña.Text = " "

        'Agregar funcionalidad para agregar el nuevo usuario en la Base de Datos
    End Sub
End Class
