using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KargoManager : IKargoService
    {
        IKargoDal _kargoDal;

        public KargoManager(IKargoDal kargoDal) {
            _kargoDal = kargoDal;
        }

        public void Add(Tblkargo entity)
        {
            _kargoDal.Insert(entity);
        }

        public void Delete(Tblkargo entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteList(List<Tblkargo> list)
        {
            throw new NotImplementedException();
        }

        public List<Tblkargo> GetKullaniciListesi()
        {
            throw new NotImplementedException();
        }

        public Tblkargo GetKullaniciToId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tblkargo entity)
        {
            throw new NotImplementedException();
        }
    }
}
