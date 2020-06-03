
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class ProfilManager : IProfilService
    {
        IProfilDal _ProfilDal;
        public ProfilManager(IProfilDal ProfilService)
        {
            _ProfilDal = ProfilService;
        }
        public void Add(Tblprofil entity)
        {
            _ProfilDal.Insert(entity);
        }
        public void Delete(Tblprofil entity)
        {
            _ProfilDal.Delete(entity);
        }
        public void DeleteList(List<Tblprofil> list)
        {
            foreach (var item in list)
            {
                _ProfilDal.Delete(item);
            }
        }
        public List<Tblprofil> GetAll()
        {
            return _ProfilDal.GetList();
        }
        public Tblprofil GetById(int id)
        {
            return _ProfilDal.Get(x => x.Id == id);
        }
        public void Update(Tblprofil entity)
        {
            _ProfilDal.Update(entity);
        }
    }
}