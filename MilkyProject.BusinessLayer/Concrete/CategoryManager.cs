using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categorDal;

        public CategoryManager(ICategoryDal categorDal)
        {
            _categorDal = categorDal;
        }

        public void TDelete(int id)
        {
            _categorDal.Delete(id);
        }

        public Category TGetById(int id)
        {
            return _categorDal.GetById(id);
        }

        public List<Category> TGetListAll()
        {
            return _categorDal.GetListAll();
        }

        public void TInsert(Category entity)
        {
            _categorDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categorDal.Update(entity);
        }
    }
}
