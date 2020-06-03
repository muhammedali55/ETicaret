using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class EniyilerHomedesignManager : IEniyilerHomedesignService
    {
        IEniyilerHomedesignDal _EniyilerHomedesignDal;
        public EniyilerHomedesignManager(IEniyilerHomedesignDal EniyilerHomedesignService)
        {
            _EniyilerHomedesignDal = EniyilerHomedesignService;
        }
        public void Add(TbleniyilerHomedesign entity)
        {
            _EniyilerHomedesignDal.Insert(entity);
        }
        public void Delete(TbleniyilerHomedesign entity)
        {
            _EniyilerHomedesignDal.Delete(entity);
        }
        public void DeleteList(List<TbleniyilerHomedesign> list)
        {
            foreach (var item in list)
            {
                _EniyilerHomedesignDal.Delete(item);
            }
        }
        public List<TbleniyilerHomedesign> GetAll()
        {
            return _EniyilerHomedesignDal.GetList();
        }
        public TbleniyilerHomedesign GetById(int id)
        {
            return _EniyilerHomedesignDal.Get(x => x.Id == id);
        }
        public void Update(TbleniyilerHomedesign entity)
        {
            _EniyilerHomedesignDal.Update(entity);
        }
    }
}