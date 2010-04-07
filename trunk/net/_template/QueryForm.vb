Namespace frm._template

	Public Class QueryForm
        Inherits repsol.forms.template.consulta.QueryForm

		Private Const STR_Width As String = "Width"
		Private Const STR_Height As String = "Height"
		Private Const STR_Top As String = "Top"
		Private Const STR_Left As String = "Left"
		Protected Friend WithEvents contextMenuAux As System.Windows.Forms.ContextMenuStrip
		Private components As System.ComponentModel.IContainer
		Private _GuardarPosicion As Boolean = True

		Public Sub New()
			MyBase.New()
			InitializeComponent()
			initForm()
		End Sub

		Public Sub New(ByVal soloconsulta As Boolean)
			MyBase.New(soloconsulta)
			InitializeComponent()
			initForm()
		End Sub

		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryForm))
            Me.contextMenuAux = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.panInfo.SuspendLayout()
            CType(Me.dvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panInfo
            '
            Me.panInfo.Location = New System.Drawing.Point(0, 127)
            '
            'contextMenuAux
            '
            Me.contextMenuAux.Name = "contextMenuAux"
            Me.contextMenuAux.Size = New System.Drawing.Size(61, 4)
            '
            'QueryForm
            '
            Me.ClientSize = New System.Drawing.Size(792, 573)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "QueryForm"
            Me.RememberUserPreferences = True
            Me.Controls.SetChildIndex(Me.panHead, 0)
            Me.Controls.SetChildIndex(Me.panInfo, 0)
            Me.Controls.SetChildIndex(Me.panDetail, 0)
            Me.panInfo.ResumeLayout(False)
            Me.panInfo.PerformLayout()
            CType(Me.dvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		Protected Overrides Sub btFiltrar_record()
			Me.chkVerFiltro.Checked = Me.btFiltrar.Checked
		End Sub

		Public ReadOnly Property ToolStripMain() As ToolStrip
			Get
				Return tbar
			End Get
		End Property

#Region "Opciones de Botones y Menus contextuales"

        Public Property ContextMenuShow() As Boolean
            Get
                Return Me.contextMenu2.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.contextMenu2.Visible = value
            End Set
        End Property

        Public Property ButtonShowBorrar() As Boolean
            Get
                Return Me.btBorrar.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btBorrar.Visible = value
                Me.BorrarToolStripMenuItem.Visible = Me.btBorrar.Visible
            End Set
        End Property

        Public Property ButtonShowDuplicar() As Boolean
            Get
                Return Me.btDuplicar.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btDuplicar.Visible = value
                Me.DuplicarToolStripMenuItem.Visible = Me.btDuplicar.Visible
            End Set
        End Property

        Public Property ButtonShowFiltro() As Boolean
            Get
                Return Me.btFiltrar.Checked
            End Get
			Set(ByVal value As Boolean)
				Me.chkVerFiltro.Visible = value
				Me.btFiltrar.Checked = value
				Me.chkVerFiltro.Checked = value
			End Set
        End Property

        Public Property ButtonShowModificar() As Boolean
            Get
                Return Me.btModificar.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btModificar.Visible = value
                Me.ModificarToolStripMenuItem.Visible = Me.btModificar.Visible
            End Set
        End Property

        Public Property ButtonShowNuevo() As Boolean
            Get
                Return Me.btNuevo.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btNuevo.Visible = value
                Me.NuevoToolStripMenuItem.Visible = Me.btNuevo.Visible
            End Set
        End Property

        Public Property ButtonShowVer() As Boolean
            Get
                Return Me.btConsulta.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btConsulta.Visible = value
                Me.VerToolStripMenuItem.Visible = value
            End Set
        End Property

        Public Property ButtonShowImprimir() As Boolean
            Get
                Return Me.btImprimir.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btImprimir.Visible = value
                'Me.vVerToolStripMenuItem.Visible = value
            End Set
        End Property

        ' ===========  Obsoletos ==================
        <Obsolete("Evitar su uso. Utilizar ButtonShowVer en su lugar.")> _
        Public Property ShowVerButton() As Boolean
            Get
                Return Me.btConsulta.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btConsulta.Visible = value
                Me.VerToolStripMenuItem.Visible = value
            End Set
        End Property

        <Obsolete("Evitar su uso. Utilizar ButtonShowFiltro en su lugar.")> _
        Public Property ShowFiltro() As Boolean
            Get
                Return Me.btFiltrar.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.btFiltrar.Checked = value
                Me.chkVerFiltro.Checked = Me.btFiltrar.Checked
            End Set
        End Property

#End Region

#Region "AppSetting"

        Protected Overrides Function getUserPreferences() As repsol.util.setting.userpreferences
            Dim res As New _common.settings.AppPreferences(MyBase.getUserPreferences())
            Return res
        End Function

#End Region

#Region "Gestionar ratón en el grid "

		Private Sub initForm()
			AddHandler Me.dgConsulta.DoubleClick, AddressOf dgConsulta_DoubleClick
			AddHandler Me.dgConsulta.MouseDown, AddressOf dgConsulta_MouseDown
			AddHandler Me.contextMenu2.Opening, AddressOf contextMenu2_opening
		End Sub

		Public Sub dgConsulta_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim point As System.Drawing.Point = dgConsulta.PointToClient(System.Windows.Forms.Cursor.Position)
			Dim info As Windows.Forms.DataGridView.HitTestInfo = Me.dgConsulta.HitTest(point.X, point.Y)
			If (info.RowIndex > -1) Then
				If (Me.Modal) Then
					Me.btSeleccionar_record()
				Else
					Me.btConsulta_record()
				End If
			End If
		End Sub	   'Lo sacamos porque en el doble click en el histórico tenemos otra funcionalidad distinta

		Public Sub dgConsulta_MouseDown(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs)
			Dim info As Windows.Forms.DataGridView.HitTestInfo = Me.dgConsulta.HitTest(e.X, e.Y)
			If (info.RowIndex > -1) AndAlso (info.ColumnIndex > -1) Then
				Me.dgConsulta.CurrentCell = Me.dgConsulta.Rows(info.RowIndex).Cells(info.ColumnIndex)
			End If
		End Sub

		Public Sub contextMenu2_opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			Dim point As System.Drawing.Point = dgConsulta.PointToClient(System.Windows.Forms.Cursor.Position)
			Dim info As Windows.Forms.DataGridView.HitTestInfo = Me.dgConsulta.HitTest(point.X, point.Y)

			If (Me.dgConsulta.DataSource Is Nothing) OrElse (Me.dgConsulta.Rows.Count = 0) OrElse (info.RowIndex = -1) Then
				e.Cancel = True
			End If
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

#End Region

	End Class

End Namespace
