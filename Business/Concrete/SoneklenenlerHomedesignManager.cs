
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SoneklenenlerHomedesignManager : ISoneklenenlerHomedesignService
    {
        ISoneklenenlerHomedesignDal _SoneklenenlerHomedesignDal;
        public SoneklenenlerHomedesignManager(ISoneklenenlerHomedesignDal SoneklenenlerHomedesignService)
        {
            _SoneklenenlerHomedesignDal = SoneklenenlerHomedesignService;
        }
        public void Add(TblsoneklenenlerHomedesign entity)
        {
            _SoneklenenlerHomedesignDal.Insert(entity);
        }
        public void Delete(TblsoneklenenlerHomedesign entity)
        {
            _SoneklenenlerHomedesignDal.Delete(entity);
        }
        public void DeleteList(List<TblsoneklenenlerHomedesign> list)
        {
            foreach (var item in list)
            {
                _SoneklenenlerHomedesignDal.Delete(item);
            }
        }
        public List<TblsoneklenenlerHomedesign> GetAll()
        {
            return _SoneklenenlerHomedesignDal.GetList();
        }
        public TblsoneklenenlerHomedesign GetById(int id)
        {
            return _SoneklenenlerHomedesignDal.Get(x => x.Id == id);
        }
        public void Update(TblsoneklenenlerHomedesign entity)
        {
            _SoneklenenlerHomedesignDal.Update(entity);
        }
    }
}