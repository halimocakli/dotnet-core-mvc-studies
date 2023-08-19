using Directory.BLL.RepositoryPattern.Base;
using Directory.BLL.RepositoryPattern.Interface;
using Directory.DAL.Context;
using Directory.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.BLL.RepositoryPattern.Concrete
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(MyDbContext db) : base(db) { }
    }
}
