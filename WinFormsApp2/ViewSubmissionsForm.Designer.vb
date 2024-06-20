<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnHome = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(230, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 20)
        Label1.TabIndex = 4
        Label1.Text = "Anay Kedia, Slidely Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(86, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 5
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(86, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 6
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(86, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 7
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(86, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 8
        Label5.Text = "Github Link For Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(86, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 20)
        Label6.TabIndex = 9
        Label6.Text = "Stopwatch Time"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(345, 119)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(338, 27)
        txtName.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(345, 163)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(338, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(345, 210)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(338, 27)
        txtPhone.TabIndex = 12
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(345, 254)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(338, 27)
        txtGithubLink.TabIndex = 13
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(345, 296)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(338, 27)
        txtStopwatchTime.TabIndex = 14
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(123, 355)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(189, 29)
        btnPrevious.TabIndex = 15
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(350, 355)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(189, 29)
        btnNext.TabIndex = 16
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(589, 400)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(94, 29)
        btnHome.TabIndex = 17
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(123, 400)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 18
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(350, 400)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 19
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnHome)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
