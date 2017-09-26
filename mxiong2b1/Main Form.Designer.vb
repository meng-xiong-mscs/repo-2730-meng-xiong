<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Label0 = New System.Windows.Forms.Label()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRasp = New System.Windows.Forms.TextBox()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.lblProjBlue = New System.Windows.Forms.Label()
        Me.lblProjRasp = New System.Windows.Forms.Label()
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRetirementForm = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.Location = New System.Drawing.Point(242, 66)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(195, 28)
        Me.Label0.TabIndex = 10
        Me.Label0.Text = "Projected Increase %:"
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjIncrease.Location = New System.Drawing.Point(451, 73)
        Me.txtProjIncrease.Multiline = True
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(111, 30)
        Me.txtProjIncrease.TabIndex = 0
        Me.txtProjIncrease.Text = "0.05"
        Me.txtProjIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 28)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Current Sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(429, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Projected Sales"
        '
        'txtStraw
        '
        Me.txtStraw.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStraw.Location = New System.Drawing.Point(257, 203)
        Me.txtStraw.Multiline = True
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(128, 39)
        Me.txtStraw.TabIndex = 2
        Me.txtStraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(257, 254)
        Me.txtBlue.Multiline = True
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(128, 39)
        Me.txtBlue.TabIndex = 4
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRasp
        '
        Me.txtRasp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRasp.Location = New System.Drawing.Point(257, 305)
        Me.txtRasp.Multiline = True
        Me.txtRasp.Name = "txtRasp"
        Me.txtRasp.Size = New System.Drawing.Size(128, 39)
        Me.txtRasp.TabIndex = 6
        Me.txtRasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjStraw.Location = New System.Drawing.Point(437, 203)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(128, 39)
        Me.lblProjStraw.TabIndex = 14
        Me.lblProjStraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjBlue
        '
        Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjBlue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjBlue.Location = New System.Drawing.Point(437, 254)
        Me.lblProjBlue.Name = "lblProjBlue"
        Me.lblProjBlue.Size = New System.Drawing.Size(128, 39)
        Me.lblProjBlue.TabIndex = 15
        Me.lblProjBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjRasp
        '
        Me.lblProjRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjRasp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjRasp.Location = New System.Drawing.Point(437, 305)
        Me.lblProjRasp.Name = "lblProjRasp"
        Me.lblProjRasp.Size = New System.Drawing.Size(128, 39)
        Me.lblProjRasp.TabIndex = 16
        Me.lblProjRasp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraw.Location = New System.Drawing.Point(113, 208)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(123, 28)
        Me.lblStraw.TabIndex = 1
        Me.lblStraw.Text = "&Strawberries:"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(113, 259)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(112, 28)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "&Blueberries:"
        '
        'lblRasp
        '
        Me.lblRasp.AutoSize = True
        Me.lblRasp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRasp.Location = New System.Drawing.Point(114, 310)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(117, 28)
        Me.lblRasp.TabIndex = 5
        Me.lblRasp.Text = "&Raspberries:"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(127, 378)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(109, 42)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(247, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 42)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(487, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 42)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "(in decimal form)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mxiong1f1.My.Resources.Resources.berries
        Me.PictureBox1.Location = New System.Drawing.Point(25, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRetirementForm
        '
        Me.btnRetirementForm.Location = New System.Drawing.Point(368, 378)
        Me.btnRetirementForm.Name = "btnRetirementForm"
        Me.btnRetirementForm.Size = New System.Drawing.Size(109, 42)
        Me.btnRetirementForm.TabIndex = 17
        Me.btnRetirementForm.Text = "Retirement Form"
        Me.btnRetirementForm.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 464)
        Me.Controls.Add(Me.btnRetirementForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.lblProjRasp)
        Me.Controls.Add(Me.lblProjBlue)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.txtRasp)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label0 As Label
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRasp As TextBox
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents lblProjBlue As Label
    Friend WithEvents lblProjRasp As Label
    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRetirementForm As Button
End Class
