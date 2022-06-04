Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

        If TextBox1.Text = "admin1" And TextBox2.Text = "1234" Then
        Else
            MsgBox("La contrasena es incorrecta", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        If MsgBox("¿Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
        If MsgBox("¿Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Pregunta") = vbNo Then
            End
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
