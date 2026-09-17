using projeto_patrica.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pratica
{
    public partial class frmPrincipal : Form
    {
        // Interface
        private Interfaces aInter;

        // Classes
        private formaPagamento aFormaPagamento;
        private condicaoPagamento aCondicaoPagamento;
        private pais oPais;
        private estado oEstado;
        private cidade aCidade;
        private cliente oCliente;
        private funcionario oFuncionario;
        private fornecedor oFornecedor;
        private categoria aCategoria;
        private marca aMarca;
        private unidade_medida aUnidadeMedida;
        private produto oProduto;
        private compra aCompra;
        private contasAPagar aContasAPagar;
        private venda aVenda;
        private contasAReceber aContasAReceber;

        // Controllers
        private Controller_formaPagamento oController_formaPagamento;
        private Controller_condicaoPagamento oController_condicaoPagamento;
        private Controller_pais oController_pais;
        private Controller_estado oController_estado;
        private Controller_cidade oController_cidade;
        private Controller_cliente oController_cliente;
        private Controller_funcionario oController_funcionario;
        private Controller_fornecedor oController_fornecedor;
        private Controller_categoria oController_categoria;
        private Controller_marca oController_marca;
        private Controller_unidade_medida oController_unidade_medida;
        private Controller_produto oController_produto;
        private Controller_compra oController_compra;
        private Controller_contasAPagar oController_contasAPagar;
        private Controller_venda oController_venda;
        private Controller_contasAReceber oController_contasAReceber;

        public frmPrincipal()
        {
            InitializeComponent();

            // Instanciando Interface
            aInter = new Interfaces();

            // Instanciando Classes
            aFormaPagamento = new formaPagamento();
            aCondicaoPagamento = new condicaoPagamento();
            oPais = new pais();
            oEstado = new estado();
            aCidade = new cidade();
            oCliente = new cliente();
            oFuncionario = new funcionario();
            oFornecedor = new fornecedor();
            aCategoria = new categoria();
            aMarca = new marca();
            aUnidadeMedida = new unidade_medida();
            oProduto = new produto();
            aCompra = new compra();
            aContasAPagar = new contasAPagar();
            aVenda = new venda();
            aContasAReceber = new contasAReceber();

            // Instanciando Controllers
            oController_formaPagamento = new Controller_formaPagamento();
            oController_condicaoPagamento = new Controller_condicaoPagamento();
            oController_pais = new Controller_pais();
            oController_estado = new Controller_estado();
            oController_cidade = new Controller_cidade();
            oController_cliente = new Controller_cliente();
            oController_funcionario = new Controller_funcionario();
            oController_fornecedor = new Controller_fornecedor();
            oController_categoria = new Controller_categoria();
            oController_marca = new Controller_marca();
            oController_unidade_medida = new Controller_unidade_medida();
            oController_produto = new Controller_produto();
            oController_compra = new Controller_compra();
            oController_contasAPagar = new Controller_contasAPagar();
            oController_venda = new Controller_venda();
            oController_contasAReceber = new Controller_contasAReceber();

            // Dependências
            oController_condicaoPagamento.AController_formaPagamento = oController_formaPagamento;
        }
        private void paísToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aInter.pecaConsultaPais(oPais, oController_pais);
        }

        private void estadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aInter.pecaConsultaEstado(oEstado, oController_estado);
        }

        private void cidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aInter.pecaConsultaCidade(aCidade, oController_cidade);
        }

        private void funcionárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aInter.pecaConsultaFuncionario(oFuncionario, oController_funcionario);
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aInter.pecaConsultaMarca(aMarca, oController_marca);
        }

        private void condiçãoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaCondicaoPagamento(aCondicaoPagamento, oController_condicaoPagamento);
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaFormaPagamento(aFormaPagamento, oController_formaPagamento);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaCliente(oCliente, oController_cliente);
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaFornecedor(oFornecedor, oController_fornecedor);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaCategoria(aCategoria, oController_categoria);
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaUnidadeMedida(aUnidadeMedida, oController_unidade_medida);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaProduto(oProduto, oController_produto);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaCompra(aCompra, oController_compra);
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaContasAPagar(aContasAPagar, oController_contasAPagar);
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaVenda(aVenda, oController_venda);
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.pecaConsultaContasAReceber(aContasAReceber, oController_contasAReceber);
        }
    }
}
