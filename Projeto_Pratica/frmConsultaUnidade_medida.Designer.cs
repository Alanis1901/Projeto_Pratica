namespace Projeto_Pratica
{
    partial class frmConsultaUnidade_medida
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
            this.clmSigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmSigla,
            this.clmAtivo});
            this.listV.Size = new System.Drawing.Size(1320, 555);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1155, 644);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1069, 644);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(983, 644);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1241, 644);
            // 
            // clmNome
            // 
            this.clmNome.Text = "Unidade de Medida";
            this.clmNome.Width = 200;
            // 
            // clmSigla
            // 
            this.clmSigla.Text = "Sigla";
            this.clmSigla.Width = 100;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Ativo";
            this.clmAtivo.Width = 100;
            // 
            // frmConsultaUnidade_medida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1344, 689);
            this.Name = "frmConsultaUnidade_medida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmSigla;
        private System.Windows.Forms.ColumnHeader clmAtivo;
    }
}
