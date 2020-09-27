<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NonDatabaseForm
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
        Me.GenerateButton1 = New System.Windows.Forms.Button()
        Me.SequenceTextBox = New System.Windows.Forms.TextBox()
        Me.GenerateButton2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenerateButton1
        '
        Me.GenerateButton1.Location = New System.Drawing.Point(12, 12)
        Me.GenerateButton1.Name = "GenerateButton1"
        Me.GenerateButton1.Size = New System.Drawing.Size(75, 23)
        Me.GenerateButton1.TabIndex = 0
        Me.GenerateButton1.Text = "Generate 1"
        Me.GenerateButton1.UseVisualStyleBackColor = True
        '
        'SequenceTextBox
        '
        Me.SequenceTextBox.Location = New System.Drawing.Point(93, 12)
        Me.SequenceTextBox.Name = "SequenceTextBox"
        Me.SequenceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SequenceTextBox.TabIndex = 1
        Me.SequenceTextBox.Text = "AA0001"
        '
        'GenerateButton2
        '
        Me.GenerateButton2.Location = New System.Drawing.Point(12, 41)
        Me.GenerateButton2.Name = "GenerateButton2"
        Me.GenerateButton2.Size = New System.Drawing.Size(75, 23)
        Me.GenerateButton2.TabIndex = 2
        Me.GenerateButton2.Text = "Generate 2"
        Me.GenerateButton2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(277, 134)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Value"
        Me.Column2.HeaderText = "Value"
        Me.Column2.Name = "Column2"
        '
        'NonDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 240)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GenerateButton2)
        Me.Controls.Add(Me.SequenceTextBox)
        Me.Controls.Add(Me.GenerateButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NonDatabaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GenerateButton1 As Button
    Friend WithEvents SequenceTextBox As TextBox
    Friend WithEvents GenerateButton2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
