using Login_İşlemleri.Dto;
using Login_İşlemleri.Models;
using System.Collections.Generic;

namespace Login_İşlemleri.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SelectBookTypeDto();
    }
}
