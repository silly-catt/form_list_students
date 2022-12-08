Public Class Form2


    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        Dim search As Integer

        If lblNegrito.Text = "Adicionar" Then
            If txtNome.Text = "" Then
                MsgBox("Preencha o nome do aluno", vbCritical)
            Else
                If txtTurma.Text = "" Then
                    MsgBox("Preencha a turma do aluno", vbCritical)
                Else
                    If txtNum.Text = "" Then
                        MsgBox("Preencha o número do aluno", vbCritical)
                    End If
                End If
            End If

            If txtNome.Text <> "" And txtNum.Text <> "" And txtTurma.Text <> "" Then
                Form1.lstNome.Items.Add(txtNome.Text)
                Form1.lstTurma.Items.Add(txtTurma.Text)
                Form1.lstNum.Items.Add(txtNum.Text)
            End If
        End If

        If lblNegrito.Text = "Atualizar" Then
            If txtNome.Text = "" Then
                MsgBox("Preencha o nome do aluno", vbCritical)
            Else
                If txtTurma.Text = "" Then
                    MsgBox("Preencha a turma do aluno", vbCritical)
                Else
                    If txtNum.Text = "" Then
                        MsgBox("Preencha o número do aluno", vbCritical)
                    End If
                End If
            End If

            If txtNome.Text <> "" And txtNum.Text <> "" And txtTurma.Text <> "" Then
                search = Form1.lstNome.Items.IndexOf(Form1.lstNome.SelectedItem)
                Form1.lstNome.Items(search) = (txtNome.Text)
                Form1.lstTurma.Items(search) = (txtTurma.Text)
                Form1.lstNum.Items(search) = (txtNum.Text)
            End If
        End If
        If lblNegrito.Text = "Remover" Then
            search = Form1.lstNome.Items.IndexOf(Form1.lstNome.SelectedItem)

            Form1.lstNome.Items.RemoveAt(search)
            Form1.lstTurma.Items.RemoveAt(search)
            Form1.lstNum.Items.RemoveAt(search)

        End If

    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Close()
    End Sub
End Class