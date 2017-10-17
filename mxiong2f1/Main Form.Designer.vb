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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtRooms = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblResortFee = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblRoomChg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radKing = New System.Windows.Forms.RadioButton()
        Me.radQueen = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radAtrium = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.chkParkingFee = New System.Windows.Forms.CheckBox()
        Me.lblParkingFee = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mxiong2f1.My.Resources.Resources.Tree
        Me.PictureBox1.Location = New System.Drawing.Point(13, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtChildren)
        Me.GroupBox1.Controls.Add(Me.txtAdults)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.txtRooms)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number Of"
        '
        'txtChildren
        '
        Me.txtChildren.Location = New System.Drawing.Point(193, 221)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(57, 22)
        Me.txtChildren.TabIndex = 7
        '
        'txtAdults
        '
        Me.txtAdults.Location = New System.Drawing.Point(22, 221)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(57, 22)
        Me.txtAdults.TabIndex = 5
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(193, 71)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(57, 22)
        Me.txtNights.TabIndex = 3
        '
        'txtRooms
        '
        Me.txtRooms.Location = New System.Drawing.Point(22, 71)
        Me.txtRooms.Name = "txtRooms"
        Me.txtRooms.Size = New System.Drawing.Size(57, 22)
        Me.txtRooms.TabIndex = 1
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(190, 177)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 17)
        Me.label4.TabIndex = 6
        Me.label4.Text = "&Children"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(19, 177)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(85, 17)
        Me.label3.TabIndex = 4
        Me.label3.Text = "&Adults (18+)"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(190, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 17)
        Me.label2.TabIndex = 2
        Me.label2.Text = "&Nights"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(19, 50)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "&Rooms"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblParkingFee)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.lblResortFee)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.lblRoomChg)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(448, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 280)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(107, 221)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(116, 29)
        Me.lblTotalDue.TabIndex = 7
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResortFee
        '
        Me.lblResortFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResortFee.Location = New System.Drawing.Point(107, 137)
        Me.lblResortFee.Name = "lblResortFee"
        Me.lblResortFee.Size = New System.Drawing.Size(116, 29)
        Me.lblResortFee.TabIndex = 5
        Me.lblResortFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(107, 92)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(116, 29)
        Me.lblTax.TabIndex = 3
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRoomChg
        '
        Me.lblRoomChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomChg.Location = New System.Drawing.Point(107, 49)
        Me.lblRoomChg.Name = "lblRoomChg"
        Me.lblRoomChg.Size = New System.Drawing.Size(116, 29)
        Me.lblRoomChg.TabIndex = 1
        Me.lblRoomChg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Due:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Resort Fee:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tax:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Room:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(126, 554)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 44)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Ca&lculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(319, 554)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 44)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radKing)
        Me.GroupBox3.Controls.Add(Me.radQueen)
        Me.GroupBox3.Location = New System.Drawing.Point(148, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 179)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type"
        '
        'radKing
        '
        Me.radKing.AutoSize = True
        Me.radKing.Location = New System.Drawing.Point(19, 80)
        Me.radKing.Name = "radKing"
        Me.radKing.Size = New System.Drawing.Size(86, 21)
        Me.radKing.TabIndex = 1
        Me.radKing.Text = "One &king"
        Me.radKing.UseVisualStyleBackColor = True
        '
        'radQueen
        '
        Me.radQueen.AutoSize = True
        Me.radQueen.Checked = True
        Me.radQueen.Location = New System.Drawing.Point(19, 22)
        Me.radQueen.Name = "radQueen"
        Me.radQueen.Size = New System.Drawing.Size(99, 21)
        Me.radQueen.TabIndex = 0
        Me.radQueen.TabStop = True
        Me.radQueen.Text = "Two &queen"
        Me.radQueen.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radAtrium)
        Me.GroupBox4.Controls.Add(Me.radStandard)
        Me.GroupBox4.Location = New System.Drawing.Point(471, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 179)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "View"
        '
        'radAtrium
        '
        Me.radAtrium.AutoSize = True
        Me.radAtrium.Location = New System.Drawing.Point(19, 80)
        Me.radAtrium.Name = "radAtrium"
        Me.radAtrium.Size = New System.Drawing.Size(69, 21)
        Me.radAtrium.TabIndex = 1
        Me.radAtrium.Text = "A&trium"
        Me.radAtrium.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(19, 22)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(87, 21)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "&Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'chkParkingFee
        '
        Me.chkParkingFee.AutoSize = True
        Me.chkParkingFee.Location = New System.Drawing.Point(787, 44)
        Me.chkParkingFee.Name = "chkParkingFee"
        Me.chkParkingFee.Size = New System.Drawing.Size(151, 21)
        Me.chkParkingFee.TabIndex = 5
        Me.chkParkingFee.Text = "Vehicle parking fee"
        Me.chkParkingFee.UseVisualStyleBackColor = True
        '
        'lblParkingFee
        '
        Me.lblParkingFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParkingFee.Location = New System.Drawing.Point(107, 177)
        Me.lblParkingFee.Name = "lblParkingFee"
        Me.lblParkingFee.Size = New System.Drawing.Size(116, 29)
        Me.lblParkingFee.TabIndex = 8
        Me.lblParkingFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Parking Fee:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 603)
        Me.Controls.Add(Me.chkParkingFee)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "mxiong2f1 Timerline Resort"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtChildren As TextBox
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents txtNights As TextBox
    Friend WithEvents txtRooms As TextBox
    Friend WithEvents lblRoomChg As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblResortFee As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radKing As RadioButton
    Friend WithEvents radQueen As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radAtrium As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents chkParkingFee As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblParkingFee As Label
End Class
