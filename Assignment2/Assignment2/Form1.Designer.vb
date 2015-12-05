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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.red = New System.Windows.Forms.CheckBox()
        Me.blue = New System.Windows.Forms.CheckBox()
        Me.green = New System.Windows.Forms.CheckBox()
        Me.yellow = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sex"
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(81, 58)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 3
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(81, 90)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 4
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-4, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date of birth"
        '
        'dateOfBirth
        '
        Me.dateOfBirth.Location = New System.Drawing.Point(81, 128)
        Me.dateOfBirth.Name = "dateOfBirth"
        Me.dateOfBirth.Size = New System.Drawing.Size(200, 20)
        Me.dateOfBirth.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Colors"
        '
        'red
        '
        Me.red.AutoSize = True
        Me.red.Location = New System.Drawing.Point(81, 172)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(46, 17)
        Me.red.TabIndex = 8
        Me.red.Text = "Red"
        Me.red.UseVisualStyleBackColor = True
        '
        'blue
        '
        Me.blue.AutoSize = True
        Me.blue.Location = New System.Drawing.Point(168, 172)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(47, 17)
        Me.blue.TabIndex = 9
        Me.blue.Text = "Blue"
        Me.blue.UseVisualStyleBackColor = True
        '
        'green
        '
        Me.green.AutoSize = True
        Me.green.Location = New System.Drawing.Point(168, 204)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(55, 17)
        Me.green.TabIndex = 11
        Me.green.Text = "Green"
        Me.green.UseVisualStyleBackColor = True
        '
        'yellow
        '
        Me.yellow.AutoSize = True
        Me.yellow.Location = New System.Drawing.Point(81, 204)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(57, 17)
        Me.yellow.TabIndex = 12
        Me.yellow.Text = "Yellow"
        Me.yellow.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Generate "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Age"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.ComboBox1.Location = New System.Drawing.Point(354, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 390)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.yellow)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateOfBirth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.female)
        Me.Controls.Add(Me.male)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dateOfBirth As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents red As CheckBox
    Friend WithEvents blue As CheckBox
    Friend WithEvents green As CheckBox
    Friend WithEvents yellow As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
