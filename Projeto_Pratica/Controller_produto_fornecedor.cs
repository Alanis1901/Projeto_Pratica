using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pratica
{
    class Controller_produto_fornecedor : Controller
    {
        Dao_produto_fornecedor aDao_produto_fornecedor;

        public Controller_produto_fornecedor()
        {
            aDao_produto_fornecedor = new Dao_produto_fornecedor();
        }

        public override string Salvar(object obj)
        {
            return aDao_produto_fornecedor.Salvar(obj);
        }

        public override string Excluir(object obj)
        {
            return aDao_produto_fornecedor.Excluir(obj);
        }

        public List<produto_fornecedor> ListarPorProduto(int idProduto)
        {
            return aDao_produto_fornecedor.ListarPorProduto(idProduto);
        }
    }
}
