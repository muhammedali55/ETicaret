using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYorumService
    {
        List<Tblyorum> GetAll();
        Tblyorum GetById(int id);
        void Add(Tblyorum entity);
        void Update(Tblyorum entity);
        void Delete(Tblyorum entity);
        void DeleteList(List<Tblyorum> list);
    }
}