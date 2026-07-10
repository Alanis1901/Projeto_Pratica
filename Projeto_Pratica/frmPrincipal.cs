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
        private pais oPais;
        private estado oEstado;
        private cidade aCidade;
        private funcionario oFuncionario;
        private marca aMarca;

        // Controllers
        private Controller_pais oController_pais;
        private Controller_estado oController_estado;
        private Controller_cidade oController_cidade;
        private Controller_funcionario oController_funcionario;
        private Controller_marca oController_marca;

        public frmPrincipal()
        {
            InitializeComponent();

            // Instanciando Interface
            aInter = new Interfaces();

            // Instanciando Classes
            oPais = new pais();
            oEstado = new estado();
            aCidade = new cidade();
            oFuncionario = new funcionario();
            aMarca = new marca();

            // Instanciando Controllers
            oController_pais = new Controller_pais();
            oController_estado = new Controller_estado();
            oController_cidade = new Controller_cidade();
            oController_funcionario = new Controller_funcionario();
            oController_marca = new Controller_marca();

            // Passando dependências de controllers
            oController_cidade.AController_estado = oController_estado;
            oController_funcionario.AController_cidade = oController_cidade;
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
    }
}
