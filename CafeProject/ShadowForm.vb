Public Class ShadowForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Public Sub focusMe()
        Me.Activate()
    End Sub

End Class