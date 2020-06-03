
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class KategoriUrunManager : IKategoriUrunService
    {
        IKategoriUrunDal _KategoriUrunDal;
        public KategoriUrunManager(IKategoriUrunDal KategoriUrunService)
        {
            _KategoriUrunDal = KategoriUrunService;
        }
        public void Add(TblkategoriUrun entity)
        {
            _KategoriUrunDal.Insert(entity);
        }
        public void Delete(TblkategoriUrun entity)
        {
            _KategoriUrunDal.Delete(entity);
        }
        public void DeleteList(List<TblkategoriUrun> list)
        {
            foreach (var item in list)
            {
                _KategoriUrunDal.Delete(item);
            }
        }
        public List<TblkategoriUrun> GetAll()
        {
            return _KategoriUrunDal.GetList();
        }
        public TblkategoriUrun GetById(int id)
        {
            return _KategoriUrunDal.Get(x => x.Id == id);
        }
        public void Update(TblkategoriUrun entity)
        {
            _KategoriUrunDal.Update(entity);
        }
    }
}