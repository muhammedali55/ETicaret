using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISoneklenenlerHomedesignService
    {
        List<TblsoneklenenlerHomedesign> GetAll();
        TblsoneklenenlerHomedesign GetById(int id);
        void Add(TblsoneklenenlerHomedesign entity);
        void Update(TblsoneklenenlerHomedesign entity);
        void Delete(TblsoneklenenlerHomedesign entity);
        void DeleteList(List<TblsoneklenenlerHomedesign> list);
    }
}