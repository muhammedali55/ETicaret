using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOzellikUrunService
    {
        List<TblozellikUrun> GetAll();
        TblozellikUrun GetById(int id);
        void Add(TblozellikUrun entity);
        void Update(TblozellikUrun entity);
        void Delete(TblozellikUrun entity);
        void DeleteList(List<TblozellikUrun> list);
    }
}