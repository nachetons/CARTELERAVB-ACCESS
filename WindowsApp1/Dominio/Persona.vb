Public Class Persona
    ' Atributos de la clase persona '
    Private mIdPersona As Integer
    Private mNombre As String
    Private mApellido As String
    Private mNacionalidad As String
    Private mFechaNacimiento As Date
    Private mCiudadNacimiento As String
    Private mPaisNacimiento As String
    Private mFotoPersona As String
    Private mRoles As Collection
    Private mPeliculas As Collection
    Private Gestor As gestorPersona

    ' Constructor '
    Sub New(ByVal IdPersona As Integer, ByVal nombre As String, ByVal apellido As String, ByVal nacionalidad As String, ByVal FechaNacimiento As Date, ByVal CiudadNacimiento As String, ByVal PaisNacimiento As String, ByVal FotoPersona As String)
        Me.mIdPersona = IdPersona
        Me.mNombre = nombre
        Me.mApellido = apellido
        Me.mNacionalidad = nacionalidad
        Me.mFechaNacimiento = FechaNacimiento
        Me.mCiudadNacimiento = CiudadNacimiento
        Me.mPaisNacimiento = PaisNacimiento
        Me.mFotoPersona = FotoPersona

        Gestor = New gestorPersona()
    End Sub



    Public Sub New()
        Gestor = New gestorPersona()

    End Sub


    Property IdPersona As Integer
        Get
            Return mIdPersona
        End Get
        Set(ByVal IdPersona As Integer)
            Me.mIdPersona = IdPersona
        End Set
    End Property


    Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(ByVal mNombre As String)
            Me.mNombre = mNombre
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return mApellido
        End Get
        Set(value As String)
            mApellido = value
        End Set
    End Property

    Public Property Nacionalidad As String
        Get
            Return mNacionalidad
        End Get
        Set(value As String)
            mNacionalidad = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return mFechaNacimiento
        End Get
        Set(value As Date)
            mFechaNacimiento = value
        End Set
    End Property

    Public Property CiudadNacimiento As String
        Get
            Return mCiudadNacimiento
        End Get
        Set(value As String)
            mCiudadNacimiento = value
        End Set
    End Property

    Public Property PaisNacimiento As String
        Get
            Return mPaisNacimiento
        End Get
        Set(value As String)
            mPaisNacimiento = value
        End Set
    End Property

    Public Property FotoPersona As String
        Get
            Return mFotoPersona
        End Get
        Set(value As String)
            mFotoPersona = value
        End Set
    End Property
    Property ListaPeliculas As Collection
        Get
            Return mPeliculas
        End Get
        Set(ByVal mPeliculas As Collection)
            Me.mPeliculas = mPeliculas
        End Set
    End Property

    Property ListaRoles As Collection
        Get
            Return mRoles
        End Get
        Set(ByVal mRoles As Collection)
            Me.mRoles = mRoles
        End Set
    End Property
    ' Metodo leer Persona '
    Sub leerPersona(ByVal IdPersona As Integer)
        Gestor.read(IdPersona, Me)
    End Sub

    'Nombre, Apellidos'
    Sub leerNombreApellido(ByVal Nombre As String, ByVal Apellido As String)
        Gestor.readNombreApellido(Nombre, Apellido, Me)
    End Sub


    ' Funcion leer Personas '
    Function leertodos()
        Dim todos As Collection
        Me.Gestor.readAll()
        todos = Gestor.listaPersonas
        Return todos
    End Function


    Sub leerPeliculas()
        Gestor.leerPeliculas(Me)
        ListaPeliculas = Gestor.listaPeliculas
    End Sub


    Sub leerRoles(ByVal pel As Pelicula)
        Gestor.leerRoles(Me, pel)
        ListaRoles = Gestor.listaRoles
    End Sub
    ' Metodo insertar Pelicula '
    Sub insertarPersona()
        Me.Gestor.insert(Me)
    End Sub

    ' Metodo modificar Pelicula '
    Sub modificarPersona()
        Me.Gestor.update(Me)
    End Sub

    ' Metodo eliminar Pelicula '
    Sub eliminarPersona()
        Me.Gestor.delete(Me)
    End Sub

    ' Metodo eliminar todas las Peliculas '
    Sub eliminarTodo()
        Me.Gestor.deleteAll()
    End Sub

    ' Metodo eliminar Pelicula escogida de Particpa '
    Sub eliminarPar()
        Me.Gestor.deletePar(Me)
    End Sub

    ' Metodo eliminar todo de la tabla Participa '
    Sub eliminarTodoPar()
        Me.Gestor.deleteAllPar()
    End Sub



    Sub insertarPeliculaRol(ByVal pel As Pelicula, ByVal ro As Rol)
        Me.Gestor.insertpelrol(Me, pel, ro)
    End Sub
    Sub eliminarPeliculaRol(ByVal per As Pelicula,ByVal pel As Pelicula, ByVal ro As Rol)
        Me.Gestor.deletepelrol(Me, pel, ro)
    End Sub



End Class
