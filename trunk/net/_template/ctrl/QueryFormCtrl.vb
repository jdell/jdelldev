
Namespace frm._template.ctrl

	Public MustInherit Class QueryFormCtrl
        Inherits repsol.forms.template.consulta.ctrl.QueryFormCtrl

        Public Overrides Sub inicializarForm(ByRef frm As repsol.forms.template.BaseForm)
            Dim fs As System.IO.FileStream = Nothing
            Try
                '--Registrar la apertura del formulario--
                Dim caNombreForm As New VO.canombreform.canombreformVO
                caNombreForm.CANombre = frm.Name
                Dim doExiste As New BL.canombreform.doGet(caNombreForm)
                Dim aux_caNombreForm As VO.canombreform.canombreformVO = doExiste.execute

                If aux_caNombreForm Is Nothing Then
                    Dim doAddNombreForm As New BL.canombreform.doAdd(caNombreForm)
                    caNombreForm = doAddNombreForm.execute()
                Else
                    aux_caNombreForm.CANombre = caNombreForm.CANombre
                    Dim doUpdateNombreForm As New BL.canombreform.doUpdate(aux_caNombreForm)
                    caNombreForm = doUpdateNombreForm.execute()
                End If

                Dim caForm As New VO.caform.caformVO
                caForm.CANombreForm = caNombreForm
                caForm.CASesion = _common.objs.CASesion.Sesion

                Dim doExisteForm As New BL.caform.doGet(caForm)
                Dim aux_caForm As VO.caform.caformVO = doExisteForm.execute

                If aux_caForm Is Nothing Then
                    Dim doAddForm As New BL.caform.doAdd(caForm)
                    caForm = doAddForm.execute()
                Else
                    aux_caForm.CANombreForm = caForm.CANombreForm
                    aux_caForm.CASesion = caForm.CASesion
                    Dim doUpdateForm As New BL.caform.doUpdate(aux_caForm)
                    caForm = doUpdateForm.execute()
                End If


                '----------------------------------------

                '--Cargar valores por defecto--
                'Si no existe el archivo de preferencias de usuario se cargan los valores por defecto. 
                If Not System.IO.File.Exists(repsol.forms.template.BaseForm.USERPREFERENCES_FULL_PATH) Then
                    'Cargar por defecto.
                    loadDefaultSettings(frm)

                    'El fichero si existe => Comprobamos que contiene las preferencias de usuario de este formulario.
                Else
                    Dim settingsAux As System.Collections.Generic.Dictionary(Of String, repsol.util.setting.userpreferences)
                    settingsAux = Nothing

                    If (IO.File.ReadAllBytes(repsol.forms.template.BaseForm.USERPREFERENCES_FULL_PATH).Length > 0) Then
                        Dim formatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
                        fs = New System.IO.FileStream(repsol.forms.template.BaseForm.USERPREFERENCES_FULL_PATH, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)
                        settingsAux = formatter.Deserialize(fs)
                    End If

                    If (Not settingsAux Is Nothing) Then
                        'Si no contiene las preferencias del usuario => cargar valores por defecto.
                        If Not settingsAux.ContainsKey(frm.GetType.Name) Then
                            'Cargar por defecto.
                            loadDefaultSettings(frm)
                        End If
                    End If
                End If
                '---------------------------------------------------------------------------
            Catch ex As Exception
                Throw ex
            Finally
                If (Not fs Is Nothing) Then fs.Close()
            End Try
        End Sub

        ''' <summary>
        ''' Esta función será la que se encargue de cargar los valores por defecto cuando no exista el fichero de 
        ''' preferencias de usuario, o si existe pero no contiene información sobre el formulario (frm) tratado. 
        ''' </summary>
        ''' <param name="frm"></param>
        ''' <remarks></remarks>
        Public MustOverride Sub loadDefaultSettings(ByRef frm As repsol.forms.template.consulta.QueryForm)

    End Class
End Namespace