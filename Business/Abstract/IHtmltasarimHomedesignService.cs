using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHtmltasarimHomedesignService
    {
        List<TblhtmltasarimHomedesign> GetAll();
        TblhtmltasarimHomedesign GetById(int id);
        void Add(TblhtmltasarimHomedesign entity);
        void Update(TblhtmltasarimHomedesign entity);
        void Delete(TblhtmltasarimHomedesign entity);
        void DeleteList(List<TblhtmltasarimHomedesign> list);
    }
}