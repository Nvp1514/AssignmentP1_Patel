Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Text = "un"
        lblFrench.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Text = "deux"
        lblFrench.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Text = "trois"
        lblFrench.Visible = True
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Text = "quatre"
        lblFrench.Visible = True
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Text = "cinq"
        lblFrench.Visible = True
    End Sub
End Class
