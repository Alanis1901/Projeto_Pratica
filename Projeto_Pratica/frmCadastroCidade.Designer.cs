namespace Projeto_Pratica
{
    partial class frmCadastroCidade
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodEstado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnPesquisarEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Cidade *";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(15, 81);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 58;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(421, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 132);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado *";
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.Location = new System.Drawing.Point(12, 148);
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.ReadOnly = true;
            this.txtCodEstado.ShortcutsEnabled = false;
            this.txtCodEstado.Size = new System.Drawing.Size(60, 20);
            this.txtCodEstado.TabIndex = 166;
            this.txtCodEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(81, 148);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.ShortcutsEnabled = false;
            this.txtEstado.Size = new System.Drawing.Size(355, 20);
            this.txtEstado.TabIndex = 167;
            // 
            // btnPesquisarEstado
            // 
            this.btnPesquisarEstado.Location = new System.Drawing.Point(459, 143);
            this.btnPesquisarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarEstado.Name = "btnPesquisarEstado";
            this.btnPesquisarEstado.Size = new System.Drawing.Size(71, 28);
            this.btnPesquisarEstado.TabIndex = 168;
            this.btnPesquisarEstado.Text = "Pesquisar";
            this.btnPesquisarEstado.UseVisualStyleBackColor = true;
            this.btnPesquisarEstado.Click += new System.EventHandler(this.btnPesquisarEstado_Click_1);
            // 
            // frmCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 444);
            this.Controls.Add(this.btnPesquisarEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "frmCadastroCidade";
            this.Text = "Cadastro de Cidade";
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
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtCodEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnPesquisarEstado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnPesquisarEstado;
    }
}
