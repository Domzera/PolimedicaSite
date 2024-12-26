using Microsoft.AspNetCore.Mvc;
using PolimedicaSite.Interface;
using PolimedicaSite.Models;
using PolimedicaSite.ViewModel;

namespace PolimedicaSite.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Produto> produto = await _produtoRepository.GetAll();
            return View(produto);
        }
        public IActionResult Create()
        {
            //var CurUserId = _httpContexAcessor.HttpContext.User.GetUserId();
            var cadastroProduto = new CreateProdutoViewModel();//{AppUserId = curUserId};
            return View(cadastroProduto);
        }
        [HttpPost]
        public IActionResult Create(CreateProdutoViewModel createPVM)
        {
            if (ModelState.IsValid)
            {
                var result = new Produto
                {
                    NomeProduto = createPVM.NomeProduto,
                    Descricao = createPVM.Descricao,
                    Detalhes = createPVM.Detalhes,
                    Ativo = (bool)createPVM.Ativo,
                    Preco = (long)createPVM.Preco,
                    Estoque = (int)createPVM.Estoque,
                    DataCadastro = DateOnly.FromDateTime(DateTime.Now),
                    Imagem1 = createPVM.Imagem1,
                    Imagem2 = createPVM.Imagem2,
                    Imagem3 = createPVM.Imagem3,
                    Imagem4 = createPVM.Imagem4,
                    Imagem5 = createPVM.Imagem5
                };
                _produtoRepository.Add(result);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Falha ao tentar cadastrar!");
            }
            return View("Error");
        }
    }
}
