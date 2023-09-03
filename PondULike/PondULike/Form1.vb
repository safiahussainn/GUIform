Public Class Form1

    Private Sub CalculateArea()
        Dim length, width, depth As Decimal
        depth = txt_depth.Text
        width = txt_width.Text
        length = txt_length.Text
        'calculating area
        Dim totalwidth, totallength As Decimal
        totallength = length + (2 * depth)
        totalwidth = Width + (2 * depth)
        txt_area.MaxLength = 5
        txt_area.Text = totallength * totalwidth
        If txt_area.Text <= 15 Then
            txt_typeofliner.Text = ("Gauge 1")
        ElseIf txt_area.Text > 15 Then
            txt_typeofliner.Text = ("Gauge 2")
        End If
        If txt_typeofliner.Text = ("Gauge 1") Then
            txt_costofliner.Text = ("£" & txt_area.Text * 1.12)
        ElseIf txt_typeofliner.Text = ("Gauge 2") Then
            txt_costofliner.Text = ("£" & txt_area.Text * 1.76)
        End If
    End Sub

    Private Sub btn_calc_click(sender As Object, e As EventArgs) Handles btn_calc.Click

        Dim length, width, depth As Decimal
        depth = txt_depth.Text
        width = txt_width.Text
        length = txt_length.Text

        Call PresenceCheck()

        'range check for length
        If length < 0.5 Or length > 10 Then
            MessageBox.Show("You must enter a length between 0.5 and 10.")
            txt_length.Text = ""
        End If


        'range check for width
        If width < 0.5 Or width > 10 Then
            MessageBox.Show("You must enter a width between 0.5 and 10.")
            txt_width.Text = ""

        End If

        'range check for depth
        If depth < 0.5 Or depth > 2 Then
            MessageBox.Show("You must enter a depth between 0.5 and 2.")
            txt_depth.Text = ""

        End If

        Call CalculateArea()

    End Sub

    Private Sub btn_calc_MouseHover(sender As Object, e As EventArgs) Handles btn_calc.MouseHover
        Dim but As New ToolTip()
        but.SetToolTip(btn_calc, "this button will calculate the area for you")
    End Sub

    Private Sub btn_view_MouseHover(sender As Object, e As EventArgs) Handles btn_view.MouseHover
        Dim but As New ToolTip()
        but.SetToolTip(btn_view, "this button will view the records for you")
    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        Dim but As New ToolTip()
        but.SetToolTip(btn_save, "this button will save the records for you")
    End Sub

    Private Sub btn_quit_MouseHover(sender As Object, e As EventArgs) Handles btn_quit.MouseHover
        Dim but As New ToolTip()
        but.SetToolTip(btn_quit, "this button will quit the form for you")
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        'presence check for customer name and reference number
        If txt_customername.Text = "" Then
            MessageBox.Show("Please enter a customer name")
        End If

        If txt_referencenumber.Text = "" Then
            MessageBox.Show("Please enter a reference number")
        End If

        'creating module for the saving of the records

        Dim name, linertype As String
        Dim ref, area, cost As Decimal
        name = txt_customername.Text
        ref = txt_referencenumber.Text
        area = txt_area.Text
        linertype = txt_typeofliner.Text
        cost = txt_costofliner.Text
        FileOpen(1, "PondULike.txt", OpenMode.Append)
        PrintLine(1, ref, name, area, linertype, cost)
        FileClose(1)
        MessageBox.Show("You have saved to disk")
        txt_referencenumber.Text = ""
        txt_customername.Text = ""
        txt_typeofliner.Text = ""
        txt_costofliner.Text = ""
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        'creating module for the viewings of the records
        FileOpen(1, "PondULike.txt", OpenMode.Input)
        While Not EOF(1)
            txt_View.Text = txt_View.Text & LineInput(1) & vbCrLf
        End While
        FileClose(1)

    End Sub

    Private Sub PresenceCheck()
        'presence check for depth
        If txt_depth.Text = "" Then
            MessageBox.Show("Please enter a depth")
        End If

        'presence check for width
        If txt_width.Text = "" Then
            MessageBox.Show("Please enter a width")
        End If

        'presence check for length
        If txt_length.Text = "" Then
            MessageBox.Show("Please enter a length")
        End If
    End Sub

    Private Sub txt_depth_TextChanged(sender As Object, e As EventArgs) Handles txt_depth.TextChanged

        'presence check for depth
        If txt_depth.Text = "" Then
            MessageBox.Show("Please enter a depth")
        End If

        If txt_depth.Text = Text Then
            MessageBox.Show("Please enter a decimal value.")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = DateTime.Now.ToLongDateString()
        lbl_time.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        Close()
    End Sub
End Class
