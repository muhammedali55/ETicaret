
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class OzellikUrunManager : IOzellikUrunService
    {
        IOzellikUrunDal _OzellikUrunDal;
        public OzellikUrunManager(IOzellikUrunDal OzellikUrunService)
        {
            _OzellikUrunDal = OzellikUrunService;
        }
        public void Add(TblozellikUrun entity)
        {
            _OzellikUrunDal.Insert(entity);
        }
        public void Delete(TblozellikUrun entity)
        {
            _OzellikUrunDal.Delete(entity);
        }
        public void DeleteList(List<TblozellikUrun> list)
        {
            foreach (var item in list)
            {
                _OzellikUrunDal.Delete(item);
            }
        }
        public List<TblozellikUrun> GetAll()
        {
            return _OzellikUrunDal.GetList();
        }
        public TblozellikUrun GetById(int id)
        {
            return _OzellikUrunDal.Get(x => x.Id == id);
        }
        public void Update(TblozellikUrun entity)
        {
            _OzellikUrunDal.Update(entity);
        }
    }
}