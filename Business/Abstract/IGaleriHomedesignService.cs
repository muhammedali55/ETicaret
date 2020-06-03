using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGaleriHomedesignService
    {
        List<TblgaleriHomedesign> GetAll();
        TblgaleriHomedesign GetById(int id);
        void Add(TblgaleriHomedesign entity);
        void Update(TblgaleriHomedesign entity);
        void Delete(TblgaleriHomedesign entity);
        void DeleteList(List<TblgaleriHomedesign> list);
    }
}