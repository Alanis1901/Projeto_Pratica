namespace Projeto_Pratica
{
    partial class frmConsultaCliente
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
            this.clmNomeRazaoSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCondicaoPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLimiteDeCredito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCpfCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRgInscEstadual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNomeRazaoSocial,
            this.clmTipo,
            this.clmCondicaoPagamento,
            this.clmLimiteDeCredito,
            this.clmCpfCnpj,
            this.clmRgInscEstadual,
            this.clmGenero,
            this.clmCidade,
            this.clmEmail,
            this.clmTelefone,
            this.clmAtivo});
            this.listV.Size = new System.Drawing.Size(1495, 555);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1378, 644);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1292, 644);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(1206, 644);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1464, 644);
            // 
            // clmNomeRazaoSocial
            // 
            this.clmNomeRazaoSocial.Text = "Nome/R. Social";
            this.clmNomeRazaoSocial.Width = 200;
            // 
            // clmTipo
            // 
            this.clmTipo.Text = "Tipo Pessoa";
            this.clmTipo.Width = 100;
            // 
            // clmCondicaoPagamento
            // 
            this.clmCondicaoPagamento.Text = "Condição de Pagamento";
            this.clmCondicaoPagamento.Width = 200;
            // 
            // clmLimiteDeCredito
            // 
            this.clmLimiteDeCredito.Text = "Limite de Crédito";
            this.clmLimiteDeCredito.Width = 130;
            // 
            // clmCpfCnpj
            // 
            this.clmCpfCnpj.Text = "CPF/CNPJ";
            this.clmCpfCnpj.Width = 100;
            // 
            // clmRgInscEstadual
            // 
            this.clmRgInscEstadual.Text = "RG/Insc. Est.";
            this.clmRgInscEstadual.Width = 100;
            // 
            // clmGenero
            // 
            this.clmGenero.Text = "Gênero";
            this.clmGenero.Width = 80;
            // 
            // clmCidade
            // 
            this.clmCidade.Text = "Cidade";
            this.clmCidade.Width = 150;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "E-mail";
            this.clmEmail.Width = 150;
            // 
            // clmTelefone
            // 
            this.clmTelefone.Text = "Telefone";
            this.clmTelefone.Width = 100;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Ativo";
            this.clmAtivo.Width = 100;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1567, 689);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta de Cliente ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmNomeRazaoSocial;
        private System.Windows.Forms.ColumnHeader clmTipo;
        private System.Windows.Forms.ColumnHeader clmCondicaoPagamento;
        private System.Windows.Forms.ColumnHeader clmLimiteDeCredito;
        private System.Windows.Forms.ColumnHeader clmCpfCnpj;
        private System.Windows.Forms.ColumnHeader clmRgInscEstadual;
        private System.Windows.Forms.ColumnHeader clmGenero;
        private System.Windows.Forms.ColumnHeader clmCidade;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmTelefone;
        private System.Windows.Forms.ColumnHeader clmAtivo;
    }
}
