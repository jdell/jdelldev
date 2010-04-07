Namespace frm._template

	Public Class EditForm
		Inherits repsol.forms.template.edicion.EditForm

		Public Sub New()
			MyBase.new()
		End Sub

		Public Sub New(ByVal soloconsulta As Boolean)
			MyBase.New(soloconsulta)
		End Sub

        Protected Sub guardaCAError(ByVal ex As Exception, ByVal frm As repsol.forms.template.BaseForm, Optional ByVal mostrarMensaje As Boolean = True)
            Dim caerror As New VO.caerror.caerrorVO
            caerror.CAEDesError = ex.Message
            caerror.CAEFormulario = frm.Name
            caerror.CAEProcedimiento = ex.TargetSite.Name
            caerror.CAEIdCASesion = _common.objs.CASesion.Sesion.IdCASesion
            Dim accAdd As New BL.caerror.doAdd(caerror)
            accAdd.execute()
            If (mostrarMensaje) Then
                repsol.util.messages.ShowError(ex.Message, frm.Text)
            End If
        End Sub
	End Class

End Namespace
