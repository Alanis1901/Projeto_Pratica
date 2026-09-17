namespace Projeto_Pratica
{
    partial class frmCadastroCliente
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
            this.checkBoxLimiteDeCredito = new System.Windows.Forms.CheckBox();
            this.txtLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.lblLimiteDeCredito = new System.Windows.Forms.Label();
            this.btnPesquisarCondicaoPagamento = new System.Windows.Forms.Button();
            this.txtCondicaoPagamento = new System.Windows.Forms.TextBox();
            this.lblCondicaoPagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(146, 470);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(157, 491);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(162, 514);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // txtCodCondicaoPagamento
            // 
            this.txtCodCondicaoPagamento.Location = new System.Drawing.Point(20, 393);
            this.txtCodCondicaoPagamento.Name = "txtCodCondicaoPagamento";
            this.txtCodCondicaoPagamento.ReadOnly = true;
            this.txtCodCondicaoPagamento.ShortcutsEnabled = false;
            this.txtCodCondicaoPagamento.Size = new System.Drawing.Size(60, 20);
            this.txtCodCondicaoPagamento.TabIndex = 201;
            this.txtCodCondicaoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxLimiteDeCredito
            // 
            this.checkBoxLimiteDeCredito.AutoSize = true;
            this.checkBoxLimiteDeCredito.Location = new System.Drawing.Point(421, 395);
            this.checkBoxLimiteDeCredito.Name = "checkBoxLimiteDeCredito";
            this.checkBoxLimiteDeCredito.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLimiteDeCredito.TabIndex = 197;
            this.checkBoxLimiteDeCredito.UseVisualStyleBackColor = true;
            // 
            // txtLimiteDeCredito
            // 
            this.txtLimiteDeCredito.Location = new System.Drawing.Point(444, 394);
            this.txtLimiteDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimiteDeCredito.Name = "txtLimiteDeCredito";
            this.txtLimiteDeCredito.ShortcutsEnabled = false;
            this.txtLimiteDeCredito.Size = new System.Drawing.Size(183, 20);
            this.txtLimiteDeCredito.TabIndex = 198;
            this.txtLimiteDeCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLimiteDeCredito
            // 
            this.lblLimiteDeCredito.AutoSize = true;
            this.lblLimiteDeCredito.Location = new System.Drawing.Point(418, 374);
            this.lblLimiteDeCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimiteDeCredito.Name = "lblLimiteDeCredito";
            this.lblLimiteDeCredito.Size = new System.Drawing.Size(108, 13);
            this.lblLimiteDeCredito.TabIndex = 200;
            this.lblLimiteDeCredito.Text = "Limite de Crédito (R$)";
            // 
            // btnPesquisarCondicaoPagamento
            // 
            this.btnPesquisarCondicaoPagamento.Location = new System.Drawing.Point(317, 390);
            this.btnPesquisarCondicaoPagamento.Name = "btnPesquisarCondicaoPagamento";
            this.btnPesquisarCondicaoPagamento.Size = new System.Drawing.Size(88, 26);
            this.btnPesquisarCondicaoPagamento.TabIndex = 196;
            this.btnPesquisarCondicaoPagamento.Text = "Pesquisar";
            this.btnPesquisarCondicaoPagamento.UseVisualStyleBackColor = true;
            this.btnPesquisarCondicaoPagamento.Click += new System.EventHandler(this.btnPesquisarCondicaoPagamento_Click);
            // 
            // txtCondicaoPagamento
            // 
            this.txtCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicaoPagamento.Location = new System.Drawing.Point(86, 393);
            this.txtCondicaoPagamento.Name = "txtCondicaoPagamento";
            this.txtCondicaoPagamento.ReadOnly = true;
            this.txtCondicaoPagamento.ShortcutsEnabled = false;
            this.txtCondicaoPagamento.Size = new System.Drawing.Size(225, 20);
            this.txtCondicaoPagamento.TabIndex = 195;
            // 
            // lblCondicaoPagamento
            // 
            this.lblCondicaoPagamento.AutoSize = true;
            this.lblCondicaoPagamento.Location = new System.Drawing.Point(17, 374);
            this.lblCondicaoPagamento.Name = "lblCondicaoPagamento";
            this.lblCondicaoPagamento.Size = new System.Drawing.Size(131, 13);
            this.lblCondicaoPagamento.TabIndex = 199;
            this.lblCondicaoPagamento.Text = "Condição de Pagamento *";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1089, 538);
            this.Controls.Add(this.txtCodCondicaoPagamento);
            this.Controls.Add(this.checkBoxLimiteDeCredito);
            this.Controls.Add(this.txtLimiteDeCredito);
            this.Controls.Add(this.lblLimiteDeCredito);
            this.Controls.Add(this.btnPesquisarCondicaoPagamento);
            this.Controls.Add(this.txtCondicaoPagamento);
            this.Controls.Add(this.lblCondicaoPagamento);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroCliente";
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
            this.Controls.SetChildIndex(this.lblLimiteDeCredito, 0);
            this.Controls.SetChildIndex(this.txtLimiteDeCredito, 0);
            this.Controls.SetChildIndex(this.checkBoxLimiteDeCredito, 0);
            this.Controls.SetChildIndex(this.txtCodCondicaoPagamento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodCondicaoPagamento;
        private System.Windows.Forms.CheckBox checkBoxLimiteDeCredito;
        private System.Windows.Forms.TextBox txtLimiteDeCredito;
        private System.Windows.Forms.Label lblLimiteDeCredito;
        private System.Windows.Forms.Button btnPesquisarCondicaoPagamento;
        private System.Windows.Forms.TextBox txtCondicaoPagamento;
        private System.Windows.Forms.Label lblCondicaoPagamento;
    }
}
