using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoAplicacao app = new ProdutoAplicacao();
            Produto p = new Produto();
            p.id = 2;
             p.nome = "Bolacha";
           // app.Salvar(p);
            //app.Alterar(p);
            app.Excluir(3);
             foreach (var produto in app.Listar())
            {
                Console.WriteLine(produto.id + "-" + produto.nome);

            }
 
            Console.ReadKey();
        }
    }
}
