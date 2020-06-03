using Entity.Entities;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKategorialani_homedesignService
    {
        List<TblkategorialaniHomedesign> GetAll();
        TblkategorialaniHomedesign GetById(int id);
        void Add(TblkategorialaniHomedesign entity);
        void Update(TblkategorialaniHomedesign entity);
        void Delete(TblkategorialaniHomedesign entity);
        void DeleteList(List<TblkategorialaniHomedesign> list);
    }
}