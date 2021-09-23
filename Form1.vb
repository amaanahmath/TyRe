Public Class Form1
    Dim a As Boolean
    Dim b As Integer
    Dim c As Integer
    Dim rowid As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        a = True
        b = Cursor.Position.X - Me.Left
        c = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If a Then
            Me.Top = Cursor.Position.Y - c
            Me.Left = Cursor.Position.X - b

        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        a = False
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Transparent
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Amaan_2003DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Amaan_2003DataSet.Table1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Your password or username is incorrect", 16)

        ElseIf TextBox1.Text = User_NmaeLabel1.Text And TextBox2.Text = PasswordLabel1.Text Then
            Form2.Show()
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MsgBox("Your password or username is incorrect", 16)
            TextBox2.Clear()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Table1TableAdapter.UserNameSearch(Me.Amaan_2003DataSet.Table1, TextBox1.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Me.CheckBox1.Checked = True) Then
            Me.TextBox2.PasswordChar = ""
        Else
            Me.TextBox2.PasswordChar = "#"
        End If
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.White
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Black
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()

    End Sub

    Private Sub User_NmaeLabel1_Click(sender As Object, e As EventArgs) Handles User_NmaeLabel1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Table1BindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Table1BindingSource.CurrentChanged

    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        LinkLabel1.LinkColor = Color.Red
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        LinkLabel1.LinkColor = Color.Blue
    End Sub


End Class
