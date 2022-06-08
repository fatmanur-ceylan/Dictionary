using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFAboutDal: EfEntityRepositoryBase<About, DictionaryContext>, IAboutDal
    {
    }
}
