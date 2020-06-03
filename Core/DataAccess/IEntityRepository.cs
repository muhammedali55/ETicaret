using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // T -> tblmusteri, tblmarka, tblurun v.s.
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        // item.Get(x=> x.id== getid)
        // item.Get();XXX
        T Get(Expression<Func<T,bool>> filter);
        // item.GetList();
        // item.GetList(x=> x.ad.Contains("ali"))
        List<T> GetList(Expression<Func<T,bool>> filter=null);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
