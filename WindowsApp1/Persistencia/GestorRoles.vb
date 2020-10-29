Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class GestorRol

    Private mlistaPersonas As Collection
    Private mlistaPeliculas As Collection
    Private mlistaRoles As Collection
    Private Agente As AgenteBD

    Sub New()
        listaRoles = New Collection
        listaPersonas = New Collection
        listaPeliculas = New Collection
    End Sub

    Public Property listaRoles() As Collection
        Get
            Return mlistaRoles
        End Get
        Set(ByVal value As Collection)
            mlistaRoles = value
        End Set
    End Property

    Public Property listaPersonas() As Collection
        Get
            Return mlistaPersonas
        End Get
        Set(ByVal value As Collection)
            mlistaPersonas = value
        End Set
    End Property

    Public Property listaPeliculas() As Collection
        Get
            Return mlistaPeliculas
        End Get
        Set(ByVal value As Collection)
            mlistaPeliculas = value
        End Set
    End Property

    Sub read(ByVal IdRol As Integer, ByRef ro As Rol)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Roles WHERE IdRol=" + IdRol.ToString + "")
        If reader.HasRows Then
            reader.Read()
            ro.IdRol = reader(0)
            ro.DescRol = reader(1)
        End If
    End Sub

    Sub readDescRol(ByVal DescRol As String, ByRef ro As Rol)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Roles WHERE DescRol='" + DescRol + "'")
        If reader.HasRows Then
            reader.Read()
            ro.IdRol = reader(0)
            ro.DescRol = reader(1)
        End If
    End Sub

    Sub readAll()
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Roles ORDER BY IdRol")
        While reader.Read()
            Me.listaRoles.Add(New Rol(reader.GetInt32(0), reader.GetString(1)))
        End While
    End Sub

    Sub leerPersonas(ByVal rol As Rol)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Participa WHERE Rol= " + rol.IdRol.ToString + "")
        While reader.Read()
            Me.listaPersonas.Add(New Persona(reader.GetInt32(0), vbNull, vbNull, vbNull, Nothing, vbNull, vbNull, vbNull))
        End While
    End Sub

    Sub leerPeliculas(ByVal rol As Rol, ByVal per As Persona)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Participa WHERE Rol= " + rol.IdRol.ToString + " AND Persona= " + per.IdPersona.ToString + "")
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(1), vbNull, vbNull, Nothing, vbNull, vbNull, vbNull))
        End While
    End Sub

    Sub insert(ByVal newRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Roles VALUES (" + newRol.IdRol.ToString + ", '" + newRol.DescRol + "')"
        Agente.create(sSQL)
    End Sub

    Sub update(ByVal modRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Roles SET DescRol='" + modRol.DescRol + "'WHERE IdRol=" + modRol.IdRol.ToString + ""
        Agente.update(sSQL)
    End Sub

    Sub delete(ByVal noRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Roles WHERE IdRol=" + noRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub

    Sub deleteAll()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Roles"
        Agente.delete(sSQL)
    End Sub

    Sub deleteAllPar()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Participa"
        Agente.delete(sSQL)
    End Sub

    Sub deletePar(ByVal noRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Rol=" + noRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub

    Sub insertperpel(ByVal newRol As Rol, ByVal newPersona As Persona, newPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Participa VALUES (" + newPersona.IdPersona.ToString + ", " + newPelicula.IdPelicula.ToString + "," + newRol.IdRol.ToString + ")"
        Agente.create(sSQL)
    End Sub

    Sub deleteperpel(ByVal noRol As Rol, ByVal noPersona As Persona, noPelicula As Pelicula)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Persona=" + noPersona.IdPersona.ToString + " AND Pelicula=" + noPelicula.IdPelicula.ToString + " AND Rol=" + noRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub

End Class
