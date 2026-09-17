namespace Projeto_Pratica
{
    partial class frmConsultaContasAPagar
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
            this.clmModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIdFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFormaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxFiltroStatus = new System.Windows.Forms.ComboBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnDarBaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmModelo,
            this.clmSerie,
            this.clmNumNota,
            this.clmIdFornecedor,
            this.clmFornecedor,
            this.clmValorParcela,
            this.clmFormaPagamento,
            this.clmDataEmissao,
            this.clmDataVencimento,
            this.clmAtivo});
            this.listV.Size = new System.Drawing.Size(1320, 554);
            // 
            // clmCod
            // 
            this.clmCod.Text = "Num. Parcela";
            this.clmCod.Width = 120;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1155, 644);
            this.btnExcluir.Text = "Cancelar Conta";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1069, 644);
            this.btnAlterar.Text = "Visualizar";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(893, 644);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1241, 644);
            // 
            // clmModelo
            // 
            this.clmModelo.Text = "Modelo";
            this.clmModelo.Width = 80;
            // 
            // clmSerie
            // 
            this.clmSerie.Text = "Série";
            this.clmSerie.Width = 80;
            // 
            // clmNumNota
            // 
            this.clmNumNota.Text = "Nº Nota";
            this.clmNumNota.Width = 150;
            // 
            // clmIdFornecedor
            // 
            this.clmIdFornecedor.Text = "Cód. Fornecedor";
            this.clmIdFornecedor.Width = 100;
            // 
            // clmFornecedor
            // 
            this.clmFornecedor.Text = "Fornecedor";
            this.clmFornecedor.Width = 250;
            // 
            // clmValorParcela
            // 
            this.clmValorParcela.Text = "Valor da Parcela";
            this.clmValorParcela.Width = 100;
            // 
            // clmFormaPagamento
            // 
            this.clmFormaPagamento.Text = "Forma de Pagamento";
            this.clmFormaPagamento.Width = 150;
            // 
            // clmDataEmissao
            // 
            this.clmDataEmissao.Text = "Data Emissão";
            this.clmDataEmissao.Width = 120;
            // 
            // clmDataVencimento
            // 
            this.clmDataVencimento.Text = "Data Vencimento";
            this.clmDataVencimento.Width = 120;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Status";
            this.clmAtivo.Width = 80;
            // 
            // comboBoxFiltroStatus
            // 
            this.comboBoxFiltroStatus.FormattingEnabled = true;
            this.comboBoxFiltroStatus.Items.AddRange(new object[] {
            "Em Aberto",
            "Paga",
            "Vencida",
            "Cancelada",
            "Todas"});
            this.comboBoxFiltroStatus.Location = new System.Drawing.Point(1080, 37);
            this.comboBoxFiltroStatus.Name = "comboBoxFiltroStatus";
            this.comboBoxFiltroStatus.Size = new System.Drawing.Size(252, 21);
            this.comboBoxFiltroStatus.TabIndex = 13;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(1077, 21);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(93, 13);
            this.lblFiltros.TabIndex = 12;
            this.lblFiltros.Text = "Filtros de Parcelas";
            // 
            // btnDarBaixa
            // 
            this.btnDarBaixa.Location = new System.Drawing.Point(983, 643);
            this.btnDarBaixa.Name = "btnDarBaixa";
            this.btnDarBaixa.Size = new System.Drawing.Size(80, 34);
            this.btnDarBaixa.TabIndex = 14;
            this.btnDarBaixa.Text = "Dar Baixa";
            this.btnDarBaixa.UseVisualStyleBackColor = true;
            // 
            // frmConsultaContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1344, 689);
            this.Controls.Add(this.btnDarBaixa);
            this.Controls.Add(this.comboBoxFiltroStatus);
            this.Controls.Add(this.lblFiltros);
            this.Name = "frmConsultaContasAPagar";
            this.Text = "Consulta de Contas a Pagar";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.bntLimparPesquisa, 0);
            this.Controls.SetChildIndex(this.listV, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.lblFiltros, 0);
            this.Controls.SetChildIndex(this.comboBoxFiltroStatus, 0);
            this.Controls.SetChildIndex(this.btnDarBaixa, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmModelo;
        private System.Windows.Forms.ColumnHeader clmSerie;
        private System.Windows.Forms.ColumnHeader clmNumNota;
        private System.Windows.Forms.ColumnHeader clmIdFornecedor;
        private System.Windows.Forms.ColumnHeader clmFornecedor;
        private System.Windows.Forms.ColumnHeader clmValorParcela;
        private System.Windows.Forms.ColumnHeader clmFormaPagamento;
        private System.Windows.Forms.ColumnHeader clmDataEmissao;
        private System.Windows.Forms.ColumnHeader clmDataVencimento;
        private System.Windows.Forms.ColumnHeader clmAtivo;
        private System.Windows.Forms.ComboBox comboBoxFiltroStatus;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnDarBaixa;
    }
}
