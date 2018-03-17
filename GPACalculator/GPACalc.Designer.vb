<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPACalc
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
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnGPA = New System.Windows.Forms.Button()
        Me.cmbbxGrade = New System.Windows.Forms.ComboBox()
        Me.txtbxGPA = New System.Windows.Forms.TextBox()
        Me.txtbxHours = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(41, 17)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(36, 13)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade"
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Location = New System.Drawing.Point(12, 44)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(65, 13)
        Me.lblCredits.TabIndex = 3
        Me.lblCredits.Text = "Credit Hours"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(48, 174)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(29, 13)
        Me.lblGPA.TabIndex = 4
        Me.lblGPA.Text = "GPA"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(112, 63)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(90, 47)
        Me.btnRecord.TabIndex = 5
        Me.btnRecord.Text = "Record this course"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnGPA
        '
        Me.btnGPA.Location = New System.Drawing.Point(112, 116)
        Me.btnGPA.Name = "btnGPA"
        Me.btnGPA.Size = New System.Drawing.Size(90, 49)
        Me.btnGPA.TabIndex = 6
        Me.btnGPA.Text = "Calculate GPA"
        Me.btnGPA.UseVisualStyleBackColor = True
        '
        'cmbbxGrade
        '
        Me.cmbbxGrade.FormattingEnabled = True
        Me.cmbbxGrade.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.cmbbxGrade.Location = New System.Drawing.Point(112, 9)
        Me.cmbbxGrade.Name = "cmbbxGrade"
        Me.cmbbxGrade.Size = New System.Drawing.Size(90, 21)
        Me.cmbbxGrade.TabIndex = 7
        '
        'txtbxGPA
        '
        Me.txtbxGPA.Location = New System.Drawing.Point(112, 171)
        Me.txtbxGPA.Name = "txtbxGPA"
        Me.txtbxGPA.ReadOnly = True
        Me.txtbxGPA.Size = New System.Drawing.Size(90, 20)
        Me.txtbxGPA.TabIndex = 8
        '
        'txtbxHours
        '
        Me.txtbxHours.Location = New System.Drawing.Point(112, 36)
        Me.txtbxHours.Name = "txtbxHours"
        Me.txtbxHours.Size = New System.Drawing.Size(90, 20)
        Me.txtbxHours.TabIndex = 9
        '
        'frmGPACalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 203)
        Me.Controls.Add(Me.txtbxHours)
        Me.Controls.Add(Me.txtbxGPA)
        Me.Controls.Add(Me.cmbbxGrade)
        Me.Controls.Add(Me.btnGPA)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.lblGrade)
        Me.Name = "frmGPACalc"
        Me.Text = "GPA Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblCredits As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnGPA As Button
    Friend WithEvents cmbbxGrade As ComboBox
    Friend WithEvents txtbxGPA As TextBox
    Friend WithEvents txtbxHours As TextBox
End Class
