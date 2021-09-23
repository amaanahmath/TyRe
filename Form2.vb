Public Class Form2
    Dim a As Boolean
    Dim b As Integer
    Dim c As Integer
    Dim rowid As Integer
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
        Form1.Close()
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
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TyReDataSet.tyre' table. You can move, or remove it, as needed.
        Me.TyreTableAdapter.Fill(Me.TyReDataSet.tyre)

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles Textbox1.OnTextChange
        TyreTableAdapter.Tyre(Me.TyReDataSet.tyre, Textbox1.text + "%")
    End Sub



   Private Sub BunifuImageButton1_Click_2(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub


    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Panel2.Visible = False
        Panel3.Visible = True


    End Sub


    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        Panel3.Visible = True
        Panel4.Visible = False
       
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.Black

    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Transparent
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Black
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        TyreBindingSource.AddNew()
        Panel3.Visible = False
        Panel4.Visible = True

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextBox2.Text = "" Then
                MsgBox("please insert tyre code", 16)
            ElseIf TextBox3.Text = "" Then
                MsgBox("please insert tyre name", 16)
            ElseIf TextBox4.Text = "" Then
                MsgBox("please insert quntity", 16)
            ElseIf TextBox5.Text = "" Then
                MsgBox("please insert list price", 16)
            ElseIf TextBox6.Text = "" Then
                MsgBox("please insert selling price", 16)
            ElseIf TextBox7.Text = "" Then
                MsgBox("Please insert cost price", 16)
            ElseIf Not IsNumeric(TextBox4.Text) Then
                MsgBox("Please insert valid quntity", 16)
            ElseIf Val(TextBox4.Text) <= 0 Then
                MsgBox("Please insert valid quntity", 16)
            ElseIf Not IsNumeric(TextBox5.Text) Then
                MsgBox("Please insert valid quntity", 16)
            ElseIf Val(TextBox5.Text) <= 0 Then
                MsgBox("please insert valid list price", 16)
            ElseIf Not IsNumeric(TextBox6.Text) Then
                MsgBox("Please insert valid quntity", 16)
            ElseIf Val(TextBox6.Text) <= 0 Then
                MsgBox("please insert valid selling price", 16)
            ElseIf Not IsNumeric(TextBox7.Text) Then
                MsgBox("Please insert valid quntity", 16)
            ElseIf Val(TextBox7.Text) <= 0 Then
                MsgBox("please insert valid cost", 16)
            Else
                TyreBindingSource.EndEdit()
                TyreTableAdapter.Update(TyReDataSet.tyre)
                Me.TyreTableAdapter.Fill(Me.TyReDataSet.tyre)
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TyreBindingSource.AddNew()
            End If
            
        Catch ex As Exception
            MsgBox("There is a product already in list", 16)

        End Try

    End Sub

    Private Sub BunifuCustomDataGrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        BillingBindingSource.AddNew()
        billing.Show()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        stockupdate.Show()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click

        Form4.Show()

    End Sub
End Class