using AutoMapper;
using WebLibrary.Data.Entities;
using WebLibrary.Domain.Dtos;
using WebLibrary.Web.Models.AuthorModels;
using WebLibrary.Web.Models.BookModels;
using WebLibrary.Web.Models.Books;
using WebLibrary.Web.Models.GenreModels;
using WebLibrary.Web.Models.PublisherModels;

namespace WebLibrary.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookViewModel, BookDto>().ReverseMap();

            CreateMap<BookEntity, BookViewModel>().ForMember(x => x.AuthorName, x =>  x.MapFrom(y => $"{y.Author.FirstName} {y.Author.LastName}"));

            CreateMap<BookCreateModel, BookDto>().ReverseMap();
            CreateMap<AuthorViewModel, AuthorDto>().ReverseMap().ForMember( x => x.Name, x => x.MapFrom(y => $"{y.FirstName} {y.LastName}"));
            CreateMap<AuthorCreateModel, AuthorDto>().ReverseMap();
            CreateMap<PublisherViewModel, PublisherDto>().ReverseMap();
            CreateMap<PublisherCreateModel, PublisherDto>().ReverseMap();
            CreateMap<GenreCreateModel, GenreDto>().ReverseMap();
        }
    }
}
