using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Pratica
{
    public partial class frmCadastroFormaPagamento : Projeto_Pratica.frmCadastro
    {
        private formaPagamento aFormaPagamento;
        private Controller_formaPagamento aController_formaPagamento;

        public frmCadastroFormaPagamento() : base()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            aFormaPagamento = (formaPagamento)obj;
            aController_formaPagamento = (Controller_formaPagamento)ctrl;
        }

        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                txtDescricao.Focus();

                MessageBox.Show("Preencha todos os campos obrigatórios para salvar.");
                return;
            }

            aFormaPagamento.Id = Convert.ToInt32(txtCodigo.Text);
            aFormaPagamento.Descricao = txtDescricao.Text;
            aFormaPagamento.Ativo = checkBoxAtivo.Checked;

            try
            {
                if (btnSave.Text == "Excluir")
                {
                    DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        aController_formaPagamento.Excluir(aFormaPagamento);
                        MessageBox.Show("A forma de pagamento \"" + aFormaPagamento.Descricao + "\" foi excluída com sucesso.");
                        Sair();
                    }
                }
                else if (btnSave.Text == "Alterar")
                {
                    aController_formaPagamento.Salvar(aFormaPagamento);
                    MessageBox.Show("A forma de pagamento \"" + aFormaPagamento.Descricao + "\" foi alterada com sucesso.");
                }
                else
                {
                    aController_formaPagamento.Salvar(aFormaPagamento);
                    MessageBox.Show("A forma de pagamento \"" + aFormaPagamento.Descricao + "\" foi salva com o código " + aFormaPagamento.Id + ".");
                }

                base.Salvar();
            }
            catch (Exception ex)
            {
                TratarErro(ex);
            }
        }

        public override void Limpartxt()
        {
            base.Limpartxt();

            txtDescricao.Clear();
        }

        public override void Carregatxt()
        {
            base.Carregatxt();

            txtCodigo.Text = Convert.ToString(aFormaPagamento.Id);
            txtDescricao.Text = aFormaPagamento.Descricao;
            checkBoxAtivo.Checked = aFormaPagamento.Ativo;
            lblDataCadastroData.Text = aFormaPagamento.DataCadastro.ToShortDateString();
            lblDataUltimaEdicaoData.Text = aFormaPagamento.DataUltimaEdicao?.ToShortDateString() ?? " ";
        }

        public override void Bloqueiatxt()
        {
            base.Bloqueiatxt();

            txtDescricao.Enabled = false;
        }

        public override void Desbloqueiatxt()
        {
            base.Desbloqueiatxt();

            txtDescricao.Enabled = true;
        }

        public override void CamposRestricoes()
        {
            base.CamposRestricoes();

            txtDescricao.MaxLength = 40;
        }
    }
}
