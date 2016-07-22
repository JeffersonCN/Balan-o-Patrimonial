<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TCMenu = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnConfirmar = New MetroFramework.Controls.MetroButton()
        Me.btnFinalizar = New MetroFramework.Controls.MetroButton()
        Me.cmbDescricao2 = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDescricao1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.gdMovimentacao = New MetroFramework.Controls.MetroGrid()
        Me.ClmDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmNatConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbDebito = New MetroFramework.Controls.MetroRadioButton()
        Me.rbCredito = New MetroFramework.Controls.MetroRadioButton()
        Me.cmbDescricao3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtValor = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TCMenu.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.gdMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCMenu
        '
        Me.TCMenu.Controls.Add(Me.MetroTabPage1)
        Me.TCMenu.Controls.Add(Me.MetroTabPage2)
        Me.TCMenu.Location = New System.Drawing.Point(12, 63)
        Me.TCMenu.Name = "TCMenu"
        Me.TCMenu.SelectedIndex = 1
        Me.TCMenu.Size = New System.Drawing.Size(703, 595)
        Me.TCMenu.TabIndex = 0
        Me.TCMenu.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnConfirmar)
        Me.MetroTabPage1.Controls.Add(Me.btnFinalizar)
        Me.MetroTabPage1.Controls.Add(Me.cmbDescricao2)
        Me.MetroTabPage1.Controls.Add(Me.cmbDescricao1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.gdMovimentacao)
        Me.MetroTabPage1.Controls.Add(Me.rbDebito)
        Me.MetroTabPage1.Controls.Add(Me.rbCredito)
        Me.MetroTabPage1.Controls.Add(Me.cmbDescricao3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.txtValor)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(695, 553)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Contas"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(210, 500)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(125, 34)
        Me.btnConfirmar.TabIndex = 10
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseSelectable = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(357, 500)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(125, 34)
        Me.btnFinalizar.TabIndex = 14
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseSelectable = True
        '
        'cmbDescricao2
        '
        Me.cmbDescricao2.FormattingEnabled = True
        Me.cmbDescricao2.ItemHeight = 23
        Me.cmbDescricao2.Location = New System.Drawing.Point(7, 81)
        Me.cmbDescricao2.Name = "cmbDescricao2"
        Me.cmbDescricao2.Size = New System.Drawing.Size(232, 29)
        Me.cmbDescricao2.TabIndex = 17
        Me.cmbDescricao2.UseSelectable = True
        Me.cmbDescricao2.Visible = False
        '
        'cmbDescricao1
        '
        Me.cmbDescricao1.FormattingEnabled = True
        Me.cmbDescricao1.ItemHeight = 23
        Me.cmbDescricao1.Items.AddRange(New Object() {"Ativo/Circulante", "Ativo/Não Circulante", "Passivo/Circulante", "Passivo/Não Circulante", "Passivo/Patrimônio Líquido", "Contas de Resultado"})
        Me.cmbDescricao1.Location = New System.Drawing.Point(7, 33)
        Me.cmbDescricao1.Name = "cmbDescricao1"
        Me.cmbDescricao1.Size = New System.Drawing.Size(232, 29)
        Me.cmbDescricao1.TabIndex = 16
        Me.cmbDescricao1.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(316, 11)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(195, 19)
        Me.MetroLabel3.TabIndex = 15
        Me.MetroLabel3.Text = "Preenchimento Incompleto!"
        Me.MetroLabel3.Visible = False
        '
        'gdMovimentacao
        '
        Me.gdMovimentacao.AllowUserToResizeRows = False
        Me.gdMovimentacao.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdMovimentacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gdMovimentacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gdMovimentacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdMovimentacao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gdMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdMovimentacao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmDesc, Me.ClmValor, Me.ClmNatConta})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdMovimentacao.DefaultCellStyle = DataGridViewCellStyle2
        Me.gdMovimentacao.EnableHeadersVisualStyles = False
        Me.gdMovimentacao.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gdMovimentacao.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdMovimentacao.Location = New System.Drawing.Point(245, 33)
        Me.gdMovimentacao.Name = "gdMovimentacao"
        Me.gdMovimentacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdMovimentacao.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gdMovimentacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gdMovimentacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdMovimentacao.Size = New System.Drawing.Size(454, 437)
        Me.gdMovimentacao.TabIndex = 13
        '
        'ClmDesc
        '
        Me.ClmDesc.HeaderText = "Descrição"
        Me.ClmDesc.Name = "ClmDesc"
        Me.ClmDesc.ReadOnly = True
        '
        'ClmValor
        '
        Me.ClmValor.HeaderText = "Valor"
        Me.ClmValor.Name = "ClmValor"
        Me.ClmValor.ReadOnly = True
        '
        'ClmNatConta
        '
        Me.ClmNatConta.HeaderText = "Natureza da Conta"
        Me.ClmNatConta.Name = "ClmNatConta"
        Me.ClmNatConta.ReadOnly = True
        '
        'rbDebito
        '
        Me.rbDebito.AutoSize = True
        Me.rbDebito.Location = New System.Drawing.Point(7, 331)
        Me.rbDebito.Name = "rbDebito"
        Me.rbDebito.Size = New System.Drawing.Size(58, 15)
        Me.rbDebito.TabIndex = 12
        Me.rbDebito.Text = "Débito"
        Me.rbDebito.UseSelectable = True
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(7, 299)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(62, 15)
        Me.rbCredito.TabIndex = 1
        Me.rbCredito.Text = "Crédito"
        Me.rbCredito.UseSelectable = True
        '
        'cmbDescricao3
        '
        Me.cmbDescricao3.FormattingEnabled = True
        Me.cmbDescricao3.ItemHeight = 23
        Me.cmbDescricao3.Location = New System.Drawing.Point(7, 133)
        Me.cmbDescricao3.Name = "cmbDescricao3"
        Me.cmbDescricao3.Size = New System.Drawing.Size(232, 29)
        Me.cmbDescricao3.TabIndex = 1
        Me.cmbDescricao3.UseSelectable = True
        Me.cmbDescricao3.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(7, 229)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Valor (R$)"
        '
        'txtValor
        '
        '
        '
        '
        Me.txtValor.CustomButton.Image = Nothing
        Me.txtValor.CustomButton.Location = New System.Drawing.Point(170, 1)
        Me.txtValor.CustomButton.Name = ""
        Me.txtValor.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtValor.CustomButton.TabIndex = 1
        Me.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtValor.CustomButton.UseSelectable = True
        Me.txtValor.CustomButton.Visible = False
        Me.txtValor.Lines = New String(-1) {}
        Me.txtValor.Location = New System.Drawing.Point(7, 251)
        Me.txtValor.MaxLength = 32767
        Me.txtValor.Name = "txtValor"
        Me.txtValor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtValor.SelectedText = ""
        Me.txtValor.SelectionLength = 0
        Me.txtValor.SelectionStart = 0
        Me.txtValor.ShortcutsEnabled = True
        Me.txtValor.Size = New System.Drawing.Size(192, 23)
        Me.txtValor.TabIndex = 4
        Me.txtValor.UseSelectable = True
        Me.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtValor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(7, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(175, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Descrição da movimentação"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage2.Controls.Add(Me.AxAcroPDF1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(695, 553)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Relatórios"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(162, 59)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(408, 276)
        Me.AxAcroPDF1.TabIndex = 2
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(311, 363)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 674)
        Me.Controls.Add(Me.TCMenu)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sistema Escriturário Contábil"
        Me.TCMenu.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.gdMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCMenu As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtValor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnConfirmar As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbDescricao3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents rbDebito As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbCredito As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnFinalizar As MetroFramework.Controls.MetroButton
    Friend WithEvents gdMovimentacao As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbDescricao2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDescricao1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ClmDesc As DataGridViewTextBoxColumn
    Friend WithEvents ClmValor As DataGridViewTextBoxColumn
    Friend WithEvents ClmNatConta As DataGridViewTextBoxColumn
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
