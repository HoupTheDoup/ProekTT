using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;
using WebLibrary.Web.Models.BookModels;
using WebLibrary.Web.Models.Books;

namespace WebLibrary.Web.Controllers
{
    public class BookController : Controller
    {
        protected readonly IBookService _bookService;
        protected readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var list = _bookService.GetAll();
            return View(_mapper.Map<List<BookViewModel>>(list));
        }

        public IActionResult AddBook(BookCreateModel book)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }    

            _bookService.CreateBook(_mapper.Map<BookDto>(book));
            return RedirectToAction("Index");
        }

        public IActionResult EditBook(BookCreateModel book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookService.CreateBook(_mapper.Map<BookDto>(book));
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBook(Guid id)
        {
            _bookService.DeleteBook(id);

            return RedirectToAction("Index");
        }

        public IActionResult DetailsBook(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}