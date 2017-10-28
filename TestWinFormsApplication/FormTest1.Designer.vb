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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelFixedHeader = New System.Windows.Forms.Panel()
        Me.PanelFixedFooter = New System.Windows.Forms.Panel()
        Me.PanelFixedSide = New System.Windows.Forms.Panel()
        Me.PanelBody.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMsg
        '
        Me.LabelMsg.AutoSize = True
        Me.LabelMsg.Location = New System.Drawing.Point(3, 0)
        Me.LabelMsg.Name = "LabelMsg"
        Me.LabelMsg.Size = New System.Drawing.Size(62, 13)
        Me.LabelMsg.TabIndex = 0
        Me.LabelMsg.Text = "Message...."
        '
        'PanelBody
        '
        Me.PanelBody.AutoScroll = True
        Me.PanelBody.AutoSize = True
        Me.PanelBody.Controls.Add(Me.LabelMsg)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(3, 53)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(526, 56)
        Me.PanelBody.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBody, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelFixedHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelFixedFooter, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelFixedSide, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(632, 162)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PanelFixedHeader
        '
        Me.PanelFixedHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelFixedHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFixedHeader.Location = New System.Drawing.Point(3, 3)
        Me.PanelFixedHeader.Name = "PanelFixedHeader"
        Me.PanelFixedHeader.Size = New System.Drawing.Size(526, 44)
        Me.PanelFixedHeader.TabIndex = 2
        '
        'PanelFixedFooter
        '
        Me.PanelFixedFooter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableLayoutPanel1.SetColumnSpan(Me.PanelFixedFooter, 2)
        Me.PanelFixedFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFixedFooter.Location = New System.Drawing.Point(3, 115)
        Me.PanelFixedFooter.Name = "PanelFixedFooter"
        Me.PanelFixedFooter.Size = New System.Drawing.Size(626, 44)
        Me.PanelFixedFooter.TabIndex = 3
        '
        'PanelFixedSide
        '
        Me.PanelFixedSide.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelFixedSide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFixedSide.Location = New System.Drawing.Point(535, 3)
        Me.PanelFixedSide.Name = "PanelFixedSide"
        Me.TableLayoutPanel1.SetRowSpan(Me.PanelFixedSide, 2)
        Me.PanelFixedSide.Size = New System.Drawing.Size(94, 106)
        Me.PanelFixedSide.TabIndex = 4
        '
        'FormTest1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(632, 162)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(800, 400)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "FormTest1"
        Me.Text = "FormTest1"
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMsg As Label
    Friend WithEvents PanelBody As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelFixedHeader As Panel
    Friend WithEvents PanelFixedFooter As Panel
    Friend WithEvents PanelFixedSide As Panel
End Class
