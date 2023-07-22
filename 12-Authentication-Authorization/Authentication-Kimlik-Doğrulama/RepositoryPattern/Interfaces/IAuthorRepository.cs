﻿using Authentication_Kimlik_Doğrulama.Dto;
using Authentication_Kimlik_Doğrulama.Models;
using System.Collections.Generic;

namespace Authentication_Kimlik_Doğrulama.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
