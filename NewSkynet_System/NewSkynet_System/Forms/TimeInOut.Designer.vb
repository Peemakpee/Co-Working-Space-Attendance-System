<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeInOut
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeInOut))
        Me.txtboxEmpID = New System.Windows.Forms.TextBox()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTITO = New System.Windows.Forms.DataGridView()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvTITO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxEmpID
        '
        Me.txtboxEmpID.BackColor = System.Drawing.Color.Snow
        Me.txtboxEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxEmpID.Location = New System.Drawing.Point(232, 73)
        Me.txtboxEmpID.Multiline = True
        Me.txtboxEmpID.Name = "txtboxEmpID"
        Me.txtboxEmpID.Size = New System.Drawing.Size(550, 53)
        Me.txtboxEmpID.TabIndex = 0
        '
        'btnTimeInOut
        '
        Me.btnTimeInOut.BackColor = System.Drawing.Color.SeaShell
        Me.btnTimeInOut.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeInOut.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnTimeInOut.Location = New System.Drawing.Point(788, 73)
        Me.btnTimeInOut.Name = "btnTimeInOut"
        Me.btnTimeInOut.Size = New System.Drawing.Size(283, 53)
        Me.btnTimeInOut.TabIndex = 1
        Me.btnTimeInOut.Text = "Time In/Out"
        Me.btnTimeInOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(234, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Employee ID"
        '
        'dgvTITO
        '
        Me.dgvTITO.AllowUserToAddRows = False
        Me.dgvTITO.AllowUserToDeleteRows = False
        Me.dgvTITO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTITO.BackgroundColor = System.Drawing.Color.AntiqueWhite
        Me.dgvTITO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTITO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTITO.Location = New System.Drawing.Point(12, 135)
        Me.dgvTITO.Name = "dgvTITO"
        Me.dgvTITO.ReadOnly = True
        Me.dgvTITO.RowHeadersWidth = 51
        Me.dgvTITO.RowTemplate.Height = 24
        Me.dgvTITO.Size = New System.Drawing.Size(1059, 413)
        Me.dgvTITO.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.SeaShell
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblDate.Location = New System.Drawing.Point(908, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(163, 63)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Label2"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SeaShell
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnBack.Location = New System.Drawing.Point(12, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 32)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TimeInOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1083, 560)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dgvTITO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTimeInOut)
        Me.Controls.Add(Me.txtboxEmpID)
        Me.Name = "TimeInOut"
        Me.Text = "TimeInOut"
        CType(Me.dgvTITO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxEmpID As TextBox
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTITO As DataGridView
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnBack As Button
End Class
