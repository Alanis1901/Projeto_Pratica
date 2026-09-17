namespace Projeto_Pratica
{
    partial class frmConsultaProduto
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
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCodBarras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEstoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCodBarras,
            this.clmMarca,
            this.clmCategoria,
            this.clmValorVenda,
            this.clmEstoque,
            this.clmAtivo});
            this.listV.Size = new System.Drawing.Size(1320, 551);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1155, 643);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1069, 643);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(983, 643);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1241, 644);
            // 
            // clmNome
            // 
            this.clmNome.Text = "Produto";
            this.clmNome.Width = 250;
            // 
            // clmCodBarras
            // 
            this.clmCodBarras.Text = "Código de Barras";
            this.clmCodBarras.Width = 150;
            // 
            // clmMarca
            // 
            this.clmMarca.Text = "Marca";
            this.clmMarca.Width = 150;
            // 
            // clmCategoria
            // 
            this.clmCategoria.Text = "Categoria";
            this.clmCategoria.Width = 150;
            // 
            // clmValorVenda
            // 
            this.clmValorVenda.Text = "Valor de Venda";
            this.clmValorVenda.Width = 120;
            // 
            // clmEstoque
            // 
            this.clmEstoque.Text = "Estoque";
            this.clmEstoque.Width = 80;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Ativo";
            this.clmAtivo.Width = 100;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1344, 689);
            this.Name = "frmConsultaProduto";
            this.Text = "Consulta de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCodBarras;
        private System.Windows.Forms.ColumnHeader clmMarca;
        private System.Windows.Forms.ColumnHeader clmCategoria;
        private System.Windows.Forms.ColumnHeader clmValorVenda;
        private System.Windows.Forms.ColumnHeader clmEstoque;
        private System.Windows.Forms.ColumnHeader clmAtivo;
    }
}
