using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKategoriService
    {
        List<Tblkategori> GetKategoriListesi();
        Tblkategori GetKategoriToId(int id);
        void Add(Tblkategori entity);
        void Update(Tblkategori entity);
        void Delete(Tblkategori entity);
        void DeleteList(List<Tblkategori> list);
        List<Tblkategori> GetSubKategoriList(int id);
    }
}
