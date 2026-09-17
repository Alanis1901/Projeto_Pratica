namespace Projeto_Pratica
{
    partial class frmCadastroContasAReceber
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNumDaNota = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblNumNota = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisarFormaPagamento = new System.Windows.Forms.Button();
            this.txtCodFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.lblDescontoReais = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblMultaReais = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblJurosReais = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtDescontoReais = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtMultaReais = new System.Windows.Forms.TextBox();
            this.txtJurosReais = new System.Windows.Forms.TextBox();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.txtNumParcela = new System.Windows.Forms.TextBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblNumParcela = new System.Windows.Forms.Label();
            this.lblMotivCancelamentoExplicacao = new System.Windows.Forms.Label();
            this.lblMotivoCancelamentoTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 619);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 640);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 663);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(890, 644);
            // 
            // lblCod
            // 
            this.lblCod.Location = new System.Drawing.Point(12, 20);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.Location = new System.Drawing.Point(1025, 13);
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 619);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 640);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 663);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 37);
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(983, 646);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(644, 36);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(105, 22);
            this.btnPesquisarCliente.TabIndex = 185;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(762, 37);
            this.dtpDataEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(115, 20);
            this.dtpDataEmissao.TabIndex = 186;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(895, 37);
            this.dtpDataVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(109, 20);
            this.dtpDataVencimento.TabIndex = 187;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(360, 38);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.ShortcutsEnabled = false;
            this.txtCodCliente.Size = new System.Drawing.Size(60, 20);
            this.txtCodCliente.TabIndex = 193;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(426, 37);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.ShortcutsEnabled = false;
            this.txtCliente.Size = new System.Drawing.Size(214, 20);
            this.txtCliente.TabIndex = 194;
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(891, 19);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(111, 13);
            this.lblDataVencimento.TabIndex = 190;
            this.lblDataVencimento.Text = "Data de Vencimento *";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(758, 19);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(94, 13);
            this.lblDataEmissao.TabIndex = 191;
            this.lblDataEmissao.Text = "Data de Emissão *";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(357, 17);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(46, 13);
            this.lblFornecedor.TabIndex = 192;
            this.lblFornecedor.Text = "Cliente *";
            // 
            // txtNumDaNota
            // 
            this.txtNumDaNota.Location = new System.Drawing.Point(211, 37);
            this.txtNumDaNota.Name = "txtNumDaNota";
            this.txtNumDaNota.ShortcutsEnabled = false;
            this.txtNumDaNota.Size = new System.Drawing.Size(129, 20);
            this.txtNumDaNota.TabIndex = 184;
            this.txtNumDaNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(143, 37);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ShortcutsEnabled = false;
            this.txtSerie.Size = new System.Drawing.Size(46, 20);
            this.txtSerie.TabIndex = 183;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumNota
            // 
            this.lblNumNota.AutoSize = true;
            this.lblNumNota.Location = new System.Drawing.Point(208, 19);
            this.lblNumNota.Name = "lblNumNota";
            this.lblNumNota.Size = new System.Drawing.Size(80, 13);
            this.lblNumNota.TabIndex = 188;
            this.lblNumNota.Text = "Núm. da Nota *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(140, 19);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 189;
            this.lblSerie.Text = "Série *";
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Checked = false;
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(418, 367);
            this.dtpDataPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.ShowCheckBox = true;
            this.dtpDataPagamento.Size = new System.Drawing.Size(135, 20);
            this.dtpDataPagamento.TabIndex = 210;
            // 
            // btnPesquisarFormaPagamento
            // 
            this.btnPesquisarFormaPagamento.Location = new System.Drawing.Point(299, 365);
            this.btnPesquisarFormaPagamento.Name = "btnPesquisarFormaPagamento";
            this.btnPesquisarFormaPagamento.Size = new System.Drawing.Size(104, 25);
            this.btnPesquisarFormaPagamento.TabIndex = 209;
            this.btnPesquisarFormaPagamento.Text = "Pesquisar";
            this.btnPesquisarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // txtCodFormaPagamento
            // 
            this.txtCodFormaPagamento.Location = new System.Drawing.Point(13, 368);
            this.txtCodFormaPagamento.Name = "txtCodFormaPagamento";
            this.txtCodFormaPagamento.ReadOnly = true;
            this.txtCodFormaPagamento.ShortcutsEnabled = false;
            this.txtCodFormaPagamento.Size = new System.Drawing.Size(60, 20);
            this.txtCodFormaPagamento.TabIndex = 223;
            this.txtCodFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(79, 367);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.ReadOnly = true;
            this.txtFormaPagamento.ShortcutsEnabled = false;
            this.txtFormaPagamento.Size = new System.Drawing.Size(214, 20);
            this.txtFormaPagamento.TabIndex = 224;
            // 
            // lblDescontoReais
            // 
            this.lblDescontoReais.AutoSize = true;
            this.lblDescontoReais.Location = new System.Drawing.Point(227, 251);
            this.lblDescontoReais.Name = "lblDescontoReais";
            this.lblDescontoReais.Size = new System.Drawing.Size(76, 13);
            this.lblDescontoReais.TabIndex = 217;
            this.lblDescontoReais.Text = "Desconto (R$)";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(227, 189);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 218;
            this.lblDesconto.Text = "Desconto (%)";
            // 
            // lblMultaReais
            // 
            this.lblMultaReais.AutoSize = true;
            this.lblMultaReais.Location = new System.Drawing.Point(10, 250);
            this.lblMultaReais.Name = "lblMultaReais";
            this.lblMultaReais.Size = new System.Drawing.Size(56, 13);
            this.lblMultaReais.TabIndex = 220;
            this.lblMultaReais.Text = "Multa (R$)";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(10, 188);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(50, 13);
            this.lblMulta.TabIndex = 219;
            this.lblMulta.Text = "Multa (%)";
            // 
            // lblJurosReais
            // 
            this.lblJurosReais.AutoSize = true;
            this.lblJurosReais.Location = new System.Drawing.Point(120, 250);
            this.lblJurosReais.Name = "lblJurosReais";
            this.lblJurosReais.Size = new System.Drawing.Size(55, 13);
            this.lblJurosReais.TabIndex = 221;
            this.lblJurosReais.Text = "Juros (R$)";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(120, 188);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(49, 13);
            this.lblJuros.TabIndex = 222;
            this.lblJuros.Text = "Juros (%)";
            // 
            // txtDescontoReais
            // 
            this.txtDescontoReais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescontoReais.Location = new System.Drawing.Point(230, 269);
            this.txtDescontoReais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescontoReais.Name = "txtDescontoReais";
            this.txtDescontoReais.ShortcutsEnabled = false;
            this.txtDescontoReais.Size = new System.Drawing.Size(82, 20);
            this.txtDescontoReais.TabIndex = 208;
            this.txtDescontoReais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(230, 207);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ShortcutsEnabled = false;
            this.txtDesconto.Size = new System.Drawing.Size(82, 20);
            this.txtDesconto.TabIndex = 205;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMultaReais
            // 
            this.txtMultaReais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMultaReais.Location = new System.Drawing.Point(13, 269);
            this.txtMultaReais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMultaReais.Name = "txtMultaReais";
            this.txtMultaReais.ShortcutsEnabled = false;
            this.txtMultaReais.Size = new System.Drawing.Size(82, 20);
            this.txtMultaReais.TabIndex = 206;
            this.txtMultaReais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJurosReais
            // 
            this.txtJurosReais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJurosReais.Location = new System.Drawing.Point(123, 269);
            this.txtJurosReais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJurosReais.Name = "txtJurosReais";
            this.txtJurosReais.ShortcutsEnabled = false;
            this.txtJurosReais.Size = new System.Drawing.Size(82, 20);
            this.txtJurosReais.TabIndex = 207;
            this.txtJurosReais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMulta
            // 
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.Location = new System.Drawing.Point(13, 207);
            this.txtMulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.ShortcutsEnabled = false;
            this.txtMulta.Size = new System.Drawing.Size(82, 20);
            this.txtMulta.TabIndex = 203;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJuros
            // 
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.Location = new System.Drawing.Point(123, 207);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ShortcutsEnabled = false;
            this.txtJuros.Size = new System.Drawing.Size(82, 20);
            this.txtJuros.TabIndex = 204;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(10, 349);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(115, 13);
            this.lblFormaPagamento.TabIndex = 216;
            this.lblFormaPagamento.Text = "Forma de Pagamento *";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(415, 349);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(109, 13);
            this.lblDataPagamento.TabIndex = 215;
            this.lblDataPagamento.Text = "Data do Pagamento *";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(12, 475);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.ReadOnly = true;
            this.txtValorPago.ShortcutsEnabled = false;
            this.txtValorPago.Size = new System.Drawing.Size(131, 20);
            this.txtValorPago.TabIndex = 214;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(123, 120);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.ShortcutsEnabled = false;
            this.txtValorParcela.Size = new System.Drawing.Size(189, 20);
            this.txtValorParcela.TabIndex = 202;
            this.txtValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.ForeColor = System.Drawing.Color.Black;
            this.lblValorFinal.Location = new System.Drawing.Point(10, 457);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(133, 13);
            this.lblValorFinal.TabIndex = 211;
            this.lblValorFinal.Text = "Valor Final da Parcela (R$)";
            // 
            // txtNumParcela
            // 
            this.txtNumParcela.Location = new System.Drawing.Point(13, 120);
            this.txtNumParcela.Name = "txtNumParcela";
            this.txtNumParcela.ShortcutsEnabled = false;
            this.txtNumParcela.Size = new System.Drawing.Size(83, 20);
            this.txtNumParcela.TabIndex = 201;
            this.txtNumParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(120, 102);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(115, 13);
            this.lblValorParcela.TabIndex = 213;
            this.lblValorParcela.Text = "Valor da Parcela (R$) *";
            // 
            // lblNumParcela
            // 
            this.lblNumParcela.AutoSize = true;
            this.lblNumParcela.Location = new System.Drawing.Point(10, 102);
            this.lblNumParcela.Name = "lblNumParcela";
            this.lblNumParcela.Size = new System.Drawing.Size(93, 13);
            this.lblNumParcela.TabIndex = 212;
            this.lblNumParcela.Text = "Núm. da Parcela *";
            // 
            // lblMotivCancelamentoExplicacao
            // 
            this.lblMotivCancelamentoExplicacao.AutoSize = true;
            this.lblMotivCancelamentoExplicacao.Location = new System.Drawing.Point(425, 645);
            this.lblMotivCancelamentoExplicacao.Name = "lblMotivCancelamentoExplicacao";
            this.lblMotivCancelamentoExplicacao.Size = new System.Drawing.Size(109, 13);
            this.lblMotivCancelamentoExplicacao.TabIndex = 225;
            this.lblMotivCancelamentoExplicacao.Text = "Explicação do Motivo";
            this.lblMotivCancelamentoExplicacao.Visible = false;
            // 
            // lblMotivoCancelamentoTitulo
            // 
            this.lblMotivoCancelamentoTitulo.AutoSize = true;
            this.lblMotivoCancelamentoTitulo.Location = new System.Drawing.Point(424, 626);
            this.lblMotivoCancelamentoTitulo.Name = "lblMotivoCancelamentoTitulo";
            this.lblMotivoCancelamentoTitulo.Size = new System.Drawing.Size(125, 13);
            this.lblMotivoCancelamentoTitulo.TabIndex = 226;
            this.lblMotivoCancelamentoTitulo.Text = "Motivo de Cancelamento";
            this.lblMotivoCancelamentoTitulo.Visible = false;
            // 
            // frmCadastroContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1083, 689);
            this.Controls.Add(this.lblMotivCancelamentoExplicacao);
            this.Controls.Add(this.lblMotivoCancelamentoTitulo);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.btnPesquisarFormaPagamento);
            this.Controls.Add(this.txtCodFormaPagamento);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.lblDescontoReais);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMultaReais);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJurosReais);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtDescontoReais);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtMultaReais);
            this.Controls.Add(this.txtJurosReais);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.txtNumParcela);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblNumParcela);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.dtpDataEmissao);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtNumDaNota);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblNumNota);
            this.Controls.Add(this.lblSerie);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroContasAReceber";
            this.Text = "Cadastro de Contas a Receber";
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltimaEdicao, 0);
            this.Controls.SetChildIndex(this.lblUltimoUsuarioQueEditou, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.checkBoxAtivo, 0);
            this.Controls.SetChildIndex(this.lblDataCadastroData, 0);
            this.Controls.SetChildIndex(this.lblDataUltimaEdicaoData, 0);
            this.Controls.SetChildIndex(this.lblUltimoUsuarioQueEditouNome, 0);
            this.Controls.SetChildIndex(this.lblSerie, 0);
            this.Controls.SetChildIndex(this.lblNumNota, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.txtNumDaNota, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblDataVencimento, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.dtpDataVencimento, 0);
            this.Controls.SetChildIndex(this.dtpDataEmissao, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCliente, 0);
            this.Controls.SetChildIndex(this.lblNumParcela, 0);
            this.Controls.SetChildIndex(this.lblValorParcela, 0);
            this.Controls.SetChildIndex(this.txtNumParcela, 0);
            this.Controls.SetChildIndex(this.lblValorFinal, 0);
            this.Controls.SetChildIndex(this.txtValorParcela, 0);
            this.Controls.SetChildIndex(this.txtValorPago, 0);
            this.Controls.SetChildIndex(this.lblDataPagamento, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtJurosReais, 0);
            this.Controls.SetChildIndex(this.txtMultaReais, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtDescontoReais, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblJurosReais, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblMultaReais, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.lblDescontoReais, 0);
            this.Controls.SetChildIndex(this.txtFormaPagamento, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPagamento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFormaPagamento, 0);
            this.Controls.SetChildIndex(this.dtpDataPagamento, 0);
            this.Controls.SetChildIndex(this.lblMotivoCancelamentoTitulo, 0);
            this.Controls.SetChildIndex(this.lblMotivCancelamentoExplicacao, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtNumDaNota;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblNumNota;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Button btnPesquisarFormaPagamento;
        private System.Windows.Forms.TextBox txtCodFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label lblDescontoReais;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblMultaReais;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblJurosReais;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtDescontoReais;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtMultaReais;
        private System.Windows.Forms.TextBox txtJurosReais;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.TextBox txtNumParcela;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblNumParcela;
        private System.Windows.Forms.Label lblMotivCancelamentoExplicacao;
        private System.Windows.Forms.Label lblMotivoCancelamentoTitulo;
    }
}
