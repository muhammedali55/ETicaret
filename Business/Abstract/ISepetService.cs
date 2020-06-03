using Business.Dto.Request;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISepetService
    {
        List<Tblsepet> GetAll();
        Tblsepet GetById(int id);
        void Add(Tblsepet entity);
        void Update(Tblsepet entity);
        void Delete(Tblsepet entity);
        void DeleteList(List<Tblsepet> list);
        List<SepetRequestDto> GetSepetRequestDtobyUserid(int id);
    }
}