
Public Class MachineInfo
    Private Sub MachineInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DECLARATIONS
        Dim Domain = System.DirectoryServices.ActiveDirectory.Domain.GetComputerDomain()

        'REGISTRY CV CHECK
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\CommVault Systems\Galaxy\Instance001", "sProductVersion", Nothing) Is Nothing Then
            Label13.Text = "No"
        End If

        ' COMPUTER NAME
        Label19.Text = My.Computer.Name

        ' DOMAIN NAME
        Label21.Text = Domain.Name

        ' OS TYPE
        Label22.Text = My.Computer.Info.OSFullName
    End Sub
End Class