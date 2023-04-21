using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();

        }

        public void CatergoryAddBL(Category p)
        {
            if(p.CategoryName==null || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
                
            }
        }


    }
}
