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
        Me.lblEven = New System.Windows.Forms.Label()
        Me.forLoopbtn = New System.Windows.Forms.Button()
        Me.posttestLoopUntilbtn = New System.Windows.Forms.Button()
        Me.posttestLoopWhilebtn = New System.Windows.Forms.Button()
        Me.pretestDoUntilbtn = New System.Windows.Forms.Button()
        Me.pretestDoWhilebtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.brnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.forLoopbtn)
        Me.GroupBox1.Controls.Add(Me.posttestLoopUntilbtn)
        Me.GroupBox1.Controls.Add(Me.posttestLoopWhilebtn)
        Me.GroupBox1.Controls.Add(Me.pretestDoUntilbtn)
        Me.GroupBox1.Controls.Add(Me.pretestDoWhilebtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 315)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 loop 2-20"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(17, 39)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(196, 259)
        Me.lblEven.TabIndex = 5
        '
        'forLoopbtn
        '
        Me.forLoopbtn.Location = New System.Drawing.Point(228, 204)
        Me.forLoopbtn.Name = "forLoopbtn"
        Me.forLoopbtn.Size = New System.Drawing.Size(138, 35)
        Me.forLoopbtn.TabIndex = 4
        Me.forLoopbtn.Text = "Pretest: For"
        Me.forLoopbtn.UseVisualStyleBackColor = True
        '
        'posttestLoopUntilbtn
        '
        Me.posttestLoopUntilbtn.Location = New System.Drawing.Point(228, 166)
        Me.posttestLoopUntilbtn.Name = "posttestLoopUntilbtn"
        Me.posttestLoopUntilbtn.Size = New System.Drawing.Size(138, 35)
        Me.posttestLoopUntilbtn.TabIndex = 3
        Me.posttestLoopUntilbtn.Text = "Posttest: Loop Until"
        Me.posttestLoopUntilbtn.UseVisualStyleBackColor = True
        '
        'posttestLoopWhilebtn
        '
        Me.posttestLoopWhilebtn.Location = New System.Drawing.Point(228, 126)
        Me.posttestLoopWhilebtn.Name = "posttestLoopWhilebtn"
        Me.posttestLoopWhilebtn.Size = New System.Drawing.Size(138, 35)
        Me.posttestLoopWhilebtn.TabIndex = 2
        Me.posttestLoopWhilebtn.Text = "Posttest: Loop While"
        Me.posttestLoopWhilebtn.UseVisualStyleBackColor = True
        '
        'pretestDoUntilbtn
        '
        Me.pretestDoUntilbtn.Location = New System.Drawing.Point(228, 80)
        Me.pretestDoUntilbtn.Name = "pretestDoUntilbtn"
        Me.pretestDoUntilbtn.Size = New System.Drawing.Size(138, 35)
        Me.pretestDoUntilbtn.TabIndex = 1
        Me.pretestDoUntilbtn.Text = "Pretest: Do Until"
        Me.pretestDoUntilbtn.UseVisualStyleBackColor = True
        '
        'pretestDoWhilebtn
        '
        Me.pretestDoWhilebtn.Location = New System.Drawing.Point(228, 39)
        Me.pretestDoWhilebtn.Name = "pretestDoWhilebtn"
        Me.pretestDoWhilebtn.Size = New System.Drawing.Size(138, 35)
        Me.pretestDoWhilebtn.TabIndex = 0
        Me.pretestDoWhilebtn.Text = "Pretest: Do While"
        Me.pretestDoWhilebtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.brnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Location = New System.Drawing.Point(507, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 348)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332-p348 #22 Addition"
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(285, 88)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(59, 38)
        Me.lblCount.TabIndex = 5
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(206, 88)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(59, 38)
        Me.lblAvg.TabIndex = 4
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(206, 254)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(138, 35)
        Me.btnSumForNext.TabIndex = 3
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'brnSumLoopUntil
        '
        Me.brnSumLoopUntil.Location = New System.Drawing.Point(206, 198)
        Me.brnSumLoopUntil.Name = "brnSumLoopUntil"
        Me.brnSumLoopUntil.Size = New System.Drawing.Size(138, 35)
        Me.brnSumLoopUntil.TabIndex = 2
        Me.brnSumLoopUntil.Text = "Sum, Loop Until"
        Me.brnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(206, 139)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(138, 35)
        Me.btnSumDoWhile.TabIndex = 1
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'txtList
        '
        Me.txtList.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtList.Location = New System.Drawing.Point(21, 86)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(154, 241)
        Me.txtList.TabIndex = 6
        Me.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(202, 48)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(63, 23)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "Average:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(281, 48)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 23)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Count:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 560)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "mxiong3a1 loops, sum, count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents forLoopbtn As Button
    Friend WithEvents posttestLoopUntilbtn As Button
    Friend WithEvents posttestLoopWhilebtn As Button
    Friend WithEvents pretestDoUntilbtn As Button
    Friend WithEvents pretestDoWhilebtn As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents brnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtList As TextBox
End Class
