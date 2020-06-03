using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;
       public KategoriManager(IKategoriDal kategoriDal)
        {

            _kategoriDal = kategoriDal;
        }
        public void Add(Tblkategori entity)
        {
            _kategoriDal.Insert(entity);
        }
        public void Delete(Tblkategori entity)
        {
            _kategoriDal.Delete(entity);
        }
        public void DeleteList(List<Tblkategori> list)
        {
            foreach (var item in list)
            {
                _kategoriDal.Delete(item);
            }
        }
        public List<Tblkategori> GetKategoriListesi()
        {
            return _kategoriDal.GetList();
        }
        public Tblkategori GetKategoriToId(int id)
        {
            return _kategoriDal.Get(x => x.Id == id);
        }

        public List<Tblkategori> GetSubKategoriList(int id)
        {
            List<Tblkategori> resultList = new List<Tblkategori>();
            try
            {
                return  _kategoriDal.GetList(x=> x.ParentId==id);
            }
            catch (Exception ex)
            {
                String hata = ex.ToString();
            }
            return resultList;
        }

        public void Update(Tblkategori entity)
        {
            _kategoriDal.Update(entity);
        }

    }
}
