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
        btnConvert = New Button()
        Label1 = New Label()
        convertResult = New Label()
        inpGrades = New TextBox()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(322, 233)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(150, 46)
        btnConvert.TabIndex = 0
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(213, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 32)
        Label1.TabIndex = 1
        Label1.Text = "Grade:"
        ' 
        ' convertResult
        ' 
        convertResult.AutoSize = True
        convertResult.Location = New Point(518, 163)
        convertResult.Name = "convertResult"
        convertResult.Size = New Size(78, 32)
        convertResult.TabIndex = 2
        convertResult.Text = "Result"
        ' 
        ' inpGrades
        ' 
        inpGrades.Location = New Point(301, 156)
        inpGrades.Name = "inpGrades"
        inpGrades.Size = New Size(200, 39)
        inpGrades.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(inpGrades)
        Controls.Add(convertResult)
        Controls.Add(Label1)
        Controls.Add(btnConvert)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents convertResult As Label
    Friend WithEvents inpGrades As TextBox

End Class
