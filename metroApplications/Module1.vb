Module Module1
    Public Function pegaCod(desc As String, desc1 As String) As Integer
        Dim cd As Integer
        Select Case desc
            Case "Caixa"
                cd = 0
            Case "Banco"
                cd = 1
            Case "Aplicações"
                cd = 2
            Case "Clientes"
                If desc1 = "Contas a Receber" Then
                    cd = 3
                ElseIf desc1 = "Realizável a Longo Prazo" Then
                    cd = 12
                End If
            Case "Duplicatas a Receber"
                If desc1 = "Contas a Receber" Then
                    cd = 4
                ElseIf desc1 = "Realizável a Longo Prazo" Then
                    cd = 13
                End If
            Case "Títulos a Receber"
                cd = 5
            Case "Mercadorias"
                cd = 6
            Case "Materiais de Consumo"
                cd = 7
            Case "ICMS a Recuperar"
                cd = 8
            Case "IPI a Recuperar"
                cd = 9
            Case "PIS a Recuperar"
                cd = 10
            Case "CONFINS a Recuperar"
                cd = 11
            Case "Ações"
                cd = 14
            Case "Imóvel"
                cd = 15
            Case "Veículo"
                cd = 16
            Case "Depreciação Acumulada"
                cd = 17
            Case "Sofware"
                cd = 18
            Case "Marcas/Patentes"
                cd = 19
            Case "Amortização Acumulada"
                cd = 20
            Case "Fornecedores"
                If desc1 = "Exigibilidades" Then
                    cd = 21
                ElseIf desc1 = "Elegível a Longo Prazo" Then
                    cd = 32
                End If
            Case "Duplicatas a Pagar"
                If desc1 = "Exigilidade" Then
                    cd = 22
                ElseIf desc1 = "Exi" Then
                    cd = 33
                End If
            Case "Tìtulos a Pagar"
                cd = 23
            Case "Salários a Pagar"
                cd = 24
            Case "FGTS a Pagar"
                cd = 25
            Case "INSS a Pagar"
                cd = 26
            Case "ICMS a Recolher"
                cd = 27
            Case "IRPJ/CSLL a Recolher"
                cd = 28
            Case "Aluguel a Pagar"
                cd = 29
            Case "Impostos a Pagar"
                cd = 30
            Case "Energia Elétrica a Pagar"
                cd = 31
            Case "Despesas Comerciais"
                cd = 34
            Case "Despesas Administrativas"
                cd = 35
            Case "Despesas Financeiras"
                cd = 36
            Case "Capital Social"
                cd = 53
            Case "Receita Operacional Bruta"
                cd = 58
            Case "Impostos (ICMS, IPI, PIS, COFINS)"
                cd = 59
            Case "Custo de Mercadoria Vendida"
                cd = 60
            Case "Outras Receitas"
                cd = 61
            Case "Lucro Líquido Antes do IR e CSLL"
                cd = 62
            Case "Provisão para IR e CSLL"
                cd = 63
        End Select
        Return cd
    End Function
    Function conta(cd As Integer, valor As Double, acumulado As Double, cdt As Boolean) As Double
        If cd < 21 Then
            If cdt = True Then
                acumulado = acumulado - valor
            Else
                acumulado = acumulado + valor
            End If
        ElseIf cd > 20 And cd < 33 Then
            If cdt = True Then
                acumulado = acumulado + valor
            Else
                acumulado = acumulado - valor
            End If
        End If
        Return acumulado
    End Function
End Module
