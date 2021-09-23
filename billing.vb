Public Class billing
    Dim a As Boolean
    Dim b As Integer
    Dim c As Integer
    Dim rowid As Integer
    Dim sum As Integer
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

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TyReDataSet1.Billing' table. You can move, or remove it, as needed.
        Me.BillingTableAdapter.Fill(Me.TyReDataSet1.Billing)
        'TODO: This line of code loads data into the 'TyReDataSet.tyre' table. You can move, or remove it, as needed.
        Me.TyreTableAdapter.Fill(Me.TyReDataSet.tyre)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' TyreBindingSource.AddNew()

        If ComboBox1.Text = Tyre_codeLabel1.Text Then
            TextBox5.Text = Tyre_nameLabel1.Text

        End If
    End Sub

    Private Sub TyreBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TyreBindingSource.CurrentChanged

    End Sub

   

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Then
            MsgBox("please insert Bill Number", 16)
        ElseIf Not IsNumeric(TextBox3.Text) Then
            MsgBox("Please insert valid Bill Number", 16)

        ElseIf TextBox4.Text = "" Then
            MsgBox("please insert quantity", 16)
       

        ElseIf Val(TextBox4.Text) > Val(QuntityLabel1.Text) Then
            MsgBox("you don't have enough item", 16)
        ElseIf TextBox9.Text = "" Then
            MsgBox("please insert Discount percentage", 16)
        ElseIf Not IsNumeric(TextBox4.Text) Then
            MsgBox("Please insert valid quntity", 16)
        Else
            TextBox8.Text = Val(List_priceLabel1.Text) - ((Val(List_priceLabel1.Text) * TextBox9.Text) / 100)
            If Val(TextBox8.Text) <= Val(CostLabel1.Text) Then
                MsgBox("We can't sell a product by this value", 16)
            Else


                List_priceLabel1.Text = Label2.Text
                Selling_priceLabel1.Text = Spricelabel.Text
                BillingBindingSource.EndEdit()
                BillingTableAdapter.Update(TyReDataSet1.Billing)
                Me.BillingTableAdapter.Fill(Me.TyReDataSet1.Billing)
                BillingBindingSource.AddNew()

                Label11.Text = Val(TextBox4.Text) * Val(TextBox8.Text)
                QuntityLabel1.Text = Val(QuntityLabel1.Text) - Val(TextBox4.Text)
                TyreBindingSource.EndEdit()
                TyreTableAdapter.Update(TyReDataSet.tyre)
                Me.TyreTableAdapter.Fill(Me.TyReDataSet.tyre)
                ComboBox1.Text = ""
                Tyre_nameLabel1.Text = ""
                TextBox4.Clear()
                List_priceLabel1.Text = ""
                Selling_priceLabel1.Text = ""
                TextBox8.Clear()
                TextBox9.Clear()
            End If

        End If

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
       
        TextBox7.Text = Val(TextBox5.Text) - Val(TextBox6.Text)
        ComboBox1.Text = ""
        Tyre_nameLabel1.Text = ""
        TextBox4.Clear()
        List_priceLabel1.Text = ""
        Selling_priceLabel1.Text = ""
        TextBox8.Clear()

    End Sub

    
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class