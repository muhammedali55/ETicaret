
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _ModelDal;
        public ModelManager(IModelDal ModelService)
        {
            _ModelDal = ModelService;
        }
        public void Add(Tblmodel entity)
        {
            _ModelDal.Insert(entity);
        }
        public void Delete(Tblmodel entity)
        {
            _ModelDal.Delete(entity);
        }
        public void DeleteList(List<Tblmodel> list)
        {
            foreach (var item in list)
            {
                _ModelDal.Delete(item);
            }
        }
        public List<Tblmodel> GetAll()
        {
            return _ModelDal.GetList();
        }
        public Tblmodel GetById(int id)
        {
            return _ModelDal.Get(x => x.Id == id);
        }
        public void Update(Tblmodel entity)
        {
            _ModelDal.Update(entity);
        }
    }
}