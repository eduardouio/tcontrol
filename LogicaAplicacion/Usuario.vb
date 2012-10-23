Public Class Usuario
    Protected _Usuario As String = Nothing
    Protected _Pass As String = Nothing

    Public Property Usuario() As String
        Get
            Return Me._Usuario
        End Get
        Set(ByVal value As String)
            Me._Usuario = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return Me._Pass
        End Get
        Set(ByVal value As String)
            Me._Pass = value
        End Set
    End Property

    ''' <summary>
    ''' Consrtuctor Vacio
    ''' </summary>
    Public Sub New()
        _Usuario = Nothing
        _Pass = Nothing
    End Sub
End Class
