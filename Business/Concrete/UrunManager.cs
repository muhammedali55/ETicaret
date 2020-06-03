
using Business.Abstract;
using Business.Dto.Request;
using DataAccess.Abstract;
using Entity.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _UrunDal;
        IKategoriUrunDal _kategoriUrunDal;
        IUrunresimDal _urunresimDal;
        public UrunManager(IUrunDal UrunService, IKategoriUrunDal kategoriUrunDal,IUrunresimDal urunresimDal)
        {
            _UrunDal = UrunService;
            _kategoriUrunDal = kategoriUrunDal;
            _urunresimDal = urunresimDal;
        }
        public void Add(Tblurun entity)
        {
            _UrunDal.Insert(entity);
        }
        public void Delete(Tblurun entity)
        {
            _UrunDal.Delete(entity);
        }
        public void DeleteList(List<Tblurun> list)
        {
            foreach (var item in list)
            {
                _UrunDal.Delete(item);
            }
        }
        public List<Tblurun> GetAll()
        {
            return _UrunDal.GetList();
        }

        public List<Tblurun> GetAllByKategoriId(int id)
        {
            // Burada Bir Sýkýntý var ÇÖZELÝM
            List<Tblurun> myList = new List<Tblurun>();
            List<TblkategoriUrun> myKategoriList = _kategoriUrunDal.GetList();            
            foreach (var item in myKategoriList)
            {
                if (item.KategoriId == id)
                {
                    var model = _UrunDal.Get(x => x.Id == item.UrunId);
                    myList.Add(model);
                }
            }
            return myList;
        }
        // kategori id = 7
        public List<KategoriRequestDto> GetAllByUrunKategoriDto(int id)
        {
            List<KategoriRequestDto> resultList = new List<KategoriRequestDto>();
            try
            {
                List<TblkategoriUrun> tblkategoriUruns = _kategoriUrunDal.GetList();
                KategoriRequestDto kategori;
                Tblurun tblurun;
                // KAtegoriUrun Listesini kategori id ye göre filitreleyterek dönüyoruz
                foreach (var item in tblkategoriUruns.Where(x => x.KategoriId == id))
                {
                    // kategoriurun içinden gelen ürün id si ile ürüne eriþiyorum.
                    tblurun = _UrunDal.Get(x => x.Id == item.UrunId);
                    kategori = new KategoriRequestDto();
                    kategori.urunid = tblurun.Id;
                    kategori.ad = tblurun.Ad;
                    kategori.aciklama = tblurun.Aciklama;
                    kategori.fiyat = tblurun.Fiyat==null ? 0 : (double)tblurun.Fiyat;
                    var urun = _urunresimDal.Get(x => x.UrunId == item.UrunId);
                    kategori.resimurl = urun == null ? "assets/img/feature_3.png" : urun.UrunUrl;
                    resultList.Add(kategori);
                }
            }
            catch (Exception ex)
            {
                string Hata = ex.ToString();
            }
           
            return resultList;
        }

        public Tblurun GetById(int id)
        {
            return _UrunDal.Get(x => x.Id == id);
        }
        public void Update(Tblurun entity)
        {
            _UrunDal.Update(entity);
        }

    }
}