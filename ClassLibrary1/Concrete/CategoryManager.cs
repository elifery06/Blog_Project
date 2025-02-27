using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repoCategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repoCategory.List();
        }
    }
}
