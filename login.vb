Public Class login
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MakePanelTransparent(panel As Panel)

        panel.BackColor = Color.FromArgb(90, 0, 0, 0)

    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MakePanelTransparent(Panel1)
        MakePanelTransparent(Panel2)


        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent



        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White

        user_txt.BackColor = Color.Pink
        pass_txt.BackColor = Color.Pink
        bttn_login.FlatStyle = FlatStyle.Flat
        bttn_login.BackColor = Color.FromArgb(39, 174, 96)
        bttn_login.ForeColor = Color.White
        bttn_login.FlatAppearance.BorderColor = Color.White
        Buttn_minimize.FlatStyle = FlatStyle.Flat
        bttn_close.FlatStyle = FlatStyle.Flat
        Buttn_minimize.FlatAppearance.BorderSize = 0
        bttn_close.FlatAppearance.BorderSize = 0


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint






    End Sub

    Private Sub bttn_login_Click(sender As Object, e As EventArgs) Handles bttn_login.Click



        If (user_txt.Text = "admin") And (pass_txt.Text = "1234") Then

            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Authentication failed. Please try again.")


        End If
    End Sub

    Private Sub bttn_close_Click(sender As Object, e As EventArgs) Handles bttn_close.Click
        Me.Close()

    End Sub

    Private Sub Buttn_minimize_Click(sender As Object, e As EventArgs) Handles Buttn_minimize.Click
        WindowState = WindowState.Minimized


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub user_txt_TextChanged(sender As Object, e As EventArgs) Handles user_txt.TextChanged

    End Sub
End Class