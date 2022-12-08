Public Class Form1
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Form2.Show()
        Form2.lblNegrito.Text = "Adicionar"
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        If lstNome.SelectedIndex <> -1 Then
            Form2.Show()
            Form2.lblNegrito.Text = "Atualizar"
        Else
            MsgBox("Selecione um aluno", vbCritical)
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click



        If lstNome.SelectedIndex <> -1 Then
            Form2.Show()
            Form2.lblNegrito.Text = "Remover"

            Form2.txtNome.Text = lstNome.SelectedItem
            Form2.txtNome.ReadOnly = True
            Form2.txtTurma.Text = lstTurma.Items(lstNome.SelectedIndex)
            Form2.txtTurma.ReadOnly = True
            Form2.txtNum.Text = lstNum.Items(lstNome.SelectedIndex)
            Form2.txtNum.ReadOnly = True

        Else
            MsgBox("Selecione um aluno", vbCritical)
        End If
    End Sub
End Class
