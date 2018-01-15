<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecnac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.apellido, Me.dni, Me.direccion, Me.telefono, Me.fecnac, Me.edad, Me.correo})
        Me.dgvLista.Location = New System.Drawing.Point(12, 41)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(575, 330)
        Me.dgvLista.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "Nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "Apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'dni
        '
        Me.dni.DataPropertyName = "DNI"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "Direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "Telefono"
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        '
        'fecnac
        '
        Me.fecnac.DataPropertyName = "FechaNacimiento"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fecnac.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecnac.HeaderText = "Fec. Nacimiento"
        Me.fecnac.Name = "fecnac"
        '
        'edad
        '
        Me.edad.DataPropertyName = "Edad"
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        '
        'correo
        '
        Me.correo.DataPropertyName = "Correo"
        Me.correo.HeaderText = "Correo"
        Me.correo.Name = "correo"
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 383)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmLista"
        Me.Text = "Libreta de Contactos"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents fecnac As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents correo As DataGridViewTextBoxColumn
End Class
