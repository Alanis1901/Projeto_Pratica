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
    public partial class frmCadastroMarca : Projeto_Pratica.frmCadastro
    {
        private marca oMarca;
        private Controller_marca aController_marca;

        public frmCadastroMarca() : base()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oMarca = (marca)obj;
            aController_marca = (Controller_marca)ctrl;
        }
        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Focus();
                MessageBox.Show("Preencha todos os campos obrigatórios para salvar.");
                return;
            }

            oMarca.Id = Convert.ToInt32(txtCodigo.Text);
            oMarca.Nome = txtNome.Text;
            oMarca.Ativo = checkBoxAtivo.Checked;

            try
            {
                if (btnSave.Text == "Excluir")
                {
                    DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        aController_marca.Excluir(oMarca);
                        MessageBox.Show("A marca \"" + oMarca.Nome + "\" foi excluída com sucesso.");
                        Sair();
                    }
                }
                else if (btnSave.Text == "Alterar")
                {
                    aController_marca.Salvar(oMarca);
                    MessageBox.Show("A marca \"" + oMarca.Nome + "\" foi alterada com sucesso.");
                }
                else
                {
                    aController_marca.Salvar(oMarca);
                    MessageBox.Show("A marca \"" + oMarca.Nome + "\" foi salva com o código " + oMarca.Id + ".");
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
            txtCodigo.Text = Convert.ToString(oMarca.Id);
            txtNome.Text = oMarca.Nome;
            lblDataCadastroData.Text = oMarca.DataCadastro.ToShortDateString();
            lblDataUltimaEdicaoData.Text = oMarca.DataUltimaEdicao?.ToShortDateString() ?? " ";
            checkBoxAtivo.Checked = oMarca.Ativo;
        }

        public override void Bloqueiatxt()
        {
            base.Bloqueiatxt();
            txtNome.Enabled = false;
        }
        public override void Desbloqueiatxt()
        {
            base.Desbloqueiatxt();
            txtNome.Enabled = true;
        }

        public override void CamposRestricoes()
        {
            base.CamposRestricoes();

            txtNome.MaxLength = 40;
        }
    }
}