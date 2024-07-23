Public Class Usuario
    Public Sub New()
    End Sub
    Public Sub New(usuario As String, nombre As String, contraseña As String, id As Integer)
        _usuario = usuario
        _nombre = nombre
        _contraseña = contraseña
        _id = id
    End Sub
    Public Property _usuario As String
    Public Property _nombre As String
    Public Property _contraseña As String
    Public Property _id As Integer
End Class
