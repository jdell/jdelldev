Namespace frm._template
    Public Class baseForm
        Inherits repsol.forms.template.BaseForm


        Public Sub New()
            MyBase.New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'baseForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 573)
            Me.MaximizeBox = False
            Me.Name = "baseForm"
            Me.RememberUserPreferences = True
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "baseForm"
            Me.ResumeLayout(False)

        End Sub

        '#Region "AppSetting"

        '        Protected Overrides Function getUserPreferences() As repsol.util.setting.userpreferences
        '            Dim res As New _common.settings.AppPreferences(MyBase.getUserPreferences())
        '            Return res
        '        End Function

        '#End Region

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