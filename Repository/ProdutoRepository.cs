using Microsoft.EntityFrameworkCore;
using PolimedicaSite.Data;
using PolimedicaSite.Interface;
using PolimedicaSite.Models;

namespace PolimedicaSite.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly PolimedicaDbContext _context;

        public ProdutoRepository(PolimedicaDbContext context)
        {
            _context = context;
        }
        public bool Add(Produto produto)
        {
            _context.Add(produto);
            return Save();
        }
        public bool Delete(Produto produto)
        {
            _context.Remove(produto);
            return Save();
        }
        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _context.Produtos.ToListAsync();
        }
        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(i => i.Id == id);
        }
        public bool Update(Produto produto)
        {
            _context.Update(produto);
            return Save();
        }

        public bool Save() {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }   
    }
}
