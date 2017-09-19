<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CvNetworkDiagnostics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CvNetworkDiagnostics))
        Me.QAT_PANEL = New System.Windows.Forms.Panel()
        Me.QAT_LBL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Drag_Panel = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MachineInfo_LBL = New System.Windows.Forms.Label()
        Me.MachineInfo_Panel = New System.Windows.Forms.Panel()
        Me.QAT_PANEL.SuspendLayout()
        Me.Drag_Panel.SuspendLayout()
        Me.MachineInfo_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'QAT_PANEL
        '
        Me.QAT_PANEL.BackColor = System.Drawing.Color.Transparent
        Me.QAT_PANEL.Controls.Add(Me.QAT_LBL)
        Me.QAT_PANEL.Location = New System.Drawing.Point(0, 178)
        Me.QAT_PANEL.Name = "QAT_PANEL"
        Me.QAT_PANEL.Size = New System.Drawing.Size(222, 100)
        Me.QAT_PANEL.TabIndex = 0
        '
        'QAT_LBL
        '
        Me.QAT_LBL.AutoSize = True
        Me.QAT_LBL.BackColor = System.Drawing.Color.Transparent
        Me.QAT_LBL.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QAT_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QAT_LBL.Location = New System.Drawing.Point(27, 36)
        Me.QAT_LBL.Name = "QAT_LBL"
        Me.QAT_LBL.Size = New System.Drawing.Size(164, 18)
        Me.QAT_LBL.TabIndex = 2
        Me.QAT_LBL.Text = "Quick Access Tools"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1129, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EXIT"
        '
        'Drag_Panel
        '
        Me.Drag_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Drag_Panel.Controls.Add(Me.Label2)
        Me.Drag_Panel.Location = New System.Drawing.Point(0, -1)
        Me.Drag_Panel.Name = "Drag_Panel"
        Me.Drag_Panel.Size = New System.Drawing.Size(1200, 78)
        Me.Drag_Panel.TabIndex = 3
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainPanel.Location = New System.Drawing.Point(223, 76)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(977, 777)
        Me.MainPanel.TabIndex = 6
        '
        'MachineInfo_LBL
        '
        Me.MachineInfo_LBL.AutoSize = True
        Me.MachineInfo_LBL.BackColor = System.Drawing.Color.Transparent
        Me.MachineInfo_LBL.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineInfo_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MachineInfo_LBL.Location = New System.Drawing.Point(27, 39)
        Me.MachineInfo_LBL.Name = "MachineInfo_LBL"
        Me.MachineInfo_LBL.Size = New System.Drawing.Size(176, 18)
        Me.MachineInfo_LBL.TabIndex = 2
        Me.MachineInfo_LBL.Text = "Machine Information"
        '
        'MachineInfo_Panel
        '
        Me.MachineInfo_Panel.BackColor = System.Drawing.Color.Transparent
        Me.MachineInfo_Panel.Controls.Add(Me.MachineInfo_LBL)
        Me.MachineInfo_Panel.Location = New System.Drawing.Point(0, 77)
        Me.MachineInfo_Panel.Name = "MachineInfo_Panel"
        Me.MachineInfo_Panel.Size = New System.Drawing.Size(222, 100)
        Me.MachineInfo_Panel.TabIndex = 7
        '
        'CvNetworkDiagnostics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 850)
        Me.Controls.Add(Me.MachineInfo_Panel)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Drag_Panel)
        Me.Controls.Add(Me.QAT_PANEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CvNetworkDiagnostics"
        Me.Text = "CvNetworkDiagnostics - Garabed Araboghlian"
        Me.QAT_PANEL.ResumeLayout(False)
        Me.QAT_PANEL.PerformLayout()
        Me.Drag_Panel.ResumeLayout(False)
        Me.Drag_Panel.PerformLayout()
        Me.MachineInfo_Panel.ResumeLayout(False)
        Me.MachineInfo_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QAT_PANEL As Panel
    Friend WithEvents QAT_LBL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Drag_Panel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents MachineInfo_LBL As Label
    Friend WithEvents MachineInfo_Panel As Panel
End Class
