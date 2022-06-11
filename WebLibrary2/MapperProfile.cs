using AutoMapper;
using WebLibrary.Domain.Dtos;
using WebLibrary.Web.Models.BookModels;
using WebLibrary.Web.Models.Books;

namespace WebLibrary.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookViewModel, BookDto>().ReverseMap();
            CreateMap<BookCreateModel, BookDto>().ReverseMap();  
        }
    }
}
