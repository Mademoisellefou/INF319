Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a >= b And a >= c Then If c >= b Then GoTo ord_acb Else GoTo ord_abc
        If b >= a And b >= c Then If a >= c Then GoTo ord_bac Else GoTo ord_bca
        If c >= a And c >= b Then If a >= b Then GoTo ord_cab Else GoTo ord_cba
ord_acb:

        Label1.Text = a
        Label2.Text = c
        Label3.Text = b
        GoTo final
ord_abc:
        Label1.Text = a
        Label2.Text = b
        Label3.Text = c
        GoTo final
ord_bca:
        Label1.Text = b
        Label2.Text = c
        Label3.Text = a
        GoTo final
ord_bac:
        Label1.Text = b
        Label2.Text = a
        Label3.Text = c
        GoTo final
ord_cab:
        Label1.Text = c
        Label2.Text = a
        Label3.Text = b
        GoTo final
ord_cba:
        Label1.Text = c
        Label2.Text = b
        Label3.Text = a
        GoTo final

final:
    End Sub


End Class
