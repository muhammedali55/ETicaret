using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMarkaService
    {
        List<Tblmarka> GetAll();
        Tblmarka GetById(int id);
        void Add(Tblmarka entity);
        void Update(Tblmarka entity);
        void Delete(Tblmarka entity);
        void DeleteList(List<Tblmarka> list);
    }
}