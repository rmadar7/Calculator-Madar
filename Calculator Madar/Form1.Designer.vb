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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num1TextBox = New System.Windows.Forms.TextBox()
        Me.num2TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.modButton = New System.Windows.Forms.Button()
        Me.additionButton = New System.Windows.Forms.Button()
        Me.integerButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.multiButton = New System.Windows.Forms.Button()
        Me.subtractbutton = New System.Windows.Forms.Button()
        Me.divisionButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter Your First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please Enter Your Second Number"
        '
        'num1TextBox
        '
        Me.num1TextBox.Location = New System.Drawing.Point(190, 74)
        Me.num1TextBox.Name = "num1TextBox"
        Me.num1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.num1TextBox.TabIndex = 2
        '
        'num2TextBox
        '
        Me.num2TextBox.Location = New System.Drawing.Point(190, 153)
        Me.num2TextBox.Name = "num2TextBox"
        Me.num2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.num2TextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Answer"
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(251, 244)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(0, 13)
        Me.answerLabel.TabIndex = 5
        '
        'modButton
        '
        Me.modButton.Location = New System.Drawing.Point(382, 234)
        Me.modButton.Name = "modButton"
        Me.modButton.Size = New System.Drawing.Size(99, 23)
        Me.modButton.TabIndex = 6
        Me.modButton.Text = "Mod"
        Me.modButton.UseVisualStyleBackColor = True
        '
        'additionButton
        '
        Me.additionButton.Location = New System.Drawing.Point(382, 118)
        Me.additionButton.Name = "additionButton"
        Me.additionButton.Size = New System.Drawing.Size(99, 23)
        Me.additionButton.TabIndex = 7
        Me.additionButton.Text = "Addition"
        Me.additionButton.UseVisualStyleBackColor = True
        '
        'integerButton
        '
        Me.integerButton.Location = New System.Drawing.Point(382, 205)
        Me.integerButton.Name = "integerButton"
        Me.integerButton.Size = New System.Drawing.Size(99, 23)
        Me.integerButton.TabIndex = 8
        Me.integerButton.Text = "Integer Divison"
        Me.integerButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 301)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'multiButton
        '
        Me.multiButton.Location = New System.Drawing.Point(382, 176)
        Me.multiButton.Name = "multiButton"
        Me.multiButton.Size = New System.Drawing.Size(99, 23)
        Me.multiButton.TabIndex = 10
        Me.multiButton.Text = "Multiply"
        Me.multiButton.UseVisualStyleBackColor = True
        '
        'subtractbutton
        '
        Me.subtractbutton.Location = New System.Drawing.Point(382, 89)
        Me.subtractbutton.Name = "subtractbutton"
        Me.subtractbutton.Size = New System.Drawing.Size(99, 23)
        Me.subtractbutton.TabIndex = 11
        Me.subtractbutton.Text = "Subtract"
        Me.subtractbutton.UseVisualStyleBackColor = True
        '
        'divisionButton
        '
        Me.divisionButton.Location = New System.Drawing.Point(382, 147)
        Me.divisionButton.Name = "divisionButton"
        Me.divisionButton.Size = New System.Drawing.Size(99, 23)
        Me.divisionButton.TabIndex = 12
        Me.divisionButton.Text = "Division"
        Me.divisionButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 403)
        Me.Controls.Add(Me.divisionButton)
        Me.Controls.Add(Me.subtractbutton)
        Me.Controls.Add(Me.multiButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.integerButton)
        Me.Controls.Add(Me.additionButton)
        Me.Controls.Add(Me.modButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.num2TextBox)
        Me.Controls.Add(Me.num1TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents num1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents num2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents modButton As System.Windows.Forms.Button
    Friend WithEvents additionButton As System.Windows.Forms.Button
    Friend WithEvents integerButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents multiButton As System.Windows.Forms.Button
    Friend WithEvents subtractbutton As System.Windows.Forms.Button
    Friend WithEvents divisionButton As System.Windows.Forms.Button

End Class
