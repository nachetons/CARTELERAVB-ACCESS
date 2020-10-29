Public Class Rol

    Private mIdRol As Integer
    Private mDescRol As String
    Private mPeliculas As Collection
    Private mPersonas As Collection
    Private GestorRol As GestorRol

    Sub New(ByVal IdRol As Integer, ByVal DescRol As String)
        Me.mIdRol = IdRol
        Me.mDescRol = DescRol
        GestorRol = New GestorRol()
    End Sub

    Sub New()
        GestorRol = New GestorRol()
    End Sub

    Property IdRol As Integer
        Get
            Return mIdRol
        End Get
        Set(ByVal mIdRol As Integer)
            Me.mIdRol = mIdRol
        End Set
    End Property

    Property DescRol As String
        Get
            Return mDescRol
        End Get
        Set(ByVal mDescRol As String)
            Me.mDescRol = mDescRol
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

    Property ListaPeliculas As Collection
        Get
            Return mPeliculas
        End Get
        Set(ByVal mPeliculas As Collection)
            Me.mPeliculas = mPeliculas
        End Set
    End Property

    Sub leerRol(ByVal IdRol As Integer)
        GestorRol.read(IdRol, Me)
    End Sub

    Sub leerdescrol(ByVal Descrol As String)
        GestorRol.readDescRol(Descrol, Me)
    End Sub
    Function leertodos() As Collection
        Dim todos As Collection
        Me.GestorRol.readAll()
        todos = GestorRol.listaRoles
        Return todos
    End Function

    Sub leerPersonas(ByVal IdRol As String)
        GestorRol.leerPersonas(Me)
        ListaPersonas = GestorRol.listaPersonas
    End Sub

    Sub leerPeliculas(ByVal per As Persona)
        GestorRol.leerPeliculas(Me, per)
        ListaPeliculas = GestorRol.listaPeliculas
    End Sub

    Sub insertarRol()
        Me.GestorRol.insert(Me)
    End Sub

    Sub modificarRol()
        Me.GestorRol.update(Me)
    End Sub

    Sub eliminarRol()
        Me.GestorRol.delete(Me)
    End Sub

    Sub eliminarTodo()
        Me.GestorRol.deleteAll()
    End Sub

    Sub eliminarTodoPar()
        Me.GestorRol.deleteAllPar()
    End Sub

    Sub eliminarPar()
        Me.GestorRol.deletePar(Me)
    End Sub

    Sub insertarPersonaPelicula(ByVal per As Persona, ByVal pel As Pelicula)
        Me.GestorRol.insertperpel(Me, per, pel)
    End Sub

    Sub eliminarPersonaPelicula(ByVal per As Persona, ByVal pel As Pelicula)
        Me.GestorRol.deleteperpel(Me, per, pel)
    End Sub
End Class



