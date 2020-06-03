
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class İletisimHomedesignManager : IİletisimHomedesignService
    {
        IİletisimHomedesignDal _İletisimHomedesignDal;
        public İletisimHomedesignManager(IİletisimHomedesignDal İletisimHomedesignService)
        {
            _İletisimHomedesignDal = İletisimHomedesignService;
        }
        public void Add(TbliletisimHomedesign entity)
        {
            _İletisimHomedesignDal.Insert(entity);
        }
        public void Delete(TbliletisimHomedesign entity)
        {
            _İletisimHomedesignDal.Delete(entity);
        }
        public void DeleteList(List<TbliletisimHomedesign> list)
        {
            foreach (var item in list)
            {
                _İletisimHomedesignDal.Delete(item);
            }
        }
        public List<TbliletisimHomedesign> GetAll()
        {
            return _İletisimHomedesignDal.GetList();
        }
        public TbliletisimHomedesign GetById(int id)
        {
            return _İletisimHomedesignDal.Get(x => x.Id == id);
        }
        public void Update(TbliletisimHomedesign entity)
        {
            _İletisimHomedesignDal.Update(entity);
        }
    }
}