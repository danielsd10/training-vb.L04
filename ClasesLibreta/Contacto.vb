Public Class Contacto
    'Campos
    Private _Nombre As String
    Private _Apellido As String
    Private _DNI As String
    Private _FechaNacimiento As Date
    Private _Direccion As String
    Private _Telefono As String
    Private _Correo As String

    'Propiedades
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    Public Property DNI As String
        Get
            Return _DNI
        End Get
        Set(value As String)
            _DNI = value
        End Set
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
        End Set
    End Property
    Public ReadOnly Property Edad As Integer
        Get
            Return DateDiff(DateInterval.Year, _FechaNacimiento, DateTime.Now)
        End Get
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property

    'Constructor
    Sub New()

    End Sub

    'Métodos

End Class
