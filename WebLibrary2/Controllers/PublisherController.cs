using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;
using WebLibrary.Web.Models.PublisherModels;

namespace WebLibrary.Web.Controllers
{
    public class PublisherController : Controller
    {
        protected readonly IPublisherService _publisherService;
        protected readonly IMapper _mapper;

        public PublisherController(IPublisherService publisherService, IMapper mapper)
        {
            _publisherService = publisherService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListPublishers()
        {

            List<PublisherViewModel> publishers = _mapper.Map<List<PublisherViewModel>>(_publisherService.GetAll());
            return View(publishers);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult AddPublisher()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddPublisher(PublisherCreateModel publisher)
        {
            if(!ModelState.IsValid) return View(publisher);
            PublisherDto newPublisher = _mapper.Map<PublisherDto>(publisher);
            _publisherService.CreatePublisher(newPublisher);
            return RedirectToAction("ListPublishers");
        }

        [HttpGet]
        public IActionResult EditPublisher(Guid id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(_mapper.Map<PublisherCreateModel>(publisher));
        }

        [HttpPost]
        public IActionResult EditPublisher(PublisherCreateModel publisher)
        {
            if (!ModelState.IsValid) return View(publisher);
            _publisherService.UpdatePublisher(_mapper.Map<PublisherDto>(publisher));
            return RedirectToAction("ListPublishers");
        }

        public IActionResult DeletePublisher(Guid id)
        {
            _publisherService.DeletePublisher(id);
            return RedirectToAction("ListPublishers");
        }

        public IActionResult DetailsPublisher(Guid id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(_mapper.Map<PublisherViewModel>(publisher));
        }

    }
}
