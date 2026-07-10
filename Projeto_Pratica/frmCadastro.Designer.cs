namespace Projeto_Pratica
{
    partial class frmCadastro
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
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblDataUltimaEdicao = new System.Windows.Forms.Label();
            this.lblUltimoUsuarioQueEditou = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.lblDataCadastroData = new System.Windows.Forms.Label();
            this.lblDataUltimaEdicaoData = new System.Windows.Forms.Label();
            this.lblUltimoUsuarioQueEditouNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 384);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(93, 13);
            this.lblDataCadastro.TabIndex = 4;
            this.lblDataCadastro.Text = "Data de Cadastro:";
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.AutoSize = true;
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 405);
            this.lblDataUltimaEdicao.Name = "lblDataUltimaEdicao";
            this.lblDataUltimaEdicao.Size = new System.Drawing.Size(116, 13);
            this.lblDataUltimaEdicao.TabIndex = 5;
            this.lblDataUltimaEdicao.Text = "Data da Última Edição:";
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.AutoSize = true;
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 428);
            this.lblUltimoUsuarioQueEditou.Name = "lblUltimoUsuarioQueEditou";
            this.lblUltimoUsuarioQueEditou.Size = new System.Drawing.Size(132, 13);
            this.lblUltimoUsuarioQueEditou.TabIndex = 6;
            this.lblUltimoUsuarioQueEditou.Text = "Último Usuário que Editou:";
            this.lblUltimoUsuarioQueEditou.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 9);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 8;
            this.lblCod.Text = "Código";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Checked = true;
            this.checkBoxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAtivo.Location = new System.Drawing.Point(738, 26);
            this.checkBoxAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAtivo.TabIndex = 101;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.AutoSize = true;
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 384);
            this.lblDataCadastroData.Name = "lblDataCadastroData";
            this.lblDataCadastroData.Size = new System.Drawing.Size(10, 13);
            this.lblDataCadastroData.TabIndex = 102;
            this.lblDataCadastroData.Text = "-";
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.AutoSize = true;
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 405);
            this.lblDataUltimaEdicaoData.Name = "lblDataUltimaEdicaoData";
            this.lblDataUltimaEdicaoData.Size = new System.Drawing.Size(10, 13);
            this.lblDataUltimaEdicaoData.TabIndex = 103;
            this.lblDataUltimaEdicaoData.Text = "-";
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.AutoSize = true;
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 428);
            this.lblUltimoUsuarioQueEditouNome.Name = "lblUltimoUsuarioQueEditouNome";
            this.lblUltimoUsuarioQueEditouNome.Size = new System.Drawing.Size(10, 13);
            this.lblUltimoUsuarioQueEditouNome.TabIndex = 104;
            this.lblUltimoUsuarioQueEditouNome.Text = "-";
            this.lblUltimoUsuarioQueEditouNome.Visible = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUltimoUsuarioQueEditouNome);
            this.Controls.Add(this.lblDataUltimaEdicaoData);
            this.Controls.Add(this.lblDataCadastroData);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUltimoUsuarioQueEditou);
            this.Controls.Add(this.lblDataUltimaEdicao);
            this.Controls.Add(this.lblDataCadastro);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDataCadastro;
        public System.Windows.Forms.Label lblDataUltimaEdicao;
        public System.Windows.Forms.Label lblUltimoUsuarioQueEditou;
        public System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.Label lblCod;
        protected System.Windows.Forms.CheckBox checkBoxAtivo;
        public System.Windows.Forms.Label lblDataCadastroData;
        public System.Windows.Forms.Label lblDataUltimaEdicaoData;
        public System.Windows.Forms.Label lblUltimoUsuarioQueEditouNome;
    }
}
