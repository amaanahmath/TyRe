Public Class Form4
    Dim a As Boolean
    Dim b As Integer
    Dim c As Integer

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
    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Amaan_2003DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Amaan_2003DataSet.Table1)

    End Sub

    Private Sub Table1BindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Table1BindingSource.CurrentChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.AddNew()
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If TextBox3.Text = "" Then
                MsgBox("Please fill first name", 16)
            ElseIf IsNumeric(TextBox3.Text) Then
                MsgBox("Name must be a character", 16)
            ElseIf TextBox4.Text = "" Then
                MsgBox("Please fill last name", 16)
            ElseIf IsNumeric(TextBox4.Text) Then
                MsgBox("Name must be a character", 16)
            ElseIf ComboBox2.Text = "" Then
                MsgBox("Please select a question", 16)
            ElseIf TextBox5.Text = "" Then
                MsgBox("Please give answer", 16)
            ElseIf TextBox6.Text = "" Then
                MsgBox("Please give username", 16)
            ElseIf TextBox7.Text = "" Then
                MsgBox("Please give password", 16)
            ElseIf TextBox8.Text <> TextBox7.Text Then
                MsgBox("Password not match", 16)
            Else

                Table1BindingSource.EndEdit()
                Table1TableAdapter.Update(Amaan_2003DataSet.Table1)
                Me.Table1TableAdapter.Fill(Me.Amaan_2003DataSet.Table1)
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                ComboBox2.Text = ""
                MsgBox("your account has created succefully", 64)
                Panel3.Visible = True
                Panel2.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Please try another User name", 16)

        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (Me.CheckBox1.Checked = True) Then
            Me.TextBox7.PasswordChar = ""
        Else
            Me.TextBox7.PasswordChar = "#"
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (Me.CheckBox2.Checked = True) Then
            Me.TextBox8.PasswordChar = ""
        Else
            Me.TextBox8.PasswordChar = "#"
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub
End Class