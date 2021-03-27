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
        Me.Ascending_Order = New System.Windows.Forms.Button()
        Me.Descending_Order = New System.Windows.Forms.Button()
        Me.File = New System.Windows.Forms.ListBox()
        Me.Sorted = New System.Windows.Forms.ListBox()
        Me.Read_n_Text = New System.Windows.Forms.Button()
        Me.Finish = New System.Windows.Forms.Button()
        Me.File_Content = New System.Windows.Forms.Label()
        Me.Output = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ascending_Order
        '
        Me.Ascending_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Ascending_Order.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ascending_Order.Location = New System.Drawing.Point(313, 166)
        Me.Ascending_Order.Name = "Ascending_Order"
        Me.Ascending_Order.Size = New System.Drawing.Size(168, 43)
        Me.Ascending_Order.TabIndex = 0
        Me.Ascending_Order.Text = "Ascending Order"
        Me.Ascending_Order.UseVisualStyleBackColor = False
        '
        'Descending_Order
        '
        Me.Descending_Order.BackColor = System.Drawing.Color.Thistle
        Me.Descending_Order.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descending_Order.Location = New System.Drawing.Point(313, 292)
        Me.Descending_Order.Name = "Descending_Order"
        Me.Descending_Order.Size = New System.Drawing.Size(168, 43)
        Me.Descending_Order.TabIndex = 1
        Me.Descending_Order.Text = "Descending Order"
        Me.Descending_Order.UseVisualStyleBackColor = False
        '
        'File
        '
        Me.File.BackColor = System.Drawing.SystemColors.Info
        Me.File.FormattingEnabled = True
        Me.File.ItemHeight = 16
        Me.File.Location = New System.Drawing.Point(12, 43)
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(269, 356)
        Me.File.TabIndex = 2
        '
        'Sorted
        '
        Me.Sorted.BackColor = System.Drawing.Color.Plum
        Me.Sorted.FormattingEnabled = True
        Me.Sorted.ItemHeight = 16
        Me.Sorted.Location = New System.Drawing.Point(511, 43)
        Me.Sorted.Name = "Sorted"
        Me.Sorted.Size = New System.Drawing.Size(277, 356)
        Me.Sorted.TabIndex = 3
        '
        'Read_n_Text
        '
        Me.Read_n_Text.BackColor = System.Drawing.Color.RoyalBlue
        Me.Read_n_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Read_n_Text.Location = New System.Drawing.Point(69, 405)
        Me.Read_n_Text.Name = "Read_n_Text"
        Me.Read_n_Text.Size = New System.Drawing.Size(132, 33)
        Me.Read_n_Text.TabIndex = 4
        Me.Read_n_Text.Text = "Read n Text"
        Me.Read_n_Text.UseVisualStyleBackColor = False
        '
        'Finish
        '
        Me.Finish.BackColor = System.Drawing.Color.Silver
        Me.Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finish.Location = New System.Drawing.Point(582, 405)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(127, 33)
        Me.Finish.TabIndex = 5
        Me.Finish.Text = "Exit"
        Me.Finish.UseVisualStyleBackColor = False
        '
        'File_Content
        '
        Me.File_Content.AutoSize = True
        Me.File_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_Content.Location = New System.Drawing.Point(12, 18)
        Me.File_Content.Name = "File_Content"
        Me.File_Content.Size = New System.Drawing.Size(111, 20)
        Me.File_Content.TabIndex = 6
        Me.File_Content.Text = "File Content"
        '
        'Output
        '
        Me.Output.AutoSize = True
        Me.Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(508, 18)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(126, 20)
        Me.Output.TabIndex = 7
        Me.Output.Text = "Sorted Output"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.File_Content)
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.Read_n_Text)
        Me.Controls.Add(Me.Sorted)
        Me.Controls.Add(Me.File)
        Me.Controls.Add(Me.Descending_Order)
        Me.Controls.Add(Me.Ascending_Order)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ascending_Order As Button
    Friend WithEvents Descending_Order As Button
    Friend WithEvents File As ListBox
    Friend WithEvents Sorted As ListBox
    Friend WithEvents Read_n_Text As Button
    Friend WithEvents Finish As Button
    Friend WithEvents File_Content As Label
    Friend WithEvents Output As Label
End Class
