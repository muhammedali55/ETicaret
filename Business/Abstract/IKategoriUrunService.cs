using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKategoriUrunService
    {
        List<TblkategoriUrun> GetAll();
        TblkategoriUrun GetById(int id);
        void Add(TblkategoriUrun entity);
        void Update(TblkategoriUrun entity);
        void Delete(TblkategoriUrun entity);
        void DeleteList(List<TblkategoriUrun> list);
    }
}