using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Os formulários de consulta permitem localizar registros já cadastrados.
//Funcionalidades:

namespace Projeto_Pratica
{
    public partial class frmConsulta : Projeto_Pratica.frmBase
    {
        public frmConsulta() : base()
        {
            InitializeComponent();
        }


        public virtual void Incluir()
        {

        }

        public virtual void Excluir()
        {

        }

        public virtual void Alterar()
        {

        }


        public virtual void Pesquisar()
        {

        }



        public virtual void LimparPesquisa()
        {
            txtCodigo.Text = " ";
            CarregaLV();
        }


        public virtual void setFrmCadastro(object obj)
        {

        }


        public virtual void CarregaLV()
        {

        }
        public virtual void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Verifica se há um item selecionado antes de alterar/excluir
        protected bool ItemSelecionado(string acao)
        {
            if (listV.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum item selecionado. Selecione um registro para " + acao + ".",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (ItemSelecionado("alterar"))
                Alterar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (ItemSelecionado("excluir"))
                Excluir();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void bntLimparPesquisa_Click(object sender, EventArgs e)
        {
            LimparPesquisa();
        }
    }
}
