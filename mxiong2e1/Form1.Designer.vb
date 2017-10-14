<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.btnCalcNotEql = New System.Windows.Forms.Button()
        Me.btnCalcEql = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCard)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Savannah (Y/N):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Shipping Charge:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calculate (And)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(468, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 51)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Calculate (Or)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipping.Location = New System.Drawing.Point(304, 61)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(123, 40)
        Me.lblShipping.TabIndex = 5
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(10, 61)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(100, 22)
        Me.txtOrder.TabIndex = 6
        Me.txtOrder.Text = "100"
        '
        'txtCard
        '
        Me.txtCard.Location = New System.Drawing.Point(149, 61)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(100, 22)
        Me.txtCard.TabIndex = 7
        Me.txtCard.Text = "Y"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.lblCommission)
        Me.GroupBox2.Controls.Add(Me.btnCalcNotEql)
        Me.GroupBox2.Controls.Add(Me.btnCalcEql)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(706, 166)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% Commission for sales > 25000 with codes A1, B2, C3"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(149, 61)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 22)
        Me.txtSales.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(10, 61)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 6
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(304, 61)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(123, 40)
        Me.lblCommission.TabIndex = 5
        '
        'btnCalcNotEql
        '
        Me.btnCalcNotEql.Location = New System.Drawing.Point(468, 79)
        Me.btnCalcNotEql.Name = "btnCalcNotEql"
        Me.btnCalcNotEql.Size = New System.Drawing.Size(110, 51)
        Me.btnCalcNotEql.TabIndex = 4
        Me.btnCalcNotEql.Text = "Calculate (<>)"
        Me.btnCalcNotEql.UseVisualStyleBackColor = True
        '
        'btnCalcEql
        '
        Me.btnCalcEql.Location = New System.Drawing.Point(468, 22)
        Me.btnCalcEql.Name = "btnCalcEql"
        Me.btnCalcEql.Size = New System.Drawing.Size(110, 51)
        Me.btnCalcEql.TabIndex = 3
        Me.btnCalcEql.Text = "Calculate (=)"
        Me.btnCalcEql.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Commission:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sales:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ID:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "mxiong2e1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCard As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblCommission As Label
    Friend WithEvents btnCalcNotEql As Button
    Friend WithEvents btnCalcEql As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
