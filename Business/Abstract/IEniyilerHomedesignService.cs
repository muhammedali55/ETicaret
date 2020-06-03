
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEniyilerHomedesignService
    {
        List<TbleniyilerHomedesign> GetAll();
        TbleniyilerHomedesign GetById(int id);
        void Add(TbleniyilerHomedesign entity);
        void Update(TbleniyilerHomedesign entity);
        void Delete(TbleniyilerHomedesign entity);
        void DeleteList(List<TbleniyilerHomedesign> list);
    }
}