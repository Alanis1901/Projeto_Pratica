using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Os DAOs são responsáveis pela comunicação direta com o banco de dados.
//Toda operação no banco passa pelos DAOs.

namespace Projeto_Pratica
{

    internal class Dao
    {
        public Dao()
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