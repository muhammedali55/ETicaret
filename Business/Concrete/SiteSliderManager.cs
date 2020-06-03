using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SiteSliderManager : ISiteSliderService
    {
        ISiteSliderDal _SiteSliderDal;
        public SiteSliderManager(ISiteSliderDal SiteSliderService)
        {
            _SiteSliderDal = SiteSliderService;
        }
        public void Add(TblsiteSlider entity)
        {
            _SiteSliderDal.Insert(entity);
        }
        public void Delete(TblsiteSlider entity)
        {
            _SiteSliderDal.Delete(entity);
        }
        public void DeleteList(List<TblsiteSlider> list)
        {
            foreach (var item in list)
            {
                _SiteSliderDal.Delete(item);
            }
        }
        public List<TblsiteSlider> GetAll()
        {
            return _SiteSliderDal.GetList();
        }
        public TblsiteSlider GetById(int id)
        {
            return _SiteSliderDal.Get(x => x.Id == id);
        }
        public void Update(TblsiteSlider entity)
        {
            _SiteSliderDal.Update(entity);
        }
    }
}