namespace Projeto_Pratica
{
    partial class frmConsultaFormaPagamento
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
            this.clmDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDescricao,
            this.clmAtivo});
            this.listV.Size = new System.Drawing.Size(636, 384);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(471, 478);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(385, 478);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(299, 478);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(557, 478);
            // 
            // clmDescricao
            // 
            this.clmDescricao.Text = "Forma de Pagamento";
            this.clmDescricao.Width = 200;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Ativo";
            this.clmAtivo.Width = 100;
            // 
            // frmConsultaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(673, 525);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmConsultaFormaPagamento";
            this.Text = "Consulta de Forma de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmDescricao;
        private System.Windows.Forms.ColumnHeader clmAtivo;
    }
}
