Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class Webcam_Form
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap

    Dim parentsForm As Member_Registration_Form  ' Reference to the parent form

    ' Constructor
    Public Sub New(parent As Member_Registration_Form)
        InitializeComponent()
        parentsForm = parent
    End Sub

    Private Sub Webcam_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically start the camera on form load
        Dim cameras As New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If cameras.Count > 0 Then
            camera = New VideoCaptureDevice(cameras(0).MonikerString) ' Automatically select the first camera
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            camera.Start()
        Else
            MessageBox.Show("No camera found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            Dim bitmap As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            ptprofile.Image = bitmap
        Catch ex As Exception
            ' Just in case
        End Try
    End Sub

    ' When the capture button is clicked
    Private Sub btncapture_Click(sender As Object, e As EventArgs) Handles btncapture.Click
        If ptprofile.Image IsNot Nothing Then
            parentsForm.memberpic.Image = CType(ptprofile.Image.Clone(), Bitmap) ' Send the image back
        End If

        ' Stop the camera safely
        If camera IsNot Nothing AndAlso camera.IsRunning Then
            RemoveHandler camera.NewFrame, AddressOf Captured
            camera.SignalToStop()
            camera.WaitForStop()
        End If

        Me.Close() ' Close the webcam form
    End Sub

    ' When closing the form manually (control box)
    Private Sub Webcam_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If camera IsNot Nothing AndAlso camera.IsRunning Then
            RemoveHandler camera.NewFrame, AddressOf Captured
            camera.SignalToStop()
            camera.WaitForStop()
        End If
    End Sub
End Class
