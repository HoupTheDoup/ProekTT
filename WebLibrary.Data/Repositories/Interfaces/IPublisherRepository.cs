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
        public Guid CreatePublisher(PublisherDto publisher);

        public Guid UpdatePublisher(PublisherDto publisher);

        public void DeletePublisher(Guid id);

        public PublisherDto GetPublisherById(Guid id);

        public List<PublisherDto> GetAll();

        public string GetPublisherName(Guid id);
    }
}
