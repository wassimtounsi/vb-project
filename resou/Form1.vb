Imports System.Windows.Forms
Imports System.Threading
Public Class Form1

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_c.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub resoudre_Click(sender As Object, e As EventArgs) Handles resoudre.Click

        Dim a, b, c As Single
        a = CSng(txt_a.Text)
        b = CSng(txt_b.Text)
        c = CSng(txt_c.Text)
        Dim delta As Single
        delta = (b * b) - 4 * (a * c)
        lbl_delta.Text = delta.ToString
        If delta < 0 Then
            lbl_pas.Text = "pas de solution reél"
            MsgBox("desolé,pas de solution!")


        Else
            If delta = 0 Then
                Dim x12 As Single
                x12 = (-b) / (2 * a)
                lbl_soldelta.Text = x12.ToString

            Else
                MsgBox("il ya deux solution rélles")
                Dim x123, x124 As Single
                x123 = (-b - Math.Sqrt(delta)) / (2 * a)
                x124 = (-b + Math.Sqrt(delta)) / (2 * a)
                lbl_x1.Text = x123.ToString
                lbl_x2.Text = x124.ToString




            End If


        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
