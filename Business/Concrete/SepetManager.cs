
using Business.Abstract;
using Business.Dto.Request;
using DataAccess.Abstract;
using Entity.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class SepetManager : ISepetService
    {
        ISepetDal _SepetDal;
        IUrunDal _urunDal;
        IUrunresimDal _urunresimDal;

        public SepetManager(ISepetDal SepetService, IUrunDal urunDal,IUrunresimDal urunresimDal)
        {
            _SepetDal = SepetService;
            _urunDal = urunDal;
            _urunresimDal = urunresimDal;
        }
        public void Add(Tblsepet entity)
        {
            _SepetDal.Insert(entity);
        }
        public void Delete(Tblsepet entity)
        {
            _SepetDal.Delete(entity);
        }
        public void DeleteList(List<Tblsepet> list)
        {
            foreach (var item in list)
            {
                _SepetDal.Delete(item);
            }
        }
        public List<Tblsepet> GetAll()
        {
            return _SepetDal.GetList();
        }
        public Tblsepet GetById(int id)
        {
            return _SepetDal.Get(x => x.Id == id);
        }

        public List<SepetRequestDto> GetSepetRequestDtobyUserid(int id)
        {
            List<SepetRequestDto> resultList = new List<SepetRequestDto>();
            
            try
            {
                List<Tblsepet> sepetList = _SepetDal.GetList(x=> x.KullaniciId==id);
                SepetRequestDto sepet;
                Tblurun urun ;
                foreach (var item in sepetList)
                {
                    sepet = new SepetRequestDto();
                    var resim = _urunresimDal.Get(x => x.UrunId == item.UrunId && x.Anaresim == true);
                    urun = _urunDal.Get(x=> x.Id==item.UrunId);
                    sepet.kullaniciid = item.KullaniciId==null ? 0: (int)item.KullaniciId;
                    sepet.adet = item.Adet==null ? 1: (int)item.Adet;
                    sepet.fiyat = urun.Fiyat==null ? 0: (double)urun.Fiyat;
                    sepet.urunadi = urun.Ad;
                    sepet.urunid = (int)item.UrunId;
                    sepet.resimurl = resim == null ? "" : resim.UrunUrl;
                    sepet.id = item.Id;
                    resultList.Add(sepet);
                }

            }
            catch (Exception ex)
            {
                string hata = ex.ToString();
            }
            return resultList;
        }

        public void Update(Tblsepet entity)
        {
            _SepetDal.Update(entity);
        }
    }
}