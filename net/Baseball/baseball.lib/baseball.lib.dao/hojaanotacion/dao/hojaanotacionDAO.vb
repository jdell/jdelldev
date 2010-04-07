Imports baseball.lib.vo
Imports System.Data.Common

Namespace hojaanotacion.DAO
    Friend Class hojaanotacionDAO
        Inherits _template.objectDAO

        '*********************************
        Protected Overrides Function dataReaderToList(ByVal reader As System.Data.Common.DbDataReader) As Object
            Try
                Dim res As New List(Of baseball.lib.vo.HojaAnotacion)

                If (Not reader Is Nothing) Then
                    While (reader.Read)
                        res.Add(dataReaderToVO(reader))
                    End While
                    reader.Close()
                End If

                Return res
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Protected Overrides Function dataReaderToVO(ByVal reader As System.Data.Common.DbDataReader) As Object
            Try
                Dim res As baseball.lib.vo.HojaAnotacion = Nothing
                If (Not reader Is Nothing) Then
                    Dim ccollections As New List(Of String)
                    For i As Integer = 0 To reader.FieldCount - 1
                        ccollections.Add(reader.GetName(i))
                    Next
                    Dim col As String = String.Empty

                    res = New baseball.lib.vo.HojaAnotacion

                    res.Id = Convert.ToInt16(reader("id_hojaanotacion"))
                    res.Equipo = New baseball.lib.vo.Equipo
                    res.Equipo.Id = Convert.ToInt16(reader("id_equipo"))
                    res.Partido = New baseball.lib.vo.Partido
                    res.Partido.Id = Convert.ToInt16(reader("id_partido"))
                End If
                Return res

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Friend Overrides Function checkIfExists(ByVal command As System.Data.Common.DbCommand, ByVal obj As Object) As Boolean
            Try
                Dim objVO As baseball.lib.vo.HojaAnotacion = obj

                Dim strQuery As String = _
                "select * from hojaanotacion" _
                & " where " _
                & " id_hojaanotacion=@id_hojaanotacion"

                command.CommandText = strQuery
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_hojaanotacion", objVO.Id, command))

                Dim reader As Data.Common.DbDataReader = command.ExecuteReader
                Dim res As Boolean = reader.Read
                reader.Close()

                Return res

            Catch ex As Data.Common.DbException
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function

        Friend Overrides Function [get](ByVal command As System.Data.Common.DbCommand, ByVal obj As Object) As Object
            Try
                Dim objVO As baseball.lib.vo.HojaAnotacion = obj

                Dim strQuery As String = _
                "select * from hojaanotacion" _
                & " where " _
                & " id_hojaanotacion=@id_hojaanotacion"

                command.CommandText = strQuery
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_hojaanotacion", objVO.Id, command))

                Dim reader As Data.Common.DbDataReader = command.ExecuteReader
                Dim res As baseball.lib.vo.HojaAnotacion = Nothing
                If (reader.Read) Then
                    res = dataReaderToVO(reader)
                End If
                reader.Close()

                Return res

            Catch ex As Data.Common.DbException
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function

        Friend Overrides Function getAll(ByVal command As System.Data.Common.DbCommand) As Object
            Try
                Dim strQuery As String = "SELECT * FROM hojaanotacion " _
                & " order by id_hojaanotacion desc"
                command.CommandText = strQuery

                Dim reader As Data.Common.DbDataReader = command.ExecuteReader
                Dim res As List(Of baseball.lib.vo.HojaAnotacion) = dataReaderToList(reader)
                reader.Close()

                Return res
            Catch ex As Exception
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function

        Friend Overrides Function update(ByVal command As System.Data.Common.DbCommand, ByVal obj As Object) As Object
            Try
                Dim objVO As baseball.lib.vo.HojaAnotacion = obj

                Dim strQuery As String = _
                " update hojaanotacion" _
                & " set " _
                & "  id_equipo = @id_equipo" _
                & " ,id_partido= @id_partido" _
                & " where " _
                & " id_hojaanotacion = @id_hojaanotacion"

                command.CommandText = strQuery
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_hojaanotacion", objVO.Id, command))
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_equipo", objVO.Equipo.Id, command))
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_partido", objVO.Partido.Id, command))

                command.ExecuteNonQuery()

                Return objVO
            Catch ex As Data.Common.DbException
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function

        Friend Overrides Function add(ByVal command As System.Data.Common.DbCommand, ByVal obj As Object) As Object
            Try
                Dim objVO As baseball.lib.vo.HojaAnotacion = obj

                Dim strQuery As String = _
                " insert into hojaanotacion" _
                & " (id_equipo, id_partido) " _
                & " values " _
                & " (@id_equipo, @id_partido) " _
                & "; select @id = SCOPE_IDENTITY()"

                command.CommandText = strQuery

                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_equipo", objVO.Equipo.Id, command))
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_partido", objVO.Partido.Id, command))
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id", command))
                command.ExecuteNonQuery()

                Dim res As Int16
                res = Convert.ToInt16(command.Parameters("@id").Value)

                Return res

            Catch ex As Data.Common.DbException
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function

        Friend Overrides Function remove(ByVal command As System.Data.Common.DbCommand, ByVal obj As Object) As Object
            Try
                Dim objVO As baseball.lib.vo.HojaAnotacion = obj

                Dim strQuery As String = _
                " delete hojaanotacion" _
                & " where " _
                & " id_hojaanotacion = @id_hojaanotacion"

                command.CommandText = strQuery
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_hojaanotacion", objVO.Id, command))

                command.ExecuteNonQuery()

                Return True

            Catch ex As Data.Common.DbException
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function

        Friend Overloads Function [get](ByVal command As System.Data.Common.DbCommand, ByVal partido As vo.Partido, ByVal equipo As vo.Equipo) As vo.HojaAnotacion
            Try
                Dim strQuery As String = _
                "select * from hojaanotacion" _
                & " where " _
                & " id_partido=@id_partido" _
                & " AND " _
                & " id_equipo=@id_equipo"

                command.CommandText = strQuery
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_partido", partido.Id, command))
                command.Parameters.Add(Me.CreateParameter(DbType.Int16, "@id_equipo", equipo.Id, command))

                Dim reader As Data.Common.DbDataReader = command.ExecuteReader
                Dim res As baseball.lib.vo.HojaAnotacion = Nothing
                If (reader.Read) Then
                    res = dataReaderToVO(reader)
                End If
                reader.Close()

                Return res

            Catch ex As Data.Common.DbException
                Throw ex
            Finally
                command.Parameters.Clear()
            End Try
        End Function
    End Class
End Namespace
