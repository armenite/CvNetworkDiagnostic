Public Class QuickAccess
    Private Sub QuickAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_IPConfig_Click(sender As Object, e As EventArgs) Handles btn_IPConfig.Click
        Dim ip As String
        Dim h As System.Net.IPHostEntry = Nothing
        h = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        ip = h.AddressList.GetValue(1).ToString
        MsgBox(ip)

    End Sub
End Class