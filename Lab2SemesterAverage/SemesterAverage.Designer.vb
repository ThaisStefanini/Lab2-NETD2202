<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
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
        Me.lbCourse1 = New System.Windows.Forms.Label()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.tbCourse1 = New System.Windows.Forms.TextBox()
        Me.tbCourse2 = New System.Windows.Forms.TextBox()
        Me.tbCourse3 = New System.Windows.Forms.TextBox()
        Me.tbCourse4 = New System.Windows.Forms.TextBox()
        Me.tbCourse5 = New System.Windows.Forms.TextBox()
        Me.tbCourse6 = New System.Windows.Forms.TextBox()
        Me.lbCourse1Letter = New System.Windows.Forms.Label()
        Me.lbCourse2Letter = New System.Windows.Forms.Label()
        Me.lbCourse3Letter = New System.Windows.Forms.Label()
        Me.lbCourse4Letter = New System.Windows.Forms.Label()
        Me.lbCourse5Letter = New System.Windows.Forms.Label()
        Me.lbCourse6Letter = New System.Windows.Forms.Label()
        Me.lbSemesterLabel = New System.Windows.Forms.Label()
        Me.lbSemesterAverage = New System.Windows.Forms.Label()
        Me.lbSemesterLetter = New System.Windows.Forms.Label()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.btCalculate = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbCourse1
        '
        Me.lbCourse1.Location = New System.Drawing.Point(17, 22)
        Me.lbCourse1.Name = "lbCourse1"
        Me.lbCourse1.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse1.TabIndex = 0
        Me.lbCourse1.Text = "Course 1"
        '
        'lbCourse2
        '
        Me.lbCourse2.Location = New System.Drawing.Point(17, 55)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse2.TabIndex = 3
        Me.lbCourse2.Text = "Course 2"
        '
        'lbCourse3
        '
        Me.lbCourse3.Location = New System.Drawing.Point(17, 88)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse3.TabIndex = 6
        Me.lbCourse3.Text = "Course 3"
        '
        'lbCourse4
        '
        Me.lbCourse4.Location = New System.Drawing.Point(17, 121)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse4.TabIndex = 9
        Me.lbCourse4.Text = "Course 4"
        '
        'lbCourse5
        '
        Me.lbCourse5.Location = New System.Drawing.Point(17, 154)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse5.TabIndex = 12
        Me.lbCourse5.Text = "Course 5"
        '
        'lbCourse6
        '
        Me.lbCourse6.Location = New System.Drawing.Point(17, 187)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse6.TabIndex = 15
        Me.lbCourse6.Text = "Course 6"
        '
        'tbCourse1
        '
        Me.tbCourse1.Location = New System.Drawing.Point(88, 19)
        Me.tbCourse1.Name = "tbCourse1"
        Me.tbCourse1.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse1.TabIndex = 1
        Me.tbCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse2
        '
        Me.tbCourse2.Location = New System.Drawing.Point(88, 52)
        Me.tbCourse2.Name = "tbCourse2"
        Me.tbCourse2.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse2.TabIndex = 4
        Me.tbCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse3
        '
        Me.tbCourse3.Location = New System.Drawing.Point(88, 85)
        Me.tbCourse3.Name = "tbCourse3"
        Me.tbCourse3.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse3.TabIndex = 7
        Me.tbCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse4
        '
        Me.tbCourse4.Location = New System.Drawing.Point(88, 118)
        Me.tbCourse4.Name = "tbCourse4"
        Me.tbCourse4.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse4.TabIndex = 10
        Me.tbCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse5
        '
        Me.tbCourse5.Location = New System.Drawing.Point(88, 151)
        Me.tbCourse5.Name = "tbCourse5"
        Me.tbCourse5.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse5.TabIndex = 13
        Me.tbCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourse6
        '
        Me.tbCourse6.Location = New System.Drawing.Point(88, 184)
        Me.tbCourse6.Name = "tbCourse6"
        Me.tbCourse6.Size = New System.Drawing.Size(100, 22)
        Me.tbCourse6.TabIndex = 16
        Me.tbCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbCourse1Letter
        '
        Me.lbCourse1Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse1Letter.Location = New System.Drawing.Point(213, 19)
        Me.lbCourse1Letter.Name = "lbCourse1Letter"
        Me.lbCourse1Letter.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse1Letter.TabIndex = 2
        Me.lbCourse1Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse2Letter
        '
        Me.lbCourse2Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse2Letter.Location = New System.Drawing.Point(213, 52)
        Me.lbCourse2Letter.Name = "lbCourse2Letter"
        Me.lbCourse2Letter.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse2Letter.TabIndex = 5
        Me.lbCourse2Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse3Letter
        '
        Me.lbCourse3Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse3Letter.Location = New System.Drawing.Point(213, 85)
        Me.lbCourse3Letter.Name = "lbCourse3Letter"
        Me.lbCourse3Letter.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse3Letter.TabIndex = 8
        Me.lbCourse3Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse4Letter
        '
        Me.lbCourse4Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse4Letter.Location = New System.Drawing.Point(213, 118)
        Me.lbCourse4Letter.Name = "lbCourse4Letter"
        Me.lbCourse4Letter.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse4Letter.TabIndex = 11
        Me.lbCourse4Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse5Letter
        '
        Me.lbCourse5Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse5Letter.Location = New System.Drawing.Point(213, 151)
        Me.lbCourse5Letter.Name = "lbCourse5Letter"
        Me.lbCourse5Letter.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse5Letter.TabIndex = 14
        Me.lbCourse5Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourse6Letter
        '
        Me.lbCourse6Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse6Letter.Location = New System.Drawing.Point(213, 187)
        Me.lbCourse6Letter.Name = "lbCourse6Letter"
        Me.lbCourse6Letter.Size = New System.Drawing.Size(100, 22)
        Me.lbCourse6Letter.TabIndex = 17
        Me.lbCourse6Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemesterLabel
        '
        Me.lbSemesterLabel.Location = New System.Drawing.Point(17, 220)
        Me.lbSemesterLabel.Name = "lbSemesterLabel"
        Me.lbSemesterLabel.Size = New System.Drawing.Size(100, 22)
        Me.lbSemesterLabel.TabIndex = 18
        Me.lbSemesterLabel.Text = "Semester"
        '
        'lbSemesterAverage
        '
        Me.lbSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterAverage.Location = New System.Drawing.Point(85, 220)
        Me.lbSemesterAverage.Name = "lbSemesterAverage"
        Me.lbSemesterAverage.Size = New System.Drawing.Size(100, 22)
        Me.lbSemesterAverage.TabIndex = 19
        Me.lbSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemesterLetter
        '
        Me.lbSemesterLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterLetter.Location = New System.Drawing.Point(213, 220)
        Me.lbSemesterLetter.Name = "lbSemesterLetter"
        Me.lbSemesterLetter.Size = New System.Drawing.Size(100, 22)
        Me.lbSemesterLetter.TabIndex = 20
        Me.lbSemesterLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbMessage
        '
        Me.lbMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMessage.Location = New System.Drawing.Point(20, 254)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(293, 229)
        Me.lbMessage.TabIndex = 21
        '
        'btCalculate
        '
        Me.btCalculate.Location = New System.Drawing.Point(20, 490)
        Me.btCalculate.Name = "btCalculate"
        Me.btCalculate.Size = New System.Drawing.Size(97, 23)
        Me.btCalculate.TabIndex = 22
        Me.btCalculate.Text = "&Calculate"
        Me.btCalculate.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btReset.Location = New System.Drawing.Point(140, 490)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(75, 23)
        Me.btReset.TabIndex = 23
        Me.btReset.Text = "&Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(238, 490)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(75, 23)
        Me.btExit.TabIndex = 24
        Me.btExit.Text = "&Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btReset
        Me.ClientSize = New System.Drawing.Size(335, 523)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btCalculate)
        Me.Controls.Add(Me.lbMessage)
        Me.Controls.Add(Me.lbSemesterLetter)
        Me.Controls.Add(Me.lbSemesterAverage)
        Me.Controls.Add(Me.lbSemesterLabel)
        Me.Controls.Add(Me.lbCourse6Letter)
        Me.Controls.Add(Me.lbCourse5Letter)
        Me.Controls.Add(Me.lbCourse4Letter)
        Me.Controls.Add(Me.lbCourse3Letter)
        Me.Controls.Add(Me.lbCourse2Letter)
        Me.Controls.Add(Me.lbCourse1Letter)
        Me.Controls.Add(Me.tbCourse6)
        Me.Controls.Add(Me.tbCourse5)
        Me.Controls.Add(Me.tbCourse4)
        Me.Controls.Add(Me.tbCourse3)
        Me.Controls.Add(Me.tbCourse2)
        Me.Controls.Add(Me.tbCourse1)
        Me.Controls.Add(Me.lbCourse6)
        Me.Controls.Add(Me.lbCourse5)
        Me.Controls.Add(Me.lbCourse4)
        Me.Controls.Add(Me.lbCourse3)
        Me.Controls.Add(Me.lbCourse2)
        Me.Controls.Add(Me.lbCourse1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCourse1 As Label
    Friend WithEvents lbCourse2 As Label
    Friend WithEvents lbCourse3 As Label
    Friend WithEvents lbCourse4 As Label
    Friend WithEvents lbCourse5 As Label
    Friend WithEvents lbCourse6 As Label
    Friend WithEvents tbCourse1 As TextBox
    Friend WithEvents tbCourse2 As TextBox
    Friend WithEvents tbCourse3 As TextBox
    Friend WithEvents tbCourse4 As TextBox
    Friend WithEvents tbCourse5 As TextBox
    Friend WithEvents tbCourse6 As TextBox
    Friend WithEvents lbCourse1Letter As Label
    Friend WithEvents lbCourse2Letter As Label
    Friend WithEvents lbCourse3Letter As Label
    Friend WithEvents lbCourse4Letter As Label
    Friend WithEvents lbCourse5Letter As Label
    Friend WithEvents lbCourse6Letter As Label
    Friend WithEvents lbSemesterLabel As Label
    Friend WithEvents lbSemesterAverage As Label
    Friend WithEvents lbSemesterLetter As Label
    Friend WithEvents lbMessage As Label
    Friend WithEvents btCalculate As Button
    Friend WithEvents btReset As Button
    Friend WithEvents btExit As Button
End Class
