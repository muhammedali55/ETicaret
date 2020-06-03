
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class ModelUrunManager : IModelUrunService
    {
        IModelUrunDal _ModelUrunDal;
        public ModelUrunManager(IModelUrunDal ModelUrunService)
        {
            _ModelUrunDal = ModelUrunService;
        }
        public void Add(TblmodelUrun entity)
        {
            _ModelUrunDal.Insert(entity);
        }
        public void Delete(TblmodelUrun entity)
        {
            _ModelUrunDal.Delete(entity);
        }
        public void DeleteList(List<TblmodelUrun> list)
        {
            foreach (var item in list)
            {
                _ModelUrunDal.Delete(item);
            }
        }
        public List<TblmodelUrun> GetAll()
        {
            return _ModelUrunDal.GetList();
        }
        public TblmodelUrun GetById(int id)
        {
            return _ModelUrunDal.Get(x => x.Id == id);
        }
        public void Update(TblmodelUrun entity)
        {
            _ModelUrunDal.Update(entity);
        }
    }
}