
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class UrunresimManager : IUrunresimService
    {
        IUrunresimDal _UrunresimDal;
        public UrunresimManager(IUrunresimDal UrunresimService)
        {
            _UrunresimDal = UrunresimService;
        }
        public void Add(Tblurunresim entity)
        {
            _UrunresimDal.Insert(entity);
        }
        public void Delete(Tblurunresim entity)
        {
            _UrunresimDal.Delete(entity);
        }
        public void DeleteList(List<Tblurunresim> list)
        {
            foreach (var item in list)
            {
                _UrunresimDal.Delete(item);
            }
        }
        public List<Tblurunresim> GetAll()
        {
            return _UrunresimDal.GetList();
        }
        public Tblurunresim GetById(int id)
        {
            return _UrunresimDal.Get(x => x.Id == id);
        }
        public void Update(Tblurunresim entity)
        {
            _UrunresimDal.Update(entity);
        }
    }
}