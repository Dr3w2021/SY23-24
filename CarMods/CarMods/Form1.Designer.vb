<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chkEngine = New System.Windows.Forms.CheckBox()
        Me.chkSuspension = New System.Windows.Forms.CheckBox()
        Me.chkExhaust = New System.Windows.Forms.CheckBox()
        Me.chkWheels = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkEngine
        '
        Me.chkEngine.AutoSize = True
        Me.chkEngine.Location = New System.Drawing.Point(45, 54)
        Me.chkEngine.Name = "chkEngine"
        Me.chkEngine.Size = New System.Drawing.Size(76, 24)
        Me.chkEngine.TabIndex = 0
        Me.chkEngine.Text = "Engine"
        Me.chkEngine.UseVisualStyleBackColor = True
        '
        'chkSuspension
        '
        Me.chkSuspension.AutoSize = True
        Me.chkSuspension.Location = New System.Drawing.Point(45, 103)
        Me.chkSuspension.Name = "chkSuspension"
        Me.chkSuspension.Size = New System.Drawing.Size(105, 24)
        Me.chkSuspension.TabIndex = 1
        Me.chkSuspension.Text = "Suspension"
        Me.chkSuspension.UseVisualStyleBackColor = True
        '
        'chkExhaust
        '
        Me.chkExhaust.AutoSize = True
        Me.chkExhaust.Location = New System.Drawing.Point(45, 152)
        Me.chkExhaust.Name = "chkExhaust"
        Me.chkExhaust.Size = New System.Drawing.Size(81, 24)
        Me.chkExhaust.TabIndex = 2
        Me.chkExhaust.Text = "Exhaust"
        Me.chkExhaust.UseVisualStyleBackColor = True
        '
        'chkWheels
        '
        Me.chkWheels.AutoSize = True
        Me.chkWheels.Location = New System.Drawing.Point(45, 201)
        Me.chkWheels.Name = "chkWheels"
        Me.chkWheels.Size = New System.Drawing.Size(79, 24)
        Me.chkWheels.TabIndex = 3
        Me.chkWheels.Text = "Wheels"
        Me.chkWheels.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(45, 244)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 29)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkWheels)
        Me.Controls.Add(Me.chkExhaust)
        Me.Controls.Add(Me.chkSuspension)
        Me.Controls.Add(Me.chkEngine)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkEngine As CheckBox
    Friend WithEvents chkSuspension As CheckBox
    Friend WithEvents chkExhaust As CheckBox
    Friend WithEvents chkWheels As CheckBox
    Friend WithEvents btnCalculate As Button
End Class
