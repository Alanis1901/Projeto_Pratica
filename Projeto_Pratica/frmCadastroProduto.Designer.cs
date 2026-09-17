namespace Projeto_Pratica
{
    partial class frmCadastroProduto
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
            this.txtCodUnidadeDeMedida = new System.Windows.Forms.TextBox();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.txtCodMarca = new System.Windows.Forms.TextBox();
            this.lblPorcentagemLucro = new System.Windows.Forms.Label();
            this.lblPrecoDeCustoAnterior = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.txtPorcentagemLucro = new System.Windows.Forms.TextBox();
            this.txtValorCompraAnterior = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnPesquisarUnidadeMedida = new System.Windows.Forms.Button();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.btnPesquisarMarca = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnPesquisarCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.btnRemoverFornecedor = new System.Windows.Forms.Button();
            this.btnAdicionarFornecedor = new System.Windows.Forms.Button();
            this.listVFornecedores = new System.Windows.Forms.ListView();
            this.clmCodFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNomeRazaoSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 622);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 643);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 666);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1152, 644);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.Location = new System.Drawing.Point(1287, 13);
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 622);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 643);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 666);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1245, 646);
            // 
            // txtCodUnidadeDeMedida
            // 
            this.txtCodUnidadeDeMedida.Location = new System.Drawing.Point(14, 366);
            this.txtCodUnidadeDeMedida.Name = "txtCodUnidadeDeMedida";
            this.txtCodUnidadeDeMedida.ReadOnly = true;
            this.txtCodUnidadeDeMedida.ShortcutsEnabled = false;
            this.txtCodUnidadeDeMedida.Size = new System.Drawing.Size(60, 20);
            this.txtCodUnidadeDeMedida.TabIndex = 161;
            this.txtCodUnidadeDeMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(14, 313);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.ReadOnly = true;
            this.txtCodCategoria.ShortcutsEnabled = false;
            this.txtCodCategoria.Size = new System.Drawing.Size(60, 20);
            this.txtCodCategoria.TabIndex = 160;
            this.txtCodCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Location = new System.Drawing.Point(14, 255);
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.ReadOnly = true;
            this.txtCodMarca.ShortcutsEnabled = false;
            this.txtCodMarca.Size = new System.Drawing.Size(60, 20);
            this.txtCodMarca.TabIndex = 159;
            this.txtCodMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPorcentagemLucro
            // 
            this.lblPorcentagemLucro.AutoSize = true;
            this.lblPorcentagemLucro.Location = new System.Drawing.Point(238, 442);
            this.lblPorcentagemLucro.Name = "lblPorcentagemLucro";
            this.lblPorcentagemLucro.Size = new System.Drawing.Size(114, 13);
            this.lblPorcentagemLucro.TabIndex = 156;
            this.lblPorcentagemLucro.Text = "Margem de Lucro (%) *";
            // 
            // lblPrecoDeCustoAnterior
            // 
            this.lblPrecoDeCustoAnterior.AutoSize = true;
            this.lblPrecoDeCustoAnterior.Location = new System.Drawing.Point(238, 498);
            this.lblPrecoDeCustoAnterior.Name = "lblPrecoDeCustoAnterior";
            this.lblPrecoDeCustoAnterior.Size = new System.Drawing.Size(142, 13);
            this.lblPrecoDeCustoAnterior.TabIndex = 158;
            this.lblPrecoDeCustoAnterior.Text = "Preço de Custo Anterior (R$)";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(464, 442);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(114, 13);
            this.lblValorVenda.TabIndex = 157;
            this.lblValorVenda.Text = "Preço de Venda (R$) *";
            // 
            // txtPorcentagemLucro
            // 
            this.txtPorcentagemLucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagemLucro.Location = new System.Drawing.Point(241, 461);
            this.txtPorcentagemLucro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPorcentagemLucro.Name = "txtPorcentagemLucro";
            this.txtPorcentagemLucro.ReadOnly = true;
            this.txtPorcentagemLucro.ShortcutsEnabled = false;
            this.txtPorcentagemLucro.Size = new System.Drawing.Size(194, 20);
            this.txtPorcentagemLucro.TabIndex = 144;
            this.txtPorcentagemLucro.Text = "0";
            this.txtPorcentagemLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorCompraAnterior
            // 
            this.txtValorCompraAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorCompraAnterior.Location = new System.Drawing.Point(241, 517);
            this.txtValorCompraAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorCompraAnterior.Name = "txtValorCompraAnterior";
            this.txtValorCompraAnterior.ReadOnly = true;
            this.txtValorCompraAnterior.ShortcutsEnabled = false;
            this.txtValorCompraAnterior.Size = new System.Drawing.Size(194, 20);
            this.txtValorCompraAnterior.TabIndex = 147;
            this.txtValorCompraAnterior.Text = "0";
            this.txtValorCompraAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorVenda.Location = new System.Drawing.Point(467, 461);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.ShortcutsEnabled = false;
            this.txtValorVenda.Size = new System.Drawing.Size(194, 20);
            this.txtValorVenda.TabIndex = 145;
            this.txtValorVenda.Text = "0";
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(11, 442);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(103, 13);
            this.lblValorCompra.TabIndex = 154;
            this.lblValorCompra.Text = "Preço de Custo (R$)";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(11, 498);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 155;
            this.lblEstoque.Text = "Estoque ";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorCompra.Location = new System.Drawing.Point(14, 461);
            this.txtValorCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.ReadOnly = true;
            this.txtValorCompra.ShortcutsEnabled = false;
            this.txtValorCompra.Size = new System.Drawing.Size(194, 20);
            this.txtValorCompra.TabIndex = 143;
            this.txtValorCompra.Text = "0";
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstoque
            // 
            this.txtEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstoque.Location = new System.Drawing.Point(14, 517);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.ShortcutsEnabled = false;
            this.txtEstoque.Size = new System.Drawing.Size(194, 20);
            this.txtEstoque.TabIndex = 146;
            this.txtEstoque.Text = "0";
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPesquisarUnidadeMedida
            // 
            this.btnPesquisarUnidadeMedida.Location = new System.Drawing.Point(190, 361);
            this.btnPesquisarUnidadeMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarUnidadeMedida.Name = "btnPesquisarUnidadeMedida";
            this.btnPesquisarUnidadeMedida.Size = new System.Drawing.Size(85, 28);
            this.btnPesquisarUnidadeMedida.TabIndex = 142;
            this.btnPesquisarUnidadeMedida.Text = "Pesquisar";
            this.btnPesquisarUnidadeMedida.UseVisualStyleBackColor = true;
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(80, 366);
            this.txtUnidadeMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.ReadOnly = true;
            this.txtUnidadeMedida.ShortcutsEnabled = false;
            this.txtUnidadeMedida.Size = new System.Drawing.Size(104, 20);
            this.txtUnidadeMedida.TabIndex = 141;
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Location = new System.Drawing.Point(11, 345);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(107, 13);
            this.lblUnidadeMedida.TabIndex = 153;
            this.lblUnidadeMedida.Text = "Unidade de Medida *";
            // 
            // btnPesquisarMarca
            // 
            this.btnPesquisarMarca.Location = new System.Drawing.Point(431, 250);
            this.btnPesquisarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarMarca.Name = "btnPesquisarMarca";
            this.btnPesquisarMarca.Size = new System.Drawing.Size(92, 28);
            this.btnPesquisarMarca.TabIndex = 138;
            this.btnPesquisarMarca.Text = "Pesquisar";
            this.btnPesquisarMarca.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(80, 255);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.ShortcutsEnabled = false;
            this.txtMarca.Size = new System.Drawing.Size(345, 20);
            this.txtMarca.TabIndex = 137;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(11, 236);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 13);
            this.lblMarca.TabIndex = 152;
            this.lblMarca.Text = "Marca *";
            // 
            // btnPesquisarCategoria
            // 
            this.btnPesquisarCategoria.Location = new System.Drawing.Point(431, 308);
            this.btnPesquisarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarCategoria.Name = "btnPesquisarCategoria";
            this.btnPesquisarCategoria.Size = new System.Drawing.Size(92, 28);
            this.btnPesquisarCategoria.TabIndex = 140;
            this.btnPesquisarCategoria.Text = "Pesquisar";
            this.btnPesquisarCategoria.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Location = new System.Drawing.Point(80, 313);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.ShortcutsEnabled = false;
            this.txtCategoria.Size = new System.Drawing.Size(345, 20);
            this.txtCategoria.TabIndex = 139;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 294);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(59, 13);
            this.lblCategoria.TabIndex = 151;
            this.lblCategoria.Text = "Categoria *";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(14, 185);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.MaxLength = 40;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ShortcutsEnabled = false;
            this.txtDescricao.Size = new System.Drawing.Size(647, 35);
            this.txtDescricao.TabIndex = 136;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(11, 166);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 150;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(14, 134);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(647, 20);
            this.txtNome.TabIndex = 135;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 115);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 13);
            this.lblNome.TabIndex = 149;
            this.lblNome.Text = "Produto *";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarras.Location = new System.Drawing.Point(14, 85);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodBarras.MaxLength = 40;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.ShortcutsEnabled = false;
            this.txtCodBarras.Size = new System.Drawing.Size(254, 20);
            this.txtCodBarras.TabIndex = 134;
            this.txtCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(11, 66);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(95, 13);
            this.lblCodBarras.TabIndex = 148;
            this.lblCodBarras.Text = "Código de Barras *";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(713, 83);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.ReadOnly = true;
            this.txtCodFornecedor.ShortcutsEnabled = false;
            this.txtCodFornecedor.Size = new System.Drawing.Size(60, 20);
            this.txtCodFornecedor.TabIndex = 168;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoverFornecedor
            // 
            this.btnRemoverFornecedor.Location = new System.Drawing.Point(1242, 80);
            this.btnRemoverFornecedor.Name = "btnRemoverFornecedor";
            this.btnRemoverFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverFornecedor.TabIndex = 165;
            this.btnRemoverFornecedor.Text = "Remover";
            this.btnRemoverFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(1162, 80);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(74, 23);
            this.btnAdicionarFornecedor.TabIndex = 164;
            this.btnAdicionarFornecedor.Text = "Adicionar ";
            this.btnAdicionarFornecedor.UseVisualStyleBackColor = true;
            // 
            // listVFornecedores
            // 
            this.listVFornecedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodFornecedor,
            this.clmNomeRazaoSocial,
            this.clmTipo});
            this.listVFornecedores.FullRowSelect = true;
            this.listVFornecedores.GridLines = true;
            this.listVFornecedores.HideSelection = false;
            this.listVFornecedores.Location = new System.Drawing.Point(713, 113);
            this.listVFornecedores.Name = "listVFornecedores";
            this.listVFornecedores.Size = new System.Drawing.Size(604, 194);
            this.listVFornecedores.TabIndex = 167;
            this.listVFornecedores.UseCompatibleStateImageBehavior = false;
            this.listVFornecedores.View = System.Windows.Forms.View.Details;
            // 
            // clmCodFornecedor
            // 
            this.clmCodFornecedor.Text = "Cód. Fornecedor";
            this.clmCodFornecedor.Width = 100;
            // 
            // clmNomeRazaoSocial
            // 
            this.clmNomeRazaoSocial.Text = "Nome/Razão Social";
            this.clmNomeRazaoSocial.Width = 200;
            // 
            // clmTipo
            // 
            this.clmTipo.Text = "Tipo";
            this.clmTipo.Width = 100;
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(1049, 82);
            this.btnPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(90, 21);
            this.btnPesquisarFornecedor.TabIndex = 163;
            this.btnPesquisarFornecedor.Text = "Pesquisar";
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(779, 83);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.ShortcutsEnabled = false;
            this.txtFornecedor.Size = new System.Drawing.Size(264, 20);
            this.txtFornecedor.TabIndex = 162;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(710, 64);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(72, 13);
            this.lblFornecedor.TabIndex = 166;
            this.lblFornecedor.Text = "Fornecedores";
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1344, 689);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnRemoverFornecedor);
            this.Controls.Add(this.btnAdicionarFornecedor);
            this.Controls.Add(this.listVFornecedores);
            this.Controls.Add(this.btnPesquisarFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtCodUnidadeDeMedida);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.txtCodMarca);
            this.Controls.Add(this.lblPorcentagemLucro);
            this.Controls.Add(this.lblPrecoDeCustoAnterior);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.txtPorcentagemLucro);
            this.Controls.Add(this.txtValorCompraAnterior);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnPesquisarUnidadeMedida);
            this.Controls.Add(this.txtUnidadeMedida);
            this.Controls.Add(this.lblUnidadeMedida);
            this.Controls.Add(this.btnPesquisarMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnPesquisarCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.lblCodBarras);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produto";
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
            this.Controls.SetChildIndex(this.lblCodBarras, 0);
            this.Controls.SetChildIndex(this.txtCodBarras, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.lblCategoria, 0);
            this.Controls.SetChildIndex(this.txtCategoria, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCategoria, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.btnPesquisarMarca, 0);
            this.Controls.SetChildIndex(this.lblUnidadeMedida, 0);
            this.Controls.SetChildIndex(this.txtUnidadeMedida, 0);
            this.Controls.SetChildIndex(this.btnPesquisarUnidadeMedida, 0);
            this.Controls.SetChildIndex(this.txtEstoque, 0);
            this.Controls.SetChildIndex(this.txtValorCompra, 0);
            this.Controls.SetChildIndex(this.lblEstoque, 0);
            this.Controls.SetChildIndex(this.lblValorCompra, 0);
            this.Controls.SetChildIndex(this.txtValorVenda, 0);
            this.Controls.SetChildIndex(this.txtValorCompraAnterior, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemLucro, 0);
            this.Controls.SetChildIndex(this.lblValorVenda, 0);
            this.Controls.SetChildIndex(this.lblPrecoDeCustoAnterior, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemLucro, 0);
            this.Controls.SetChildIndex(this.txtCodMarca, 0);
            this.Controls.SetChildIndex(this.txtCodCategoria, 0);
            this.Controls.SetChildIndex(this.txtCodUnidadeDeMedida, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFornecedor, 0);
            this.Controls.SetChildIndex(this.listVFornecedores, 0);
            this.Controls.SetChildIndex(this.btnAdicionarFornecedor, 0);
            this.Controls.SetChildIndex(this.btnRemoverFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodUnidadeDeMedida;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.TextBox txtCodMarca;
        private System.Windows.Forms.Label lblPorcentagemLucro;
        private System.Windows.Forms.Label lblPrecoDeCustoAnterior;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.TextBox txtPorcentagemLucro;
        private System.Windows.Forms.TextBox txtValorCompraAnterior;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnPesquisarUnidadeMedida;
        private System.Windows.Forms.TextBox txtUnidadeMedida;
        private System.Windows.Forms.Label lblUnidadeMedida;
        private System.Windows.Forms.Button btnPesquisarMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnPesquisarCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Button btnRemoverFornecedor;
        private System.Windows.Forms.Button btnAdicionarFornecedor;
        private System.Windows.Forms.ListView listVFornecedores;
        private System.Windows.Forms.ColumnHeader clmCodFornecedor;
        private System.Windows.Forms.ColumnHeader clmNomeRazaoSocial;
        private System.Windows.Forms.ColumnHeader clmTipo;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
    }
}
