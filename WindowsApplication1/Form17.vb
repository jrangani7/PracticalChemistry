﻿Public Class Form17
    Public hcl As Boolean
    Public resulto As String
    Public nh4oh As Boolean
    Public nh4cl As Boolean
    Public a As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Transfered O.S. to new test tube.")
        nh4cl = True
        Button1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton3.Checked = True And Not (Form1.a = 3 Or Form1.a = 2) Then
            Me.Hide()
            Form18.Show()
            Form4.TextBox36.Text = "O.S. + NH4Cl + NH4OH(till alkaline)"
            Form4.TextBox35.Text = "No precipitate"
            Form4.TextBox34.Text = "Group III A absent"
        ElseIf RadioButton1.Checked = True And (Form1.a = 3 Or Form1.a = 2) Then
            Me.Hide()
            Form4.TextBox36.Text = "O.S. + NH4Cl + NH4OH(till alkaline)"
            Form4.TextBox35.Text = "" + resulto
            Form4.TextBox34.Text = "Group III A present"
            a = MsgBox("This confirms presence of Group III A continue?", MsgBoxStyle.OkCancel)
            If a = vbOK Then
                Form23.Show()
            Else
                Form4.Show()
            End If
        Else
            erro.Visible = True
            Label7.Visible = True
            PictureBox1.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If nh4cl = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Added NH4Cl to test tube with O.S. ")
            nh4oh = True
            Button2.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If nh4oh = True Then
            RichTextBox1.Clear()
            RichTextBox1.AppendText("Added NH4OH to test tube with O.S. ")
            RichTextBox1.AppendText("Wait for 2 seconds....")
            Button4.Hide()
            Timer2.Start()
        End If
        If Form1.a = 3 Or Form1.a = 2 Then
            resulto = "White ppt or Reddish brown ppt"
        Else
            resulto = "No precipitate"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Clear()
        RichTextBox1.AppendText("The process is completed results below-")
        RichTextBox1.AppendText(vbNewLine + resulto)
        Timer2.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        erro.Visible = False
        Label7.Visible = False
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Form4.BringToFront()
        Form4.Focus()
    End Sub
End Class