using Microsoft.AspNetCore.Mvc;
using XOakStore.Models;

namespace XOakStore.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _produtos = new List<Produto>(); // Aqui você pode substituir por acesso ao banco

        // Ação para listar os produtos
        public ActionResult Index()
        {
            return View(_produtos); // Passando a lista de produtos para a view
        }

        // Ação para criar um novo produto
        [HttpPost]
        public ActionResult Criar(Produto produto)
        {
            _produtos.Add(produto);
            return RedirectToAction("Index");
        }

    }
}
