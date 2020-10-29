Public Class Pelicula

    Private mIdPelicula As Integer
    Private mTitulo As String
    Private mTituloOriginal As String
    Private mAñoEstreno As Date
    Private mDuracion As Integer
    Private mSinopsis As String
    Private mCartelPelicula As String
    Private mRoles As Collection
    Private mPersonas As Collection
    Private mGeneros As Collection

    Private GestorPel As GestorPelicula
    Sub New(ByVal IdPelicula As Integer, ByVal Titulo As String, ByVal TituloOriginal As String,
             ByVal AñoEstreno As Date, ByVal Duracion As Integer, ByVal Sinopsis As String, ByVal CartelPelicula As String)
        Me.mIdPelicula = IdPelicula
        Me.mTitulo = Titulo
        Me.mTituloOriginal = TituloOriginal
        Me.mAñoEstreno = AñoEstreno
        Me.mDuracion = Duracion
        Me.mSinopsis = Sinopsis
        Me.mCartelPelicula = CartelPelicula

        GestorPel = New GestorPelicula()
    End Sub
    Sub New()
        GestorPel = New GestorPelicula()
    End Sub
    Property IdPelicula As Integer
        Get
            Return mIdPelicula
        End Get
        Set(ByVal mIdPelicula As Integer)
            Me.mIdPelicula = mIdPelicula
        End Set
    End Property
    Property Titulo As String
        Get
            Return mTitulo
        End Get
        Set(ByVal mTitulo As String)
            Me.mTitulo = mTitulo
        End Set
    End Property
    Property TituloOriginal As String
        Get
            Return mTituloOriginal
        End Get
        Set(ByVal mTituloOriginal As String)
            Me.mTituloOriginal = mTituloOriginal
        End Set
    End Property
    Property AñoEstreno As Date
        Get
            Return mAñoEstreno
        End Get
        Set(ByVal mAñoEstreno As Date)
            Me.mAñoEstreno = mAñoEstreno
        End Set
    End Property
    Property Duracion As Integer
        Get
            Return mDuracion
        End Get
        Set(ByVal mDuracion As Integer)
            Me.mDuracion = mDuracion
        End Set
    End Property
    Property Sinopsis As String
        Get
            Return mSinopsis
        End Get
        Set(ByVal mSinopsis As String)
            Me.mSinopsis = mSinopsis
        End Set
    End Property
    Property CartelPelicula As String
        Get
            Return mCartelPelicula
        End Get
        Set(ByVal mCartelPelicula As String)
            Me.mCartelPelicula = mCartelPelicula
        End Set
    End Property
    Property ListaGeneros As Collection
        Get
            Return mGeneros
        End Get
        Set(ByVal mgeneros As Collection)
            Me.mGeneros = mgeneros
        End Set
    End Property
    Property ListaPersonas As Collection
        Get
            Return mPersonas
        End Get
        Set(ByVal mPersonas As Collection)
            Me.mPersonas = mPersonas
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
    Sub leerPelicula(ByVal IdPelicula As Integer)
        GestorPel.read(IdPelicula, Me)
    End Sub
    Sub leerTitulo(ByVal Titulo As String)
        GestorPel.readtitulo(Titulo, Me)
    End Sub
    Function leertodos() As Collection
        Dim todos As Collection
        Me.GestorPel.readAll()
        todos = GestorPel.listaPeliculas
        Return todos
    End Function
    Sub leerGeneros()
        GestorPel.leerGenero(Me)
        ListaGeneros = GestorPel.listaGeneros
    End Sub
    Sub leerPersonas()
        GestorPel.leerPersonas(Me)
        ListaPersonas = GestorPel.listaPersonas
    End Sub
    Sub leerRoles(ByVal per As Persona)
        GestorPel.leerRoles(Me, per)
        ListaRoles = GestorPel.listaRoles
    End Sub
    Sub insertarPelicula()
        Me.GestorPel.insert(Me)
    End Sub
    Sub modificarPelicula()
        Me.GestorPel.update(Me)
    End Sub
    Sub eliminarPelicula()
        Me.GestorPel.delete(Me)
    End Sub
    Sub eliminarTodo()
        Me.GestorPel.deleteAll()
    End Sub
    Sub eliminarGen()
        Me.GestorPel.deletegen(Me)
    End Sub
    Sub eliminarTodoGen()
        Me.GestorPel.deleteAllPelGen()
    End Sub
    Sub eliminarPar()
        Me.GestorPel.deletePar(Me)
    End Sub
    Sub eliminarTodoPar()
        Me.GestorPel.deleteAllPar()
    End Sub
    Sub insertarGenero(ByVal gen As Genero)
        Me.GestorPel.insertgen(Me, gen)
    End Sub
    Sub eliminarGenero(ByVal gen As Genero)
        Me.GestorPel.deletegen(Me, gen)
    End Sub
    Sub insertarPersonaRol(ByVal per As Persona, ByVal ro As Rol)
        Me.GestorPel.insertperrol(Me, per, ro)
    End Sub
    Sub eliminarPersonaRol(ByVal per As Persona, ByVal ro As Rol)
        Me.GestorPel.deleteperrol(Me, per, ro)
    End Sub

End Class