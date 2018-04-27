Public Class Form2


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, i, j, k, l, bot, tot As Single
        a = nkecil.Text
        b = nbesar.Text
        c = nuts.Text
        d = nuas.Text
        i = bkecil.Text
        j = bbesar.Text
        k = buts.Text
        l = buas.Text

        tot = ((a * i) / 100) + ((b * j) / 100) + ((c * k) / 100) + ((d * l) / 100)
        Hasil.Text = tot
        bot = i + j + k + l


        If bot = 100 Then

            If Hasil.Text > 80 Then
                txtgrade.Text = "A"
            ElseIf Hasil.Text > 70 Then
                txtgrade.Text = "B"
            ElseIf Hasil.Text > 60 Then
                txtgrade.Text = "C"
            ElseIf Hasil.Text > 50 Then
                txtgrade.Text = "D"
            Else : txtgrade.Text = "E"

            End If

        ElseIf bot > 100 Then
            MsgBox("Bobot Lebih", MsgBoxStyle.Information)
            bkecil.Clear()
            bbesar.Clear()
            buts.Clear()
            buas.Clear()
            Hasil.Text = ""

        Else
            MsgBox("Bobot Kurang", MsgBoxStyle.Information)
            bkecil.Clear()
            bbesar.Clear()
            buts.Clear()
            buas.Clear()
            Hasil.Text = ""
            
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class