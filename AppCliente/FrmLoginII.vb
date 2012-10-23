Imports LogicaAplicacion

Public Class FrmLoginII
    Private _Usuario As String = Nothing
    Private _Pass As String = Nothing

    Public Function Autentificar(ByVal Usuario As String, ByVal Pass As String) As Boolean
        Dim condicion As Boolean = False
        Dim CatUsuarios As CatalogoUsuarios = New CatalogoUsuarios()
        Dim MiUsuario As Usuario = New Usuario()
        MiUsuario = CatUsuarios.ObtenerUsuario(Usuario)
        If Not MiUsuario Is Nothing Then
            If (MiUsuario.Usuario = Usuario) And (MiUsuario.Pass = Pass) Then
                condicion = True
            Else
                condicion = False
                MsgBox("El usuario o Pass es invalido II")
                UsernameTextBox.Focus()
                UsernameTextBox.Select()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            End If
        Else
            MsgBox("El usuario o Pass es invalido II")
            UsernameTextBox.Focus()
            UsernameTextBox.Select()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
        Return condicion
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me._Usuario = UsernameTextBox.Text
        Me._Pass = PasswordTextBox.Text
        Dim Paso As Boolean = False
        Paso = Me.Autentificar(Me._Usuario, Me._Pass)
        If Paso = True Then
            FrmControlPanel.Enabled = True
            Call FrmControlPanel.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLoginII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        FrmControlPanel.Enabled = False
    End Sub
End Class
