
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class YetkiKullaniciManager : IYetkiKullaniciService
    {
        IYetkiKullaniciDal _YetkiKullaniciDal;
        public YetkiKullaniciManager(IYetkiKullaniciDal YetkiKullaniciService)
        {
            _YetkiKullaniciDal = YetkiKullaniciService;
        }
        public void Add(TblyetkiKullanici entity)
        {
            _YetkiKullaniciDal.Insert(entity);
        }
        public void Delete(TblyetkiKullanici entity)
        {
            _YetkiKullaniciDal.Delete(entity);
        }
        public void DeleteList(List<TblyetkiKullanici> list)
        {
            foreach (var item in list)
            {
                _YetkiKullaniciDal.Delete(item);
            }
        }
        public List<TblyetkiKullanici> GetAll()
        {
            return _YetkiKullaniciDal.GetList();
        }
        public TblyetkiKullanici GetById(int id)
        {
            return _YetkiKullaniciDal.Get(x => x.Id == id);
        }
        public void Update(TblyetkiKullanici entity)
        {
            _YetkiKullaniciDal.Update(entity);
        }
    }
}