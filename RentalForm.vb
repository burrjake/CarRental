Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim msgNumber = MsgBox("Are you sure you want to Quit?", MsgBoxStyle.YesNo, "Quit")
        If msgNumber = 6 Then
            Me.Close()
        Else
        End If
    End Sub


End Class
