using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYetkiKullaniciService
    {
        List<TblyetkiKullanici> GetAll();
        TblyetkiKullanici GetById(int id);
        void Add(TblyetkiKullanici entity);
        void Update(TblyetkiKullanici entity);
        void Delete(TblyetkiKullanici entity);
        void DeleteList(List<TblyetkiKullanici> list);
    }
}