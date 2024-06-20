Imports System.Net.Http
Imports System.Text.Json
Imports System.Threading.Tasks

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private isEditMode As Boolean = False

    Private Sub EnableEditMode(enable As Boolean)
        txtName.ReadOnly = Not enable
        txtEmail.ReadOnly = Not enable
        txtPhone.ReadOnly = Not enable
        txtGithubLink.ReadOnly = Not enable
        txtStopwatchTime.ReadOnly = Not enable
    End Sub
    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not isEditMode Then
            ' Enter edit mode
            EnableEditMode(True)
            btnEdit.Text = "Submit Edit"
            isEditMode = True
        Else
            ' Submit edit
            Await SubmitEditAsync()
        End If
    End Sub

    Private Async Function SubmitEditAsync() As Task
        Try
            Dim editedSubmission As New Submission With {
            .name = txtName.Text.Trim(),
            .email = txtEmail.Text.Trim(),
            .phone = txtPhone.Text.Trim(),
            .github_link = txtGithubLink.Text.Trim(),
            .stopwatch_time = txtStopwatchTime.Text.Trim()
        }

            ' Send editedSubmission to backend /edit endpoint
            Dim isSuccess As Boolean = Await EditSubmissionAsync(editedSubmission, currentIndex)

            If isSuccess Then
                MessageBox.Show("Edit successful!")
                ' Exit edit mode
                EnableEditMode(False)
                btnEdit.Text = "Edit"
                isEditMode = False
                ' Refresh displayed submission
                Await FetchAndDisplaySubmissionAsync(currentIndex)
            Else
                MessageBox.Show("Failed to edit. Please try again.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Function

    Private Async Function EditSubmissionAsync(submission As Submission, index As Integer) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                Dim jsonContent As String = JsonSerializer.Serialize(New With {
                Key .name = submission.name,
                Key .email = submission.email,
                Key .phone = submission.phone,
                Key .github_link = submission.github_link,
                Key .stopwatch_time = submission.stopwatch_time,
                Key .index = index
            })
                Dim content As New StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/edit", content)
                response.EnsureSuccessStatusCode()

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error editing submission: " & ex.Message)
            Return False
        End Try
    End Function
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isConnected As Boolean = Await CheckConnectionAsync()
        If isConnected Then
            ' Fetch the first submission to initialize
            Await FetchAndDisplaySubmissionAsync(currentIndex)
        Else
            MessageBox.Show("Unable to connect to server.")
        End If
    End Sub

    Private Async Function CheckConnectionAsync() As Task(Of Boolean)
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/ping")
            Return response.IsSuccessStatusCode
        Catch ex As HttpRequestException
            Return False
        End Try
    End Function

    Private Async Function FetchSubmissionByIndexAsync(index As Integer) As Task(Of Submission)
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            response.EnsureSuccessStatusCode()
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Return JsonSerializer.Deserialize(Of Submission)(jsonResponse)
        Catch ex As HttpRequestException
            MessageBox.Show("Error fetching submission: " & ex.Message)
            Return Nothing
        Catch ex As JsonException
            MessageBox.Show("Error parsing JSON: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Async Function FetchAndDisplaySubmissionAsync(index As Integer) As Task
        Try
            Dim submission As Submission = Await FetchSubmissionByIndexAsync(index)
            If submission IsNot Nothing Then
                DisplaySubmission(submission)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.phone
        txtGithubLink.Text = submission.github_link
        txtStopwatchTime.Text = submission.stopwatch_time
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await FetchAndDisplaySubmissionAsync(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Fetch total submissions count from backend (you need to implement this)
        Dim totalSubmissions As Integer = Await FetchSubmissionCountAsync()

        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await FetchAndDisplaySubmissionAsync(currentIndex)
        End If
    End Sub

    Private Async Function FetchSubmissionCountAsync() As Task(Of Integer)
        ' Placeholder function to fetch the total number of submissions
        ' Adjust according to your backend implementation
        Return 10 ' Placeholder, replace with actual implementation
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim Home As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim isSuccess As Boolean = Await DeleteSubmissionAsync(currentIndex)

            If isSuccess Then
                MessageBox.Show("Submission deleted successfully!")
                ' Refresh the form or adjust accordingly
            Else
                MessageBox.Show("Failed to delete submission. Please try again.")
            End If
        End If
    End Sub

    Private Async Function DeleteSubmissionAsync(index As Integer) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                Dim response = Await client.DeleteAsync($"http://localhost:3000/delete/{index}")
                response.EnsureSuccessStatusCode()

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting submission: " & ex.Message)
            Return False
        End Try
    End Function
End Class
