<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblTurma = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lstNome = New System.Windows.Forms.ListBox()
        Me.lstTurma = New System.Windows.Forms.ListBox()
        Me.lstNum = New System.Windows.Forms.ListBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNome.Location = New System.Drawing.Point(29, 52)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(252, 23)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "NOME DO ALUNO"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTurma
        '
        Me.lblTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTurma.Location = New System.Drawing.Point(281, 52)
        Me.lblTurma.Name = "lblTurma"
        Me.lblTurma.Size = New System.Drawing.Size(148, 23)
        Me.lblTurma.TabIndex = 1
        Me.lblTurma.Text = "TURMA"
        Me.lblTurma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumero
        '
        Me.lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumero.Location = New System.Drawing.Point(429, 52)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(70, 23)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Nº"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstNome
        '
        Me.lstNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstNome.FormattingEnabled = True
        Me.lstNome.ItemHeight = 15
        Me.lstNome.Location = New System.Drawing.Point(29, 75)
        Me.lstNome.Name = "lstNome"
        Me.lstNome.Size = New System.Drawing.Size(252, 304)
        Me.lstNome.TabIndex = 3
        '
        'lstTurma
        '
        Me.lstTurma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstTurma.FormattingEnabled = True
        Me.lstTurma.ItemHeight = 15
        Me.lstTurma.Location = New System.Drawing.Point(281, 75)
        Me.lstTurma.Name = "lstTurma"
        Me.lstTurma.Size = New System.Drawing.Size(148, 304)
        Me.lstTurma.TabIndex = 4
        '
        'lstNum
        '
        Me.lstNum.FormattingEnabled = True
        Me.lstNum.ItemHeight = 15
        Me.lstNum.Location = New System.Drawing.Point(429, 75)
        Me.lstNum.Name = "lstNum"
        Me.lstNum.Size = New System.Drawing.Size(70, 304)
        Me.lstNum.TabIndex = 5
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(29, 403)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(128, 40)
        Me.btnAdicionar.TabIndex = 6
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(200, 403)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(128, 40)
        Me.btnAtualizar.TabIndex = 7
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(362, 403)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(128, 40)
        Me.btnRemover.TabIndex = 10
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(392, 469)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 42)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 542)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.lstNum)
        Me.Controls.Add(Me.lstTurma)
        Me.Controls.Add(Me.lstNome)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblTurma)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents lblTurma As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lstNome As ListBox
    Friend WithEvents lstTurma As ListBox
    Friend WithEvents lstNum As ListBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnFechar As Button
End Class
