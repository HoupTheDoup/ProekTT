using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;

namespace WebLibrary.Services
{
    public class PublisherService : IPublisherService
    {
        protected readonly IPublisherRepository _authorRepository;

        public PublisherService(IPublisherRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Guid CreatePublisher(PublisherDto book) => _authorRepository.CreatePublisher(book);

        public void DeletePublisher(Guid id) => _authorRepository.DeletePublisher(id);

        public PublisherDto GetPublisherById(Guid id) => _authorRepository.GetPublisherById(id);

        public Guid UpdatePublisher(PublisherDto book) => _authorRepository.UpdatePublisher(book);

        public List<PublisherDto> GetAll() => _authorRepository.GetAll();
    }
}
