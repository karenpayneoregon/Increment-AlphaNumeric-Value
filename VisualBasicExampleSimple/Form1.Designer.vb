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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CurrentSequenceTextBox = New System.Windows.Forms.TextBox()
        Me.IncrementButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 17)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 108)
        Me.ListBox1.TabIndex = 0
        '
        'CurrentSequenceTextBox
        '
        Me.CurrentSequenceTextBox.BackColor = System.Drawing.Color.White
        Me.CurrentSequenceTextBox.Location = New System.Drawing.Point(176, 17)
        Me.CurrentSequenceTextBox.Name = "CurrentSequenceTextBox"
        Me.CurrentSequenceTextBox.ReadOnly = True
        Me.CurrentSequenceTextBox.Size = New System.Drawing.Size(149, 20)
        Me.CurrentSequenceTextBox.TabIndex = 1
        '
        'IncrementButton
        '
        Me.IncrementButton.Location = New System.Drawing.Point(176, 53)
        Me.IncrementButton.Name = "IncrementButton"
        Me.IncrementButton.Size = New System.Drawing.Size(149, 23)
        Me.IncrementButton.TabIndex = 2
        Me.IncrementButton.Text = "Increment"
        Me.IncrementButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 153)
        Me.Controls.Add(Me.IncrementButton)
        Me.Controls.Add(Me.CurrentSequenceTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CurrentSequenceTextBox As TextBox
    Friend WithEvents IncrementButton As Button
End Class
