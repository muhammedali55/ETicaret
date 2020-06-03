
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class MarkaManager : IMarkaService
    {
        IMarkaDal _MarkaDal;
        public MarkaManager(IMarkaDal MarkaService)
        {
            _MarkaDal = MarkaService;
        }
        public void Add(Tblmarka entity)
        {
            _MarkaDal.Insert(entity);
        }
        public void Delete(Tblmarka entity)
        {
            _MarkaDal.Delete(entity);
        }
        public void DeleteList(List<Tblmarka> list)
        {
            foreach (var item in list)
            {
                _MarkaDal.Delete(item);
            }
        }
        public List<Tblmarka> GetAll()
        {
            return _MarkaDal.GetList();
        }
        public Tblmarka GetById(int id)
        {
            return _MarkaDal.Get(x => x.Id == id);
        }
        public void Update(Tblmarka entity)
        {
            _MarkaDal.Update(entity);
        }
    }
}