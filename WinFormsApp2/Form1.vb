Imports System.Net.Http
Imports System.Text.Json
Imports System.Threading.Tasks

Public Class Form1

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check server connection
        Dim isConnected As Boolean = Await CheckServerConnectionAsync()
        If Not isConnected Then
            MessageBox.Show("Unable to connect to the server. Please check your connection and try again.")
            Me.Close() ' Close the form if the server is not reachable
        End If
    End Sub

    Private Async Function CheckServerConnectionAsync() As Task(Of Boolean)
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/ping")
            response.EnsureSuccessStatusCode()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error checking server connection: " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub btnViewSub_Click(sender As Object, e As EventArgs) Handles btnViewSub.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreateSub_Click(sender As Object, e As EventArgs) Handles btnCreateSub.Click
        Dim createSubmissionsForm As New CreateSubmissionsForm()
        createSubmissionsForm.Show()
        Me.Hide()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSub.PerformClick()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.N) Then
            btnCreateSub.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


End Class
