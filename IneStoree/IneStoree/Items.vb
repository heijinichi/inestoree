Option Explicit On
Option Strict On
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class Items

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private ID As String = ""
    Private intRow As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetMe()
        LoadData()
    End Sub


    Private Sub ResetMe()
        Me.ID = ""

        ItNameTb.Text = ""
        QuantityTb.Text = ""
        PriceTb.Text = ""

        UpdateBtn.Text = "Update"
        DeleteBtn.Text = "Delete"


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
        Cmd.Parameters.AddWithValue("Category", CbCat.SelectedItem.ToString().Trim())

        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            Cmd.Parameters.AddWithValue("ID", Me.ID)
        End If

    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If String.IsNullOrEmpty(ItNameTb.Text.Trim()) Or String.IsNullOrEmpty(QuantityTb.Text.Trim()) Or String.IsNullOrEmpty(PriceTb.Text.Trim()) Then
            MsgBox("Please Input the complete details", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Sql = " INSERT INTO items(Itname, Quantity, Price, Category) VALUES (@ItemName, @Quantity, @Price, @Category);"

        Execute(Sql, "Insert")

        MsgBox("Items saved successfully", MsgBoxStyle.OkOnly)

        LoadData()

        ResetMe()


    End Sub
    Private Sub LoadData(Optional keyword As String = "")

        Sql = " SELECT ID, Itname, Quantity, Price, Category FROM items"


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

        With PdDGV
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "ItemName"
            .Columns(2).HeaderText = "Quantity"
            .Columns(3).HeaderText = "Price"
            .Columns(4).HeaderText = "Category"

            .Columns(0).Width = 85
            .Columns(0).Width = 170
            .Columns(0).Width = 100
            .Columns(0).Width = 100
            .Columns(0).Width = 100
        End With
    End Sub

    Private Sub PdDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PdDGV.CellClick

        Try
            Dim dgv As DataGridView = PdDGV

            If e.RowIndex <> -1 Then

                Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()
                UpdateBtn.Text = "Update(" & Me.ID & ")"
                DeleteBtn.Text = "Delete (" & Me.ID & ")"

                ItNameTb.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim()
                QuantityTb.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value).Trim()
                PriceTb.Text = Convert.ToString(dgv.CurrentRow.Cells(3).Value).Trim()
                CbCat.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells(4).Value).Trim()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If PdDGV.Rows.Count = 0 Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox(" Select items to be updated", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If String.IsNullOrEmpty(ItNameTb.Text.Trim()) Or String.IsNullOrEmpty(QuantityTb.Text.Trim()) Or String.IsNullOrEmpty(PriceTb.Text.Trim()) Then
            MsgBox("Please put a complete details", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Sql = " UPDATE items SET Itname = @ItemName, Quantity = @Quantity, Price = @Price, Category = @Category WHERE ID = @ID;"

        Execute(Sql, "Update")

        MsgBox("Items updated successfully", MsgBoxStyle.OkOnly)

        LoadData()

        ResetMe()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If PdDGV.Rows.Count = 0 Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MsgBox(" Select items to be deleted", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Sql = " DELETE FROM items WHERE ID = @ID;"

        Execute(Sql, "Delete")

        MsgBox("Items deleted successfully", MsgBoxStyle.OkOnly)

        LoadData()

        ResetMe()

    End Sub
    Private Sub Clear()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QuantityTb.Text = ""
        CbCat.SelectedItem = 0

    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        TryCast(PdDGV.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("ItName like '%" & TbSearch.Text & "%'")
    End Sub

    Private Sub BtnGTBilling_Click(sender As Object, e As EventArgs) Handles BtnGTBilling.Click
        Dim obj = New Billing
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

End Class
