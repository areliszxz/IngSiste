Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "12345") Then
            Form2.Show()
            MDIParent1.NewToolStripMenuItem.Enabled = True
            MDIParent1.OpenToolStripMenuItem.Enabled = True
            MDIParent1.ToolStripMenuLogin.Visible = False
            MDIParent1.Show()
            Me.Visible = False
        Else
            MsgBox("No existe ususario", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIParent1.NewToolStripMenuItem.Enabled = False
        MDIParent1.OpenToolStripMenuItem.Enabled = False
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
