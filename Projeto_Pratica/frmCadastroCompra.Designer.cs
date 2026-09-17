namespace Projeto_Pratica
{
    partial class frmCadastroCompra
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
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtNumDaNota = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblNumNota = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnLimparListaProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtUnidadeDeMedida = new System.Windows.Forms.TextBox();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblUnidadeDeMedida = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.listVProdutos = new System.Windows.Forms.ListView();
            this.clmCodProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUnMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtValorFrete = new System.Windows.Forms.TextBox();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblValorQtdTotalProdutos = new System.Windows.Forms.Label();
            this.lblValorTotalGeralProdutos = new System.Windows.Forms.Label();
            this.lblQtdTotalProdutos = new System.Windows.Forms.Label();
            this.lblTotalGeralProdutos = new System.Windows.Forms.Label();
            this.lblValorFrete = new System.Windows.Forms.Label();
            this.btnPesquisarCondicaoDePagamento = new System.Windows.Forms.Button();
            this.btnLimparParcelas = new System.Windows.Forms.Button();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.txtCondicaoDePagamento = new System.Windows.Forms.TextBox();
            this.txtValorTotalValores = new System.Windows.Forms.TextBox();
            this.lblCondicaoDePagamento = new System.Windows.Forms.Label();
            this.lblValorTotalValores = new System.Windows.Forms.Label();
            this.txtCodCondicaoDePagamento = new System.Windows.Forms.TextBox();
            this.listVParcelas = new System.Windows.Forms.ListView();
            this.clmNumParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFormaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblValorTotalParcelas = new System.Windows.Forms.Label();
            this.lblTotalParcelas = new System.Windows.Forms.Label();
            this.lblMotivCancelamentoExplicacao = new System.Windows.Forms.Label();
            this.lblMotivoCancelamentoTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 660);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 681);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 704);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1058, 680);
            // 
            // lblCod
            // 
            this.lblCod.Size = new System.Drawing.Size(49, 13);
            this.lblCod.Text = "Modelo *";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.Location = new System.Drawing.Point(1200, 12);
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 660);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 681);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 704);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1151, 682);
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(775, 26);
            this.dtpDataEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(115, 20);
            this.dtpDataEmissao.TabIndex = 108;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(908, 26);
            this.dtpDataEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(109, 20);
            this.dtpDataEntrega.TabIndex = 109;
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(665, 22);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(93, 25);
            this.btnPesquisarFornecedor.TabIndex = 107;
            this.btnPesquisarFornecedor.Text = "Pesquisar";
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(377, 26);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.ReadOnly = true;
            this.txtCodFornecedor.ShortcutsEnabled = false;
            this.txtCodFornecedor.Size = new System.Drawing.Size(60, 20);
            this.txtCodFornecedor.TabIndex = 118;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(443, 25);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.ShortcutsEnabled = false;
            this.txtFornecedor.Size = new System.Drawing.Size(214, 20);
            this.txtFornecedor.TabIndex = 119;
            // 
            // txtNumDaNota
            // 
            this.txtNumDaNota.Location = new System.Drawing.Point(222, 25);
            this.txtNumDaNota.Name = "txtNumDaNota";
            this.txtNumDaNota.ShortcutsEnabled = false;
            this.txtNumDaNota.Size = new System.Drawing.Size(129, 20);
            this.txtNumDaNota.TabIndex = 106;
            this.txtNumDaNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(147, 26);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ShortcutsEnabled = false;
            this.txtSerie.Size = new System.Drawing.Size(46, 20);
            this.txtSerie.TabIndex = 105;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(904, 8);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(98, 13);
            this.lblDataEntrega.TabIndex = 113;
            this.lblDataEntrega.Text = "Data de Chegada *";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(771, 8);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(94, 13);
            this.lblDataEmissao.TabIndex = 114;
            this.lblDataEmissao.Text = "Data de Emissão *";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(374, 6);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(68, 13);
            this.lblFornecedor.TabIndex = 115;
            this.lblFornecedor.Text = "Fornecedor *";
            // 
            // lblNumNota
            // 
            this.lblNumNota.AutoSize = true;
            this.lblNumNota.Location = new System.Drawing.Point(219, 7);
            this.lblNumNota.Name = "lblNumNota";
            this.lblNumNota.Size = new System.Drawing.Size(80, 13);
            this.lblNumNota.TabIndex = 116;
            this.lblNumNota.Text = "Núm. da Nota *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(144, 8);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 117;
            this.lblSerie.Text = "Série *";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(293, 73);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(90, 23);
            this.btnPesquisarProduto.TabIndex = 120;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // btnLimparListaProduto
            // 
            this.btnLimparListaProduto.Location = new System.Drawing.Point(1078, 76);
            this.btnLimparListaProduto.Name = "btnLimparListaProduto";
            this.btnLimparListaProduto.Size = new System.Drawing.Size(98, 23);
            this.btnLimparListaProduto.TabIndex = 126;
            this.btnLimparListaProduto.Text = "Limpar Lista";
            this.btnLimparListaProduto.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(997, 76);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverProduto.TabIndex = 125;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(915, 76);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(76, 23);
            this.btnEditarProduto.TabIndex = 124;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(835, 76);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(74, 23);
            this.btnAdicionarProduto.TabIndex = 123;
            this.btnAdicionarProduto.Text = "Adicionar ";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // txtUnidadeDeMedida
            // 
            this.txtUnidadeDeMedida.Location = new System.Drawing.Point(405, 78);
            this.txtUnidadeDeMedida.Name = "txtUnidadeDeMedida";
            this.txtUnidadeDeMedida.ReadOnly = true;
            this.txtUnidadeDeMedida.ShortcutsEnabled = false;
            this.txtUnidadeDeMedida.Size = new System.Drawing.Size(80, 20);
            this.txtUnidadeDeMedida.TabIndex = 132;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Location = new System.Drawing.Point(706, 78);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.ReadOnly = true;
            this.txtTotalProduto.ShortcutsEnabled = false;
            this.txtTotalProduto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProduto.TabIndex = 133;
            this.txtTotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(599, 79);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ShortcutsEnabled = false;
            this.txtValorUnitario.Size = new System.Drawing.Size(88, 20);
            this.txtValorUnitario.TabIndex = 122;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(506, 79);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ShortcutsEnabled = false;
            this.txtQuantidade.Size = new System.Drawing.Size(74, 20);
            this.txtQuantidade.TabIndex = 121;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(80, 76);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.ShortcutsEnabled = false;
            this.txtProduto.Size = new System.Drawing.Size(207, 20);
            this.txtProduto.TabIndex = 134;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(14, 76);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.ShortcutsEnabled = false;
            this.txtCodProduto.Size = new System.Drawing.Size(60, 20);
            this.txtCodProduto.TabIndex = 135;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Location = new System.Drawing.Point(703, 60);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(54, 13);
            this.lblTotalProduto.TabIndex = 127;
            this.lblTotalProduto.Text = "Total (R$)";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(596, 60);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(93, 13);
            this.lblValorUnitario.TabIndex = 128;
            this.lblValorUnitario.Text = "Valor Unitário (R$)";
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(404, 60);
            this.lblUnidadeDeMedida.Name = "lblUnidadeDeMedida";
            this.lblUnidadeDeMedida.Size = new System.Drawing.Size(77, 13);
            this.lblUnidadeDeMedida.TabIndex = 129;
            this.lblUnidadeDeMedida.Text = "Un. de Medida";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(503, 61);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 130;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 58);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 13);
            this.lblProduto.TabIndex = 131;
            this.lblProduto.Text = "Produto *";
            // 
            // listVProdutos
            // 
            this.listVProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodProduto,
            this.clmProduto,
            this.clmUnMedida,
            this.clmQtd,
            this.clmValorUnitario,
            this.clmTotal});
            this.listVProdutos.FullRowSelect = true;
            this.listVProdutos.GridLines = true;
            this.listVProdutos.HideSelection = false;
            this.listVProdutos.Location = new System.Drawing.Point(12, 121);
            this.listVProdutos.Name = "listVProdutos";
            this.listVProdutos.Size = new System.Drawing.Size(1229, 227);
            this.listVProdutos.TabIndex = 136;
            this.listVProdutos.UseCompatibleStateImageBehavior = false;
            this.listVProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clmCodProduto
            // 
            this.clmCodProduto.Text = "Cód. Produto";
            this.clmCodProduto.Width = 120;
            // 
            // clmProduto
            // 
            this.clmProduto.Text = "Produto";
            this.clmProduto.Width = 180;
            // 
            // clmUnMedida
            // 
            this.clmUnMedida.Text = "Un. de Medida";
            this.clmUnMedida.Width = 120;
            // 
            // clmQtd
            // 
            this.clmQtd.Text = "Quantidade";
            this.clmQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmQtd.Width = 120;
            // 
            // clmValorUnitario
            // 
            this.clmValorUnitario.Text = "Valor Unitário";
            this.clmValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmValorUnitario.Width = 120;
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            this.clmTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmTotal.Width = 120;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(286, 387);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.ShortcutsEnabled = false;
            this.txtDespesas.Size = new System.Drawing.Size(120, 20);
            this.txtDespesas.TabIndex = 139;
            this.txtDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(149, 387);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ShortcutsEnabled = false;
            this.txtSeguro.Size = new System.Drawing.Size(113, 20);
            this.txtSeguro.TabIndex = 138;
            this.txtSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(17, 387);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.ShortcutsEnabled = false;
            this.txtValorFrete.Size = new System.Drawing.Size(113, 20);
            this.txtValorFrete.TabIndex = 137;
            this.txtValorFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(283, 369);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(84, 13);
            this.lblDespesas.TabIndex = 140;
            this.lblDespesas.Text = "Despesas (R$) *";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(146, 369);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(71, 13);
            this.lblSeguro.TabIndex = 141;
            this.lblSeguro.Text = "Seguro (R$) *";
            // 
            // lblValorQtdTotalProdutos
            // 
            this.lblValorQtdTotalProdutos.AutoSize = true;
            this.lblValorQtdTotalProdutos.Location = new System.Drawing.Point(1083, 358);
            this.lblValorQtdTotalProdutos.Name = "lblValorQtdTotalProdutos";
            this.lblValorQtdTotalProdutos.Size = new System.Drawing.Size(13, 13);
            this.lblValorQtdTotalProdutos.TabIndex = 142;
            this.lblValorQtdTotalProdutos.Text = "0";
            // 
            // lblValorTotalGeralProdutos
            // 
            this.lblValorTotalGeralProdutos.AutoSize = true;
            this.lblValorTotalGeralProdutos.Location = new System.Drawing.Point(1083, 381);
            this.lblValorTotalGeralProdutos.Name = "lblValorTotalGeralProdutos";
            this.lblValorTotalGeralProdutos.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotalGeralProdutos.TabIndex = 143;
            this.lblValorTotalGeralProdutos.Text = "0";
            // 
            // lblQtdTotalProdutos
            // 
            this.lblQtdTotalProdutos.AutoSize = true;
            this.lblQtdTotalProdutos.Location = new System.Drawing.Point(921, 358);
            this.lblQtdTotalProdutos.Name = "lblQtdTotalProdutos";
            this.lblQtdTotalProdutos.Size = new System.Drawing.Size(117, 13);
            this.lblQtdTotalProdutos.TabIndex = 144;
            this.lblQtdTotalProdutos.Text = "Qtd. Total de Produtos:";
            // 
            // lblTotalGeralProdutos
            // 
            this.lblTotalGeralProdutos.AutoSize = true;
            this.lblTotalGeralProdutos.Location = new System.Drawing.Point(921, 381);
            this.lblTotalGeralProdutos.Name = "lblTotalGeralProdutos";
            this.lblTotalGeralProdutos.Size = new System.Drawing.Size(102, 13);
            this.lblTotalGeralProdutos.TabIndex = 145;
            this.lblTotalGeralProdutos.Text = "Valor Produtos (R$):";
            // 
            // lblValorFrete
            // 
            this.lblValorFrete.AutoSize = true;
            this.lblValorFrete.Location = new System.Drawing.Point(14, 367);
            this.lblValorFrete.Name = "lblValorFrete";
            this.lblValorFrete.Size = new System.Drawing.Size(88, 13);
            this.lblValorFrete.TabIndex = 146;
            this.lblValorFrete.Text = "Valor Frete (R$) *";
            // 
            // btnPesquisarCondicaoDePagamento
            // 
            this.btnPesquisarCondicaoDePagamento.Location = new System.Drawing.Point(325, 437);
            this.btnPesquisarCondicaoDePagamento.Name = "btnPesquisarCondicaoDePagamento";
            this.btnPesquisarCondicaoDePagamento.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisarCondicaoDePagamento.TabIndex = 147;
            this.btnPesquisarCondicaoDePagamento.Text = "Pesquisar";
            this.btnPesquisarCondicaoDePagamento.UseVisualStyleBackColor = true;
            // 
            // btnLimparParcelas
            // 
            this.btnLimparParcelas.Location = new System.Drawing.Point(544, 436);
            this.btnLimparParcelas.Name = "btnLimparParcelas";
            this.btnLimparParcelas.Size = new System.Drawing.Size(122, 23);
            this.btnLimparParcelas.TabIndex = 149;
            this.btnLimparParcelas.Text = "Limpar Parcelas";
            this.btnLimparParcelas.UseVisualStyleBackColor = true;
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Location = new System.Drawing.Point(426, 436);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(112, 23);
            this.btnGerarParcelas.TabIndex = 148;
            this.btnGerarParcelas.Text = "Gerar Parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            // 
            // txtCondicaoDePagamento
            // 
            this.txtCondicaoDePagamento.Location = new System.Drawing.Point(85, 438);
            this.txtCondicaoDePagamento.Name = "txtCondicaoDePagamento";
            this.txtCondicaoDePagamento.ReadOnly = true;
            this.txtCondicaoDePagamento.ShortcutsEnabled = false;
            this.txtCondicaoDePagamento.Size = new System.Drawing.Size(234, 20);
            this.txtCondicaoDePagamento.TabIndex = 152;
            // 
            // txtValorTotalValores
            // 
            this.txtValorTotalValores.Location = new System.Drawing.Point(926, 440);
            this.txtValorTotalValores.Name = "txtValorTotalValores";
            this.txtValorTotalValores.ReadOnly = true;
            this.txtValorTotalValores.ShortcutsEnabled = false;
            this.txtValorTotalValores.Size = new System.Drawing.Size(311, 20);
            this.txtValorTotalValores.TabIndex = 153;
            this.txtValorTotalValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCondicaoDePagamento
            // 
            this.lblCondicaoDePagamento.AutoSize = true;
            this.lblCondicaoDePagamento.Location = new System.Drawing.Point(16, 420);
            this.lblCondicaoDePagamento.Name = "lblCondicaoDePagamento";
            this.lblCondicaoDePagamento.Size = new System.Drawing.Size(131, 13);
            this.lblCondicaoDePagamento.TabIndex = 150;
            this.lblCondicaoDePagamento.Text = "Condição de Pagamento *";
            // 
            // lblValorTotalValores
            // 
            this.lblValorTotalValores.AutoSize = true;
            this.lblValorTotalValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalValores.ForeColor = System.Drawing.Color.Black;
            this.lblValorTotalValores.Location = new System.Drawing.Point(923, 413);
            this.lblValorTotalValores.Name = "lblValorTotalValores";
            this.lblValorTotalValores.Size = new System.Drawing.Size(251, 20);
            this.lblValorTotalValores.TabIndex = 151;
            this.lblValorTotalValores.Text = "VALOR TOTAL DA NOTA (R$)";
            // 
            // txtCodCondicaoDePagamento
            // 
            this.txtCodCondicaoDePagamento.Location = new System.Drawing.Point(19, 437);
            this.txtCodCondicaoDePagamento.Name = "txtCodCondicaoDePagamento";
            this.txtCodCondicaoDePagamento.ReadOnly = true;
            this.txtCodCondicaoDePagamento.ShortcutsEnabled = false;
            this.txtCodCondicaoDePagamento.Size = new System.Drawing.Size(60, 20);
            this.txtCodCondicaoDePagamento.TabIndex = 154;
            this.txtCodCondicaoDePagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listVParcelas
            // 
            this.listVParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumParcela,
            this.clmDataEmissao,
            this.clmDataVencimento,
            this.clmValorParcela,
            this.clmFormaPagamento});
            this.listVParcelas.FullRowSelect = true;
            this.listVParcelas.GridLines = true;
            this.listVParcelas.HideSelection = false;
            this.listVParcelas.Location = new System.Drawing.Point(20, 470);
            this.listVParcelas.Name = "listVParcelas";
            this.listVParcelas.Size = new System.Drawing.Size(1217, 168);
            this.listVParcelas.TabIndex = 155;
            this.listVParcelas.UseCompatibleStateImageBehavior = false;
            this.listVParcelas.View = System.Windows.Forms.View.Details;
            // 
            // clmNumParcela
            // 
            this.clmNumParcela.Text = "Num. Parcela";
            this.clmNumParcela.Width = 120;
            // 
            // clmDataEmissao
            // 
            this.clmDataEmissao.Text = "Data de Emissão";
            this.clmDataEmissao.Width = 120;
            // 
            // clmDataVencimento
            // 
            this.clmDataVencimento.Text = "Data de Vencimento";
            this.clmDataVencimento.Width = 120;
            // 
            // clmValorParcela
            // 
            this.clmValorParcela.Text = "Valor Parcela";
            this.clmValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmValorParcela.Width = 120;
            // 
            // clmFormaPagamento
            // 
            this.clmFormaPagamento.Text = "Forma de Pagamento";
            this.clmFormaPagamento.Width = 200;
            // 
            // lblValorTotalParcelas
            // 
            this.lblValorTotalParcelas.AutoSize = true;
            this.lblValorTotalParcelas.Location = new System.Drawing.Point(1083, 640);
            this.lblValorTotalParcelas.Name = "lblValorTotalParcelas";
            this.lblValorTotalParcelas.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotalParcelas.TabIndex = 156;
            this.lblValorTotalParcelas.Text = "0";
            // 
            // lblTotalParcelas
            // 
            this.lblTotalParcelas.AutoSize = true;
            this.lblTotalParcelas.Location = new System.Drawing.Point(921, 639);
            this.lblTotalParcelas.Name = "lblTotalParcelas";
            this.lblTotalParcelas.Size = new System.Drawing.Size(101, 13);
            this.lblTotalParcelas.TabIndex = 157;
            this.lblTotalParcelas.Text = "Total Parcelas (R$):";
            // 
            // lblMotivCancelamentoExplicacao
            // 
            this.lblMotivCancelamentoExplicacao.AutoSize = true;
            this.lblMotivCancelamentoExplicacao.Location = new System.Drawing.Point(395, 659);
            this.lblMotivCancelamentoExplicacao.Name = "lblMotivCancelamentoExplicacao";
            this.lblMotivCancelamentoExplicacao.Size = new System.Drawing.Size(109, 13);
            this.lblMotivCancelamentoExplicacao.TabIndex = 158;
            this.lblMotivCancelamentoExplicacao.Text = "Explicação do Motivo";
            this.lblMotivCancelamentoExplicacao.Visible = false;
            // 
            // lblMotivoCancelamentoTitulo
            // 
            this.lblMotivoCancelamentoTitulo.AutoSize = true;
            this.lblMotivoCancelamentoTitulo.Location = new System.Drawing.Point(394, 640);
            this.lblMotivoCancelamentoTitulo.Name = "lblMotivoCancelamentoTitulo";
            this.lblMotivoCancelamentoTitulo.Size = new System.Drawing.Size(125, 13);
            this.lblMotivoCancelamentoTitulo.TabIndex = 159;
            this.lblMotivoCancelamentoTitulo.Text = "Motivo de Cancelamento";
            this.lblMotivoCancelamentoTitulo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Explicação do Motivo";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 161;
            this.label2.Text = "Motivo de Cancelamento";
            this.label2.Visible = false;
            // 
            // frmCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1253, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMotivCancelamentoExplicacao);
            this.Controls.Add(this.lblMotivoCancelamentoTitulo);
            this.Controls.Add(this.lblTotalParcelas);
            this.Controls.Add(this.lblValorTotalParcelas);
            this.Controls.Add(this.listVParcelas);
            this.Controls.Add(this.btnPesquisarCondicaoDePagamento);
            this.Controls.Add(this.btnLimparParcelas);
            this.Controls.Add(this.btnGerarParcelas);
            this.Controls.Add(this.txtCondicaoDePagamento);
            this.Controls.Add(this.txtValorTotalValores);
            this.Controls.Add(this.lblCondicaoDePagamento);
            this.Controls.Add(this.lblValorTotalValores);
            this.Controls.Add(this.txtCodCondicaoDePagamento);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtValorFrete);
            this.Controls.Add(this.lblDespesas);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.lblValorQtdTotalProdutos);
            this.Controls.Add(this.lblValorTotalGeralProdutos);
            this.Controls.Add(this.lblQtdTotalProdutos);
            this.Controls.Add(this.lblTotalGeralProdutos);
            this.Controls.Add(this.lblValorFrete);
            this.Controls.Add(this.listVProdutos);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.btnLimparListaProduto);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.txtUnidadeDeMedida);
            this.Controls.Add(this.txtTotalProduto);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.lblTotalProduto);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblUnidadeDeMedida);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dtpDataEmissao);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.btnPesquisarFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtNumDaNota);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblNumNota);
            this.Controls.Add(this.lblSerie);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroCompra";
            this.Text = "Cadastro de Compra";
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
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblDataEntrega, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.txtNumDaNota, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFornecedor, 0);
            this.Controls.SetChildIndex(this.dtpDataEntrega, 0);
            this.Controls.SetChildIndex(this.dtpDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblProduto, 0);
            this.Controls.SetChildIndex(this.lblQuantidade, 0);
            this.Controls.SetChildIndex(this.lblUnidadeDeMedida, 0);
            this.Controls.SetChildIndex(this.lblValorUnitario, 0);
            this.Controls.SetChildIndex(this.lblTotalProduto, 0);
            this.Controls.SetChildIndex(this.txtCodProduto, 0);
            this.Controls.SetChildIndex(this.txtProduto, 0);
            this.Controls.SetChildIndex(this.txtQuantidade, 0);
            this.Controls.SetChildIndex(this.txtValorUnitario, 0);
            this.Controls.SetChildIndex(this.txtTotalProduto, 0);
            this.Controls.SetChildIndex(this.txtUnidadeDeMedida, 0);
            this.Controls.SetChildIndex(this.btnAdicionarProduto, 0);
            this.Controls.SetChildIndex(this.btnEditarProduto, 0);
            this.Controls.SetChildIndex(this.btnRemoverProduto, 0);
            this.Controls.SetChildIndex(this.btnLimparListaProduto, 0);
            this.Controls.SetChildIndex(this.btnPesquisarProduto, 0);
            this.Controls.SetChildIndex(this.listVProdutos, 0);
            this.Controls.SetChildIndex(this.lblValorFrete, 0);
            this.Controls.SetChildIndex(this.lblTotalGeralProdutos, 0);
            this.Controls.SetChildIndex(this.lblQtdTotalProdutos, 0);
            this.Controls.SetChildIndex(this.lblValorTotalGeralProdutos, 0);
            this.Controls.SetChildIndex(this.lblValorQtdTotalProdutos, 0);
            this.Controls.SetChildIndex(this.lblSeguro, 0);
            this.Controls.SetChildIndex(this.lblDespesas, 0);
            this.Controls.SetChildIndex(this.txtValorFrete, 0);
            this.Controls.SetChildIndex(this.txtSeguro, 0);
            this.Controls.SetChildIndex(this.txtDespesas, 0);
            this.Controls.SetChildIndex(this.txtCodCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.lblValorTotalValores, 0);
            this.Controls.SetChildIndex(this.lblCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.txtValorTotalValores, 0);
            this.Controls.SetChildIndex(this.txtCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.btnGerarParcelas, 0);
            this.Controls.SetChildIndex(this.btnLimparParcelas, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.listVParcelas, 0);
            this.Controls.SetChildIndex(this.lblValorTotalParcelas, 0);
            this.Controls.SetChildIndex(this.lblTotalParcelas, 0);
            this.Controls.SetChildIndex(this.lblMotivoCancelamentoTitulo, 0);
            this.Controls.SetChildIndex(this.lblMotivCancelamentoExplicacao, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtNumDaNota;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblNumNota;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnLimparListaProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtUnidadeDeMedida;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblUnidadeDeMedida;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListView listVProdutos;
        private System.Windows.Forms.ColumnHeader clmCodProduto;
        private System.Windows.Forms.ColumnHeader clmProduto;
        private System.Windows.Forms.ColumnHeader clmUnMedida;
        private System.Windows.Forms.ColumnHeader clmQtd;
        private System.Windows.Forms.ColumnHeader clmValorUnitario;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtValorFrete;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblValorQtdTotalProdutos;
        private System.Windows.Forms.Label lblValorTotalGeralProdutos;
        private System.Windows.Forms.Label lblQtdTotalProdutos;
        private System.Windows.Forms.Label lblTotalGeralProdutos;
        private System.Windows.Forms.Label lblValorFrete;
        private System.Windows.Forms.Button btnPesquisarCondicaoDePagamento;
        private System.Windows.Forms.Button btnLimparParcelas;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.TextBox txtCondicaoDePagamento;
        private System.Windows.Forms.TextBox txtValorTotalValores;
        private System.Windows.Forms.Label lblCondicaoDePagamento;
        private System.Windows.Forms.Label lblValorTotalValores;
        private System.Windows.Forms.TextBox txtCodCondicaoDePagamento;
        private System.Windows.Forms.ListView listVParcelas;
        private System.Windows.Forms.ColumnHeader clmNumParcela;
        private System.Windows.Forms.ColumnHeader clmDataEmissao;
        private System.Windows.Forms.ColumnHeader clmDataVencimento;
        private System.Windows.Forms.ColumnHeader clmValorParcela;
        private System.Windows.Forms.ColumnHeader clmFormaPagamento;
        private System.Windows.Forms.Label lblValorTotalParcelas;
        private System.Windows.Forms.Label lblTotalParcelas;
        private System.Windows.Forms.Label lblMotivCancelamentoExplicacao;
        private System.Windows.Forms.Label lblMotivoCancelamentoTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
