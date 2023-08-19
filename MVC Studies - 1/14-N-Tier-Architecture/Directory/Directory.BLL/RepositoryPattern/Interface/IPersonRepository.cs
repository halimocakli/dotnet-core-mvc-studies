using Directory.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.BLL.RepositoryPattern.Interface
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
