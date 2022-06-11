using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories.Interfaces
{
    public interface IPublisherRepository
    {
        public Guid CreatePublisher(PublisherDto book);

        public Guid UpdatePublisher(PublisherDto book);

        public void DeletePublisher(Guid id);

        public PublisherDto GetPublisherById(Guid id);

        public List<PublisherDto> GetAll();
    }
}
