Imports ClasesLibreta

Public Class frmNuevo
    Public Property NuevoContacto As Contacto

    Private Sub frmNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NuevoContacto = New Contacto
        txtNombre.DataBindings.Add(New Binding("Text", NuevoContacto, "Nombre"))
        txtApellido.DataBindings.Add(New Binding("Text", NuevoContacto, "Apellido"))
        txtDNI.DataBindings.Add(New Binding("Text", NuevoContacto, "DNI"))
        dtpFecNac.DataBindings.Add(New Binding("Value", NuevoContacto, "FechaNacimiento"))
        txtDirec.DataBindings.Add(New Binding("Text", NuevoContacto, "Direccion", DataSourceUpdateMode.OnPropertyChanged))
        txtTelefono.DataBindings.Add(New Binding("Text", NuevoContacto, "Telefono"))
        txtCorreo.DataBindings.Add(New Binding("Text", NuevoContacto, "Correo"))
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        '
    End Sub
End Class