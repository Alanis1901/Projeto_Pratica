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
    public partial class frmCadastroCategoria : Projeto_Pratica.frmCadastro
    {
        private categoria oCategoria;
        private Controller_categoria aController_categoria;

        public frmCadastroCategoria() : base()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCategoria = (categoria)obj;
            aController_categoria = (Controller_categoria)ctrl;
        }

        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Focus();
                MessageBox.Show("Preencha todos os campos obrigatórios para salvar.");
                return;
            }

            oCategoria.Id = Convert.ToInt32(txtCodigo.Text);
            oCategoria.Nome = txtNome.Text;
            oCategoria.Descricao = txtDescricao.Text;
            oCategoria.Ativo = checkBoxAtivo.Checked;

            try
            {
                if (btnSave.Text == "Excluir")
                {
                    DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        aController_categoria.Excluir(oCategoria);
                        MessageBox.Show("A categoria \"" + oCategoria.Nome + "\" foi excluída com sucesso.");
                        Sair();
                    }
                }
                else if (btnSave.Text == "Alterar")
                {
                    aController_categoria.Salvar(oCategoria);
                    MessageBox.Show("A categoria \"" + oCategoria.Nome + "\" foi alterada com sucesso.");
                }
                else
                {
                    aController_categoria.Salvar(oCategoria);
                    MessageBox.Show("A categoria \"" + oCategoria.Nome + "\" foi salva com o código " + oCategoria.Id + ".");
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
            txtDescricao.Clear();
        }

        public override void Carregatxt()
        {
            base.Carregatxt();
            txtCodigo.Text = oCategoria.Id.ToString();
            txtNome.Text = oCategoria.Nome;
            txtDescricao.Text = oCategoria.Descricao;
            checkBoxAtivo.Checked = oCategoria.Ativo;
            lblDataCadastroData.Text = oCategoria.DataCadastro.ToShortDateString();
            lblDataUltimaEdicaoData.Text = oCategoria.DataUltimaEdicao?.ToShortDateString() ?? " ";
        }

        public override void Bloqueiatxt()
        {
            base.Bloqueiatxt();
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
        }

        public override void Desbloqueiatxt()
        {
            base.Desbloqueiatxt();
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
        }

        public override void CamposRestricoes()
        {
            base.CamposRestricoes();

            txtNome.MaxLength = 40;
            txtDescricao.MaxLength = 80;
        }
    }
}
