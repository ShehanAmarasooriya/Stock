Public Class CRISMS
    Dim pcount As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoginAdmin.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        LoginTechnician.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoginOfficer.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        LoginInventoryHolder.Show()

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        HELP.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoginAdmin.Show()

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.Admin_login

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.download
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LoginOfficer.Show()

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.Admin_login

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.officer__2_
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoginInventoryHolder.Show()

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.Admin_login
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.Stock
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        LoginTechnician.Show()

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.Admin_login

    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.technician
    End Sub

    Private Sub tmranimation_Tick(sender As Object, e As EventArgs) Handles tmranimation.Tick

        Select Case pcount
            Case 1
                animationpic.Image = My.Resources.animation1
                pcount += 1
            Case 2
                animationpic.Image = My.Resources.animation2
                pcount += 1
            Case 3
                animationpic.Image = My.Resources.animation3
                pcount += 1
            Case 4
                animationpic.Image = My.Resources.animation4
                pcount += 1
            Case 5
                animationpic.Image = My.Resources.animation5
                pcount += 1
            Case 6
                animationpic.Image = My.Resources.animation6
                pcount = 1
        End Select
    End Sub

    Private Sub CRISMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmranimation.Start()

    End Sub

    Private Sub animationpic_Click(sender As Object, e As EventArgs) Handles animationpic.Click

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()

    End Sub
End Class