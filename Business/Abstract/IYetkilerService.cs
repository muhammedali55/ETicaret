using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYetkilerService
    {
        List<Tblyetkiler> GetAll();
        Tblyetkiler GetById(int id);
        void Add(Tblyetkiler entity);
        void Update(Tblyetkiler entity);
        void Delete(Tblyetkiler entity);
        void DeleteList(List<Tblyetkiler> list);
    }
}