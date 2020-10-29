Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class GestorPersona

    Private mlistaPersonas As Collection
    Private mlistaPeliculas As Collection
    Private mlistaRoles As Collection
    Private Agente As AgenteBD

    Sub New()
        listaPersonas = New Collection
        listaPeliculas = New Collection
        listaRoles = New Collection
    End Sub

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
    Public Property listaPeliculas As Collection
        Get
            Return mlistaPeliculas
        End Get
        Set(ByVal value As Collection)
            mlistaPeliculas = value
        End Set
    End Property

    Sub read(ByVal IdPersona As Integer, ByRef per As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Personas WHERE IdPersona=" + IdPersona.ToString + ""
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            per.IdPersona = reader(0)
            per.Nombre = reader(1)
            per.Apellido = reader(2)
            per.Nacionalidad = reader(3)
            per.FechaNacimiento = reader(4)
            per.CiudadNacimiento = reader(5)
            per.PaisNacimiento = reader(6)
            per.FotoPersona = reader(7)
        End If
    End Sub

    ' Lee la Persona que tenga el Nombre y apellido escogido '
    Sub readNombreApellido(ByVal nombre As String, ByVal apellido As String, ByRef per As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Personas WHERE Nombre='" + nombre + "'AND Apellido='" + apellido + "'"
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            per.IdPersona = reader(0)
            per.Nombre = reader(1)
            per.Apellido = reader(2)
            per.Nacionalidad = reader(3)
            per.FechaNacimiento = reader(4)
            per.CiudadNacimiento = reader(5)
            per.PaisNacimiento = reader(6)
            per.FotoPersona = reader(7)
        End If
    End Sub

    Sub readAll()
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Personas ORDER BY IdPersona"
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        While reader.Read()
            Me.listaPersonas.Add(New Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                             reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)))
        End While
    End Sub

    Sub leerPeliculas(ByVal per As Persona)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Participa WHERE Persona= " + per.IdPersona.ToString + "")
        While reader.Read()
            Me.listaPeliculas.Add(New Pelicula(reader.GetInt32(1), vbNull, vbNull, Nothing, vbNull, vbNull, vbNull))
        End While
    End Sub

    Sub leerRoles(ByVal per As Persona, ByVal pel As Pelicula)
        Dim reader As OleDbDataReader = AgenteBD.getInstancia().read("SELECT * FROM Participa WHERE Pelicula= " + pel.IdPelicula.ToString + " AND Persona= " + per.IdPersona.ToString + "")
        While reader.Read()
            Me.listaRoles.Add(New Rol(reader.GetInt32(2), vbNull))
        End While
    End Sub

    Sub insert(ByVal newPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Personas VALUES (" + newPersona.IdPersona.ToString + ", '" + newPersona.Nombre + "', '" + newPersona.Apellido + "', '" + newPersona.Nacionalidad + "', '" & newPersona.FechaNacimiento & "', '" + newPersona.CiudadNacimiento + "', '" + newPersona.PaisNacimiento + "', '" + newPersona.FotoPersona + "')"
        Agente.create(sSQL)
    End Sub

    Sub update(ByVal modPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Personas SET Nombre='" + modPersona.Nombre + "', Apellido= '" + modPersona.Apellido + "',Nacionalidad= '" + modPersona.Nacionalidad + "',FechaNacimiento= '" & modPersona.FechaNacimiento & "',CiudadNacimiento= '" + modPersona.CiudadNacimiento + "',PaisNacimiento= '" + modPersona.PaisNacimiento + "', FotoPersona= '" + modPersona.FotoPersona + "' WHERE IdPersona=" + modPersona.IdPersona.ToString + ""
        Agente.update(sSQL)
    End Sub

    Sub delete(ByVal noPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Personas WHERE IdPersona=" + noPersona.IdPersona.ToString + ""
        Agente.delete(sSQL)
    End Sub

    Sub deleteAll()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Personas"
        Agente.delete(sSQL)
    End Sub

    Sub deletePar(ByVal noPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Persona=" + noPersona.IdPersona.ToString + ""
        Agente.delete(sSQL)
    End Sub

    Sub deleteAllPar()
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM Participa"
        Agente.delete(sSQL)
    End Sub

    Sub insertpelrol(ByVal newPersona As Persona, ByVal newPelicula As Pelicula, ByVal newRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Participa VALUES (" + newPersona.IdPersona.ToString + ", " + newPelicula.IdPelicula.ToString + "," + newRol.IdRol.ToString + ")"
        Agente.create(sSQL)
    End Sub

    Sub deletepelrol(ByVal noPersona As Persona, ByVal noPelicula As Pelicula, ByVal noRol As Rol)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Participa WHERE Persona=" + noPersona.IdPersona.ToString + " AND Pelicula=" + noPelicula.IdPelicula.ToString + " AND Rol=" + noRol.IdRol.ToString + ""
        Agente.delete(sSQL)
    End Sub

End Class