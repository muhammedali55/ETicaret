using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IModelUrunService
    {
        List<TblmodelUrun> GetAll();
        TblmodelUrun GetById(int id);
        void Add(TblmodelUrun entity);
        void Update(TblmodelUrun entity);
        void Delete(TblmodelUrun entity);
        void DeleteList(List<TblmodelUrun> list);
    }
}