using Business.Dto.Request;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunService
    {
        List<Tblurun> GetAll();
        Tblurun GetById(int id);
        void Add(Tblurun entity);
        void Update(Tblurun entity);
        void Delete(Tblurun entity);
        void DeleteList(List<Tblurun> list);
        List<Tblurun> GetAllByKategoriId(int id);
        List<KategoriRequestDto> GetAllByUrunKategoriDto(int id);
    }
}