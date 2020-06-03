using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISiparisService
    {
        List<Tblsiparis> GetAll();
        Tblsiparis GetById(int id);
        void Add(Tblsiparis entity);
        void Update(Tblsiparis entity);
        void Delete(Tblsiparis entity);
        void DeleteList(List<Tblsiparis> list);
    }
}