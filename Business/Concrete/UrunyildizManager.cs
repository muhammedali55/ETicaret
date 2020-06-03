
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class UrunyildizManager : IUrunyildizService
    {
        IUrunyildizDal _UrunyildizDal;
        public UrunyildizManager(IUrunyildizDal UrunyildizService)
        {
            _UrunyildizDal = UrunyildizService;
        }
        public void Add(Tblurunyildiz entity)
        {
            _UrunyildizDal.Insert(entity);
        }
        public void Delete(Tblurunyildiz entity)
        {
            _UrunyildizDal.Delete(entity);
        }
        public void DeleteList(List<Tblurunyildiz> list)
        {
            foreach (var item in list)
            {
                _UrunyildizDal.Delete(item);
            }
        }
        public List<Tblurunyildiz> GetAll()
        {
            return _UrunyildizDal.GetList();
        }
        public Tblurunyildiz GetById(int id)
        {
            return _UrunyildizDal.Get(x => x.Id == id);
        }
        public void Update(Tblurunyildiz entity)
        {
            _UrunyildizDal.Update(entity);
        }
    }
}