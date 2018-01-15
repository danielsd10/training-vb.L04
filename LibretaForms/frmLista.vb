Imports System.ComponentModel
Imports ClasesLibreta

Public Class frmLista
    Private lstContactos As BindingList(Of Contacto)

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstContactos = New BindingList(Of Contacto)

        ' nuevo contacto
        Dim persona As New Persona()
        persona.Apellido = "Smith"
        persona.Nombre = "John"
        persona.DNI = "12345678"
        persona.Direccion = "Lima"
        persona.FechaNacimiento = #1/22/1995#
        persona.Telefono = "941399129"
        persona.Correo = "jsmith@ejemplo.com"

        Dim empresa As New Empresa()
        empresa.Nombre = "GMD"
        empresa.RUC = "12345678"
        empresa.Direccion = "Lima"
        empresa.Telefono = "20991122"
        empresa.Correo = "info@gmd.com.pe"

        'agregar contacto en lista
        lstContactos.Add(persona)
        lstContactos.Add(empresa)

        'vincular lista con DataGrid
        dgvLista.DataSource = lstContactos
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New frmNuevo
        If frm.ShowDialog() = DialogResult.OK Then
            lstContactos.Add(frm.NuevoContacto)
        End If

    End Sub
End Class
