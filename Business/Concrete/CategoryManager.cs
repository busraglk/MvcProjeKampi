using Business.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //GenericRepository'i newlemeden, genericrepository bağımlılığını minimize ederek GenericRepository içerisindeki değerlere erişim sağlamış olduk.
        // Farklı bir teknolojiye geçtiğimde ama kolaylık sağlayacak.
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

       

    }
}
