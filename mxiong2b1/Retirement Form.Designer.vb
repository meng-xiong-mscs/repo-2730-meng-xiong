<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeRate = New System.Windows.Forms.TextBox()
        Me.txtEmployerRate = New System.Windows.Forms.TextBox()
        Me.lblEmployeeContrib = New System.Windows.Forms.Label()
        Me.lblEmployerContrib = New System.Windows.Forms.Label()
        Me.lblTotalContrib = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Gross weekly pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Employee contribution rate (decimal form):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employe&r contribution rate (decimal form):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee annual contribution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Employer annual contribution:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total annual contribution:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(372, 26)
        Me.txtGrossPay.Multiline = True
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(127, 23)
        Me.txtGrossPay.TabIndex = 6
        Me.txtGrossPay.Text = "1000"
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeeRate
        '
        Me.txtEmployeeRate.Location = New System.Drawing.Point(372, 70)
        Me.txtEmployeeRate.Multiline = True
        Me.txtEmployeeRate.Name = "txtEmployeeRate"
        Me.txtEmployeeRate.Size = New System.Drawing.Size(127, 23)
        Me.txtEmployeeRate.TabIndex = 7
        Me.txtEmployeeRate.Text = "0.05"
        Me.txtEmployeeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerRate
        '
        Me.txtEmployerRate.Location = New System.Drawing.Point(372, 118)
        Me.txtEmployerRate.Multiline = True
        Me.txtEmployerRate.Name = "txtEmployerRate"
        Me.txtEmployerRate.Size = New System.Drawing.Size(127, 23)
        Me.txtEmployerRate.TabIndex = 8
        Me.txtEmployerRate.Text = "0.07"
        Me.txtEmployerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmployeeContrib
        '
        Me.lblEmployeeContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeContrib.Location = New System.Drawing.Point(372, 201)
        Me.lblEmployeeContrib.Name = "lblEmployeeContrib"
        Me.lblEmployeeContrib.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployeeContrib.TabIndex = 9
        '
        'lblEmployerContrib
        '
        Me.lblEmployerContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerContrib.Location = New System.Drawing.Point(372, 255)
        Me.lblEmployerContrib.Name = "lblEmployerContrib"
        Me.lblEmployerContrib.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployerContrib.TabIndex = 10
        '
        'lblTotalContrib
        '
        Me.lblTotalContrib.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalContrib.Location = New System.Drawing.Point(372, 306)
        Me.lblTotalContrib.Name = "lblTotalContrib"
        Me.lblTotalContrib.Size = New System.Drawing.Size(127, 23)
        Me.lblTotalContrib.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(195, 361)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(123, 54)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 54)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 440)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalContrib)
        Me.Controls.Add(Me.lblEmployerContrib)
        Me.Controls.Add(Me.lblEmployeeContrib)
        Me.Controls.Add(Me.txtEmployerRate)
        Me.Controls.Add(Me.txtEmployeeRate)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtEmployeeRate As TextBox
    Friend WithEvents txtEmployerRate As TextBox
    Friend WithEvents lblEmployerContrib As Label
    Friend WithEvents lblTotalContrib As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployeeContrib As Label
End Class
