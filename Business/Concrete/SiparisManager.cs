
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SiparisManager : ISiparisService
    {
        ISiparisDal _SiparisDal;
        public SiparisManager(ISiparisDal SiparisService)
        {
            _SiparisDal = SiparisService;
        }
        public void Add(Tblsiparis entity)
        {
            _SiparisDal.Insert(entity);
        }
        public void Delete(Tblsiparis entity)
        {
            _SiparisDal.Delete(entity);
        }
        public void DeleteList(List<Tblsiparis> list)
        {
            foreach (var item in list)
            {
                _SiparisDal.Delete(item);
            }
        }
        public List<Tblsiparis> GetAll()
        {
            return _SiparisDal.GetList();
        }
        public Tblsiparis GetById(int id)
        {
            return _SiparisDal.Get(x => x.Id == id);
        }
        public void Update(Tblsiparis entity)
        {
            _SiparisDal.Update(entity);
        }
    }
}