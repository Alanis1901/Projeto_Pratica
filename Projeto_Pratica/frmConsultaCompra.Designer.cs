namespace Projeto_Pratica
{
    partial class frmConsultaCompra
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
            this.clmSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIdFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataEntrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCondicaoPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMotivoCancelamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataCancelamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSerie,
            this.clmNumNota,
            this.clmIdFornecedor,
            this.clmFornecedor,
            this.clmDataEmissao,
            this.clmDataEntrega,
            this.clmValorTotal,
            this.clmCondicaoPagamento,
            this.clmAtivo,
            this.clmMotivoCancelamento,
            this.clmDataCancelamento});
            this.listV.Size = new System.Drawing.Size(1437, 550);
            // 
            // clmCod
            // 
            this.clmCod.Width = 80;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1272, 644);
            this.btnExcluir.Text = "Cancelar Nota";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1186, 644);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(1100, 644);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1358, 644);
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
            // clmDataEmissao
            // 
            this.clmDataEmissao.Text = "Data Emissão";
            this.clmDataEmissao.Width = 120;
            // 
            // clmDataEntrega
            // 
            this.clmDataEntrega.Text = "Data Entrega";
            this.clmDataEntrega.Width = 120;
            // 
            // clmValorTotal
            // 
            this.clmValorTotal.Text = "Valor Total";
            this.clmValorTotal.Width = 100;
            // 
            // clmCondicaoPagamento
            // 
            this.clmCondicaoPagamento.Text = "Condição de Pagamento";
            this.clmCondicaoPagamento.Width = 150;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Status";
            this.clmAtivo.Width = 80;
            // 
            // clmMotivoCancelamento
            // 
            this.clmMotivoCancelamento.Text = "Motivo do Cancelamento";
            this.clmMotivoCancelamento.Width = 500;
            // 
            // clmDataCancelamento
            // 
            this.clmDataCancelamento.Text = "Data Cancelamento";
            this.clmDataCancelamento.Width = 150;
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1479, 689);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmConsultaCompra";
            this.Text = "Consulta de Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmSerie;
        private System.Windows.Forms.ColumnHeader clmNumNota;
        private System.Windows.Forms.ColumnHeader clmIdFornecedor;
        private System.Windows.Forms.ColumnHeader clmFornecedor;
        private System.Windows.Forms.ColumnHeader clmDataEmissao;
        private System.Windows.Forms.ColumnHeader clmDataEntrega;
        private System.Windows.Forms.ColumnHeader clmValorTotal;
        private System.Windows.Forms.ColumnHeader clmCondicaoPagamento;
        private System.Windows.Forms.ColumnHeader clmAtivo;
        private System.Windows.Forms.ColumnHeader clmMotivoCancelamento;
        private System.Windows.Forms.ColumnHeader clmDataCancelamento;
    }
}
