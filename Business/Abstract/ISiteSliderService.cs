using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISiteSliderService
    {
        List<TblsiteSlider> GetAll();
        TblsiteSlider GetById(int id);
        void Add(TblsiteSlider entity);
        void Update(TblsiteSlider entity);
        void Delete(TblsiteSlider entity);
        void DeleteList(List<TblsiteSlider> list);
    }
}