<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionsForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnStopwatch = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatch = New TextBox()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 20)
        Label1.TabIndex = 3
        Label1.Text = "Anay Kedia, Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 4
        Label2.Text = "Name "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 5
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 6
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 7
        Label5.Text = "Github Link For Task 2"
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Location = New Point(68, 301)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(249, 42)
        btnStopwatch.TabIndex = 8
        btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStopwatch.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(397, 119)
        txtName.Name = "txtName"
        txtName.Size = New Size(327, 27)
        txtName.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(397, 164)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(327, 27)
        txtEmail.TabIndex = 10
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(397, 210)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(327, 27)
        txtPhone.TabIndex = 11
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(397, 256)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(327, 27)
        txtGithubLink.TabIndex = 12
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(397, 309)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(327, 27)
        txtStopwatch.TabIndex = 13
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(224, 380)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(314, 41)
        btnSubmit.TabIndex = 14
        btnSubmit.Text = "SUBMIT (CTRL +S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(630, 392)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(94, 29)
        btnHome.TabIndex = 15
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnHome)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnStopwatch)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateSubmissionsForm"
        Text = "CreateSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnHome As Button
End Class
