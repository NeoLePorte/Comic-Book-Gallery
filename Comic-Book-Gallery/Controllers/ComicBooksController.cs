using Comic_Book_Gallery.Data;
using Comic_Book_Gallery.Models;
using System.Web.Mvc;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        // GET: ComicBooks
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(model: comicBook);
        }
    }
}