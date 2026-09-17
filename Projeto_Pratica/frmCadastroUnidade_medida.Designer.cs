namespace Projeto_Pratica
{
    partial class frmCadastroUnidade_medida
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
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 347);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 368);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 391);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(565, 366);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.Location = new System.Drawing.Point(687, 26);
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 347);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 368);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 391);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(658, 368);
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Location = new System.Drawing.Point(15, 146);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSigla.MaxLength = 40;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.ShortcutsEnabled = false;
            this.txtSigla.Size = new System.Drawing.Size(155, 20);
            this.txtSigla.TabIndex = 106;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(12, 127);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(37, 13);
            this.lblSigla.TabIndex = 107;
            this.lblSigla.Text = "Sigla *";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(15, 85);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(411, 20);
            this.txtNome.TabIndex = 105;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(107, 13);
            this.lblNome.TabIndex = 108;
            this.lblNome.Text = "Unidade de Medida *";
            // 
            // frmCadastroUnidade_medida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(755, 416);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroUnidade_medida";
            this.Text = "Cadastro de Unidade de Medida";
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
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}
