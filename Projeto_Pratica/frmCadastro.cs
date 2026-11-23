using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Os formulários de cadastro são responsáveis pelas operações de manutenção dos dados.

namespace Projeto_Pratica
{
    public partial class frmCadastro : Projeto_Pratica.frmBase
    {
        public frmCadastro() : base()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            this.Shown += (s, e) => CamposRestricoes();
        }

        public virtual void Salvar()
        {
            Sair();
        }

        public virtual void Alterar()
        {
            Sair();
        }

        public virtual void Limpartxt()
        {
            txtCodigo.Text = "0";
            lblDataCadastroData.Text = "-";
            lblDataUltimaEdicaoData.Text = "-";
            lblUltimoUsuarioQueEditouNome.Text = "-";
            checkBoxAtivo.Checked = true;
            checkBoxAtivo.Enabled = false;
        }

        public virtual void Carregatxt()
        {
        }

        public virtual void Bloqueiatxt()
        {
            txtCodigo.Enabled = false;
            checkBoxAtivo.Enabled = false;
        }

        public virtual void Desbloqueiatxt()
        {
            checkBoxAtivo.Enabled = true;

        }

        public override void ConhecaObj(object obj, object ctrl)
        {

        }

        public virtual bool ValidacaoCampos()
        {
            return false;
        }

        public virtual void CamposRestricoes()
        {
            DisablePasteInTextBoxes(this.Controls);
        }

        public virtual void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            e.Handled = true;
        }

        public virtual void ApenasNumerosDecimal(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                char ch = e.KeyChar;

                if (char.IsControl(ch))
                {
                    e.Handled = false;
                    return;
                }

                if (char.IsDigit(ch))
                {
                    if (textBox.Text.Contains(","))
                    {
                        int commaIndex = textBox.Text.IndexOf(',');
                        int decimalDigits = textBox.Text.Length - (commaIndex + 1);

                        if (textBox.SelectionStart > commaIndex && decimalDigits >= 6)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (textBox.Text.Length >= 18 && textBox.SelectionStart == textBox.Text.Length)
                        {
                            e.Handled = true;
                            return;
                        }
                    }

                    e.Handled = false;
                    return;
                }

                if (ch == '.')
                {
                    if (!textBox.Text.Contains(",") && textBox.Text.Length > 0)
                    {
                        int pos = textBox.SelectionStart;

                        textBox.Text = textBox.Text.Insert(pos, ",");
                        textBox.SelectionStart = pos + 1;
                    }

                    e.Handled = true;
                    return;
                }

                if (ch == ',')
                {
                    if (!textBox.Text.Contains(",") && textBox.Text.Length > 0)
                    {
                        e.Handled = false;
                        return;
                    }
                }

                e.Handled = true;
            }
        }

        private void DisablePasteInTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ShortcutsEnabled = false;
                }

                if (control.HasChildren)
                {
                    DisablePasteInTextBoxes(control.Controls);
                }
            }
        }

        // Tratamento de erros usado por todos os cadastros (antes cada formulário repetia este bloco)
        public virtual void TratarErro(Exception ex)
        {
            MySqlException erroBanco = ex as MySqlException;

            if (erroBanco == null)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (erroBanco.Number)
            {
                case 1062: // Entrada duplicada
                    MessageBox.Show(
                        "Não foi possível salvar o item.\n\nJá existe um item salvo com estes dados.",
                        "Erro: Item duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;

                case 1451: // Entrada interligada
                    MessageBox.Show(
                        "Não foi possível excluir o item.\n\nEle está interligado a outro item existente.",
                        "Erro: Item em uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;

                case 1264: // Valor fora do limite
                    MessageBox.Show(
                        "Não foi possível salvar o item.\n\nUm ou mais valores informados excedem o limite suportado pelo banco de dados.",
                        "Erro: Valor muito grande",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;

                default: // Outros erros de banco de dados
                    MessageBox.Show(
                        "Não foi possível concluir a operação. Verifique os dados e tente novamente.\n\nDetalhes técnicos: " + erroBanco.Message,
                        "Erro no Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}