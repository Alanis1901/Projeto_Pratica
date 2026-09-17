using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Os Controllers são responsáveis por controlar as operações do sistema.
//Eles fazem a comunicação entre os formulários e os DAOs.

namespace Projeto_Pratica
{
    internal class Controller
    {
        public Controller()
        {

        }

        public virtual string Salvar(object obj)
        {
            return " ";
        }

        public virtual string CarregaObj(object obj)
        {
            return "";
        }

        public virtual string Excluir(object obj)
        {
            return " ";
        }
    }
}
