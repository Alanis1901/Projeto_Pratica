namespace Projeto_Pratica
{
    partial class frmConsultaVenda
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
            this.clmIdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIdFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.clmIdCliente,
            this.clmCliente,
            this.clmIdFuncionario,
            this.clmFuncionario,
            this.clmSerie,
            this.clmNumNota,
            this.clmDataEmissao,
            this.clmValorTotal,
            this.clmCondicaoPagamento,
            this.clmAtivo,
            this.clmMotivoCancelamento,
            this.clmDataCancelamento});
            this.listV.Size = new System.Drawing.Size(1320, 552);
            // 
            // clmCod
            // 
            this.clmCod.Text = "Modelo";
            this.clmCod.Width = 80;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1155, 644);
            this.btnExcluir.Text = "Cancelar Nota";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1069, 644);
            this.btnAlterar.Text = "Visualizar";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(983, 644);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1241, 644);
            // 
            // clmIdCliente
            // 
            this.clmIdCliente.Text = "Cód. Cliente";
            this.clmIdCliente.Width = 100;
            // 
            // clmCliente
            // 
            this.clmCliente.Text = "Cliente";
            this.clmCliente.Width = 250;
            // 
            // clmIdFuncionario
            // 
            this.clmIdFuncionario.Text = "Cód. Funcionário";
            this.clmIdFuncionario.Width = 100;
            // 
            // clmFuncionario
            // 
            this.clmFuncionario.Text = "Funcionário";
            this.clmFuncionario.Width = 250;
            // 
            // clmSerie
            // 
            this.clmSerie.Text = "Série";
            this.clmSerie.Width = 80;
            // 
            // clmNumNota
            // 
            this.clmNumNota.Text = "Nº  Nota";
            this.clmNumNota.Width = 150;
            // 
            // clmDataEmissao
            // 
            this.clmDataEmissao.Text = "Data Emissão";
            this.clmDataEmissao.Width = 120;
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
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1344, 689);
            this.Name = "frmConsultaVenda";
            this.Text = "Consulta de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmIdCliente;
        private System.Windows.Forms.ColumnHeader clmCliente;
        private System.Windows.Forms.ColumnHeader clmIdFuncionario;
        private System.Windows.Forms.ColumnHeader clmFuncionario;
        private System.Windows.Forms.ColumnHeader clmSerie;
        private System.Windows.Forms.ColumnHeader clmNumNota;
        private System.Windows.Forms.ColumnHeader clmDataEmissao;
        private System.Windows.Forms.ColumnHeader clmValorTotal;
        private System.Windows.Forms.ColumnHeader clmCondicaoPagamento;
        private System.Windows.Forms.ColumnHeader clmAtivo;
        private System.Windows.Forms.ColumnHeader clmMotivoCancelamento;
        private System.Windows.Forms.ColumnHeader clmDataCancelamento;
    }
}
