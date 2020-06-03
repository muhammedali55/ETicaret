using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISiteHomedesignService
    {
        List<TblsiteHomedesign> GetAll();
        TblsiteHomedesign GetById(int id);
        void Add(TblsiteHomedesign entity);
        void Update(TblsiteHomedesign entity);
        void Delete(TblsiteHomedesign entity);
        void DeleteList(List<TblsiteHomedesign> list);
    }
}