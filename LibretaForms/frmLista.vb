Imports ClasesLibreta

Public Class frmLista
    Private lstContactos As List(Of Contacto)

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstContactos = New List(Of Contacto)

        ' nuevo contacto
        Dim contacto As New Contacto()
        contacto.Apellido = "Smith"
        contacto.Nombre = "John"
        contacto.DNI = "12345678"
        contacto.Direccion = "Lima"
        contacto.FechaNacimiento = #1/22/1995#
        contacto.Telefono = "941399129"
        contacto.Correo = "jsmith@ejemplo.com"

        'agregar contacto en lista
        lstContactos.Add(contacto)

        'vincular lista con DataGrid
        dgvLista.DataSource = lstContactos
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '
    End Sub
End Class
