Public Class Form1
    Dim j As Boolean = False
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 13 Then
            Try
                ' Dim result = New DataTable().Compute(TextBox1.Text, Nothing)
                TextBox1.Text = New DataTable().Compute(TextBox1.Text, Nothing)
                j = True
            Catch ex As Exception
                MsgBox("Expression is May be a wrong or invalid")
            End Try
        Else
            If j = True Then
                j = False
                TextBox1.Clear()
            End If
        End If
    End Sub

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
