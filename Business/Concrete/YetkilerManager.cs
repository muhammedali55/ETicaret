
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class YetkilerManager : IYetkilerService
    {
        IYetkilerDal _YetkilerDal;
        public YetkilerManager(IYetkilerDal YetkilerService)
        {
            _YetkilerDal = YetkilerService;
        }
        public void Add(Tblyetkiler entity)
        {
            _YetkilerDal.Insert(entity);
        }
        public void Delete(Tblyetkiler entity)
        {
            _YetkilerDal.Delete(entity);
        }
        public void DeleteList(List<Tblyetkiler> list)
        {
            foreach (var item in list)
            {
                _YetkilerDal.Delete(item);
            }
        }
        public List<Tblyetkiler> GetAll()
        {
            return _YetkilerDal.GetList();
        }
        public Tblyetkiler GetById(int id)
        {
            return _YetkilerDal.Get(x => x.Id == id);
        }
        public void Update(Tblyetkiler entity)
        {
            _YetkilerDal.Update(entity);
        }
    }
}