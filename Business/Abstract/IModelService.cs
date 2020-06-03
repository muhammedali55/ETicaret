using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IModelService
    {
        List<Tblmodel> GetAll();
        Tblmodel GetById(int id);
        void Add(Tblmodel entity);
        void Update(Tblmodel entity);
        void Delete(Tblmodel entity);
        void DeleteList(List<Tblmodel> list);
    }
}