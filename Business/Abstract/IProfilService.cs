using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProfilService
    {
        List<Tblprofil> GetAll();
        Tblprofil GetById(int id);
        void Add(Tblprofil entity);
        void Update(Tblprofil entity);
        void Delete(Tblprofil entity);
        void DeleteList(List<Tblprofil> list);
    }
}