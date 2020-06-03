using Entity.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        List<Tblkullanici> GetKullaniciListesi();
        Tblkullanici GetKullaniciToId(int id);
        void Add(Tblkullanici entity);
        void Update(Tblkullanici entity);
        void Delete(Tblkullanici entity);
        void DeleteList(List<Tblkullanici> list);
        Tblkullanici isLogin(String kullaniciadi, String sifre);
    }
}
