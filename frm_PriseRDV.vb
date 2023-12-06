Imports System.Net.Mime.MediaTypeNames
Imports System.Reflection.Emit

Public Class frm_PriseRDV
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_valid_Click(sender As Object, e As EventArgs) Handles btn_valid.Click
        Dim x As rdv

        x.code = codep.Text
        x.temp = DateTimePicker1.Text


        add(x)


        codep.Clear()



    End Sub
    Private Sub MakePanelTransparent(panel As Panel)

        panel.BackColor = Color.FromArgb(90, 0, 0, 0)
        btn_valid.FlatStyle = FlatStyle.Flat
        btn_valid.BackColor = Color.FromArgb(39, 174, 96)
        btn_valid.ForeColor = Color.White
        btn_valid.FlatAppearance.BorderColor = Color.White
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.BackColor = Color.Red
        btn_cancel.ForeColor = Color.White
        btn_cancel.FlatAppearance.BorderColor = Color.White

    End Sub




    Private Sub frm_PriseRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        label2.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        label2.ForeColor = Color.White
        codep.BackColor = Color.Pink
        DateTimePicker1.BackColor = Color.Pink
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White

        MakePanelTransparent(Panel1)
        MakePanelTransparent(Panel2)



    End Sub

    Private Sub btn_cancel_Clxick(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub codep_TextChanged(sender As Object, e As EventArgs) Handles codep.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub bttn_close_Click(sender As Object, e As EventArgs) Handles bttn_close.Click
        Me.Close()

    End Sub

    Private Sub bttn_minimise_Click(sender As Object, e As EventArgs) Handles bttn_minimise.Click
        WindowState = WindowState.Minimized
    End Sub
End Class