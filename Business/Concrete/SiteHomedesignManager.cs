
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SiteHomedesignManager : ISiteHomedesignService
    {
        ISiteHomedesignDal _SiteHomedesignDal;
        public SiteHomedesignManager(ISiteHomedesignDal SiteHomedesignService)
        {
            _SiteHomedesignDal = SiteHomedesignService;
        }
        public void Add(TblsiteHomedesign entity)
        {
            _SiteHomedesignDal.Insert(entity);
        }
        public void Delete(TblsiteHomedesign entity)
        {
            _SiteHomedesignDal.Delete(entity);
        }
        public void DeleteList(List<TblsiteHomedesign> list)
        {
            foreach (var item in list)
            {
                _SiteHomedesignDal.Delete(item);
            }
        }
        public List<TblsiteHomedesign> GetAll()
        {
            return _SiteHomedesignDal.GetList();
        }
        public TblsiteHomedesign GetById(int id)
        {
            return _SiteHomedesignDal.Get(x => x.Id == id);
        }
        public void Update(TblsiteHomedesign entity)
        {
            _SiteHomedesignDal.Update(entity);
        }
    }
}