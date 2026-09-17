namespace Projeto_Pratica
{
    partial class frmCadastroFornecedor
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
            this.txtCodCondicaoPagamento = new System.Windows.Forms.TextBox();
            this.btnPesquisarCondicaoPagamento = new System.Windows.Forms.Button();
            this.txtCondicaoPagamento = new System.Windows.Forms.TextBox();
            this.lblCondicaoPagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.Location = new System.Drawing.Point(318, 158);
            this.btnPesquisarCidade.Size = new System.Drawing.Size(87, 25);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 541);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 562);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 585);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(904, 568);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.Location = new System.Drawing.Point(1038, 11);
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(145, 537);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(156, 558);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(161, 582);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(997, 570);
            // 
            // txtCodCondicaoPagamento
            // 
            this.txtCodCondicaoPagamento.Location = new System.Drawing.Point(21, 398);
            this.txtCodCondicaoPagamento.Name = "txtCodCondicaoPagamento";
            this.txtCodCondicaoPagamento.ReadOnly = true;
            this.txtCodCondicaoPagamento.ShortcutsEnabled = false;
            this.txtCodCondicaoPagamento.Size = new System.Drawing.Size(60, 20);
            this.txtCodCondicaoPagamento.TabIndex = 198;
            this.txtCodCondicaoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPesquisarCondicaoPagamento
            // 
            this.btnPesquisarCondicaoPagamento.Location = new System.Drawing.Point(317, 397);
            this.btnPesquisarCondicaoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarCondicaoPagamento.Name = "btnPesquisarCondicaoPagamento";
            this.btnPesquisarCondicaoPagamento.Size = new System.Drawing.Size(87, 22);
            this.btnPesquisarCondicaoPagamento.TabIndex = 196;
            this.btnPesquisarCondicaoPagamento.Text = "Pesquisar";
            this.btnPesquisarCondicaoPagamento.UseVisualStyleBackColor = true;
            // 
            // txtCondicaoPagamento
            // 
            this.txtCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicaoPagamento.Location = new System.Drawing.Point(88, 398);
            this.txtCondicaoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondicaoPagamento.Name = "txtCondicaoPagamento";
            this.txtCondicaoPagamento.ReadOnly = true;
            this.txtCondicaoPagamento.ShortcutsEnabled = false;
            this.txtCondicaoPagamento.Size = new System.Drawing.Size(224, 20);
            this.txtCondicaoPagamento.TabIndex = 195;
            // 
            // lblCondicaoPagamento
            // 
            this.lblCondicaoPagamento.AutoSize = true;
            this.lblCondicaoPagamento.Location = new System.Drawing.Point(18, 379);
            this.lblCondicaoPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondicaoPagamento.Name = "lblCondicaoPagamento";
            this.lblCondicaoPagamento.Size = new System.Drawing.Size(131, 13);
            this.lblCondicaoPagamento.TabIndex = 197;
            this.lblCondicaoPagamento.Text = "Condição de Pagamento *";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1099, 609);
            this.Controls.Add(this.txtCodCondicaoPagamento);
            this.Controls.Add(this.btnPesquisarCondicaoPagamento);
            this.Controls.Add(this.txtCondicaoPagamento);
            this.Controls.Add(this.lblCondicaoPagamento);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Controls.SetChildIndex(this.checkBoxAtivo, 0);
            this.Controls.SetChildIndex(this.lblDataCadastroData, 0);
            this.Controls.SetChildIndex(this.lblDataUltimaEdicaoData, 0);
            this.Controls.SetChildIndex(this.lblUltimoUsuarioQueEditouNome, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltimaEdicao, 0);
            this.Controls.SetChildIndex(this.lblUltimoUsuarioQueEditou, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.comboBoxTipo, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtApelidoNomeFantasia, 0);
            this.Controls.SetChildIndex(this.txtNomeRazaoSocial, 0);
            this.Controls.SetChildIndex(this.lblApelido, 0);
            this.Controls.SetChildIndex(this.lblGenero, 0);
            this.Controls.SetChildIndex(this.comboBoxGenero, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCidade, 0);
            this.Controls.SetChildIndex(this.txtCodCidade, 0);
            this.Controls.SetChildIndex(this.lblEndereco, 0);
            this.Controls.SetChildIndex(this.txtEndereco, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtNumeroEndereco, 0);
            this.Controls.SetChildIndex(this.lblNumeroEndereco, 0);
            this.Controls.SetChildIndex(this.lblBairro, 0);
            this.Controls.SetChildIndex(this.txtBairro, 0);
            this.Controls.SetChildIndex(this.lblCep, 0);
            this.Controls.SetChildIndex(this.txtCep, 0);
            this.Controls.SetChildIndex(this.txtComplementoEndereco, 0);
            this.Controls.SetChildIndex(this.lblComplementoEndereco, 0);
            this.Controls.SetChildIndex(this.lblRg, 0);
            this.Controls.SetChildIndex(this.lblDataNascimento, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.lblCpf, 0);
            this.Controls.SetChildIndex(this.txtCpfCnpj, 0);
            this.Controls.SetChildIndex(this.txtRgInscEstadual, 0);
            this.Controls.SetChildIndex(this.lblTelefone, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.dtpDataNascimentoCriacao, 0);
            this.Controls.SetChildIndex(this.lblCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.txtCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.txtCodCondicaoPagamento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodCondicaoPagamento;
        private System.Windows.Forms.Button btnPesquisarCondicaoPagamento;
        private System.Windows.Forms.TextBox txtCondicaoPagamento;
        private System.Windows.Forms.Label lblCondicaoPagamento;
    }
}
