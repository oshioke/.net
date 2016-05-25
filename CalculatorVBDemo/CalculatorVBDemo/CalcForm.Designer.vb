<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcForm
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
        Me.CalcTextBox = New System.Windows.Forms.TextBox()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.OneButton = New System.Windows.Forms.Button()
        Me.FourButton = New System.Windows.Forms.Button()
        Me.SevenButton = New System.Windows.Forms.Button()
        Me.EightButton = New System.Windows.Forms.Button()
        Me.NineButton = New System.Windows.Forms.Button()
        Me.FiveButton = New System.Windows.Forms.Button()
        Me.SixButton = New System.Windows.Forms.Button()
        Me.TwoButton = New System.Windows.Forms.Button()
        Me.ThreeButton = New System.Windows.Forms.Button()
        Me.DotButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.DivideButton = New System.Windows.Forms.Button()
        Me.MultiplicationButton = New System.Windows.Forms.Button()
        Me.EqualButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CalcTextBox
        '
        Me.CalcTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcTextBox.Location = New System.Drawing.Point(8, 25)
        Me.CalcTextBox.Name = "CalcTextBox"
        Me.CalcTextBox.Size = New System.Drawing.Size(343, 35)
        Me.CalcTextBox.TabIndex = 0
        Me.CalcTextBox.Text = "0"
        Me.CalcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ZeroButton
        '
        Me.ZeroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZeroButton.Location = New System.Drawing.Point(8, 248)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(60, 44)
        Me.ZeroButton.TabIndex = 1
        Me.ZeroButton.Text = "0"
        Me.ZeroButton.UseVisualStyleBackColor = True
        '
        'OneButton
        '
        Me.OneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneButton.Location = New System.Drawing.Point(8, 198)
        Me.OneButton.Name = "OneButton"
        Me.OneButton.Size = New System.Drawing.Size(60, 44)
        Me.OneButton.TabIndex = 1
        Me.OneButton.Text = "1"
        Me.OneButton.UseVisualStyleBackColor = True
        '
        'FourButton
        '
        Me.FourButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FourButton.Location = New System.Drawing.Point(8, 148)
        Me.FourButton.Name = "FourButton"
        Me.FourButton.Size = New System.Drawing.Size(60, 44)
        Me.FourButton.TabIndex = 1
        Me.FourButton.Text = "4"
        Me.FourButton.UseVisualStyleBackColor = True
        '
        'SevenButton
        '
        Me.SevenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenButton.Location = New System.Drawing.Point(8, 98)
        Me.SevenButton.Name = "SevenButton"
        Me.SevenButton.Size = New System.Drawing.Size(60, 44)
        Me.SevenButton.TabIndex = 1
        Me.SevenButton.Text = "7"
        Me.SevenButton.UseVisualStyleBackColor = True
        '
        'EightButton
        '
        Me.EightButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EightButton.Location = New System.Drawing.Point(74, 98)
        Me.EightButton.Name = "EightButton"
        Me.EightButton.Size = New System.Drawing.Size(60, 44)
        Me.EightButton.TabIndex = 1
        Me.EightButton.Text = "8"
        Me.EightButton.UseVisualStyleBackColor = True
        '
        'NineButton
        '
        Me.NineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NineButton.Location = New System.Drawing.Point(140, 98)
        Me.NineButton.Name = "NineButton"
        Me.NineButton.Size = New System.Drawing.Size(60, 44)
        Me.NineButton.TabIndex = 1
        Me.NineButton.Text = "9"
        Me.NineButton.UseVisualStyleBackColor = True
        '
        'FiveButton
        '
        Me.FiveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiveButton.Location = New System.Drawing.Point(74, 148)
        Me.FiveButton.Name = "FiveButton"
        Me.FiveButton.Size = New System.Drawing.Size(60, 44)
        Me.FiveButton.TabIndex = 1
        Me.FiveButton.Text = "5"
        Me.FiveButton.UseVisualStyleBackColor = True
        '
        'SixButton
        '
        Me.SixButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SixButton.Location = New System.Drawing.Point(140, 148)
        Me.SixButton.Name = "SixButton"
        Me.SixButton.Size = New System.Drawing.Size(60, 44)
        Me.SixButton.TabIndex = 1
        Me.SixButton.Text = "6"
        Me.SixButton.UseVisualStyleBackColor = True
        '
        'TwoButton
        '
        Me.TwoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwoButton.Location = New System.Drawing.Point(74, 198)
        Me.TwoButton.Name = "TwoButton"
        Me.TwoButton.Size = New System.Drawing.Size(60, 44)
        Me.TwoButton.TabIndex = 1
        Me.TwoButton.Text = "2"
        Me.TwoButton.UseVisualStyleBackColor = True
        '
        'ThreeButton
        '
        Me.ThreeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeButton.Location = New System.Drawing.Point(140, 198)
        Me.ThreeButton.Name = "ThreeButton"
        Me.ThreeButton.Size = New System.Drawing.Size(60, 44)
        Me.ThreeButton.TabIndex = 1
        Me.ThreeButton.Text = "3"
        Me.ThreeButton.UseVisualStyleBackColor = True
        '
        'DotButton
        '
        Me.DotButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DotButton.Location = New System.Drawing.Point(74, 247)
        Me.DotButton.Name = "DotButton"
        Me.DotButton.Size = New System.Drawing.Size(60, 44)
        Me.DotButton.TabIndex = 1
        Me.DotButton.Text = "."
        Me.DotButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(216, 98)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(135, 44)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "C"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'PlusButton
        '
        Me.PlusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusButton.Location = New System.Drawing.Point(291, 198)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(60, 44)
        Me.PlusButton.TabIndex = 1
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinusButton.Location = New System.Drawing.Point(216, 198)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(60, 44)
        Me.MinusButton.TabIndex = 1
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'DivideButton
        '
        Me.DivideButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivideButton.Location = New System.Drawing.Point(216, 248)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(60, 44)
        Me.DivideButton.TabIndex = 1
        Me.DivideButton.Text = "/"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'MultiplicationButton
        '
        Me.MultiplicationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplicationButton.Location = New System.Drawing.Point(291, 247)
        Me.MultiplicationButton.Name = "MultiplicationButton"
        Me.MultiplicationButton.Size = New System.Drawing.Size(60, 44)
        Me.MultiplicationButton.TabIndex = 1
        Me.MultiplicationButton.Text = "*"
        Me.MultiplicationButton.UseVisualStyleBackColor = True
        '
        'EqualButton
        '
        Me.EqualButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EqualButton.Location = New System.Drawing.Point(140, 248)
        Me.EqualButton.Name = "EqualButton"
        Me.EqualButton.Size = New System.Drawing.Size(60, 44)
        Me.EqualButton.TabIndex = 1
        Me.EqualButton.Text = "="
        Me.EqualButton.UseVisualStyleBackColor = True
        '
        'CalcForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(358, 336)
        Me.Controls.Add(Me.MultiplicationButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DivideButton)
        Me.Controls.Add(Me.ThreeButton)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.SixButton)
        Me.Controls.Add(Me.EqualButton)
        Me.Controls.Add(Me.DotButton)
        Me.Controls.Add(Me.TwoButton)
        Me.Controls.Add(Me.PlusButton)
        Me.Controls.Add(Me.FiveButton)
        Me.Controls.Add(Me.NineButton)
        Me.Controls.Add(Me.EightButton)
        Me.Controls.Add(Me.SevenButton)
        Me.Controls.Add(Me.FourButton)
        Me.Controls.Add(Me.OneButton)
        Me.Controls.Add(Me.ZeroButton)
        Me.Controls.Add(Me.CalcTextBox)
        Me.MaximizeBox = False
        Me.Name = "CalcForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator VB Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZeroButton As System.Windows.Forms.Button
    Friend WithEvents OneButton As System.Windows.Forms.Button
    Friend WithEvents FourButton As System.Windows.Forms.Button
    Friend WithEvents SevenButton As System.Windows.Forms.Button
    Friend WithEvents EightButton As System.Windows.Forms.Button
    Friend WithEvents NineButton As System.Windows.Forms.Button
    Friend WithEvents FiveButton As System.Windows.Forms.Button
    Friend WithEvents SixButton As System.Windows.Forms.Button
    Friend WithEvents TwoButton As System.Windows.Forms.Button
    Friend WithEvents ThreeButton As System.Windows.Forms.Button
    Friend WithEvents DotButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PlusButton As System.Windows.Forms.Button
    Friend WithEvents MinusButton As System.Windows.Forms.Button
    Friend WithEvents DivideButton As System.Windows.Forms.Button
    Friend WithEvents MultiplicationButton As System.Windows.Forms.Button
    Friend WithEvents EqualButton As System.Windows.Forms.Button

End Class
