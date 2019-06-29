<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCargarExcel = New System.Windows.Forms.Button()
        Me.dtgExcel = New System.Windows.Forms.DataGridView()
        CType(Me.dtgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargarExcel
        '
        Me.btnCargarExcel.Location = New System.Drawing.Point(377, 31)
        Me.btnCargarExcel.Name = "btnCargarExcel"
        Me.btnCargarExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnCargarExcel.TabIndex = 0
        Me.btnCargarExcel.Text = "Cargar Excel"
        Me.btnCargarExcel.UseVisualStyleBackColor = True
        '
        'dtgExcel
        '
        Me.dtgExcel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgExcel.Location = New System.Drawing.Point(12, 143)
        Me.dtgExcel.Name = "dtgExcel"
        Me.dtgExcel.Size = New System.Drawing.Size(813, 235)
        Me.dtgExcel.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 390)
        Me.Controls.Add(Me.dtgExcel)
        Me.Controls.Add(Me.btnCargarExcel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCargarExcel As System.Windows.Forms.Button
    Friend WithEvents dtgExcel As System.Windows.Forms.DataGridView
End Class
