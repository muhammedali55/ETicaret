using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISiparisdetayService
    {
        List<Tblsiparisdetay> GetAll();
        Tblsiparisdetay GetById(int id);
        void Add(Tblsiparisdetay entity);
        void Update(Tblsiparisdetay entity);
        void Delete(Tblsiparisdetay entity);
        void DeleteList(List<Tblsiparisdetay> list);
    }
}