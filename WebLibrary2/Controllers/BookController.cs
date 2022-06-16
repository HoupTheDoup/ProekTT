using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;
using WebLibrary.Web.Models.AuthorModels;
using WebLibrary.Web.Models.BookModels;
using WebLibrary.Web.Models.Books;
using WebLibrary.Web.Models.GenreModels;
using WebLibrary.Web.Models.PublisherModels;

namespace WebLibrary.Web.Controllers
{
    public class BookController : Controller
    {
        protected readonly IPublisherService _publisherService;
        protected readonly IAuthorService _authorService;
        protected readonly IBookService _bookService;
        protected readonly IGenreService _genreService;
        protected readonly IMapper _mapper;

        public BookController(IBookService bookService, IAuthorService authorService, IPublisherService publisherService, IGenreService genreService, IMapper mapper)
        {
            _bookService = bookService;
            _authorService = authorService;
            _publisherService = publisherService;
            _genreService = genreService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListBooks()
        {
            var books = _bookService.GetAll<BookViewModel>();
            return View(books);
        }

        [HttpGet]
        [Authorize(Roles ="admin")]
        public IActionResult AddBook()
        {
            BookCreateModel model = new BookCreateModel();
            PopulateDropDowns(model);
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddBook(BookCreateModel book)
        {
            BookDto newBook = _mapper.Map<BookDto>(book);
            _bookService.CreateBook(newBook);
            return RedirectToAction("ListBooks");
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult EditBook(Guid id)
        {  
            var book = _mapper.Map<BookCreateModel>(_bookService.GetBookById(id));
            PopulateDropDowns(book);
            return View(book);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult EditBook(BookCreateModel book)
        {
            _bookService.UpdateBook(_mapper.Map<BookDto>(book));
            return RedirectToAction("ListBooks");
        }

        [Authorize(Roles = "admin")]
        public IActionResult DeleteBook(Guid id)
        {
            _bookService.DeleteBook(id);
            return RedirectToAction("ListBooks");
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddGenre(GenreCreateModel genre)
        {
            GenreDto newGenre = _mapper.Map<GenreDto>(genre);
            _genreService.CreateGenre(newGenre);
            return RedirectToAction("AddBook");
        }

        [Authorize(Roles = "admin")]
        public IActionResult DeleteGenre(Guid id)
        {
            _genreService.DeleteGenre(id);
            return RedirectToAction("AddBook");
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult ListGenres()
        {
            var genres = _mapper.Map<List<GenreCreateModel>>(_genreService.GetAll());
            return View(genres);
        }

        private BookCreateModel PopulateDropDowns(BookCreateModel model)
        {
            model.Authors = _mapper.Map<List<AuthorViewModel>>(_authorService.GetAll());
            model.Publishers = _mapper.Map<List<PublisherViewModel>>(_publisherService.GetAll());
            model.Genres = _mapper.Map<List<GenreCreateModel>>(_genreService.GetAll());
            return model;
        }


    }
}
