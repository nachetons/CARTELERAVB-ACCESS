Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class GestorGenero

    Private mlistaGeneros As Collection
    Private mlistaPeliculas As Collection
    Private Agente As AgenteBD

    Sub New()
        listaGeneros = New Collection
        listaPeliculas = New Collection
    End Sub

    Public Property listaGeneros As Collection
        Get
            Return mlistaGeneros
        End Get
        Set(ByVal value As Collection)
            mlistaGeneros = value
        End Set
    End Property

    Public Property listaPeliculas As Collection
        Get
            Return mlistaPeliculas
        End Get
        Set(ByVal value As Collection)
            mlistaPeliculas = value
        End Set
    End Property

    Sub read(ByVal IdGenero As String, ByRef ger As Genero)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Generos WHERE IdGenero=" + IdGenero + ""
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            ger.IdGenero = reader(0)
            ger.DescGenero = reader(1)
        End If
    End Sub

    Sub readdescGenero(ByVal DescGenero As String, ByRef ger As Genero)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Generos WHERE DescGenero='" + DescGenero + "'"
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            ger.IdGenero = reader(0)
            ger.DescGenero = reader(1)
        End If
    End Sub

    Sub readAll()
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Generos ORDER BY IdGenero")
        While reader.Read()
            Me.listaGeneros.Add(New Genero(reader.GetInt32(0), reader.GetString(1)))
        End While
    End Sub

    Sub leerPeliculas(ByVal gen As Genero)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Peli_Gen WHERE Genero=" + gen.IdGenero.ToString + "")
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(0), vbNull, vbNull, Nothing, vbNull, vbNull, vbNull))
        End While
    End Sub

    Sub insert(ByVal newGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Generos VALUES (" + newGenero.IdGenero.ToString + ", '" + newGenero.DescGenero + "')"
        Agente.create(sSQL)
    End Sub

    Sub update(ByVal modGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Generos SET DescGenero='" + modGenero.DescGenero + "'WHERE IdGenero=" + modGenero.IdGenero.ToString + ""
        Agente.update(sSQL)
    End Sub

    Sub delete(ByVal noGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Generos WHERE IdGenero=" + noGenero.IdGenero.ToString + ""
        Agente.delete(sSQL)
    End Sub

    Sub deleteAll()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Generos"
        Agente.delete(sSQL)
    End Sub

    Sub deletePeliGen(ByVal gen As Genero)
        AgenteBD.getInstancia().delete("DELETE * FROM Peli_Gen WHERE Genero=" + gen.IdGenero.ToString + "")
    End Sub

    Sub deleteAllPeliGen()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Peli_Gen"
        Agente.delete(sSQL)
    End Sub

    Sub insertPelicula(ByVal newGenero As Genero, ByVal pel As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Peli_Gen VALUES (" + pel.IdPelicula.ToString + ", " + newGenero.IdGenero.ToString + ")"
        Agente.create(sSQL)
    End Sub

    Sub deletePelicula(ByVal noGenero As Genero, ByVal pel As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peli_Gen WHERE Genero=" + noGenero.IdGenero.ToString + " AND  Pelicula=" + pel.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub

End Class


