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
        protected readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public Guid CreatePublisher(PublisherDto publisher) => _publisherRepository.CreatePublisher(publisher);

        public void DeletePublisher(Guid id) => _publisherRepository.DeletePublisher(id);

        public PublisherDto GetPublisherById(Guid id) => _publisherRepository.GetPublisherById(id);

        public Guid UpdatePublisher(PublisherDto publisher) => _publisherRepository.UpdatePublisher(publisher);

        public List<PublisherDto> GetAll() => _publisherRepository.GetAll();

        public string? GetPublisherName(Guid id) => _publisherRepository.GetPublisherName(id);
    }
}
