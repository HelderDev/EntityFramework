    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
   public class ProdutoAplicacao
    {
        public DBProduto banco { get; set; }
        public ProdutoAplicacao()
        {
            banco = new DBProduto();

        }

        public void Salvar (Produto produto)
        {
            banco.Produtos.Add(produto);
            banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return banco.Produtos.ToList();
        }
        public void Alterar(Produto produto)
        {
            Produto prodSalvar = banco.Produtos.Where(x => x.id == produto.id).First();
            prodSalvar.nome = produto.nome;
            banco.SaveChanges();
        }
        public void Excluir(int id)
        {
            Produto prodExcluir = banco.Produtos.Where(x => x.id == id).First();
           // banco.Produtos.Remove(prodExcluir);
            banco.Set<Produto>().Remove(prodExcluir);
            banco.SaveChanges();
        }
    }
}
