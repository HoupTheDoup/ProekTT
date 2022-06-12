using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Entities;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        protected readonly WebLibraryDbContext _dbContext;
        protected readonly IMapper _mapper;

        public PublisherRepository(WebLibraryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Guid CreatePublisher(PublisherDto publisher)
        {
            PublisherEntity entity = _mapper.Map<PublisherEntity>(publisher);
            entity.Id = Guid.NewGuid();

            _dbContext.Publishers.Add(entity);
            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void DeletePublisher(Guid id)
        {
            PublisherEntity publisher = _dbContext.Publishers.FirstOrDefault(p => p.Id == id);
            if (publisher != null)
            {
                _dbContext.Publishers.Remove(publisher);
                _dbContext.SaveChanges();
            }
        }
        public PublisherDto GetPublisherById(Guid id)
        {
            var publisher = _dbContext.Publishers.FirstOrDefault(b => b.Id == id);
            return _mapper.Map<PublisherDto>(publisher);
        }

        public Guid UpdatePublisher(PublisherDto publisher)
        {
            _dbContext.Publishers.Update(_mapper.Map<PublisherEntity>(publisher));
            _dbContext.SaveChanges();

            return publisher.Id;
        }
        public List<PublisherDto> GetAll()
        {
            return _mapper.Map<List<PublisherDto>>(_dbContext.Publishers.ToList());
        }

        public string? GetPublisherName(Guid id)
        {
            var publisher = _dbContext.Publishers.FirstOrDefault(a => a.Id == id);
            return publisher.Name;
        }




    }
}
