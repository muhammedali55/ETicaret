
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class HtmltasarimHomedesignManager : IHtmltasarimHomedesignService
    {
        IHtmltasarimHomedesignDal _HtmltasarimHomedesignDal;
        public HtmltasarimHomedesignManager(IHtmltasarimHomedesignDal HtmltasarimHomedesignService)
        {
            _HtmltasarimHomedesignDal = HtmltasarimHomedesignService;
        }
        public void Add(TblhtmltasarimHomedesign entity)
        {
            _HtmltasarimHomedesignDal.Insert(entity);
        }
        public void Delete(TblhtmltasarimHomedesign entity)
        {
            _HtmltasarimHomedesignDal.Delete(entity);
        }
        public void DeleteList(List<TblhtmltasarimHomedesign> list)
        {
            foreach (var item in list)
            {
                _HtmltasarimHomedesignDal.Delete(item);
            }
        }
        public List<TblhtmltasarimHomedesign> GetAll()
        {
            return _HtmltasarimHomedesignDal.GetList();
        }
        public TblhtmltasarimHomedesign GetById(int id)
        {
            return _HtmltasarimHomedesignDal.Get(x => x.Id == id);
        }
        public void Update(TblhtmltasarimHomedesign entity)
        {
            _HtmltasarimHomedesignDal.Update(entity);
        }
    }
}