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
        Me.btn_initial_allowance = New System.Windows.Forms.Button()
        Me.btn_make_transaction = New System.Windows.Forms.Button()
        Me.grd_transactions = New UJGrid.UJGrid()
        Me.initial_allowance_input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_initial_allowance
        '
        Me.btn_initial_allowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_initial_allowance.Location = New System.Drawing.Point(110, 24)
        Me.btn_initial_allowance.Name = "btn_initial_allowance"
        Me.btn_initial_allowance.Size = New System.Drawing.Size(286, 35)
        Me.btn_initial_allowance.TabIndex = 0
        Me.btn_initial_allowance.Text = "Initial Allowance"
        Me.btn_initial_allowance.UseVisualStyleBackColor = True
        '
        'btn_make_transaction
        '
        Me.btn_make_transaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_make_transaction.Location = New System.Drawing.Point(461, 24)
        Me.btn_make_transaction.Name = "btn_make_transaction"
        Me.btn_make_transaction.Size = New System.Drawing.Size(286, 41)
        Me.btn_make_transaction.TabIndex = 1
        Me.btn_make_transaction.Text = "Make Transaction"
        Me.btn_make_transaction.UseVisualStyleBackColor = True
        '
        'grd_transactions
        '
        Me.grd_transactions.Cols = 5
        Me.grd_transactions.FixedCols = 1
        Me.grd_transactions.FixedRows = 1
        Me.grd_transactions.Location = New System.Drawing.Point(62, 156)
        Me.grd_transactions.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_transactions.Name = "grd_transactions"
        Me.grd_transactions.Rows = 6
        Me.grd_transactions.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_transactions.Size = New System.Drawing.Size(702, 185)
        Me.grd_transactions.TabIndex = 2
        '
        'initial_allowance_input
        '
        Me.initial_allowance_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initial_allowance_input.Location = New System.Drawing.Point(461, 81)
        Me.initial_allowance_input.Name = "initial_allowance_input"
        Me.initial_allowance_input.Size = New System.Drawing.Size(273, 32)
        Me.initial_allowance_input.TabIndex = 3
        Me.initial_allowance_input.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Initial Allowance:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.initial_allowance_input)
        Me.Controls.Add(Me.grd_transactions)
        Me.Controls.Add(Me.btn_make_transaction)
        Me.Controls.Add(Me.btn_initial_allowance)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_initial_allowance As Button
    Friend WithEvents btn_make_transaction As Button
    Friend WithEvents grd_transactions As UJGrid.UJGrid
    Friend WithEvents initial_allowance_input As TextBox
    Friend WithEvents Label1 As Label
End Class
