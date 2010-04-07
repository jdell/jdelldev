Namespace frm._template
    Public Class printform
        'Inherits saiiform
        Inherits repsol.forms.template.informe.ReportForm

        Protected WithEvents btRefresh As System.Windows.Forms.Button
        'Protected WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        'Public WithEvents viewer As Microsoft.Reporting.WinForms.ReportViewer

        Private _hasParameters As Boolean

        Public Sub New()
            MyBase.New()
            InitializeComponent()

            Me.RememberUserPreferences = True
        End Sub
        Public Sub New(ByVal hasParameters As Boolean)
            MyBase.New(hasParameters)
            InitializeComponent()

            Me.RememberUserPreferences = True
            Me.tsbVerParametros.Enabled = True

        End Sub

        Private Sub InitializeComponent()
            Me.btRefresh = New System.Windows.Forms.Button
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.btRefresh)
            Me.SplitContainer1.Size = New System.Drawing.Size(792, 548)
            '
            'viewer
            '
            Me.viewer.ShowPrintButton = False
            Me.viewer.Size = New System.Drawing.Size(792, 548)
            '
            'btRefresh
            '
            Me.btRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btRefresh.Image = Global.GesTDC.PC.GesTDC.My.Resources.Resources.ico_report
            Me.btRefresh.Location = New System.Drawing.Point(721, 39)
            Me.btRefresh.Name = "btRefresh"
            Me.btRefresh.Size = New System.Drawing.Size(65, 55)
            Me.btRefresh.TabIndex = 0
            Me.btRefresh.Text = "Actualizar"
            Me.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btRefresh.UseVisualStyleBackColor = True
            Me.btRefresh.Visible = False
            '
            'printform
            '
            Me.ClientSize = New System.Drawing.Size(792, 573)
            Me.Name = "printform"
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            Me.SplitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefresh.Click
            Cursor = Cursors.WaitCursor
            VerInforme()
            Cursor = Cursors.Default
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

#Region "AppSetting"

        'Protected Overrides Function getUserPreferences() As repsol.util.setting.userpreferences
        '    Dim res As New _common.settings.AppPreferences(MyBase.getUserPreferences())

        '    Return res
        'End Function

#End Region

    End Class
End Namespace