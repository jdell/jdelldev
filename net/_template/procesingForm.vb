Namespace frm._template
    Public Class procesingForm
        Inherits repsol.forms.template.BaseForm


        Public Sub New()
            MyBase.New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(procesingForm))
            Me.lbInfo = New System.Windows.Forms.Label
            Me.btAcept = New System.Windows.Forms.Button
            Me.btCancel = New System.Windows.Forms.Button
            Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker
            Me.btParar = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'lbInfo
            '
            Me.lbInfo.AutoSize = True
            Me.lbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbInfo.Location = New System.Drawing.Point(20, 9)
            Me.lbInfo.Name = "lbInfo"
            Me.lbInfo.Size = New System.Drawing.Size(352, 16)
            Me.lbInfo.TabIndex = 0
            Me.lbInfo.Text = "El proceso puede tardar unos minutos. ¿Desea continuar?"
            '
            'btAcept
            '
            Me.btAcept.Location = New System.Drawing.Point(216, 130)
            Me.btAcept.Name = "btAcept"
            Me.btAcept.Size = New System.Drawing.Size(75, 23)
            Me.btAcept.TabIndex = 1
            Me.btAcept.Text = "Continuar"
            Me.btAcept.UseVisualStyleBackColor = True
            '
            'btCancel
            '
            Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btCancel.Location = New System.Drawing.Point(297, 130)
            Me.btCancel.Name = "btCancel"
            Me.btCancel.Size = New System.Drawing.Size(75, 23)
            Me.btCancel.TabIndex = 0
            Me.btCancel.Text = "Cerrar"
            Me.btCancel.UseVisualStyleBackColor = True
            '
            'BackgroundWorker
            '
            Me.BackgroundWorker.WorkerSupportsCancellation = True
            '
            'btParar
            '
            Me.btParar.Location = New System.Drawing.Point(166, 130)
            Me.btParar.Name = "btParar"
            Me.btParar.Size = New System.Drawing.Size(44, 23)
            Me.btParar.TabIndex = 1
            Me.btParar.Text = "Parar"
            Me.btParar.UseVisualStyleBackColor = True
            Me.btParar.Visible = False
            '
            'procesingForm
            '
            Me.AcceptButton = Me.btAcept
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btCancel
            Me.ClientSize = New System.Drawing.Size(372, 153)
            Me.Controls.Add(Me.btCancel)
            Me.Controls.Add(Me.btParar)
            Me.Controls.Add(Me.btAcept)
            Me.Controls.Add(Me.lbInfo)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(380, 180)
            Me.MinimumSize = New System.Drawing.Size(380, 180)
            Me.Name = "procesingForm"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "procesingForm"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Public WithEvents lbInfo As System.Windows.Forms.Label
        Public WithEvents btCancel As System.Windows.Forms.Button
        Public WithEvents btAcept As System.Windows.Forms.Button
        Public WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
        Public WithEvents btParar As System.Windows.Forms.Button

        Public Overridable Sub btAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAcept.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End Sub

        Public Overridable Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Public Overridable Sub btParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btParar.Click

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