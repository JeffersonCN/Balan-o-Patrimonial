Public Class Form1
    Public valor As Double
    Public desc, natConta As String
    Public mov(68) As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If ((cmbDescricao3.SelectedItem = "" And cmbDescricao3.Visible = True) Or (cmbDescricao2.SelectedItem = "" And cmbDescricao3.Visible = False)) Or ((rbCredito.Checked = False And rbDebito.Checked = False) And (rbCredito.Enabled = True And rbDebito.Checked = True)) Or txtValor.Text = "" Then
            MetroLabel3.Visible = True
        Else
            If cmbDescricao3.Visible = False Then
                desc = cmbDescricao2.SelectedItem
            Else
                desc = cmbDescricao3.SelectedItem
            End If
            valor = txtValor.Text
            If rbCredito.Checked = True And rbDebito.Checked = False Then
                natConta = "Crédito"
            ElseIf rbDebito.Checked = True And rbCredito.Checked = False Then
                natConta = "Débito"
            End If
            gdMovimentacao.Rows.Add(desc, FormatCurrency(valor), natConta)

            If (cmbDescricao1.SelectedItem = "Passivo/Patrimônio Líquido") Or (cmbDescricao1.SelectedItem = "Contas de Resultado" And cmbDescricao2.SelectedItem <> "Despesas Operacionais") Then
                mov(pegaCod(cmbDescricao2.SelectedItem, cmbDescricao1.SelectedItem)) = mov(pegaCod(cmbDescricao2.SelectedItem, cmbDescricao1.SelectedItem)) + valor
            Else
                mov(pegaCod(cmbDescricao3.SelectedItem, cmbDescricao2.SelectedItem)) = conta(pegaCod(cmbDescricao3.SelectedItem, cmbDescricao2.SelectedItem), valor, mov(pegaCod(cmbDescricao3.SelectedItem, cmbDescricao2.SelectedItem)), rbCredito.Checked)
            End If

            txtValor.Text = ""
            rbCredito.Checked = False
            rbDebito.Checked = False
            MetroLabel3.Visible = False
        End If
    End Sub
    Private Sub txtValor_KeyUp(sender As Object, e As EventArgs) Handles txtValor.KeyUp
        If Not IsNumeric(txtValor.Text) Then
            txtValor.Text = ""
        End If
    End Sub
    Private Sub cmbDescricao1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDescricao1.SelectionChangeCommitted
        cmbDescricao2.Visible = True
        If cmbDescricao1.SelectedItem = "Ativo/Circulante" Then
            cmbDescricao2.Items.Add("Disponível")
            cmbDescricao2.Items.Add("Contas a Receber")
            cmbDescricao2.Items.Add("Estoque")
            cmbDescricao2.Items.Add("Impostos a Recuperar")
        ElseIf cmbDescricao1.SelectedItem = "Ativo/Não Circulante" Then
            cmbDescricao2.Items.Add("Realizável a Longo Prazo")
            cmbDescricao2.Items.Add("Investimentos")
            cmbDescricao2.Items.Add("Imobilizado")
            cmbDescricao2.Items.Add("Intangível")
        ElseIf cmbDescricao1.SelectedItem = "Passivo/Circulante" Then
            cmbDescricao2.Items.Add("Exigibilidades")
            cmbDescricao2.Items.Add("Obrigações Trabalhistas")
            cmbDescricao2.Items.Add("Obrigações Fiscais")
            cmbDescricao2.Items.Add("Obrigações Administrativas")
        ElseIf cmbDescricao1.SelectedItem = "Passivo/Não Circulante" Then
            cmbDescricao2.Items.Add("Elegível a Longo Prazo")
        ElseIf cmbDescricao1.SelectedItem = "Passivo/Patrimônio Líquido" Then
            cmbDescricao2.Items.Add("Capital Social")
        ElseIf cmbDescricao1.SelectedItem = "Contas de Resultado" Then
            rbCredito.Enabled = False
            rbDebito.Enabled = False
            cmbDescricao2.Items.Add("Receita Operacional Bruta")
            cmbDescricao2.Items.Add("Impostos (ICMS, IPI, PIS, COFINS)")
            cmbDescricao2.Items.Add("Custo de Mercadoria Vendida")
            cmbDescricao2.Items.Add("Despesas Operacionais")
            cmbDescricao2.Items.Add("Outras Receitas")
            cmbDescricao2.Items.Add("Lucro Líquido Antes do IR e CSLL")
            cmbDescricao2.Items.Add("Provisão para IR e CSLL")
        End If
    End Sub
    Private Sub cmbDescricao1_GotFocus(sender As Object, e As EventArgs) Handles cmbDescricao1.GotFocus
        cmbDescricao2.Items.Clear()
        rbCredito.Enabled = True
        rbDebito.Enabled = True
        cmbDescricao2.Visible = False
        cmbDescricao3.Visible = False
    End Sub
    Private Sub cmbDescricao2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDescricao2.SelectionChangeCommitted
        cmbDescricao3.Visible = True
        If cmbDescricao2.SelectedItem = "Disponível" Then
            cmbDescricao3.Items.Add("Caixa")
            cmbDescricao3.Items.Add("Banco")
            cmbDescricao3.Items.Add("Aplicações")
        ElseIf cmbDescricao2.SelectedItem = "Estoque" Then
            cmbDescricao3.Items.Add("Mercadorias")
            cmbDescricao3.Items.Add("Material de Consumo")
        ElseIf cmbDescricao2.SelectedItem = "Contas a Receber" Then
            cmbDescricao3.Items.Add("Clientes")
            cmbDescricao3.Items.Add("Duplicatas a Receber")
            cmbDescricao3.Items.Add("Títulos a Receber")
        ElseIf cmbDescricao2.SelectedItem = "Impostos a Recuperar" Then
            cmbDescricao3.Items.Add("ICMS a Recuperar")
            cmbDescricao3.Items.Add("IPI a Recuperar")
            cmbDescricao3.Items.Add("PIS a Recuperar")
            cmbDescricao3.Items.Add("COFINS a Recuperar")
        ElseIf cmbDescricao2.SelectedItem = "Realizável a Longo Prazo" Then
            cmbDescricao3.Items.Add("Clientes")
            cmbDescricao3.Items.Add("Duplicatas a Receber")
        ElseIf cmbDescricao2.SelectedItem = "Investimentos" Then
            cmbDescricao3.Items.Add("Ações")
        ElseIf cmbDescricao2.SelectedItem = "Imobilizado" Then
            cmbDescricao3.Items.Add("Imóvel")
            cmbDescricao3.Items.Add("Veículos")
            cmbDescricao3.Items.Add("Depreciação Acumulada")
        ElseIf cmbDescricao2.SelectedItem = "Intangível" Then
            cmbDescricao3.Items.Add("Software")
            cmbDescricao3.Items.Add("Marcas/Patente")
            cmbDescricao3.Items.Add("Amortização Acumulada")
        ElseIf cmbDescricao2.SelectedItem = "Exigibilidades" Then
            cmbDescricao3.Items.Add("Fornecedores")
            cmbDescricao3.Items.Add("Duplicatas a Pagar")
            cmbDescricao3.Items.Add("Títulos a Pagar")
        ElseIf cmbDescricao2.SelectedItem = "Obrigações Trabalhistas" Then
            cmbDescricao3.Items.Add("Salários a Pagar")
            cmbDescricao3.Items.Add("FGTS a Pagar")
            cmbDescricao3.Items.Add("INSS a Pagar")
        ElseIf cmbDescricao2.SelectedItem = "Obrigações Fiscais" Then
            cmbDescricao3.Items.Add("ICMS a Recolher")
            cmbDescricao3.Items.Add("IRPJ/CSLL a Recolher")
        ElseIf cmbDescricao2.SelectedItem = "Obrigações Administrativas" Then
            cmbDescricao3.Items.Add("Aluguel a Pagar")
            cmbDescricao3.Items.Add("Impostos a Pagar")
            cmbDescricao3.Items.Add("Energia Elétrica a Pagar")
        ElseIf cmbDescricao2.SelectedItem = "Elegível a Longo Prazo" Then
            cmbDescricao3.Items.Add("Fornecedores")
            cmbDescricao3.Items.Add("Duplicatas a Pagar")
        ElseIf cmbDescricao2.SelectedItem = "Despesas Operacionais" Then
            cmbDescricao3.Items.Add("Despesas Comerciais")
            cmbDescricao3.Items.Add("Despesas Administrativas")
            cmbDescricao3.Items.Add("Despesas Financeiras")
        Else
            cmbDescricao3.Visible = False
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Form2.ShowDialog()
    End Sub

    Private Sub cmbDescricao3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDescricao3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\Felipe\Desktop\Relatórios"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmbDescricao2_GotFocus(sender As Object, e As EventArgs) Handles cmbDescricao2.GotFocus
        cmbDescricao3.Items.Clear()
        cmbDescricao3.Visible = False
    End Sub
End Class