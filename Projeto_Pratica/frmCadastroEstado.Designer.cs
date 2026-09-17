namespace Projeto_Pratica
{
    partial class frmCadastroEstado
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnPesquisarPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Estado *";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(12, 87);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 58;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(417, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(9, 134);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "País *";
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(12, 150);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.ReadOnly = true;
            this.txtCodPais.ShortcutsEnabled = false;
            this.txtCodPais.Size = new System.Drawing.Size(60, 20);
            this.txtCodPais.TabIndex = 166;
            this.txtCodPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(78, 150);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.ShortcutsEnabled = false;
            this.txtPais.Size = new System.Drawing.Size(351, 20);
            this.txtPais.TabIndex = 167;
            // 
            // btnPesquisarPais
            // 
            this.btnPesquisarPais.Location = new System.Drawing.Point(465, 150);
            this.btnPesquisarPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarPais.Name = "btnPesquisarPais";
            this.btnPesquisarPais.Size = new System.Drawing.Size(101, 28);
            this.btnPesquisarPais.TabIndex = 168;
            this.btnPesquisarPais.Text = "Pesquisar";
            this.btnPesquisarPais.UseVisualStyleBackColor = true;
            this.btnPesquisarPais.Click += new System.EventHandler(this.btnPesquisarPais_Click_1);
            // 
            // frmCadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 444);
            this.Controls.Add(this.btnPesquisarPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroEstado";
            this.Text = "Cadastro de Estado";
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
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnPesquisarPais;
    }
}
