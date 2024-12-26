using PolimedicaSite.Models;

namespace PolimedicaSite.Interface
{
    public interface IProdutoRepository
    {
        bool Add(Produto produto);
        bool Update(Produto produto);
        bool Delete(Produto produto);
        Task<Produto> GetByIdAsync(int id);
        Task<IEnumerable<Produto>> GetAll();
    }
}
