using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum item selecionado. Selecione um registro para alterar.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum item selecionado. Selecione um registro para excluir.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        public virtual void CarregaLV()
        {

        }
        public virtual void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum item selecionado. Selecione um registro para alterar.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Alterar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum item selecionado. Selecione um registro para excluir.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Excluir();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            txtCodigo.Text = " ";
            CarregaLV();
        }

        private void bntLimparPesquisa_Click(object sender, EventArgs e)
        {
            LimparPesquisa();
        }
    }
}
