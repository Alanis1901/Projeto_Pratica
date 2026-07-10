namespace Projeto_Pratica
{
    partial class frmConsultaFuncionario
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
            this.clmMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTurno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCargaHoraria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataAdmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataDemissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMatricula,
            this.clmNome,
            this.clmCargo,
            this.clmSalario,
            this.clmTurno,
            this.clmCargaHoraria,
            this.clmCpf,
            this.clmRg,
            this.clmGenero,
            this.clmCidade,
            this.clmEmail,
            this.clmTelefone,
            this.clmDataAdmissao,
            this.clmDataDemissao,
            this.clmAtivo});
            this.listV.Location = new System.Drawing.Point(12, 71);
            this.listV.Size = new System.Drawing.Size(1652, 385);
            this.listV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmConsultaFuncionario_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1487, 471);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(1401, 471);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(1315, 471);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1573, 471);
            // 
            // clmMatricula
            // 
            this.clmMatricula.Text = "Matrícula";
            this.clmMatricula.Width = 100;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 200;
            // 
            // clmCargo
            // 
            this.clmCargo.Text = "Cargo";
            this.clmCargo.Width = 100;
            // 
            // clmSalario
            // 
            this.clmSalario.Text = "Salário";
            this.clmSalario.Width = 130;
            // 
            // clmTurno
            // 
            this.clmTurno.Text = "Turno";
            this.clmTurno.Width = 100;
            // 
            // clmCargaHoraria
            // 
            this.clmCargaHoraria.Text = "Carga Horária ";
            this.clmCargaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmCargaHoraria.Width = 80;
            // 
            // clmCpf
            // 
            this.clmCpf.Text = "CPF";
            this.clmCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmCpf.Width = 100;
            // 
            // clmRg
            // 
            this.clmRg.Text = "RG";
            this.clmRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmRg.Width = 100;
            // 
            // clmGenero
            // 
            this.clmGenero.Text = "Gênero ";
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
            this.clmEmail.Width = 50;
            // 
            // clmTelefone
            // 
            this.clmTelefone.Text = "Telefone";
            this.clmTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmTelefone.Width = 100;
            // 
            // clmDataAdmissao
            // 
            this.clmDataAdmissao.Text = "Admissão";
            this.clmDataAdmissao.Width = 80;
            // 
            // clmDataDemissao
            // 
            this.clmDataDemissao.Text = "Demissão";
            this.clmDataDemissao.Width = 80;
            // 
            // clmAtivo
            // 
            this.clmAtivo.Text = "Ativo";
            this.clmAtivo.Width = 100;
            // 
            // frmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1344, 689);
            this.Name = "frmConsultaFuncionario";
            this.Text = "Consulta de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmMatricula;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCargo;
        private System.Windows.Forms.ColumnHeader clmSalario;
        private System.Windows.Forms.ColumnHeader clmTurno;
        private System.Windows.Forms.ColumnHeader clmCargaHoraria;
        private System.Windows.Forms.ColumnHeader clmCpf;
        private System.Windows.Forms.ColumnHeader clmRg;
        private System.Windows.Forms.ColumnHeader clmGenero;
        private System.Windows.Forms.ColumnHeader clmCidade;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmTelefone;
        private System.Windows.Forms.ColumnHeader clmDataAdmissao;
        private System.Windows.Forms.ColumnHeader clmDataDemissao;
        private System.Windows.Forms.ColumnHeader clmAtivo;
    }
}
