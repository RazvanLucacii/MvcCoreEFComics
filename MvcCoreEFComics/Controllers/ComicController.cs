using Microsoft.AspNetCore.Mvc;
using MvcCoreEFComics.Models;
using MvcCoreEFComics.Repositories;

namespace MvcCoreEFComics.Controllers
{
    public class ComicController : Controller
    {
        IRepositoryComics repo;

        public ComicController(IRepositoryComics repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Comic> comics = await this.repo.GetComicsAsync(); 
            return View(comics);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Comic comic)
        {
            this.repo.InsertComic(comic.Nombre, comic.Imagen, comic.Descripcion);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int idComic)
        {
            this.repo.DeleteComic(idComic);
            return RedirectToAction("Index");
        }
    }
}
