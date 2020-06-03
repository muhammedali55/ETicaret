
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class GaleriHomedesignManager : IGaleriHomedesignService
    {
        IGaleriHomedesignDal _GaleriHomedesignDal;
        public GaleriHomedesignManager(IGaleriHomedesignDal GaleriHomedesignService)
        {
            _GaleriHomedesignDal = GaleriHomedesignService;
        }
        public void Add(TblgaleriHomedesign entity)
        {
            _GaleriHomedesignDal.Insert(entity);
        }
        public void Delete(TblgaleriHomedesign entity)
        {
            _GaleriHomedesignDal.Delete(entity);
        }
        public void DeleteList(List<TblgaleriHomedesign> list)
        {
            foreach (var item in list)
            {
                _GaleriHomedesignDal.Delete(item);
            }
        }
        public List<TblgaleriHomedesign> GetAll()
        {
            return _GaleriHomedesignDal.GetList();
        }
        public TblgaleriHomedesign GetById(int id)
        {
            return _GaleriHomedesignDal.Get(x => x.Id == id);
        }
        public void Update(TblgaleriHomedesign entity)
        {
            _GaleriHomedesignDal.Update(entity);
        }
    }
}