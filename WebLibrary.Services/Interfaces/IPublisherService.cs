using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Services.Interfaces
{
    public interface IPublisherService
    {
        public Guid CreatePublisher(PublisherDto book);

        public Guid UpdatePublisher(PublisherDto book);

        public void DeletePublisher(Guid id);

        public PublisherDto GetPublisherById(Guid id);

        public List<PublisherDto> GetAll();
    }
}
