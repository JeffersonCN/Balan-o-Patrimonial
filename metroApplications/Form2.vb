Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Form2
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'contas do DRE
        Form1.mov(65) = Form1.mov(58) - Form1.mov(59)
        Form1.mov(66) = Form1.mov(65) - Form1.mov(60)
        Form1.mov(67) = Form1.mov(34) + Form1.mov(35) + Form1.mov(36)
        Form1.mov(62) = Form1.mov(66) - Form1.mov(67) + Form1.mov(61)
        Form1.mov(54) = Form1.mov(62) - Form1.mov(63)

        'contas do balanço patrimonial
        Form1.mov(37) = Form1.mov(0) + Form1.mov(1) + Form1.mov(2)
        Form1.mov(38) = Form1.mov(3) + Form1.mov(4) + Form1.mov(5)
        Form1.mov(39) = Form1.mov(6) + Form1.mov(7)
        Form1.mov(40) = Form1.mov(8) + Form1.mov(9) + Form1.mov(10) + Form1.mov(11)
        Form1.mov(41) = Form1.mov(12) + Form1.mov(13)
        Form1.mov(42) = Form1.mov(14)
        Form1.mov(43) = Form1.mov(15) + Form1.mov(16) - Form1.mov(17)
        Form1.mov(44) = Form1.mov(18) + Form1.mov(19) - Form1.mov(20)
        Form1.mov(45) = Form1.mov(21) + Form1.mov(22) + Form1.mov(23)
        Form1.mov(46) = Form1.mov(24) + Form1.mov(25) + Form1.mov(26)
        Form1.mov(47) = Form1.mov(27) + Form1.mov(28)
        Form1.mov(48) = Form1.mov(29) + Form1.mov(30) + Form1.mov(31)
        Form1.mov(49) = Form1.mov(32) + Form1.mov(33) ' usar esse na linha do passivo não circulante também
        Form1.mov(55) = Form1.mov(53) + Form1.mov(54)

        Form1.mov(50) = Form1.mov(37) + Form1.mov(38) + Form1.mov(39) + Form1.mov(40)
        Form1.mov(51) = Form1.mov(41) + Form1.mov(42) + Form1.mov(43) + Form1.mov(44)
        Form1.mov(52) = Form1.mov(45) + Form1.mov(46) + Form1.mov(47) + Form1.mov(48)

        Form1.mov(56) = Form1.mov(50) + Form1.mov(51)
        Form1.mov(57) = Form1.mov(52) + Form1.mov(33) + Form1.mov(55)

        'cria instancia do Document
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
        'define um stream
        Dim arquivo As FileStream = New FileStream("C:\Users\Felipe\Desktop\Relatórios\Balanço Patrimonial.pdf", FileMode.Create)
        'define um pdfwriter
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, arquivo)

        doc.Open()

        'meta informações
        doc.AddCreator("Sistema Escriturário Contábil")
        doc.AddSubject("Demonstrativo do Balanço Patrimonial conforme as movimentações registradas")
        doc.AddTitle("Balanço Patrimonia")

        'definindo as fontes
        Dim titulo1 As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 24, Font.Underline, BaseColor.BLACK)
        Dim titulo2 As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, Font.Bold, BaseColor.BLACK)
        Dim titulo3 As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, Font.Italic, BaseColor.BLACK)

        Dim prgf1 As New Paragraph("Balanço Patrimonial - " & Now.Year.ToString(), titulo1)
        prgf1.Alignment = Element.ALIGN_CENTER
        doc.Add(prgf1)

        doc.Add(New Paragraph())
        doc.Add(New Paragraph())

        Dim prgf2 As New Paragraph("Ativo", titulo2)
        prgf2.Alignment = Element.ALIGN_CENTER
        doc.Add(prgf2)

        doc.Add(New Paragraph("   Ativo Circulante: " & FormatCurrency(Form1.mov(50)), titulo2))
        doc.Add(New Paragraph("      Disponível: " & FormatCurrency(Form1.mov(37)), titulo2))
        doc.Add(New Paragraph("           Caixa: " & FormatCurrency(Form1.mov(0)), titulo3))
        doc.Add(New Paragraph("           Banco: " & FormatCurrency(Form1.mov(1)), titulo3))
        doc.Add(New Paragraph("           Aplicações: " & FormatCurrency(Form1.mov(2)), titulo3))
        doc.Add(New Paragraph("      Contas a Receber: " & FormatCurrency(Form1.mov(38)), titulo2))
        doc.Add(New Paragraph("           Clientes: " & FormatCurrency(Form1.mov(3)), titulo3))
        doc.Add(New Paragraph("           Duplicatas a Receber: " & FormatCurrency(Form1.mov(4)), titulo3))
        doc.Add(New Paragraph("           Títulos a Receber: " & FormatCurrency(Form1.mov(5)), titulo3))
        doc.Add(New Paragraph("      Estoque: " & FormatCurrency(Form1.mov(39)), titulo2))
        doc.Add(New Paragraph("           Mercadorias: " & FormatCurrency(Form1.mov(6)), titulo3))
        doc.Add(New Paragraph("           Materiais de Consumo: " & FormatCurrency(Form1.mov(7)), titulo3))
        doc.Add(New Paragraph("      Impostos a Recuperar: " & FormatCurrency(Form1.mov(40)), titulo2))
        doc.Add(New Paragraph("           ICMS a Recuperar: " & FormatCurrency(Form1.mov(8)), titulo3))
        doc.Add(New Paragraph("           IPI a Recuperar: " & FormatCurrency(Form1.mov(9)), titulo3))
        doc.Add(New Paragraph("           PIS a Recuperar: " & FormatCurrency(Form1.mov(10)), titulo3))
        doc.Add(New Paragraph("           COFINS a Recuperar: " & FormatCurrency(Form1.mov(11)), titulo3))
        doc.Add(New Paragraph("   Ativo Não Circulante " & FormatCurrency(Form1.mov(51)), titulo2))
        doc.Add(New Paragraph("      Realizável a Longo Prazo: " & FormatCurrency(Form1.mov(41)), titulo2))
        doc.Add(New Paragraph("           Clientes: " & FormatCurrency(Form1.mov(12)), titulo3))
        doc.Add(New Paragraph("           Duplicatas a Receber: " & FormatCurrency(Form1.mov(13)), titulo3))
        doc.Add(New Paragraph("      Investimentos" & FormatCurrency(Form1.mov(42)), titulo2))
        doc.Add(New Paragraph("           Ações: " & FormatCurrency(Form1.mov(14)), titulo3))
        doc.Add(New Paragraph("      Imobilizado: " & FormatCurrency(Form1.mov(43)), titulo2))
        doc.Add(New Paragraph("           Imóvel: " & FormatCurrency(Form1.mov(15)), titulo3))
        doc.Add(New Paragraph("           Veículo: " & FormatCurrency(Form1.mov(16)), titulo3))
        doc.Add(New Paragraph("           (-)Depreciação Acumulada: " & FormatCurrency(Form1.mov(17)), titulo3))
        doc.Add(New Paragraph("      Intangível: " & FormatCurrency(Form1.mov(44)), titulo2))
        doc.Add(New Paragraph("           Software: " & FormatCurrency(Form1.mov(18)), titulo3))
        doc.Add(New Paragraph("           Marcas/Patentes: " & FormatCurrency(Form1.mov(19)), titulo3))
        doc.Add(New Paragraph("           (-)Amortização Acumulado: " & FormatCurrency(Form1.mov(20)), titulo3))

        Dim prgf4 As New Paragraph("RESULTADO DO ATIVO: " & Form1.mov(56), titulo2)
        prgf4.Alignment = Element.ALIGN_CENTER
        doc.Add(prgf4)

        doc.NewPage()

        doc.Add(prgf1)

        Dim prgf3 As New Paragraph("Passivo", titulo2)
        prgf3.Alignment = Element.ALIGN_CENTER
        doc.Add(prgf3)

        doc.Add(New Paragraph("   Passivo Circulante: " & FormatCurrency(Form1.mov(53)), titulo2))
        doc.Add(New Paragraph("      Exigibilidades: " & FormatCurrency(Form1.mov(45)), titulo2))
        doc.Add(New Paragraph("           Fornecedores: " & FormatCurrency(Form1.mov(21)), titulo3))
        doc.Add(New Paragraph("           Duplicatas a Pagar: " & FormatCurrency(Form1.mov(22)), titulo3))
        doc.Add(New Paragraph("           Títulos a Pagar: " & FormatCurrency(Form1.mov(23)), titulo3))
        doc.Add(New Paragraph("      Obrigações Trabalhistas" & FormatCurrency(Form1.mov(46)), titulo2))
        doc.Add(New Paragraph("           Salários a Pagar: " & FormatCurrency(Form1.mov(24)), titulo3))
        doc.Add(New Paragraph("           FGTS a Pagar: " & FormatCurrency(Form1.mov(25)), titulo3))
        doc.Add(New Paragraph("           INSS a Pagar: " & FormatCurrency(Form1.mov(26)), titulo3))
        doc.Add(New Paragraph("      Obrigações Fiscais: " & FormatCurrency(Form1.mov(47)), titulo2))
        doc.Add(New Paragraph("           ICMS a Recolher: " & FormatCurrency(Form1.mov(27)), titulo3))
        doc.Add(New Paragraph("           IRPJ/CSLL a Recolher: " & FormatCurrency(Form1.mov(28)), titulo3))
        doc.Add(New Paragraph("      Obrigações Administrativas: " & FormatCurrency(Form1.mov(48)), titulo2))
        doc.Add(New Paragraph("           Aluguel a Pagar: " & FormatCurrency(Form1.mov(29)), titulo3))
        doc.Add(New Paragraph("           Impostos a Pagar: " & FormatCurrency(Form1.mov(30)), titulo3))
        doc.Add(New Paragraph("           Energia Elétrica a Pagar: " & FormatCurrency(Form1.mov(31)), titulo3))
        doc.Add(New Paragraph("           COFINS a Recuperar: " & FormatCurrency(Form1.mov(11)), titulo3))
        doc.Add(New Paragraph("   Passivo Não Circulante: " & FormatCurrency(Form1.mov(49)), titulo2))
        doc.Add(New Paragraph("      Elegível a Longo Prazo: " & FormatCurrency(Form1.mov(49)), titulo2))
        doc.Add(New Paragraph("           Fornecedores: " & FormatCurrency(Form1.mov(32)), titulo3))
        doc.Add(New Paragraph("           Duplicatas a Pagar: " & FormatCurrency(Form1.mov(33)), titulo3))
        doc.Add(New Paragraph("   Patrimônio Líquido: " & FormatCurrency(Form1.mov(55)), titulo2))
        doc.Add(New Paragraph("      Capital Social: " & FormatCurrency(Form1.mov(53)), titulo3))
        doc.Add(New Paragraph("      Reserva de Lucro: " & FormatCurrency(Form1.mov(54)), titulo3))

        Dim prgf5 As New Paragraph("RESULTADO DO PASSIVO: " & FormatCurrency(Form1.mov(57)), titulo2)
        prgf5.Alignment = Element.ALIGN_CENTER
        doc.Add(prgf5)

        doc.Close()
        arquivo.Close()

        If chbDRE.Checked = True Then
            'cria instancia do Document
            Dim doc2 As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
            'define um stream
            Dim arquivo2 As FileStream = New FileStream("C:\Users\Felipe\Desktop\Relatórios\Demonstração de Resultado do Exercício.pdf", FileMode.Create)
            'define um pdfwriter
            Dim writer2 As PdfWriter = PdfWriter.GetInstance(doc2, arquivo2)

            doc2.Open()

            'meta informações
            doc2.AddCreator("Sistema Escriturário Contábil")
            doc2.AddSubject("Relatório de Lucro ou Prejuízo durante o exercício")
            doc2.AddTitle("Demonstração de Resultado do Exercício")

            Dim prgf6 As New Paragraph("Demonstração de Resultado do Exercício - " & Now.Year.ToString(), titulo1)
            prgf6.Alignment = Element.ALIGN_CENTER
            doc2.Add(prgf6)

            doc2.Add(New Paragraph("  "))
            doc2.Add(New Paragraph("Receita Operacional Bruta: " & FormatCurrency(Form1.mov(58)), titulo2))
            doc2.Add(New Paragraph("(-) Impostos (ICMS, IPI, PIS, COFINS): " & FormatCurrency(Form1.mov(59)), titulo2))
            doc2.Add(New Paragraph("= Receita Operacional Líquida: " & FormatCurrency(Form1.mov(65)), titulo2))
            doc2.Add(New Paragraph("(-) Custo de Mercadoria Vendida: " & FormatCurrency(Form1.mov(60)), titulo2))
            doc2.Add(New Paragraph("= Lucro Operacional Bruto: " & FormatCurrency(Form1.mov(66)), titulo2))
            doc2.Add(New Paragraph("(-) Despesas Operacionais: " & FormatCurrency(Form1.mov(67)), titulo2))
            doc2.Add(New Paragraph("      (-) Despesas Comerciais: " & FormatCurrency(Form1.mov(34)), titulo3))
            doc2.Add(New Paragraph("      (-) Despesas Administrativas: " & FormatCurrency(Form1.mov(35)), titulo3))
            doc2.Add(New Paragraph("      (-) Despesas Financeiras: " & FormatCurrency(Form1.mov(36)), titulo3))
            doc2.Add(New Paragraph("(+) Outras Receitas: " & FormatCurrency(Form1.mov(61)), titulo2))
            doc2.Add(New Paragraph("Lucro Líquido Antes do IR e CSLL: " & FormatCurrency(Form1.mov(62)), titulo2))
            doc2.Add(New Paragraph("(-) Provisão para IR e CSLL: " & FormatCurrency(Form1.mov(63)), titulo2))
            doc2.Add(New Paragraph("Lucro do Exercício: " & FormatCurrency(Form1.mov(54)), titulo2))

            Dim prgf7 As New Paragraph("LUCRO DO EXERCÍCIO: ", titulo2)
            prgf7.Alignment = Element.ALIGN_CENTER
            doc2.Add(prgf7)

            doc2.Close()
            arquivo.Close()
        End If

        Me.Hide()
    End Sub
End Class