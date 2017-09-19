Public Class CvNetworkDiagnostics
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim QAT As New QuickAccess
    Dim MachineInfo As New MachineInfo
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
    Private Sub CvNetworkDiagnostics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MachineInfo_Panel.BackgroundImage = My.Resources.Selected
        QAT_PANEL.BackgroundImage = Nothing
        Dim MachineInfo As New MachineInfo
        MachineInfo.TopLevel = False
        Me.MainPanel.Controls.Add(MachineInfo)
        MachineInfo.Show()
    End Sub

    Private Sub QAT_LBL_Click(sender As Object, e As EventArgs) Handles QAT_LBL.Click
        MachineInfo.Hide()


        QAT_PANEL.BackgroundImage = My.Resources.Selected
        MachineInfo_Panel.BackgroundImage = Nothing
        QAT.TopLevel = False
        Me.MainPanel.Controls.Clear()
        Me.MainPanel.Controls.Add(QAT)
        QAT.Show()


    End Sub
    Private Sub MachineInfo_LBL_Click(sender As Object, e As EventArgs) Handles MachineInfo_LBL.Click
        MachineInfo_Panel.BackgroundImage = My.Resources.Selected
        QAT_PANEL.BackgroundImage = Nothing

        MachineInfo.TopLevel = False
        Me.MainPanel.Controls.Clear()
        Me.MainPanel.Controls.Add(MachineInfo)

        MachineInfo.Show()
        QAT.Hide()
    End Sub





    Private Sub Drag_Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Drag_Panel.MouseDown

        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Drag_Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Drag_Panel.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Drag_Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles Drag_Panel.MouseUp
        drag = False
    End Sub

    Private Sub MachineInfo_Panel_Paint(sender As Object, e As PaintEventArgs) Handles MachineInfo_Panel.Paint

    End Sub


End Class
