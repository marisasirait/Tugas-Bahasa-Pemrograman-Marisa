Public Class Form1



    Private Sub txtHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHitung.Click
        Dim a, b, c, rat As Single
        a = N1.Text
        b = N2.Text
        c = N3.Text
        rat = CDec(a + b + c) / 3
        rata.Text = rat

        If rata.Text > 80 Then
            txthadiah.Text = "Rp 10 jt"
        ElseIf rata.Text > 70 Then
            txthadiah.Text = "Rp 7.5 jt "
        Else : txthadiah.Text = "Hanya Dapat Sertifikat"

        End If
    End Sub

    Private Sub txtulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtulang.Click
        txtnama.Clear()
        N1.Clear()
        N2.Clear()
        N3.Clear()
        rata.Text = "----------------------------------"
        txthadiah.Text = "----------------------------------"
        txtnama.Focus()
    End Sub
End Class
