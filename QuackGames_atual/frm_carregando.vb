Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_carregando
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With PictureBox3

            Static x = 0
            If .Width + 10 < 540 Then
                .Width += 20
            Else
                .Width = 540
            End If

            If x >= 550 Then
                Timer1.Enabled = False
                Me.Close()
            End If
            x += 20
        End With

    End Sub

    Private Sub frm_carregando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

End Class