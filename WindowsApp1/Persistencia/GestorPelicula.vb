Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class GestorPelicula

    Private mlistaPeliculas As Collection
    Private mlistaGeneros As Collection
    Private mlistaPersonas As Collection
    Private mlistaRoles As Collection
    Private Agente As AgenteBD

    Sub New()
        listaPeliculas = New Collection
        listaGeneros = New Collection
        listaPeliculas = New Collection
        listaPersonas = New Collection
        listaRoles = New Collection
    End Sub
    Public Property listaPeliculas As Collection
        Get
            Return mlistaPeliculas
        End Get
        Set(ByVal value As Collection)
            mlistaPeliculas = value
        End Set
    End Property
    Public Property listaGeneros As Collection
        Get
            Return mlistaGeneros
        End Get
        Set(ByVal value As Collection)
            mlistaGeneros = value
        End Set
    End Property
    Public Property listaPersonas As Collection
        Get
            Return mlistaPersonas
        End Get
        Set(ByVal value As Collection)
            mlistaPersonas = value
        End Set
    End Property
    Public Property listaRoles As Collection
        Get
            Return mlistaRoles
        End Get
        Set(ByVal value As Collection)
            mlistaRoles = value
        End Set
    End Property
    Sub read(ByVal IdPelicula As Integer, ByRef pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Peliculas WHERE IdPelicula=" + IdPelicula.ToString + "")
        If reader.HasRows Then
            reader.Read()
            pel.IdPelicula = reader(0)
            pel.Titulo = reader(1)
            pel.TituloOriginal = reader(2)
            pel.AñoEstreno = reader(3)
            pel.Duracion = reader(4)
            pel.Sinopsis = reader(5)
            pel.CartelPelicula = reader(6)
        End If
    End Sub
    Sub readtitulo(ByVal Titulo As String, ByRef pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Peliculas WHERE Titulo='" + Titulo + "'")
        If reader.HasRows Then
            reader.Read()
            pel.IdPelicula = reader(0)
            pel.Titulo = reader(1)
            pel.TituloOriginal = reader(2)
            pel.AñoEstreno = reader(3)
            pel.Duracion = reader(4)
            pel.Sinopsis = reader(5)
            pel.CartelPelicula = reader(6)
        End If
    End Sub
    Sub readAll()
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Peliculas ORDER BY IdPelicula")
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3),
                                               reader.GetInt32(4), reader.GetString(5), reader.GetString(6)))
        End While
    End Sub
    Sub leerGenero(ByVal pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT Genero FROM Peli_Gen WHERE Pelicula=" + pel.IdPelicula.ToString + "")
        While reader.Read()
            Me.listaGeneros.Add(New Genero(reader.GetInt32(0), vbNull))
        End While
    End Sub
    Sub leerPersonas(ByVal pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT DISTINCT Persona FROM Participa WHERE Pelicula= " + pel.IdPelicula.ToString + "")
        While reader.Read()
            Me.listaPersonas.Add(New Persona(reader.GetInt32(0), vbNull, vbNull, vbNull, Nothing, vbNull, vbNull, vbNull))
        End While

    End Sub
    Sub leerRoles(ByVal pel As Pelicula, ByVal per As Persona)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT Rol FROM Participa WHERE Pelicula= " + pel.IdPelicula.ToString + " AND Persona= " + per.IdPersona.ToString + "")
        While reader.Read()
            Me.listaRoles.Add(New Rol(reader.GetInt32(0), vbNull))
        End While
    End Sub
    Sub insert(ByVal newPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Peliculas VALUES (" + newPelicula.IdPelicula.ToString + ", '" + newPelicula.Titulo + "', '" + newPelicula.TituloOriginal + "', '" & newPelicula.AñoEstreno & "', " + newPelicula.Duracion.ToString + ", '" + newPelicula.Sinopsis + "', '" + newPelicula.CartelPelicula + "')"
        Agente.create(sSQL)
    End Sub
    Sub update(ByVal modPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Peliculas SET Titulo= '" + modPelicula.Titulo + "',TituloOriginal= '" + modPelicula.TituloOriginal + "',AñoEstreno= '" & modPelicula.AñoEstreno & "',Duracion= " + modPelicula.Duracion.ToString + ",Sinopsis= '" + modPelicula.Sinopsis + "',CartelPelicula= '" + modPelicula.CartelPelicula + "' WHERE IdPelicula=" + modPelicula.IdPelicula.ToString + ""
        Agente.update(sSQL)
    End Sub
    Sub delete(ByVal noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peliculas WHERE IdPelicula=" + noPelicula.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub
    Sub deleteAll()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Peliculas"
        Agente.delete(sSQL)
    End Sub
    Sub deletegen(ByVal noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peli_Gen WHERE Pelicula=" + noPelicula.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub
    Sub deleteAllPelGen()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Peli_Gen"
        Agente.delete(sSQL)
    End Sub
    Sub deletePar(ByVal noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Pelicula=" + noPelicula.IdPelicula.ToString + ""
        Agente.delete(sSQL)
    End Sub
    Sub deleteAllPar()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Participa"
        Agente.delete(sSQL)
    End Sub
    Sub insertgen(ByVal newPelicula As Pelicula, ByVal newGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Peli_gen VALUES (" + newPelicula.IdPelicula.ToString + ", " + newGenero.IdGenero.ToString + ")"
        Agente.create(sSQL)
    End Sub
    Sub deletegen(ByVal noPelicula As Pelicula, ByVal noGenero As Genero)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Peli_gen WHERE Pelicula=" + noPelicula.IdPelicula.ToString + " AND Genero=" + noGenero.IdGenero.ToString + ""
        Agente.delete(sSQL)
    End Sub
    Sub insertperrol(ByVal newPelicula As Pelicula, ByVal newPersona As Persona, ByVal newRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Participa VALUES (" + newPersona.IdPersona.ToString + ", " + newPelicula.IdPelicula.ToString + "," + newRol.IdRol.ToString + ")"
        Agente.create(sSQL)
    End Sub
    Sub deleteperrol(ByVal noPelicula As Pelicula, ByVal noPersona As Persona, ByVal noRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Persona=" + noPersona.IdPersona.ToString + " AND Pelicula=" + noPelicula.IdPelicula.ToString + " AND Rol=" + noRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub

End Class