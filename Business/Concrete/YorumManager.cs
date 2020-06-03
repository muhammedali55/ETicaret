
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class YorumManager : IYorumService
    {
        IYorumDal _YorumDal;
        public YorumManager(IYorumDal YorumService)
        {
            _YorumDal = YorumService;
        }
        public void Add(Tblyorum entity)
        {
            _YorumDal.Insert(entity);
        }
        public void Delete(Tblyorum entity)
        {
            _YorumDal.Delete(entity);
        }
        public void DeleteList(List<Tblyorum> list)
        {
            foreach (var item in list)
            {
                _YorumDal.Delete(item);
            }
        }
        public List<Tblyorum> GetAll()
        {
            return _YorumDal.GetList();
        }
        public Tblyorum GetById(int id)
        {
            return _YorumDal.Get(x => x.Id == id);
        }
        public void Update(Tblyorum entity)
        {
            _YorumDal.Update(entity);
        }
    }
}