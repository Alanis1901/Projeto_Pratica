namespace Projeto_Pratica
{
    partial class frmCadastroCondicaoPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtQtdParcelas = new System.Windows.Forms.TextBox();
            this.lvlQtdParcelas = new System.Windows.Forms.Label();
            this.listVParcelas = new System.Windows.Forms.ListView();
            this.clmNumParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCodFormaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPercentualParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDiasAposPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblParcelas = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblPorcentagemTotalNum = new System.Windows.Forms.Label();
            this.lblPorcentagemTotal = new System.Windows.Forms.Label();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btnRemoverParcela = new System.Windows.Forms.Button();
            this.btnEditarParcela = new System.Windows.Forms.Button();
            this.btnAdicionarParcela = new System.Windows.Forms.Button();
            this.btnPesquisarFormaPagamento = new System.Windows.Forms.Button();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtPrazoDias = new System.Windows.Forms.TextBox();
            this.lblPrazoDias = new System.Windows.Forms.Label();
            this.txtPercentualParcela = new System.Windows.Forms.TextBox();
            this.lblPercentualParcela = new System.Windows.Forms.Label();
            this.txtNumParcela = new System.Windows.Forms.TextBox();
            this.lblNumParcela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 620);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 641);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 664);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1147, 642);
            this.btnSave.TabIndex = 15;
            // 
            // lblDataCadastroData
            // 
            this.lblDataCadastroData.Location = new System.Drawing.Point(134, 620);
            // 
            // lblDataUltimaEdicaoData
            // 
            this.lblDataUltimaEdicaoData.Location = new System.Drawing.Point(145, 641);
            // 
            // lblUltimoUsuarioQueEditouNome
            // 
            this.lblUltimoUsuarioQueEditouNome.Location = new System.Drawing.Point(150, 664);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.ShortcutsEnabled = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1240, 644);
            this.btnSair.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(13, 105);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ShortcutsEnabled = false;
            this.txtDescricao.Size = new System.Drawing.Size(445, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(10, 86);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(131, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Condição de Pagamento *";
            // 
            // txtQtdParcelas
            // 
            this.txtQtdParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdParcelas.Location = new System.Drawing.Point(13, 163);
            this.txtQtdParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdParcelas.Name = "txtQtdParcelas";
            this.txtQtdParcelas.ShortcutsEnabled = false;
            this.txtQtdParcelas.Size = new System.Drawing.Size(142, 20);
            this.txtQtdParcelas.TabIndex = 3;
            this.txtQtdParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvlQtdParcelas
            // 
            this.lvlQtdParcelas.AutoSize = true;
            this.lvlQtdParcelas.Location = new System.Drawing.Point(10, 143);
            this.lvlQtdParcelas.Name = "lvlQtdParcelas";
            this.lvlQtdParcelas.Size = new System.Drawing.Size(78, 13);
            this.lvlQtdParcelas.TabIndex = 4;
            this.lvlQtdParcelas.Text = "Qtd. Parcelas *";
            // 
            // listVParcelas
            // 
            this.listVParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumParcela,
            this.clmCodFormaPagamento,
            this.clmPercentualParcela,
            this.clmDiasAposPagamento});
            this.listVParcelas.FullRowSelect = true;
            this.listVParcelas.GridLines = true;
            this.listVParcelas.HideSelection = false;
            this.listVParcelas.Location = new System.Drawing.Point(489, 182);
            this.listVParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listVParcelas.Name = "listVParcelas";
            this.listVParcelas.Size = new System.Drawing.Size(842, 444);
            this.listVParcelas.TabIndex = 7;
            this.listVParcelas.UseCompatibleStateImageBehavior = false;
            this.listVParcelas.View = System.Windows.Forms.View.Details;
            // 
            // clmNumParcela
            // 
            this.clmNumParcela.Text = "Num. Parcela";
            this.clmNumParcela.Width = 100;
            // 
            // clmCodFormaPagamento
            // 
            this.clmCodFormaPagamento.Text = "Forma de Pagamento";
            this.clmCodFormaPagamento.Width = 200;
            // 
            // clmPercentualParcela
            // 
            this.clmPercentualParcela.Text = "Percentual";
            this.clmPercentualParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmPercentualParcela.Width = 100;
            // 
            // clmDiasAposPagamento
            // 
            this.clmDiasAposPagamento.Text = "Dias após Venda";
            this.clmDiasAposPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmDiasAposPagamento.Width = 150;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(491, 36);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(48, 13);
            this.lblParcelas.TabIndex = 0;
            this.lblParcelas.Text = "Parcelas";
            // 
            // txtJuros
            // 
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.Location = new System.Drawing.Point(15, 297);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ShortcutsEnabled = false;
            this.txtJuros.Size = new System.Drawing.Size(142, 20);
            this.txtJuros.TabIndex = 5;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(12, 278);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(56, 13);
            this.lblJuros.TabIndex = 4;
            this.lblJuros.Text = "Juros (%) *";
            // 
            // txtMulta
            // 
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.Location = new System.Drawing.Point(15, 241);
            this.txtMulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.ShortcutsEnabled = false;
            this.txtMulta.Size = new System.Drawing.Size(142, 20);
            this.txtMulta.TabIndex = 4;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(12, 222);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(57, 13);
            this.lblMulta.TabIndex = 4;
            this.lblMulta.Text = "Multa (%) *";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(15, 352);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ShortcutsEnabled = false;
            this.txtDesconto.Size = new System.Drawing.Size(142, 20);
            this.txtDesconto.TabIndex = 6;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(12, 334);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(77, 13);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "Desconto (%) *";
            // 
            // lblPorcentagemTotalNum
            // 
            this.lblPorcentagemTotalNum.AutoSize = true;
            this.lblPorcentagemTotalNum.Location = new System.Drawing.Point(711, 138);
            this.lblPorcentagemTotalNum.Name = "lblPorcentagemTotalNum";
            this.lblPorcentagemTotalNum.Size = new System.Drawing.Size(13, 13);
            this.lblPorcentagemTotalNum.TabIndex = 113;
            this.lblPorcentagemTotalNum.Text = "0";
            // 
            // lblPorcentagemTotal
            // 
            this.lblPorcentagemTotal.AutoSize = true;
            this.lblPorcentagemTotal.Location = new System.Drawing.Point(646, 138);
            this.lblPorcentagemTotal.Name = "lblPorcentagemTotal";
            this.lblPorcentagemTotal.Size = new System.Drawing.Size(48, 13);
            this.lblPorcentagemTotal.TabIndex = 111;
            this.lblPorcentagemTotal.Text = "% Total: ";
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(956, 105);
            this.comboBoxFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(233, 21);
            this.comboBoxFormaPagamento.TabIndex = 114;
            // 
            // btnRemoverParcela
            // 
            this.btnRemoverParcela.Location = new System.Drawing.Point(1096, 140);
            this.btnRemoverParcela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverParcela.Name = "btnRemoverParcela";
            this.btnRemoverParcela.Size = new System.Drawing.Size(144, 34);
            this.btnRemoverParcela.TabIndex = 118;
            this.btnRemoverParcela.Text = "Remover Parcela";
            this.btnRemoverParcela.UseVisualStyleBackColor = true;
            // 
            // btnEditarParcela
            // 
            this.btnEditarParcela.Location = new System.Drawing.Point(947, 140);
            this.btnEditarParcela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarParcela.Name = "btnEditarParcela";
            this.btnEditarParcela.Size = new System.Drawing.Size(144, 34);
            this.btnEditarParcela.TabIndex = 117;
            this.btnEditarParcela.Text = "Editar Parcela";
            this.btnEditarParcela.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarParcela
            // 
            this.btnAdicionarParcela.Location = new System.Drawing.Point(797, 140);
            this.btnAdicionarParcela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarParcela.Name = "btnAdicionarParcela";
            this.btnAdicionarParcela.Size = new System.Drawing.Size(144, 34);
            this.btnAdicionarParcela.TabIndex = 116;
            this.btnAdicionarParcela.Text = "Adicionar Parcela";
            this.btnAdicionarParcela.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarFormaPagamento
            // 
            this.btnPesquisarFormaPagamento.Location = new System.Drawing.Point(1195, 99);
            this.btnPesquisarFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarFormaPagamento.Name = "btnPesquisarFormaPagamento";
            this.btnPesquisarFormaPagamento.Size = new System.Drawing.Size(70, 34);
            this.btnPesquisarFormaPagamento.TabIndex = 115;
            this.btnPesquisarFormaPagamento.Text = "Pesquisar";
            this.btnPesquisarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(953, 86);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPagamento.TabIndex = 105;
            this.lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // txtPrazoDias
            // 
            this.txtPrazoDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrazoDias.Location = new System.Drawing.Point(804, 105);
            this.txtPrazoDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrazoDias.Name = "txtPrazoDias";
            this.txtPrazoDias.ShortcutsEnabled = false;
            this.txtPrazoDias.Size = new System.Drawing.Size(135, 20);
            this.txtPrazoDias.TabIndex = 112;
            this.txtPrazoDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrazoDias
            // 
            this.lblPrazoDias.AutoSize = true;
            this.lblPrazoDias.Location = new System.Drawing.Point(801, 86);
            this.lblPrazoDias.Name = "lblPrazoDias";
            this.lblPrazoDias.Size = new System.Drawing.Size(75, 13);
            this.lblPrazoDias.TabIndex = 106;
            this.lblPrazoDias.Text = "Prazo em Dias";
            // 
            // txtPercentualParcela
            // 
            this.txtPercentualParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPercentualParcela.Location = new System.Drawing.Point(649, 105);
            this.txtPercentualParcela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPercentualParcela.Name = "txtPercentualParcela";
            this.txtPercentualParcela.ShortcutsEnabled = false;
            this.txtPercentualParcela.Size = new System.Drawing.Size(135, 20);
            this.txtPercentualParcela.TabIndex = 110;
            this.txtPercentualParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPercentualParcela
            // 
            this.lblPercentualParcela.AutoSize = true;
            this.lblPercentualParcela.Location = new System.Drawing.Point(646, 86);
            this.lblPercentualParcela.Name = "lblPercentualParcela";
            this.lblPercentualParcela.Size = new System.Drawing.Size(75, 13);
            this.lblPercentualParcela.TabIndex = 107;
            this.lblPercentualParcela.Text = "Percentual (%)";
            // 
            // txtNumParcela
            // 
            this.txtNumParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumParcela.Location = new System.Drawing.Point(489, 105);
            this.txtNumParcela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumParcela.Name = "txtNumParcela";
            this.txtNumParcela.ShortcutsEnabled = false;
            this.txtNumParcela.Size = new System.Drawing.Size(143, 20);
            this.txtNumParcela.TabIndex = 109;
            this.txtNumParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumParcela
            // 
            this.lblNumParcela.AutoSize = true;
            this.lblNumParcela.Location = new System.Drawing.Point(486, 86);
            this.lblNumParcela.Name = "lblNumParcela";
            this.lblNumParcela.Size = new System.Drawing.Size(98, 13);
            this.lblNumParcela.TabIndex = 108;
            this.lblNumParcela.Text = "Número da Parcela";
            // 
            // frmCadastroCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1343, 689);
            this.Controls.Add(this.lblPorcentagemTotalNum);
            this.Controls.Add(this.lblPorcentagemTotal);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(this.btnRemoverParcela);
            this.Controls.Add(this.btnEditarParcela);
            this.Controls.Add(this.btnAdicionarParcela);
            this.Controls.Add(this.btnPesquisarFormaPagamento);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.txtPrazoDias);
            this.Controls.Add(this.lblPrazoDias);
            this.Controls.Add(this.txtPercentualParcela);
            this.Controls.Add(this.lblPercentualParcela);
            this.Controls.Add(this.txtNumParcela);
            this.Controls.Add(this.lblNumParcela);
            this.Controls.Add(this.listVParcelas);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lvlQtdParcelas);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtQtdParcelas);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblParcelas);
            this.Name = "frmCadastroCondicaoPagamento";
            this.Text = "Cadastro de Condição de Pagamento";
            this.Controls.SetChildIndex(this.lblParcelas, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtQtdParcelas, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lvlQtdParcelas, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.checkBoxAtivo, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataCadastroData, 0);
            this.Controls.SetChildIndex(this.lblDataUltimaEdicao, 0);
            this.Controls.SetChildIndex(this.lblDataUltimaEdicaoData, 0);
            this.Controls.SetChildIndex(this.lblUltimoUsuarioQueEditou, 0);
            this.Controls.SetChildIndex(this.lblUltimoUsuarioQueEditouNome, 0);
            this.Controls.SetChildIndex(this.listVParcelas, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblNumParcela, 0);
            this.Controls.SetChildIndex(this.txtNumParcela, 0);
            this.Controls.SetChildIndex(this.lblPercentualParcela, 0);
            this.Controls.SetChildIndex(this.txtPercentualParcela, 0);
            this.Controls.SetChildIndex(this.lblPrazoDias, 0);
            this.Controls.SetChildIndex(this.txtPrazoDias, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFormaPagamento, 0);
            this.Controls.SetChildIndex(this.btnAdicionarParcela, 0);
            this.Controls.SetChildIndex(this.btnEditarParcela, 0);
            this.Controls.SetChildIndex(this.btnRemoverParcela, 0);
            this.Controls.SetChildIndex(this.comboBoxFormaPagamento, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemTotalNum, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtQtdParcelas;
        private System.Windows.Forms.Label lvlQtdParcelas;
        private System.Windows.Forms.ListView listVParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.ColumnHeader clmNumParcela;
        private System.Windows.Forms.ColumnHeader clmCodFormaPagamento;
        private System.Windows.Forms.ColumnHeader clmPercentualParcela;
        private System.Windows.Forms.ColumnHeader clmDiasAposPagamento;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblPorcentagemTotalNum;
        private System.Windows.Forms.Label lblPorcentagemTotal;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Button btnRemoverParcela;
        private System.Windows.Forms.Button btnEditarParcela;
        private System.Windows.Forms.Button btnAdicionarParcela;
        private System.Windows.Forms.Button btnPesquisarFormaPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtPrazoDias;
        private System.Windows.Forms.Label lblPrazoDias;
        private System.Windows.Forms.TextBox txtPercentualParcela;
        private System.Windows.Forms.Label lblPercentualParcela;
        private System.Windows.Forms.TextBox txtNumParcela;
        private System.Windows.Forms.Label lblNumParcela;
    }
}
