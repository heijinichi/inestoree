<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbExit = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItNameTb = New System.Windows.Forms.TextBox()
        Me.QuantityTb = New System.Windows.Forms.TextBox()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BillBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.SearchTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PdDGV = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.PbExit)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-20, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 72)
        Me.Panel1.TabIndex = 21
        '
        'PbExit
        '
        Me.PbExit.Image = CType(resources.GetObject("PbExit.Image"), System.Drawing.Image)
        Me.PbExit.Location = New System.Drawing.Point(867, 0)
        Me.PbExit.Name = "PbExit"
        Me.PbExit.Size = New System.Drawing.Size(33, 33)
        Me.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbExit.TabIndex = 17
        Me.PbExit.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Billing"
        '
        'ItNameTb
        '
        Me.ItNameTb.BackColor = System.Drawing.SystemColors.Window
        Me.ItNameTb.Location = New System.Drawing.Point(121, 153)
        Me.ItNameTb.Name = "ItNameTb"
        Me.ItNameTb.Size = New System.Drawing.Size(112, 22)
        Me.ItNameTb.TabIndex = 22
        '
        'QuantityTb
        '
        Me.QuantityTb.BackColor = System.Drawing.SystemColors.Window
        Me.QuantityTb.Location = New System.Drawing.Point(340, 109)
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.Size = New System.Drawing.Size(112, 22)
        Me.QuantityTb.TabIndex = 23
        '
        'PriceTb
        '
        Me.PriceTb.BackColor = System.Drawing.SystemColors.Window
        Me.PriceTb.Location = New System.Drawing.Point(340, 153)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(112, 22)
        Me.PriceTb.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ItemName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Price"
        '
        'BillBtn
        '
        Me.BillBtn.BackColor = System.Drawing.Color.Firebrick
        Me.BillBtn.ForeColor = System.Drawing.Color.White
        Me.BillBtn.Location = New System.Drawing.Point(48, 181)
        Me.BillBtn.Name = "BillBtn"
        Me.BillBtn.Size = New System.Drawing.Size(105, 37)
        Me.BillBtn.TabIndex = 28
        Me.BillBtn.Text = "Add to Bill"
        Me.BillBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.Firebrick
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(176, 181)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(105, 37)
        Me.ResetBtn.TabIndex = 29
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'PrintBtn
        '
        Me.PrintBtn.BackColor = System.Drawing.Color.Firebrick
        Me.PrintBtn.ForeColor = System.Drawing.Color.White
        Me.PrintBtn.Location = New System.Drawing.Point(300, 181)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(105, 37)
        Me.PrintBtn.TabIndex = 30
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = False
        '
        'BillDGV
        '
        Me.BillDGV.AllowUserToAddRows = False
        Me.BillDGV.AllowUserToDeleteRows = False
        Me.BillDGV.BackgroundColor = System.Drawing.Color.White
        Me.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDGV.ColumnHeadersVisible = False
        Me.BillDGV.GridColor = System.Drawing.Color.Maroon
        Me.BillDGV.Location = New System.Drawing.Point(12, 224)
        Me.BillDGV.Name = "BillDGV"
        Me.BillDGV.ReadOnly = True
        Me.BillDGV.RowHeadersWidth = 51
        Me.BillDGV.RowTemplate.Height = 24
        Me.BillDGV.Size = New System.Drawing.Size(436, 233)
        Me.BillDGV.TabIndex = 31
        '
        'SearchTb
        '
        Me.SearchTb.BackColor = System.Drawing.SystemColors.Window
        Me.SearchTb.Location = New System.Drawing.Point(583, 114)
        Me.SearchTb.Name = "SearchTb"
        Me.SearchTb.Size = New System.Drawing.Size(239, 22)
        Me.SearchTb.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(509, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Search"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Firebrick
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(639, 163)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(105, 37)
        Me.SearchBtn.TabIndex = 34
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Firebrick
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(375, 503)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(105, 37)
        Me.BtnLogout.TabIndex = 35
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'PdDGV
        '
        Me.PdDGV.AllowUserToAddRows = False
        Me.PdDGV.AllowUserToDeleteRows = False
        Me.PdDGV.BackgroundColor = System.Drawing.Color.White
        Me.PdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PdDGV.ColumnHeadersVisible = False
        Me.PdDGV.Location = New System.Drawing.Point(475, 224)
        Me.PdDGV.Name = "PdDGV"
        Me.PdDGV.ReadOnly = True
        Me.PdDGV.RowHeadersWidth = 51
        Me.PdDGV.RowTemplate.Height = 24
        Me.PdDGV.Size = New System.Drawing.Size(377, 233)
        Me.PdDGV.TabIndex = 36
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Client Name"
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(120, 114)
        Me.txtCName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(113, 22)
        Me.txtCName.TabIndex = 40
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 552)
        Me.Controls.Add(Me.txtCName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PdDGV)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SearchTb)
        Me.Controls.Add(Me.BillDGV)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.BillBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PriceTb)
        Me.Controls.Add(Me.QuantityTb)
        Me.Controls.Add(Me.ItNameTb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PdDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbExit As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ItNameTb As TextBox
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BillBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents SearchTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents PdDGV As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCName As TextBox
End Class
