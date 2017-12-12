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
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblValueCount = New System.Windows.Forms.Label()
        Me.lblRangeCount = New System.Windows.Forms.Label()
        Me.cboSearchValues = New System.Windows.Forms.ComboBox()
        Me.cboSearchRanges = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(238, 40)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(415, 164)
        Me.lblCommission.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(45, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Commission Values:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(45, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search for value:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(45, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Search for range:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(417, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Count:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(417, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Count:"
        '
        'lblValueCount
        '
        Me.lblValueCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValueCount.Location = New System.Drawing.Point(477, 237)
        Me.lblValueCount.Name = "lblValueCount"
        Me.lblValueCount.Size = New System.Drawing.Size(114, 24)
        Me.lblValueCount.TabIndex = 6
        '
        'lblRangeCount
        '
        Me.lblRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeCount.Location = New System.Drawing.Point(477, 378)
        Me.lblRangeCount.Name = "lblRangeCount"
        Me.lblRangeCount.Size = New System.Drawing.Size(114, 24)
        Me.lblRangeCount.TabIndex = 7
        '
        'cboSearchValues
        '
        Me.cboSearchValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchValues.FormattingEnabled = True
        Me.cboSearchValues.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboSearchValues.Location = New System.Drawing.Point(172, 235)
        Me.cboSearchValues.Name = "cboSearchValues"
        Me.cboSearchValues.Size = New System.Drawing.Size(121, 93)
        Me.cboSearchValues.TabIndex = 8
        '
        'cboSearchRanges
        '
        Me.cboSearchRanges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchRanges.FormattingEnabled = True
        Me.cboSearchRanges.Items.AddRange(New Object() {"0-200", "100-300", "700-800"})
        Me.cboSearchRanges.Location = New System.Drawing.Point(172, 379)
        Me.cboSearchRanges.Name = "cboSearchRanges"
        Me.cboSearchRanges.Size = New System.Drawing.Size(121, 93)
        Me.cboSearchRanges.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 574)
        Me.Controls.Add(Me.cboSearchRanges)
        Me.Controls.Add(Me.cboSearchValues)
        Me.Controls.Add(Me.lblRangeCount)
        Me.Controls.Add(Me.lblValueCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCommission)
        Me.Name = "Form1"
        Me.Text = "mxiong3e1 Arrays, function"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCommission As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblValueCount As Label
    Friend WithEvents lblRangeCount As Label
    Friend WithEvents cboSearchValues As ComboBox
    Friend WithEvents cboSearchRanges As ComboBox
End Class
