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
    public partial class frmCadastroUnidade_medida : Projeto_Pratica.frmCadastro
    {
        private unidade_medida oUnidadeMedida;
        private Controller_unidade_medida aController_unidade_medida;

        public frmCadastroUnidade_medida() : base()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oUnidadeMedida = (unidade_medida)obj;
            aController_unidade_medida = (Controller_unidade_medida)ctrl;
        }
        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Focus();
                MessageBox.Show("Preencha todos os campos obrigatórios para salvar.");
                return;
            }

            oUnidadeMedida.Id = Convert.ToInt32(txtCodigo.Text);
            oUnidadeMedida.Nome = txtNome.Text;
            oUnidadeMedida.Sigla = txtSigla.Text;
            oUnidadeMedida.Ativo = checkBoxAtivo.Checked;

            try
            {
                if (btnSave.Text == "Excluir")
                {
                    DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        aController_unidade_medida.Excluir(oUnidadeMedida);
                        MessageBox.Show("A unidade de medida \"" + oUnidadeMedida.Nome + "\" foi excluída com sucesso.");
                        Sair();
                    }
                }
                else if (btnSave.Text == "Alterar")
                {
                    aController_unidade_medida.Salvar(oUnidadeMedida);
                    MessageBox.Show("A unidade de medida \"" + oUnidadeMedida.Nome + "\" foi alterada com sucesso.");
                }
                else
                {
                    aController_unidade_medida.Salvar(oUnidadeMedida);
                    MessageBox.Show("A unidade de medida \"" + oUnidadeMedida.Nome + "\" foi salva com o código " + oUnidadeMedida.Id + ".");
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
            txtNome.Clear();
        }

        public override void Carregatxt()
        {
            base.Carregatxt();
            txtCodigo.Text = Convert.ToString(oUnidadeMedida.Id);
            txtNome.Text = oUnidadeMedida.Nome;
            txtSigla.Text = oUnidadeMedida.Sigla;
            lblDataCadastroData.Text = oUnidadeMedida.DataCadastro.ToShortDateString();
            lblDataUltimaEdicaoData.Text = oUnidadeMedida.DataUltimaEdicao?.ToShortDateString() ?? " ";
            checkBoxAtivo.Checked = oUnidadeMedida.Ativo;
        }

        public override void Bloqueiatxt()
        {
            base.Bloqueiatxt();
            txtNome.Enabled = false;
            txtSigla.Enabled = false;
        }
        public override void Desbloqueiatxt()
        {
            base.Desbloqueiatxt();
            txtNome.Enabled = true;
            txtSigla.Enabled = true;
        }

        public override void CamposRestricoes()
        {
            base.CamposRestricoes();
            txtNome.MaxLength = 40;
            txtSigla.MaxLength = 3;
        }
    }
}