<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTest1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelMsg = New System.Windows.Forms.Label()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.PanelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMsg
        '
        Me.LabelMsg.Location = New System.Drawing.Point(3, 0)
        Me.LabelMsg.Name = "LabelMsg"
        Me.LabelMsg.Size = New System.Drawing.Size(13, 13)
        Me.LabelMsg.TabIndex = 0
        Me.LabelMsg.Text = "Msg...."
        '
        'PanelBody
        '
        Me.PanelBody.AutoScroll = True
        Me.PanelBody.Controls.Add(Me.LabelMsg)
        Me.PanelBody.Location = New System.Drawing.Point(12, 26)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(116, 100)
        Me.PanelBody.TabIndex = 1
        '
        'FormTest1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(310, 164)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "FormTest1"
        Me.Text = "FormTest1"
        Me.PanelBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelMsg As Label
    Friend WithEvents PanelBody As Panel
End Class
