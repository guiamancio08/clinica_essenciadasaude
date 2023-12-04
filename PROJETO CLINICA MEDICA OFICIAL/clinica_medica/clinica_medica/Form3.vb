Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        barra_prog.Value += 1
        If barra_prog.Value = 100 Then
            Form1.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class