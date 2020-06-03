using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IİletisimHomedesignService
    {
        List<TbliletisimHomedesign> GetAll();
        TbliletisimHomedesign GetById(int id);
        void Add(TbliletisimHomedesign entity);
        void Update(TbliletisimHomedesign entity);
        void Delete(TbliletisimHomedesign entity);
        void DeleteList(List<TbliletisimHomedesign> list);
    }
}