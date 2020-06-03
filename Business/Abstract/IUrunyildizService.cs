using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunyildizService
    {
        List<Tblurunyildiz> GetAll();
        Tblurunyildiz GetById(int id);
        void Add(Tblurunyildiz entity);
        void Update(Tblurunyildiz entity);
        void Delete(Tblurunyildiz entity);
        void DeleteList(List<Tblurunyildiz> list);
    }
}