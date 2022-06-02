Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Billing
    Private Sub AddBill()
        Try
            Con.Open()
            Dim query = "insert into billing values('" & txtCName.Text & "','" & DateTime.Today.Date & "')"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill Saved Successfully", vbInformation, "Saved")
            Con.Close()
            BillDGV.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pdDisplay()
        Con.Open()
        Dim query = "select * from items"
        Dim cmd = New MySqlCommand(query, Con)
        Dim adapter As MySqlDataAdapter
        adapter = New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim data As DataSet
        data = New DataSet
        adapter.Fill(data)
        PdDGV.DataSource = data.Tables(0)
        Con.Close()
    End Sub

    Private Sub PBExit_Click(sender As Object, e As EventArgs) Handles PbExit.Click
        Application.Exit()

    End Sub

    Private ID As String = ""
    Private intRow As Integer = 0

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    Private Sub Execute(MySql As String, Optional Parameter As String = "")

        Cmd = New MySqlCommand(MySql, Con)
        AddParameters(Parameter)
        PerformCRUD(Cmd)

    End Sub
    Private Sub AddParameters(str As String)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("ItemName", ItNameTb.Text.Trim())
        Cmd.Parameters.AddWithValue("Quantity", QuantityTb.Text.Trim())
        Cmd.Parameters.AddWithValue("Price", PriceTb.Text.Trim())

        If str = "Reset" Or Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("ID", Me.ID)
        End If

    End Sub
    Private Sub BillBtn_Click(sender As Object, e As EventArgs) Handles BillBtn.Click


        If String.IsNullOrEmpty(ItNameTb.Text.Trim()) Or String.IsNullOrEmpty(QuantityTb.Text.Trim()) Or String.IsNullOrEmpty(PriceTb.Text.Trim()) Then
            MsgBox("Please Input the complete details", MsgBoxStyle.OkOnly)
        End If

        Sql = " INSERT INTO  billing(Itname, Quantity, Price) VALUES (@ItemName, @Quantity, @Price);"

        Execute(Sql, "Insert")

        MsgBox("Items added successfully", MsgBoxStyle.OkOnly)

        LoadData()

    End Sub

    Private Sub LoadData(Optional keyword As String = "")

        Sql = " SELECT ID, Itname, Quantity, Price, Quantity*Price as Total FROM billing"


        Dim strKeyword As String = String.Format("%{0}%", keyword)

        Cmd = New MySqlCommand(Sql, Con)
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("keyword1", strKeyword)
        Cmd.Parameters.AddWithValue("keyword2", keyword)

        Dim dt As DataTable = PerformCRUD(Cmd)

        If dt.Rows.Count > 0 Then
            intRow = Convert.ToInt32(dt.Rows.Count.ToString())
        Else
            intRow = 0
        End If

        With BillDGV
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "ItemName"
            .Columns(2).HeaderText = "Quantity"
            .Columns(3).HeaderText = "Price"
            .Columns(4).HeaderText = "Total"

            .Columns(0).Width = 50
            .Columns(1).Width = 120
            .Columns(2).Width = 70
            .Columns(3).Width = 70
            .Columns(4).Width = 70

        End With
    End Sub

    Private Sub BillDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDGV.CellClick
        Try
            Dim dgv As DataGridView = BillDGV

            If e.RowIndex <> -1 Then

                Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()

                ItNameTb.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim()
                QuantityTb.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value).Trim()
                PriceTb.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value).Trim()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click

        Try
            Sql = "TRUNCATE billing;"
            Execute(Sql, "Reset")
            MsgBox("Data Cleared")

        Catch ex As Exception

        End Try
        LoadData()

    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim F1 As New Font("Calibri", 8, FontStyle.Regular)
        Dim F2 As New Font("Calibri", 10, FontStyle.Regular)
        Dim F3 As New Font("Calibri", 12, FontStyle.Regular)
        Dim F4 As New Font("Calibri", 14, FontStyle.Bold)
        Dim F5 As New Font("Monotype Corsiva", 12, FontStyle.Italic)


        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString("Ine'sStore", F4, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Brgy.Wawa Lumban, Laguna", F2, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel +69123467342", F1, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Invoice ID", F1, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", F1, Brushes.Black, 50, 60)
        e.Graphics.DrawString("XXXXXXX", F1, Brushes.Black, 70, 60)


        e.Graphics.DrawString("Cashier", F1, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", F1, Brushes.Black, 50, 75)
        e.Graphics.DrawString("Ine", F1, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Client Name", F1, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", F1, Brushes.Black, 60, 85)
        e.Graphics.DrawString(txtCName.Text, F1, Brushes.Black, 70, 85)

        e.Graphics.DrawString(line, F1, Brushes.Black, 0, 95)

        Dim totalAmount As Integer
        Dim height As Integer
        Dim i As Long

        BillDGV.AllowUserToAddRows = False
        For R As Integer = 0 To BillDGV.RowCount - 1
            height += 15
            totalAmount += BillDGV.Rows(R).Cells(4).Value


            e.Graphics.DrawString("Quantity", F1, Brushes.Black, 0, 105)
            e.Graphics.DrawString(":", F1, Brushes.Black, 50, 105)
            e.Graphics.DrawString("Item Name", F1, Brushes.Black, 100, 1055)
            e.Graphics.DrawString(":", F1, Brushes.Black, 100, 1055)
            e.Graphics.DrawString("Total Price", F1, Brushes.Black, rightmargin, 105, right)
            e.Graphics.DrawString(":", F1, Brushes.Black, rightmargin, 105, right)

            e.Graphics.DrawString(BillDGV.Rows(R).Cells(2).Value.ToString, F2, Brushes.Black, 25, 105 + height)
            e.Graphics.DrawString(BillDGV.Rows(R).Cells(1).Value.ToString, F2, Brushes.Black, 100, 105 + height)

            i = BillDGV.Rows(R).Cells(4).Value
            BillDGV.Rows(R).Cells(4).Value = i
            e.Graphics.DrawString(BillDGV.Rows(R).Cells(4).Value.ToString, F2, Brushes.Black, rightmargin, 105 + height, right)
        Next
        Dim height2 As Integer

        height2 = 120 + height
        e.Graphics.DrawString(line, F1, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total Bill", F3, Brushes.Black, rightmargin, 35 + height2, right)
        e.Graphics.DrawString(totalAmount, F3, Brushes.Black, rightmargin, 55 + height2, right)

        e.Graphics.DrawString("- Thank You for Buying! -", F5, Brushes.Black, centermargin, 75 + height2, center)
        e.Graphics.DrawString("Have a blessed day!", F5, Brushes.Black, centermargin, 90 + height2, center)


    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        TryCast(PdDGV.DataSource, DataTable).DefaultView.RowFilter =
            String.Format(" ItName like '%" & SearchTb.Text & "%'")
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Billing_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        pdDisplay()
    End Sub

    Dim k = 0, Stock = 0

    Private Sub PdDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PdDGV.CellMouseClick
        Dim row As DataGridViewRow = PdDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString

        PriceTb.Text = row.Cells(3).Value.ToString

        If ItNameTb.Text = "" Then
            k = 0
        Else
            k = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)
        End If
    End Sub

    Private Sub Totallbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UdProduct()
        Dim newqty = Stock - Convert.ToInt32(QuantityTb.Text)
        Try
            Con.Open()
            Dim query = "Update items set Quantity= " & newqty & " where ID= " & k & ""
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Updated Successfully", vbInformation, "Updated")
            Con.Close()
            pdDisplay()
        Catch ex As Exception

        End Try
    End Sub

End Class