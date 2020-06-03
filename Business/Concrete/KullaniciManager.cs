using Business.Abstract;
using Business.Language;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDal _kullaniciDal;
       
        public KullaniciManager(IKullaniciDal kullaniciDal) {
            
            _kullaniciDal = kullaniciDal;
        }
        public void Add(Tblkullanici entity)
        {
            _kullaniciDal.Insert(entity);
        }
        public void Delete(Tblkullanici entity)
        {
            _kullaniciDal.Delete(entity);
        }
        public void DeleteList(List<Tblkullanici> list)
        {
            foreach (var item in list)
            {
                _kullaniciDal.Delete(item);
            }
        }
        public List<Tblkullanici> GetKullaniciListesi()
        {
            return _kullaniciDal.GetList();
        }
        public Tblkullanici GetKullaniciToId(int id)
        {
            return _kullaniciDal.Get(x=> x.Id==id);
        }

        /// <summary>
        /// Kullanıcı adı ve şifreyi alarak kullanıcı var ise true yok ise false döner.
        /// </summary>
        /// <param name="kullaniciadi"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public Tblkullanici isLogin(string kullaniciadi, string sifre)
        {
            var kullanici = _kullaniciDal.Get(x=> x.Kullaniciadi.Equals(kullaniciadi) && x.Sifre.Equals(sifre));
            return kullanici;
        }

        public void Update(Tblkullanici entity)
        {
            _kullaniciDal.Update(entity);
        }


    }
}
