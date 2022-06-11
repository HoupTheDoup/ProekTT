﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Data.Repositories.Interfaces;
using WebLibrary.Domain.Dtos;
using WebLibrary.Services.Interfaces;

namespace WebLibrary.Services
{
    public class AuthorService : IAuthorService
    {
        protected readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Guid CreateAuthor(AuthorDto book) => _authorRepository.CreateAuthor(book);

        public void DeleteAuthor(Guid id) => _authorRepository.DeleteAuthor(id);

        public AuthorDto GetAuthorById(Guid id) => _authorRepository.GetAuthorById(id);

        public Guid UpdateAuthor(AuthorDto book) => _authorRepository.UpdateAuthor(book);

        public List<AuthorDto> GetAll() => _authorRepository.GetAll();
    }
}
