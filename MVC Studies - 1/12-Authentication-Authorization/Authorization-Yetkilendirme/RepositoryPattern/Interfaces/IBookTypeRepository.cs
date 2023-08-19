using Authorization_Yetkilendirme.Dto;
using Authorization_Yetkilendirme.Models;
using System.Collections.Generic;

namespace Authorization_Yetkilendirme.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SelectBookTypeDto();
    }
}
