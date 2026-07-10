using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pratica
{
    internal class Interfaces
    {
        // Formulários de Cadastro
        frmCadastroPais oFrmCadPais;
        frmCadastroEstado oFrmCadEstado;
        frmCadastroCidade oFrmCadCidade;
        frmCadastroFuncionario oFrmCadFuncionario;
        frmCadastroMarca oFrmCadMarca;

        // Formulários de Consulta
        frmConsultaPais oFrmConPais;
        frmConsultaEstado oFrmConEstado;
        frmConsultaCidade oFrmConCidade;
        frmConsultaFuncionario oFrmConFuncionario;
        frmConsultaMarca oFrmConMarca;

        public Interfaces()
        {
            // Instancia Formulários de Consulta
            oFrmConPais = new frmConsultaPais();
            oFrmConEstado = new frmConsultaEstado();
            oFrmConCidade = new frmConsultaCidade();
            oFrmConFuncionario = new frmConsultaFuncionario();
            oFrmConMarca = new frmConsultaMarca();

            // Instancia Formulários de Cadastro
            oFrmCadPais = new frmCadastroPais();
            oFrmCadEstado = new frmCadastroEstado();
            oFrmCadCidade = new frmCadastroCidade();
            oFrmCadFuncionario = new frmCadastroFuncionario();
            oFrmCadMarca = new frmCadastroMarca();

            // Vincula Formulários de Consulta aos de Cadastro
            oFrmConPais.setFrmCadastro(oFrmCadPais);
            oFrmConEstado.setFrmCadastro(oFrmCadEstado);
            oFrmConCidade.setFrmCadastro(oFrmCadCidade);
            oFrmConFuncionario.setFrmCadastro(oFrmCadFuncionario);
            oFrmConMarca.setFrmCadastro(oFrmCadMarca);

            // Vincula Consultas necessárias aos Cadastros
            oFrmCadEstado.setConsultaPais(oFrmConPais);
            oFrmCadCidade.setConsultaEstado(oFrmConEstado);
            oFrmCadFuncionario.setConsultaCidade(oFrmConCidade);
        }

        public void pecaConsultaPais(pais oPais, Controller_pais oController_pais)
        {
            oFrmConPais.ConhecaObj(oPais, oController_pais);
            oFrmConPais.ShowDialog();
        }

        public void pecaConsultaEstado(estado oEstado, Controller_estado oController_estado)
        {
            oFrmConEstado.ConhecaObj(oEstado, oController_estado);
            oFrmConEstado.ShowDialog();
        }

        public void pecaConsultaCidade(cidade aCidade, Controller_cidade oController_cidade)
        {
            oFrmConCidade.ConhecaObj(aCidade, oController_cidade);
            oFrmConCidade.ShowDialog();
        }

        public void pecaConsultaMarca(marca oMarca, Controller_marca oController_marca)
        {
            oFrmConMarca.ConhecaObj(oMarca, oController_marca);
            oFrmConMarca.ShowDialog();
        }

        public void pecaConsultaFuncionario(funcionario oFuncionario, Controller_funcionario oController_funcionario)
        {
            oFrmConFuncionario.ConhecaObj(oFuncionario, oController_funcionario);
            oFrmConFuncionario.ShowDialog();
        }
    }
}
