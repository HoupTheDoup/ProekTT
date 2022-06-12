using AutoMapper;
using WebLibrary.Domain.Dtos;
using WebLibrary.Web.Models.AuthorModels;
using WebLibrary.Web.Models.BookModels;
using WebLibrary.Web.Models.Books;
using WebLibrary.Web.Models.PublisherModels;

namespace WebLibrary.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookViewModel, BookDto>().ReverseMap();
            CreateMap<BookCreateModel, BookDto>().ReverseMap();
            CreateMap<AuthorViewModel, AuthorDto>().ReverseMap();
            CreateMap<AuthorCreateModel, AuthorDto>().ReverseMap();
            CreateMap<PublisherViewModel, PublisherDto>().ReverseMap();
            CreateMap<PublisherCreateModel, PublisherDto>().ReverseMap();
        }
    }
}
