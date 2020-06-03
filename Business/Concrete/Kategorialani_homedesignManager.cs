
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class Kategorialani_homedesignManager : IKategorialani_homedesignService
    {
        IKategorialani_homedesignDal _Kategorialani_homedesignDal;
        public Kategorialani_homedesignManager(IKategorialani_homedesignDal Kategorialani_homedesignService)
        {
            _Kategorialani_homedesignDal = Kategorialani_homedesignService;
        }
        public void Add(TblkategorialaniHomedesign entity)
        {
            _Kategorialani_homedesignDal.Insert(entity);
        }
        public void Delete(TblkategorialaniHomedesign entity)
        {
            _Kategorialani_homedesignDal.Delete(entity);
        }
        public void DeleteList(List<TblkategorialaniHomedesign> list)
        {
            foreach (var item in list)
            {
                _Kategorialani_homedesignDal.Delete(item);
            }
        }
        public List<TblkategorialaniHomedesign> GetAll()
        {
            return _Kategorialani_homedesignDal.GetList();
        }
        public TblkategorialaniHomedesign GetById(int id)
        {
            return _Kategorialani_homedesignDal.Get(x => x.Id == id);
        }
        public void Update(TblkategorialaniHomedesign entity)
        {
            _Kategorialani_homedesignDal.Update(entity);
        }
    }
}