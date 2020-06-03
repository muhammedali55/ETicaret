
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class OzellikManager : IOzellikService
    {
        IOzellikDal _OzellikDal;
        public OzellikManager(IOzellikDal OzellikService)
        {
            _OzellikDal = OzellikService;
        }
        public void Add(Tblozellik entity)
        {
            _OzellikDal.Insert(entity);
        }
        public void Delete(Tblozellik entity)
        {
            _OzellikDal.Delete(entity);
        }
        public void DeleteList(List<Tblozellik> list)
        {
            foreach (var item in list)
            {
                _OzellikDal.Delete(item);
            }
        }
        public List<Tblozellik> GetAll()
        {
            return _OzellikDal.GetList();
        }
        public Tblozellik GetById(int id)
        {
            return _OzellikDal.Get(x => x.Id == id);
        }
        public void Update(Tblozellik entity)
        {
            _OzellikDal.Update(entity);
        }
    }
}