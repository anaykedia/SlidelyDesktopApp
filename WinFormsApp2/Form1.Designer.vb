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
        btnViewSub = New Button()
        btnCreateSub = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSub
        ' 
        btnViewSub.Location = New Point(57, 159)
        btnViewSub.Name = "btnViewSub"
        btnViewSub.Size = New Size(692, 78)
        btnViewSub.TabIndex = 0
        btnViewSub.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSub.UseVisualStyleBackColor = True
        ' 
        ' btnCreateSub
        ' 
        btnCreateSub.Location = New Point(57, 243)
        btnCreateSub.Name = "btnCreateSub"
        btnCreateSub.Size = New Size(692, 73)
        btnCreateSub.TabIndex = 1
        btnCreateSub.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateSub.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(238, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 20)
        Label1.TabIndex = 2
        Label1.Text = "Anay Kedia, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnCreateSub)
        Controls.Add(btnViewSub)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSub As Button
    Friend WithEvents btnCreateSub As Button
    Friend WithEvents Label1 As Label

End Class
