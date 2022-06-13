using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Entities;
using WebLibrary.Domain.Dtos;

namespace WebLibrary.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookEntity, BookDto>().ReverseMap();
            CreateMap<AuthorEntity, AuthorDto>().ReverseMap();
            CreateMap<PublisherEntity, PublisherDto>().ReverseMap();
            CreateMap<GenreEntity, GenreDto>().ReverseMap();

        }   
    }


}
