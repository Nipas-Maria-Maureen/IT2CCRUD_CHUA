<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbodept = New System.Windows.Forms.ComboBox()
        Me.btndispaly = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.dgvinfo = New System.Windows.Forms.DataGridView()
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Department"
        '
        'Cbodept
        '
        Me.Cbodept.FormattingEnabled = True
        Me.Cbodept.Location = New System.Drawing.Point(155, 42)
        Me.Cbodept.Name = "Cbodept"
        Me.Cbodept.Size = New System.Drawing.Size(121, 21)
        Me.Cbodept.TabIndex = 1
        '
        'btndispaly
        '
        Me.btndispaly.Location = New System.Drawing.Point(515, 34)
        Me.btndispaly.Name = "btndispaly"
        Me.btndispaly.Size = New System.Drawing.Size(75, 23)
        Me.btndispaly.TabIndex = 2
        Me.btndispaly.Text = "Display"
        Me.btndispaly.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(182, 323)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 3
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'dgvinfo
        '
        Me.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinfo.Location = New System.Drawing.Point(30, 137)
        Me.dgvinfo.Name = "dgvinfo"
        Me.dgvinfo.Size = New System.Drawing.Size(741, 150)
        Me.dgvinfo.TabIndex = 4
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvinfo)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btndispaly)
        Me.Controls.Add(Me.Cbodept)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cbodept As ComboBox
    Friend WithEvents btndispaly As Button
    Friend WithEvents btnback As Button
    Friend WithEvents dgvinfo As DataGridView
End Class
