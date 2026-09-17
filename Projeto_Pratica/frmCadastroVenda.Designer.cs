namespace Projeto_Pratica
{
    partial class frmCadastroVenda
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
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtNumDaNota = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblNumNota = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.listVProdutos = new System.Windows.Forms.ListView();
            this.clmCodProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUnMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.txtValorTotalValores = new System.Windows.Forms.TextBox();
            this.lblValorTotalValores = new System.Windows.Forms.Label();
            this.btnPesquisarCondicaoDePagamento = new System.Windows.Forms.Button();
            this.btnLimparParcelas = new System.Windows.Forms.Button();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.txtCondicaoDePagamento = new System.Windows.Forms.TextBox();
            this.lblCondicaoDePagamento = new System.Windows.Forms.Label();
            this.txtCodCondicaoDePagamento = new System.Windows.Forms.TextBox();
            this.lblValorCreditoDisponivel = new System.Windows.Forms.Label();
            this.lblValorQtdTotalProdutos = new System.Windows.Forms.Label();
            this.lblValorTotalGeralProdutos = new System.Windows.Forms.Label();
            this.lblCreditoDisponivelParaOCliente = new System.Windows.Forms.Label();
            this.lblQtdTotalProdutos = new System.Windows.Forms.Label();
            this.lblTotalGeralProdutos = new System.Windows.Forms.Label();
            this.listVParcelas = new System.Windows.Forms.ListView();
            this.clmNumParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFormaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMotivCancelamentoExplicacao = new System.Windows.Forms.Label();
            this.lblMotivoCancelamentoTitulo = new System.Windows.Forms.Label();
            this.lblValorTotalParcelas = new System.Windows.Forms.Label();
            this.lblTotalParcelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 639);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 657);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 680);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1148, 660);
            this.btnSave.Size = new System.Drawing.Size(87, 33);
            // 
            // lblCod
            // 
            this.lblCod.Location = new System.Drawing.Point(12, 18);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.Location = new System.Drawing.Point(1282, 11);
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 636);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 657);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 680);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 35);
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1241, 662);
            this.btnSair.Size = new System.Drawing.Size(91, 31);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(670, 32);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(71, 22);
            this.btnPesquisarCliente.TabIndex = 146;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(1048, 31);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(67, 23);
            this.btnPesquisarFuncionario.TabIndex = 147;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(384, 34);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.ShortcutsEnabled = false;
            this.txtCodCliente.Size = new System.Drawing.Size(60, 20);
            this.txtCodCliente.TabIndex = 155;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Location = new System.Drawing.Point(762, 34);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.ReadOnly = true;
            this.txtCodFuncionario.ShortcutsEnabled = false;
            this.txtCodFuncionario.Size = new System.Drawing.Size(60, 20);
            this.txtCodFuncionario.TabIndex = 156;
            this.txtCodFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(450, 33);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.ShortcutsEnabled = false;
            this.txtCliente.Size = new System.Drawing.Size(214, 20);
            this.txtCliente.TabIndex = 153;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(828, 33);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.ShortcutsEnabled = false;
            this.txtFuncionario.Size = new System.Drawing.Size(214, 20);
            this.txtFuncionario.TabIndex = 154;
            // 
            // txtNumDaNota
            // 
            this.txtNumDaNota.Enabled = false;
            this.txtNumDaNota.Location = new System.Drawing.Point(229, 33);
            this.txtNumDaNota.Name = "txtNumDaNota";
            this.txtNumDaNota.ReadOnly = true;
            this.txtNumDaNota.ShortcutsEnabled = false;
            this.txtNumDaNota.Size = new System.Drawing.Size(129, 20);
            this.txtNumDaNota.TabIndex = 152;
            this.txtNumDaNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(154, 34);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.ShortcutsEnabled = false;
            this.txtSerie.Size = new System.Drawing.Size(46, 20);
            this.txtSerie.TabIndex = 157;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(381, 14);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 149;
            this.lblCliente.Text = "Cliente *";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(759, 14);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(69, 13);
            this.lblFuncionario.TabIndex = 150;
            this.lblFuncionario.Text = "Funcionário *";
            // 
            // lblNumNota
            // 
            this.lblNumNota.AutoSize = true;
            this.lblNumNota.Location = new System.Drawing.Point(226, 15);
            this.lblNumNota.Name = "lblNumNota";
            this.lblNumNota.Size = new System.Drawing.Size(80, 13);
            this.lblNumNota.TabIndex = 148;
            this.lblNumNota.Text = "Núm. da Nota *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(151, 16);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 151;
            this.lblSerie.Text = "Série *";
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Enabled = false;
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(1129, 31);
            this.dtpDataEmissao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(115, 20);
            this.dtpDataEmissao.TabIndex = 158;
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(1125, 13);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(94, 13);
            this.lblDataEmissao.TabIndex = 159;
            this.lblDataEmissao.Text = "Data de Emissão *";
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
            this.listVProdutos.Location = new System.Drawing.Point(16, 122);
            this.listVProdutos.Name = "listVProdutos";
            this.listVProdutos.Size = new System.Drawing.Size(1300, 227);
            this.listVProdutos.TabIndex = 192;
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
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(293, 91);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(86, 23);
            this.btnPesquisarProduto.TabIndex = 176;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // btnLimparListaProduto
            // 
            this.btnLimparListaProduto.Location = new System.Drawing.Point(1075, 91);
            this.btnLimparListaProduto.Name = "btnLimparListaProduto";
            this.btnLimparListaProduto.Size = new System.Drawing.Size(98, 23);
            this.btnLimparListaProduto.TabIndex = 182;
            this.btnLimparListaProduto.Text = "Limpar Lista";
            this.btnLimparListaProduto.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(994, 91);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverProduto.TabIndex = 181;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(912, 91);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(76, 23);
            this.btnEditarProduto.TabIndex = 180;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(832, 91);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(74, 23);
            this.btnAdicionarProduto.TabIndex = 179;
            this.btnAdicionarProduto.Text = "Adicionar ";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // txtUnidadeDeMedida
            // 
            this.txtUnidadeDeMedida.Location = new System.Drawing.Point(402, 93);
            this.txtUnidadeDeMedida.Name = "txtUnidadeDeMedida";
            this.txtUnidadeDeMedida.ReadOnly = true;
            this.txtUnidadeDeMedida.ShortcutsEnabled = false;
            this.txtUnidadeDeMedida.Size = new System.Drawing.Size(80, 20);
            this.txtUnidadeDeMedida.TabIndex = 190;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Location = new System.Drawing.Point(703, 93);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.ReadOnly = true;
            this.txtTotalProduto.ShortcutsEnabled = false;
            this.txtTotalProduto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProduto.TabIndex = 191;
            this.txtTotalProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(596, 94);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.ShortcutsEnabled = false;
            this.txtValorUnitario.Size = new System.Drawing.Size(88, 20);
            this.txtValorUnitario.TabIndex = 178;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(503, 94);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ShortcutsEnabled = false;
            this.txtQuantidade.Size = new System.Drawing.Size(74, 20);
            this.txtQuantidade.TabIndex = 177;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(82, 93);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.ShortcutsEnabled = false;
            this.txtProduto.Size = new System.Drawing.Size(207, 20);
            this.txtProduto.TabIndex = 189;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(16, 93);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.ShortcutsEnabled = false;
            this.txtCodProduto.Size = new System.Drawing.Size(60, 20);
            this.txtCodProduto.TabIndex = 188;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Location = new System.Drawing.Point(700, 75);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(54, 13);
            this.lblTotalProduto.TabIndex = 186;
            this.lblTotalProduto.Text = "Total (R$)";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(593, 75);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(107, 13);
            this.lblValorUnitario.TabIndex = 185;
            this.lblValorUnitario.Text = "Preço de Venda (R$)";
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(401, 75);
            this.lblUnidadeDeMedida.Name = "lblUnidadeDeMedida";
            this.lblUnidadeDeMedida.Size = new System.Drawing.Size(77, 13);
            this.lblUnidadeDeMedida.TabIndex = 184;
            this.lblUnidadeDeMedida.Text = "Un. de Medida";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(500, 76);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 187;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(13, 74);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 13);
            this.lblProduto.TabIndex = 183;
            this.lblProduto.Text = "Produto *";
            // 
            // txtValorTotalValores
            // 
            this.txtValorTotalValores.Location = new System.Drawing.Point(924, 430);
            this.txtValorTotalValores.Name = "txtValorTotalValores";
            this.txtValorTotalValores.ReadOnly = true;
            this.txtValorTotalValores.ShortcutsEnabled = false;
            this.txtValorTotalValores.Size = new System.Drawing.Size(311, 20);
            this.txtValorTotalValores.TabIndex = 206;
            this.txtValorTotalValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorTotalValores
            // 
            this.lblValorTotalValores.AutoSize = true;
            this.lblValorTotalValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalValores.ForeColor = System.Drawing.Color.Black;
            this.lblValorTotalValores.Location = new System.Drawing.Point(921, 403);
            this.lblValorTotalValores.Name = "lblValorTotalValores";
            this.lblValorTotalValores.Size = new System.Drawing.Size(251, 20);
            this.lblValorTotalValores.TabIndex = 205;
            this.lblValorTotalValores.Text = "VALOR TOTAL DA NOTA (R$)";
            // 
            // btnPesquisarCondicaoDePagamento
            // 
            this.btnPesquisarCondicaoDePagamento.Location = new System.Drawing.Point(323, 428);
            this.btnPesquisarCondicaoDePagamento.Name = "btnPesquisarCondicaoDePagamento";
            this.btnPesquisarCondicaoDePagamento.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisarCondicaoDePagamento.TabIndex = 193;
            this.btnPesquisarCondicaoDePagamento.Text = "Pesquisar";
            this.btnPesquisarCondicaoDePagamento.UseVisualStyleBackColor = true;
            // 
            // btnLimparParcelas
            // 
            this.btnLimparParcelas.Location = new System.Drawing.Point(553, 427);
            this.btnLimparParcelas.Name = "btnLimparParcelas";
            this.btnLimparParcelas.Size = new System.Drawing.Size(122, 23);
            this.btnLimparParcelas.TabIndex = 195;
            this.btnLimparParcelas.Text = "Limpar Parcelas";
            this.btnLimparParcelas.UseVisualStyleBackColor = true;
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Location = new System.Drawing.Point(435, 427);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(112, 23);
            this.btnGerarParcelas.TabIndex = 194;
            this.btnGerarParcelas.Text = "Gerar Parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            // 
            // txtCondicaoDePagamento
            // 
            this.txtCondicaoDePagamento.Location = new System.Drawing.Point(83, 429);
            this.txtCondicaoDePagamento.Name = "txtCondicaoDePagamento";
            this.txtCondicaoDePagamento.ReadOnly = true;
            this.txtCondicaoDePagamento.ShortcutsEnabled = false;
            this.txtCondicaoDePagamento.Size = new System.Drawing.Size(234, 20);
            this.txtCondicaoDePagamento.TabIndex = 203;
            // 
            // lblCondicaoDePagamento
            // 
            this.lblCondicaoDePagamento.AutoSize = true;
            this.lblCondicaoDePagamento.Location = new System.Drawing.Point(14, 411);
            this.lblCondicaoDePagamento.Name = "lblCondicaoDePagamento";
            this.lblCondicaoDePagamento.Size = new System.Drawing.Size(131, 13);
            this.lblCondicaoDePagamento.TabIndex = 202;
            this.lblCondicaoDePagamento.Text = "Condição de Pagamento *";
            // 
            // txtCodCondicaoDePagamento
            // 
            this.txtCodCondicaoDePagamento.Location = new System.Drawing.Point(17, 428);
            this.txtCodCondicaoDePagamento.Name = "txtCodCondicaoDePagamento";
            this.txtCodCondicaoDePagamento.ReadOnly = true;
            this.txtCodCondicaoDePagamento.ShortcutsEnabled = false;
            this.txtCodCondicaoDePagamento.Size = new System.Drawing.Size(60, 20);
            this.txtCodCondicaoDePagamento.TabIndex = 204;
            this.txtCodCondicaoDePagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorCreditoDisponivel
            // 
            this.lblValorCreditoDisponivel.AutoSize = true;
            this.lblValorCreditoDisponivel.Location = new System.Drawing.Point(259, 352);
            this.lblValorCreditoDisponivel.Name = "lblValorCreditoDisponivel";
            this.lblValorCreditoDisponivel.Size = new System.Drawing.Size(10, 13);
            this.lblValorCreditoDisponivel.TabIndex = 196;
            this.lblValorCreditoDisponivel.Text = "-";
            // 
            // lblValorQtdTotalProdutos
            // 
            this.lblValorQtdTotalProdutos.AutoSize = true;
            this.lblValorQtdTotalProdutos.Location = new System.Drawing.Point(1083, 352);
            this.lblValorQtdTotalProdutos.Name = "lblValorQtdTotalProdutos";
            this.lblValorQtdTotalProdutos.Size = new System.Drawing.Size(13, 13);
            this.lblValorQtdTotalProdutos.TabIndex = 197;
            this.lblValorQtdTotalProdutos.Text = "0";
            // 
            // lblValorTotalGeralProdutos
            // 
            this.lblValorTotalGeralProdutos.AutoSize = true;
            this.lblValorTotalGeralProdutos.Location = new System.Drawing.Point(1083, 375);
            this.lblValorTotalGeralProdutos.Name = "lblValorTotalGeralProdutos";
            this.lblValorTotalGeralProdutos.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotalGeralProdutos.TabIndex = 198;
            this.lblValorTotalGeralProdutos.Text = "0";
            // 
            // lblCreditoDisponivelParaOCliente
            // 
            this.lblCreditoDisponivelParaOCliente.AutoSize = true;
            this.lblCreditoDisponivelParaOCliente.Location = new System.Drawing.Point(18, 352);
            this.lblCreditoDisponivelParaOCliente.Name = "lblCreditoDisponivelParaOCliente";
            this.lblCreditoDisponivelParaOCliente.Size = new System.Drawing.Size(188, 13);
            this.lblCreditoDisponivelParaOCliente.TabIndex = 199;
            this.lblCreditoDisponivelParaOCliente.Text = "Crédito Disponível para o Cliente (R$):";
            // 
            // lblQtdTotalProdutos
            // 
            this.lblQtdTotalProdutos.AutoSize = true;
            this.lblQtdTotalProdutos.Location = new System.Drawing.Point(921, 352);
            this.lblQtdTotalProdutos.Name = "lblQtdTotalProdutos";
            this.lblQtdTotalProdutos.Size = new System.Drawing.Size(117, 13);
            this.lblQtdTotalProdutos.TabIndex = 200;
            this.lblQtdTotalProdutos.Text = "Qtd. Total de Produtos:";
            // 
            // lblTotalGeralProdutos
            // 
            this.lblTotalGeralProdutos.AutoSize = true;
            this.lblTotalGeralProdutos.Location = new System.Drawing.Point(921, 375);
            this.lblTotalGeralProdutos.Name = "lblTotalGeralProdutos";
            this.lblTotalGeralProdutos.Size = new System.Drawing.Size(102, 13);
            this.lblTotalGeralProdutos.TabIndex = 201;
            this.lblTotalGeralProdutos.Text = "Valor Produtos (R$):";
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
            this.listVParcelas.Location = new System.Drawing.Point(15, 455);
            this.listVParcelas.Name = "listVParcelas";
            this.listVParcelas.Size = new System.Drawing.Size(1304, 168);
            this.listVParcelas.TabIndex = 207;
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
            // lblMotivCancelamentoExplicacao
            // 
            this.lblMotivCancelamentoExplicacao.AutoSize = true;
            this.lblMotivCancelamentoExplicacao.Location = new System.Drawing.Point(378, 654);
            this.lblMotivCancelamentoExplicacao.Name = "lblMotivCancelamentoExplicacao";
            this.lblMotivCancelamentoExplicacao.Size = new System.Drawing.Size(109, 13);
            this.lblMotivCancelamentoExplicacao.TabIndex = 208;
            this.lblMotivCancelamentoExplicacao.Text = "Explicação do Motivo";
            this.lblMotivCancelamentoExplicacao.Visible = false;
            // 
            // lblMotivoCancelamentoTitulo
            // 
            this.lblMotivoCancelamentoTitulo.AutoSize = true;
            this.lblMotivoCancelamentoTitulo.Location = new System.Drawing.Point(377, 635);
            this.lblMotivoCancelamentoTitulo.Name = "lblMotivoCancelamentoTitulo";
            this.lblMotivoCancelamentoTitulo.Size = new System.Drawing.Size(125, 13);
            this.lblMotivoCancelamentoTitulo.TabIndex = 209;
            this.lblMotivoCancelamentoTitulo.Text = "Motivo de Cancelamento";
            this.lblMotivoCancelamentoTitulo.Visible = false;
            // 
            // lblValorTotalParcelas
            // 
            this.lblValorTotalParcelas.AutoSize = true;
            this.lblValorTotalParcelas.Location = new System.Drawing.Point(1083, 625);
            this.lblValorTotalParcelas.Name = "lblValorTotalParcelas";
            this.lblValorTotalParcelas.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotalParcelas.TabIndex = 210;
            this.lblValorTotalParcelas.Text = "0";
            // 
            // lblTotalParcelas
            // 
            this.lblTotalParcelas.AutoSize = true;
            this.lblTotalParcelas.Location = new System.Drawing.Point(921, 625);
            this.lblTotalParcelas.Name = "lblTotalParcelas";
            this.lblTotalParcelas.Size = new System.Drawing.Size(101, 13);
            this.lblTotalParcelas.TabIndex = 211;
            this.lblTotalParcelas.Text = "Total Parcelas (R$):";
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1340, 698);
            this.Controls.Add(this.lblValorTotalParcelas);
            this.Controls.Add(this.lblTotalParcelas);
            this.Controls.Add(this.lblMotivCancelamentoExplicacao);
            this.Controls.Add(this.lblMotivoCancelamentoTitulo);
            this.Controls.Add(this.listVParcelas);
            this.Controls.Add(this.txtValorTotalValores);
            this.Controls.Add(this.lblValorTotalValores);
            this.Controls.Add(this.btnPesquisarCondicaoDePagamento);
            this.Controls.Add(this.btnLimparParcelas);
            this.Controls.Add(this.btnGerarParcelas);
            this.Controls.Add(this.txtCondicaoDePagamento);
            this.Controls.Add(this.lblCondicaoDePagamento);
            this.Controls.Add(this.txtCodCondicaoDePagamento);
            this.Controls.Add(this.lblValorCreditoDisponivel);
            this.Controls.Add(this.lblValorQtdTotalProdutos);
            this.Controls.Add(this.lblValorTotalGeralProdutos);
            this.Controls.Add(this.lblCreditoDisponivelParaOCliente);
            this.Controls.Add(this.lblQtdTotalProdutos);
            this.Controls.Add(this.lblTotalGeralProdutos);
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
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtNumDaNota);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblNumNota);
            this.Controls.Add(this.lblSerie);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroVenda";
            this.Text = "Cadastro de Venda";
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
            this.Controls.SetChildIndex(this.lblFuncionario, 0);
            this.Controls.SetChildIndex(this.lblCliente, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.txtNumDaNota, 0);
            this.Controls.SetChildIndex(this.txtFuncionario, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtCodFuncionario, 0);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFuncionario, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCliente, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
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
            this.Controls.SetChildIndex(this.lblTotalGeralProdutos, 0);
            this.Controls.SetChildIndex(this.lblQtdTotalProdutos, 0);
            this.Controls.SetChildIndex(this.lblCreditoDisponivelParaOCliente, 0);
            this.Controls.SetChildIndex(this.lblValorTotalGeralProdutos, 0);
            this.Controls.SetChildIndex(this.lblValorQtdTotalProdutos, 0);
            this.Controls.SetChildIndex(this.lblValorCreditoDisponivel, 0);
            this.Controls.SetChildIndex(this.txtCodCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.lblCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.txtCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.btnGerarParcelas, 0);
            this.Controls.SetChildIndex(this.btnLimparParcelas, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCondicaoDePagamento, 0);
            this.Controls.SetChildIndex(this.lblValorTotalValores, 0);
            this.Controls.SetChildIndex(this.txtValorTotalValores, 0);
            this.Controls.SetChildIndex(this.listVParcelas, 0);
            this.Controls.SetChildIndex(this.lblMotivoCancelamentoTitulo, 0);
            this.Controls.SetChildIndex(this.lblMotivCancelamentoExplicacao, 0);
            this.Controls.SetChildIndex(this.lblTotalParcelas, 0);
            this.Controls.SetChildIndex(this.lblValorTotalParcelas, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtNumDaNota;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblNumNota;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.ListView listVProdutos;
        private System.Windows.Forms.ColumnHeader clmCodProduto;
        private System.Windows.Forms.ColumnHeader clmProduto;
        private System.Windows.Forms.ColumnHeader clmUnMedida;
        private System.Windows.Forms.ColumnHeader clmQtd;
        private System.Windows.Forms.ColumnHeader clmValorUnitario;
        private System.Windows.Forms.ColumnHeader clmTotal;
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
        private System.Windows.Forms.TextBox txtValorTotalValores;
        private System.Windows.Forms.Label lblValorTotalValores;
        private System.Windows.Forms.Button btnPesquisarCondicaoDePagamento;
        private System.Windows.Forms.Button btnLimparParcelas;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.TextBox txtCondicaoDePagamento;
        private System.Windows.Forms.Label lblCondicaoDePagamento;
        private System.Windows.Forms.TextBox txtCodCondicaoDePagamento;
        private System.Windows.Forms.Label lblValorCreditoDisponivel;
        private System.Windows.Forms.Label lblValorQtdTotalProdutos;
        private System.Windows.Forms.Label lblValorTotalGeralProdutos;
        private System.Windows.Forms.Label lblCreditoDisponivelParaOCliente;
        private System.Windows.Forms.Label lblQtdTotalProdutos;
        private System.Windows.Forms.Label lblTotalGeralProdutos;
        private System.Windows.Forms.ListView listVParcelas;
        private System.Windows.Forms.ColumnHeader clmNumParcela;
        private System.Windows.Forms.ColumnHeader clmDataEmissao;
        private System.Windows.Forms.ColumnHeader clmDataVencimento;
        private System.Windows.Forms.ColumnHeader clmValorParcela;
        private System.Windows.Forms.ColumnHeader clmFormaPagamento;
        private System.Windows.Forms.Label lblMotivCancelamentoExplicacao;
        private System.Windows.Forms.Label lblMotivoCancelamentoTitulo;
        private System.Windows.Forms.Label lblValorTotalParcelas;
        private System.Windows.Forms.Label lblTotalParcelas;
    }
}
