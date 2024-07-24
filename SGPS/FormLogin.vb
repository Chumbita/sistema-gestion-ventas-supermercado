Public Class Form1
    Dim supermercado As Supermercado
    Dim usuario1 As Usuario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        supermercado = New Supermercado("Marito SA")
        usuario1 = New Usuario("carlosolivera", "Carlos Olivera", "marioteamo")
        supermercado.agregar_usuario(usuario1)
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        gbRegistrar.Visible = Not gbRegistrar.Visible
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = lgTbUsuario.Text
        Dim contraseña As String = lgTbContraseña.Text
        Dim flag As Boolean = False

        If usuario = "admin" AndAlso contraseña = "admin" Then
            Dim formAdmin = New FormAdmin
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
        Dim nuevoUsuario As Usuario
        Dim user As String = rgTbUsuario.Text
        Dim nombre As String = rgTbNombre.Text & " " & rgTbApellido.Text
        Dim contraseña As String = rgTbContraseña.Text

        nuevoUsuario = New Usuario(user, nombre, contraseña)
        supermercado.agregar_usuario(nuevoUsuario)
        MsgBox("Usuario creado con éxito")
        rgTbUsuario.Text = " "
        rgTbNombre.Text = " "
        rgTbApellido.Text = " "
        rgTbContraseña.Text = " "
    End Sub
End Class
