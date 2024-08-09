Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instancias del supermercado y el cargadorDeDatos
        miSupermercado = New Supermercado("Marito SA")
        cargadorDatos = New CargadorDeDatos(miSupermercado)
        'Se cargan los usuarios registrados en la base de datos en el supermercado.
        cargadorDatos.CargaDeUsuarios()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = lgTbUsuario.Text
        Dim contraseña As String = lgTbContraseña.Text
        Dim flag As Boolean = False

        For Each user As Usuario In miSupermercado._usuarios
            If usuario = user._usuario AndAlso contraseña = user._contraseña Then
                If user._usuario = "admin" Then
                    Dim formAdmin = New FormAdmin()
                    formAdmin.Show()
                    Me.Hide()
                    flag = True
                Else
                    Dim formUser As New FormUser()
                    formUser.Show()
                    Me.Hide()
                    flag = True
                End If
                Exit For
            End If
        Next

        If Not flag Then
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btnRegister2_Click(sender As Object, e As EventArgs) Handles btnRegister2.Click
        Dim sePuedeCrear As Boolean = True
        'Registro de nuevo usuario en memoria
        Dim nuevoUsuario As Usuario
        Dim user As String = rgTbUsuario.Text
        Dim nombre As String = rgTbNombre.Text & " " & rgTbApellido.Text
        Dim contraseña As String = rgTbContraseña.Text
        For Each u As Usuario In miSupermercado._usuarios
            If u._usuario = user Then
                sePuedeCrear = False
                Exit For
            End If
        Next
        If sePuedeCrear Then
            nuevoUsuario = New Cliente(user, nombre, contraseña)
            miSupermercado.RegistrarUsuario(nuevoUsuario)
            MsgBox("Usuario creado con éxito")
            rgTbUsuario.Text = " "
            rgTbNombre.Text = " "
            rgTbApellido.Text = " "
            rgTbContraseña.Text = " "
        Else
            MsgBox("El nombre de Usuario ya existe")
        End If

    End Sub
End Class
