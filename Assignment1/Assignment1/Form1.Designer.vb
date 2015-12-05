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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.subtract = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "num2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "result"
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(103, 21)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(76, 20)
        Me.num1.TabIndex = 3
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(103, 64)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(76, 20)
        Me.num2.TabIndex = 4
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(103, 98)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(76, 20)
        Me.result.TabIndex = 5
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(44, 167)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(28, 27)
        Me.add.TabIndex = 6
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'subtract
        '
        Me.subtract.Location = New System.Drawing.Point(103, 167)
        Me.subtract.Name = "subtract"
        Me.subtract.Size = New System.Drawing.Size(28, 27)
        Me.subtract.TabIndex = 7
        Me.subtract.Text = "-"
        Me.subtract.UseVisualStyleBackColor = True
        '
        'multiply
        '
        Me.multiply.Location = New System.Drawing.Point(166, 167)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(35, 27)
        Me.multiply.TabIndex = 8
        Me.multiply.Text = "*"
        Me.multiply.UseVisualStyleBackColor = True
        '
        'divide
        '
        Me.divide.Location = New System.Drawing.Point(239, 167)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(28, 27)
        Me.divide.TabIndex = 9
        Me.divide.Text = "/"
        Me.divide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 320)
        Me.Controls.Add(Me.divide)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.subtract)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents num1 As TextBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents result As TextBox
    Friend WithEvents add As Button
    Friend WithEvents subtract As Button
    Friend WithEvents multiply As Button
    Friend WithEvents divide As Button
End Class
