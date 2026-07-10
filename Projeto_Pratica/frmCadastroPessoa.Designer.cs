namespace Projeto_Pratica
{
    partial class frmCadastroPessoa
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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtNomeRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtApelidoNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.btnPesquisarCidade = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumeroEndereco = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplementoEndereco = new System.Windows.Forms.Label();
            this.txtComplementoEndereco = new System.Windows.Forms.TextBox();
            this.dtpDataNascimentoCriacao = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtRgInscEstadual = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 472);
            // 
            // lblDataUltimaEdicao
            // 
            this.lblDataUltimaEdicao.Location = new System.Drawing.Point(12, 493);
            // 
            // lblUltimoUsuarioQueEditou
            // 
            this.lblUltimoUsuarioQueEditou.Location = new System.Drawing.Point(12, 516);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(898, 491);
            // 
            // lblCod
            // 
            this.lblCod.Location = new System.Drawing.Point(19, 78);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 95);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(991, 493);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "PESSOA FÍSICA",
            "PESSOA JURÍDICA"});
            this.comboBoxTipo.Location = new System.Drawing.Point(16, 37);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(185, 21);
            this.comboBoxTipo.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(13, 17);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(92, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Registro *";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(494, 77);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(42, 13);
            this.lblApelido.TabIndex = 14;
            this.lblApelido.Text = "Apelido";
            // 
            // txtNomeRazaoSocial
            // 
            this.txtNomeRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeRazaoSocial.Location = new System.Drawing.Point(147, 94);
            this.txtNomeRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeRazaoSocial.Name = "txtNomeRazaoSocial";
            this.txtNomeRazaoSocial.ShortcutsEnabled = false;
            this.txtNomeRazaoSocial.Size = new System.Drawing.Size(332, 20);
            this.txtNomeRazaoSocial.TabIndex = 12;
            // 
            // txtApelidoNomeFantasia
            // 
            this.txtApelidoNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApelidoNomeFantasia.Location = new System.Drawing.Point(501, 94);
            this.txtApelidoNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApelidoNomeFantasia.Name = "txtApelidoNomeFantasia";
            this.txtApelidoNomeFantasia.ShortcutsEnabled = false;
            this.txtApelidoNomeFantasia.Size = new System.Drawing.Size(332, 20);
            this.txtApelidoNomeFantasia.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(143, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome *";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.comboBoxGenero.Location = new System.Drawing.Point(845, 91);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(161, 21);
            this.comboBoxGenero.TabIndex = 16;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(840, 73);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(49, 13);
            this.lblGenero.TabIndex = 17;
            this.lblGenero.Text = "Gênero *";
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.Location = new System.Drawing.Point(21, 160);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.ReadOnly = true;
            this.txtCodCidade.ShortcutsEnabled = false;
            this.txtCodCidade.Size = new System.Drawing.Size(60, 20);
            this.txtCodCidade.TabIndex = 169;
            this.txtCodCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.Location = new System.Drawing.Point(318, 157);
            this.btnPesquisarCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarCidade.Name = "btnPesquisarCidade";
            this.btnPesquisarCidade.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisarCidade.TabIndex = 168;
            this.btnPesquisarCidade.Text = "Pesquisar";
            this.btnPesquisarCidade.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(87, 160);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.ShortcutsEnabled = false;
            this.txtCidade.Size = new System.Drawing.Size(225, 20);
            this.txtCidade.TabIndex = 167;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(18, 141);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 166;
            this.lblCidade.Text = "Cidade *";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(603, 162);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.ShortcutsEnabled = false;
            this.txtPais.Size = new System.Drawing.Size(156, 20);
            this.txtPais.TabIndex = 171;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(600, 143);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 175;
            this.lblPais.Text = "País *";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(422, 162);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.ShortcutsEnabled = false;
            this.txtEstado.Size = new System.Drawing.Size(148, 20);
            this.txtEstado.TabIndex = 170;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(419, 143);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 174;
            this.lblEstado.Text = "Estado *";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(782, 162);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ShortcutsEnabled = false;
            this.txtEndereco.Size = new System.Drawing.Size(205, 20);
            this.txtEndereco.TabIndex = 172;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(778, 143);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 13);
            this.lblEndereco.TabIndex = 173;
            this.lblEndereco.Text = "Endereço *";
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(998, 143);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(51, 13);
            this.lblNumeroEndereco.TabIndex = 177;
            this.lblNumeroEndereco.Text = "Número *";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroEndereco.Location = new System.Drawing.Point(1000, 162);
            this.txtNumeroEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.ShortcutsEnabled = false;
            this.txtNumeroEndereco.Size = new System.Drawing.Size(82, 20);
            this.txtNumeroEndereco.TabIndex = 176;
            this.txtNumeroEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCep
            // 
            this.txtCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCep.Location = new System.Drawing.Point(380, 225);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCep.Name = "txtCep";
            this.txtCep.ShortcutsEnabled = false;
            this.txtCep.Size = new System.Drawing.Size(311, 20);
            this.txtCep.TabIndex = 182;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(383, 206);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 13);
            this.lblCep.TabIndex = 178;
            this.lblCep.Text = "CEP *";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(21, 225);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ShortcutsEnabled = false;
            this.txtBairro.Size = new System.Drawing.Size(336, 20);
            this.txtBairro.TabIndex = 181;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(18, 206);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 13);
            this.lblBairro.TabIndex = 179;
            this.lblBairro.Text = "Bairro *";
            // 
            // lblComplementoEndereco
            // 
            this.lblComplementoEndereco.AutoSize = true;
            this.lblComplementoEndereco.Location = new System.Drawing.Point(715, 206);
            this.lblComplementoEndereco.Name = "lblComplementoEndereco";
            this.lblComplementoEndereco.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoEndereco.TabIndex = 184;
            this.lblComplementoEndereco.Text = "Complemento";
            // 
            // txtComplementoEndereco
            // 
            this.txtComplementoEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplementoEndereco.Location = new System.Drawing.Point(718, 225);
            this.txtComplementoEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplementoEndereco.Name = "txtComplementoEndereco";
            this.txtComplementoEndereco.ShortcutsEnabled = false;
            this.txtComplementoEndereco.Size = new System.Drawing.Size(357, 20);
            this.txtComplementoEndereco.TabIndex = 183;
            // 
            // dtpDataNascimentoCriacao
            // 
            this.dtpDataNascimentoCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoCriacao.Location = new System.Drawing.Point(734, 278);
            this.dtpDataNascimentoCriacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataNascimentoCriacao.Name = "dtpDataNascimentoCriacao";
            this.dtpDataNascimentoCriacao.Size = new System.Drawing.Size(135, 20);
            this.dtpDataNascimentoCriacao.TabIndex = 190;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(21, 338);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ShortcutsEnabled = false;
            this.txtTelefone.Size = new System.Drawing.Size(336, 20);
            this.txtTelefone.TabIndex = 191;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 319);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 13);
            this.lblTelefone.TabIndex = 193;
            this.lblTelefone.Text = "Telefone *";
            // 
            // txtRgInscEstadual
            // 
            this.txtRgInscEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRgInscEstadual.Location = new System.Drawing.Point(380, 280);
            this.txtRgInscEstadual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRgInscEstadual.Name = "txtRgInscEstadual";
            this.txtRgInscEstadual.ShortcutsEnabled = false;
            this.txtRgInscEstadual.Size = new System.Drawing.Size(332, 20);
            this.txtRgInscEstadual.TabIndex = 189;
            this.txtRgInscEstadual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpfCnpj.Location = new System.Drawing.Point(21, 280);
            this.txtCpfCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.ShortcutsEnabled = false;
            this.txtCpfCnpj.Size = new System.Drawing.Size(336, 20);
            this.txtCpfCnpj.TabIndex = 188;
            this.txtCpfCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(18, 262);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 194;
            this.lblCpf.Text = "CPF *";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(380, 338);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(332, 20);
            this.txtEmail.TabIndex = 192;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(377, 319);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 185;
            this.lblEmail.Text = "E-mail *";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(731, 258);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(111, 13);
            this.lblDataNascimento.TabIndex = 186;
            this.lblDataNascimento.Text = "Data de Nascimento *";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(377, 262);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(30, 13);
            this.lblRg.TabIndex = 187;
            this.lblRg.Text = "RG *";
            // 
            // frmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1093, 540);
            this.Controls.Add(this.dtpDataNascimentoCriacao);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtRgInscEstadual);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblComplementoEndereco);
            this.Controls.Add(this.txtComplementoEndereco);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumeroEndereco);
            this.Controls.Add(this.txtNumeroEndereco);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtCodCidade);
            this.Controls.Add(this.btnPesquisarCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.txtNomeRazaoSocial);
            this.Controls.Add(this.txtApelidoNomeFantasia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmCadastroPessoa";
            this.Text = "Cadastro de Pessoa";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox comboBoxTipo;
        protected System.Windows.Forms.Label lblTipo;
        protected System.Windows.Forms.Label lblApelido;
        protected System.Windows.Forms.TextBox txtNomeRazaoSocial;
        protected System.Windows.Forms.TextBox txtApelidoNomeFantasia;
        protected System.Windows.Forms.Label lblNome;
        protected System.Windows.Forms.ComboBox comboBoxGenero;
        protected System.Windows.Forms.Label lblGenero;
        protected System.Windows.Forms.TextBox txtCodCidade;
        protected System.Windows.Forms.Button btnPesquisarCidade;
        protected System.Windows.Forms.TextBox txtCidade;
        protected System.Windows.Forms.Label lblCidade;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.Label lblPais;
        protected System.Windows.Forms.TextBox txtEstado;
        protected System.Windows.Forms.Label lblEstado;
        protected System.Windows.Forms.TextBox txtEndereco;
        protected System.Windows.Forms.Label lblEndereco;
        protected System.Windows.Forms.Label lblNumeroEndereco;
        protected System.Windows.Forms.TextBox txtNumeroEndereco;
        protected System.Windows.Forms.TextBox txtCep;
        protected System.Windows.Forms.Label lblCep;
        protected System.Windows.Forms.TextBox txtBairro;
        protected System.Windows.Forms.Label lblBairro;
        protected System.Windows.Forms.Label lblComplementoEndereco;
        protected System.Windows.Forms.TextBox txtComplementoEndereco;
        protected System.Windows.Forms.DateTimePicker dtpDataNascimentoCriacao;
        protected System.Windows.Forms.TextBox txtTelefone;
        protected System.Windows.Forms.Label lblTelefone;
        protected System.Windows.Forms.TextBox txtRgInscEstadual;
        protected System.Windows.Forms.TextBox txtCpfCnpj;
        protected System.Windows.Forms.Label lblCpf;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.Label lblDataNascimento;
        protected System.Windows.Forms.Label lblRg;
    }
}
