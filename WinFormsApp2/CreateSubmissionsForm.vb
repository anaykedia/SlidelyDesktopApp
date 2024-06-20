Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text.Json

Public Class CreateSubmissionsForm
    Private stopwatch As Stopwatch = New Stopwatch()
    Private isStopwatchRunning As Boolean = False

    Private Sub SubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStopwatch.Text = "00:00:00"
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If Not isStopwatchRunning Then
            ' Start the stopwatch
            stopwatch.Start()
            Timer1.Start() ' Start the timer to update UI
            btnStopwatch.Text = "Pause"
            isStopwatchRunning = True
        Else
            ' Pause the stopwatch
            stopwatch.Stop()
            Timer1.Stop() ' Stop the timer
            btnStopwatch.Text = "Start"
            isStopwatchRunning = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the stopwatch display
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Prepare data for submission
        Dim name As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim github_link As String = txtGithubLink.Text.Trim() ' Updated variable name
        Dim stopwatch_time As String = txtStopwatch.Text ' Updated variable name

        ' Validate input (add validation logic as needed)

        ' Create submission object
        Dim submission As New Submission With {
            .Name = name,
            .Email = email,
            .Phone = phone,
            .Github_link = github_link, ' Updated property name
            .Stopwatch_time = stopwatch_time ' Updated property name
        }

        ' Submit to backend using /submit endpoint
        Dim isSuccess As Boolean = Await SubmitToBackendAsync(submission)

        If isSuccess Then
            MessageBox.Show("Submission successful!")
            ResetForm()
        Else
            MessageBox.Show("Failed to submit. Please try again.")
        End If
    End Sub

    Private Async Function SubmitToBackendAsync(submission As Submission) As Task(Of Boolean)
        Try
            Dim client As New HttpClient()
            Dim jsonContent As String = JsonSerializer.Serialize(submission)
            Dim content As New StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            response.EnsureSuccessStatusCode()

            Return True
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub ResetForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        txtStopwatch.Text = "00:00:00"
        stopwatch.Reset()
        btnStopwatch.Text = "Start"
        isStopwatchRunning = False
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            btnStopwatch.PerformClick()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim Home As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class
