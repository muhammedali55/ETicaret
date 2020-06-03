using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunresimService
    {
        List<Tblurunresim> GetAll();
        Tblurunresim GetById(int id);
        void Add(Tblurunresim entity);
        void Update(Tblurunresim entity);
        void Delete(Tblurunresim entity);
        void DeleteList(List<Tblurunresim> list);
    }
}