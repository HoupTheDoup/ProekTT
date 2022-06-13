using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;
using WebLibrary.Web.Models.AuthorModels;
using WebLibrary.Web.Models.BookModels;
using WebLibrary.Web.Models.Books;
using WebLibrary.Web.Models.PublisherModels;

namespace WebLibrary.Web.Controllers
{
    public class BookController : Controller
    {
        protected readonly IPublisherService _publisherService;
        protected readonly IAuthorService _authorService;
        protected readonly IBookService _bookService;
        protected readonly IMapper _mapper;

        public BookController(IBookService bookService, IAuthorService authorService, IPublisherService publisherService, IMapper mapper)
        {
            _publisherService = publisherService;
            _authorService = authorService;
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListBooks()
        {
            var books = _bookService.GetAll<BookViewModel>();
            return View(books);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            List<AuthorViewModel> authors = _mapper.Map<List<AuthorViewModel>>(_authorService.GetAll());
            List<PublisherViewModel> publisher = _mapper.Map<List<PublisherViewModel>>(_publisherService.GetAll());
            ViewBag.Authors = authors;
            ViewBag.Publishers = publisher;
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookCreateModel book)
        {
            BookDto newBook = _mapper.Map<BookDto>(book);
            _bookService.CreateBook(newBook);
            return RedirectToAction("ListBooks");
        }

        [HttpGet]
        public IActionResult EditBook(Guid id)
        {
            var book = _bookService.GetBookById(id);
            return View(_mapper.Map<BookCreateModel>(book));
        }

        [HttpPost]
        public IActionResult EditBook(BookCreateModel book)
        {
            _bookService.UpdateBook(_mapper.Map<BookDto>(book));
            return RedirectToAction("ListBooks");
        }

        public IActionResult DeleteBook(Guid id)
        {
            _bookService.DeleteBook(id);
            return RedirectToAction("ListBooks");
        }
    }
}
