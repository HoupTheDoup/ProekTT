using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;
using WebLibrary.Web.Models.AuthorModels;

namespace WebLibrary.Web.Controllers
{
    public class AuthorController : Controller
    {

        protected readonly IAuthorService _authorService;
        protected readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListAuthors()
        {
           
            List<AuthorViewModel> authors = _mapper.Map<List<AuthorViewModel>>(_authorService.GetAll());
         /*   foreach (var author in authors)
            {
                author.Name = _authorService.GetAuthorName(author.Id);
            }
         */
            return View(authors);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddAuthor(AuthorCreateModel author)
        {
            AuthorDto newAuthor = _mapper.Map<AuthorDto>(author);
            _authorService.CreateAuthor(newAuthor);
            return RedirectToAction("ListAuthors");
        }

        [HttpGet]
        public IActionResult EditAuthor(Guid id)
        {
            var author = _authorService.GetAuthorById(id);
            return View(_mapper.Map<AuthorCreateModel>(author));
        }

        [HttpPost]
        public IActionResult EditAuthor(AuthorCreateModel author)
        {
            _authorService.UpdateAuthor(_mapper.Map<AuthorDto>(author));
            return RedirectToAction("ListAuthors");
        }

        public IActionResult DeleteAuthor(Guid id)
        {
            _authorService.DeleteAuthor(id);
            return RedirectToAction("ListAuthors");
        }







    }
}
