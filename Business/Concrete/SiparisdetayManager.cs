
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SiparisdetayManager : ISiparisdetayService
    {
        ISiparisdetayDal _SiparisdetayDal;
        public SiparisdetayManager(ISiparisdetayDal SiparisdetayService)
        {
            _SiparisdetayDal = SiparisdetayService;
        }
        public void Add(Tblsiparisdetay entity)
        {
            _SiparisdetayDal.Insert(entity);
        }
        public void Delete(Tblsiparisdetay entity)
        {
            _SiparisdetayDal.Delete(entity);
        }
        public void DeleteList(List<Tblsiparisdetay> list)
        {
            foreach (var item in list)
            {
                _SiparisdetayDal.Delete(item);
            }
        }
        public List<Tblsiparisdetay> GetAll()
        {
            return _SiparisdetayDal.GetList();
        }
        public Tblsiparisdetay GetById(int id)
        {
            return _SiparisdetayDal.Get(x => x.Id == id);
        }
        public void Update(Tblsiparisdetay entity)
        {
            _SiparisdetayDal.Update(entity);
        }
    }
}