<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNegrito = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblTurma = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTurma = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNegrito
        '
        Me.lblNegrito.AutoSize = True
        Me.lblNegrito.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNegrito.Location = New System.Drawing.Point(50, 40)
        Me.lblNegrito.Name = "lblNegrito"
        Me.lblNegrito.Size = New System.Drawing.Size(48, 17)
        Me.lblNegrito.TabIndex = 0
        Me.lblNegrito.Text = "Label1"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(50, 120)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(40, 15)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome"
        '
        'lblTurma
        '
        Me.lblTurma.AutoSize = True
        Me.lblTurma.Location = New System.Drawing.Point(50, 167)
        Me.lblTurma.Name = "lblTurma"
        Me.lblTurma.Size = New System.Drawing.Size(41, 15)
        Me.lblTurma.TabIndex = 2
        Me.lblTurma.Text = "Turma"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(50, 212)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(21, 15)
        Me.lblNum.TabIndex = 3
        Me.lblNum.Text = "Nº"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(129, 117)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(316, 23)
        Me.txtNome.TabIndex = 4
        '
        'txtTurma
        '
        Me.txtTurma.Location = New System.Drawing.Point(129, 164)
        Me.txtTurma.Name = "txtTurma"
        Me.txtTurma.Size = New System.Drawing.Size(131, 23)
        Me.txtTurma.TabIndex = 5
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(129, 209)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(54, 23)
        Me.txtNum.TabIndex = 6
        '
        'btnConfirma
        '
        Me.btnConfirma.Location = New System.Drawing.Point(50, 287)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(100, 32)
        Me.btnConfirma.TabIndex = 7
        Me.btnConfirma.Text = "Confirma"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.Location = New System.Drawing.Point(345, 287)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(100, 32)
        Me.btnCancela.TabIndex = 8
        Me.btnCancela.Text = "Cancela"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 353)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtTurma)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblTurma)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblNegrito)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNegrito As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblTurma As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtTurma As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnConfirma As Button
    Friend WithEvents btnCancela As Button
End Class
