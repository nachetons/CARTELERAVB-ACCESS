Public Class Genero

    Private mIdGenero As Integer
    Private mDescGenero As String
    Private mListaPeliculas As Collection
    Private GestorGen As gestorGenero

    Sub New(ByVal IdGenero As Integer, ByVal DescGenero As String)
        Me.mIdGenero = IdGenero
        Me.mDescGenero = DescGenero
        GestorGen = New gestorGenero()
    End Sub

    Sub New()
        GestorGen = New gestorGenero()
    End Sub

    Property IdGenero As Integer
        Get
            Return mIdGenero
        End Get
        Set(ByVal mIdGenero As Integer)
            Me.mIdGenero = mIdGenero
        End Set
    End Property

    Property DescGenero As String
        Get
            Return mDescGenero
        End Get
        Set(ByVal mDescGenero As String)
            Me.mDescGenero = mDescGenero
        End Set
    End Property

    Property ListaPeliculas As Collection
        Get
            Return mListaPeliculas
        End Get
        Set(ByVal mListaPeliculas As Collection)
            Me.mListaPeliculas = mListaPeliculas
        End Set
    End Property

    Sub leerGenero(ByVal IdGenero As Integer)
        GestorGen.read(IdGenero, Me)
    End Sub

    Sub leerdescGenero(ByVal DescGenero As String)
        GestorGen.readdescGenero(DescGenero, Me)
    End Sub

    Function leertodos() As Collection
        Dim todos As Collection
        Me.GestorGen.readAll()
        todos = GestorGen.listaGeneros
        Return todos
    End Function

    Sub leerPeliculas()
        GestorGen.leerPeliculas(Me)
        ListaPeliculas = GestorGen.listaPeliculas
    End Sub

    Sub insertarGenero()
        Me.GestorGen.insert(Me)
    End Sub

    Sub modificarGenero()
        Me.GestorGen.update(Me)
    End Sub

    Sub eliminarGenero()
        Me.GestorGen.delete(Me)
    End Sub

    Sub eliminarTodoGen()
        Me.GestorGen.deleteAll()
    End Sub

    Sub eliminarPeliGen()
        Me.GestorGen.deletePeliGen(Me)
    End Sub

    Sub eliminarTodoPeliGen()
        Me.GestorGen.deleteAllPeliGen()
    End Sub

    Sub insertarPelicula(ByVal pel As Pelicula)
        Me.GestorGen.insertPelicula(Me, pel)
    End Sub

    Sub eliminarPelicula(ByVal pel As Pelicula)
        Me.GestorGen.deletePelicula(Me, pel)
    End Sub

End Class



