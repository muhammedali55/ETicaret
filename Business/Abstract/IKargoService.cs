using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKargoService
    {
        List<Tblkargo> GetKullaniciListesi();
        Tblkargo GetKullaniciToId(int id);
        void Add(Tblkargo entity);
        void Update(Tblkargo entity);
        void Delete(Tblkargo entity);
        void DeleteList(List<Tblkargo> list);
    }
}
