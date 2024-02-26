using MvcCoreEFComics.Models;

namespace MvcCoreEFComics.Repositories
{
    public interface IRepositoryComics
    {
        Task<List<Comic>> GetComicsAsync();

        Task<Comic> FindComicAsync(int idComic);

        void InsertComic(string nombre, string imagen, string descripcion);

        void DeleteComic(int idComic);
    }
}
