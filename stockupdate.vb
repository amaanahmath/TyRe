Public Class stockupdate
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub stockupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TyReDataSet.tyre' table. You can move, or remove it, as needed.
        Me.TyreTableAdapter.Fill(Me.TyReDataSet.tyre)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
       

    End Sub

   
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox4.Text = "" Then
            MsgBox("please insert quantity", 16)
        ElseIf Not IsNumeric(TextBox4.Text) Then
            MsgBox("Quantity must be an integer value", 16)
        Else
            Label1.Text = Val(TextBox4.Text) * Val(List_priceLabel1.Text)
            ListBox1.Items.Add(ComboBox1.Text)
            ListBox2.Items.Add(Tyre_nameLabel2.Text)
            ListBox3.Items.Add(TextBox4.Text)
            ListBox4.Items.Add(List_priceLabel1.Text)
            ListBox5.Items.Add(Label1.Text)
            ListBox10.Items.Add(ComboBox1.Text)
            ListBox9.Items.Add(Tyre_nameLabel2.Text)
            ListBox8.Items.Add(TextBox4.Text)
            ListBox7.Items.Add(List_priceLabel1.Text)
            ListBox6.Items.Add(Label1.Text)
            QuntityLabel1.Text = Val(QuntityLabel1.Text) + Val(TextBox4.Text)
            TyreBindingSource.EndEdit()
            TyreTableAdapter.Update(TyReDataSet.tyre)
            Me.TyreTableAdapter.Fill(Me.TyReDataSet.tyre)
            ComboBox1.Text = ""
            Tyre_nameLabel2.Text = ""
            TextBox4.Clear()
            List_priceLabel1.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Show()
        PrintDialog1.ShowDialog()

        'Panel2.Visible = False
        'Panel3.Visible = True
    End Sub
End Class