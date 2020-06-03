using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOzellikService
    {
        List<Tblozellik> GetAll();
        Tblozellik GetById(int id);
        void Add(Tblozellik entity);
        void Update(Tblozellik entity);
        void Delete(Tblozellik entity);
        void DeleteList(List<Tblozellik> list);
    }
}