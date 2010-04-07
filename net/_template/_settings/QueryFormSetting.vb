Namespace frm._template._settings

    <Serializable()> _
    Friend Class QueryFormSetting

        Inherits repsol.util.setting.userpreferences

        Public Sub New(ByVal appSetting As repsol.util.setting.userpreferences)
            Me.Location = appSetting.Location
            Me.Size = appSetting.Size
            Me.WindowState = appSetting.WindowState
        End Sub

        Private _ConfigForm As VO.configfrm.configfrm
        Public Property ConfigForm() As VO.configfrm.configfrm
            Get
                Return _ConfigForm
            End Get
            Set(ByVal value As VO.configfrm.configfrm)
                _ConfigForm = value
            End Set
        End Property

    End Class
End Namespace