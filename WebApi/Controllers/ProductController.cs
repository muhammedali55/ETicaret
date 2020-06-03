using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IUrunService _urunService;

        public ProductController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        [HttpGet("getAllProduct")]
        public IActionResult GetAllProduct( string ApiKey)
        {
            if (ApiKey != null)
            {
                if (ApiKey.Equals("vektorel"))
                {
                    var result = _urunService.GetAll();
                    if (result != null)
                        return Ok(result);
                    return BadRequest("Yanlış Yoldasın.... :)");
                }
                return Ok("Yetkisiz İşlem");
            }
            return Ok("Yetkisiz İşlem");

        }


        [HttpGet("getByIdProduct")]
        public IActionResult GetAllProduct(int? product_id,string ApiKey) {
            if (ApiKey!=null && product_id!=null)
            {
                if (ApiKey.Equals("vektorel"))
                {
                    var result = _urunService.GetAll().Where(x=> x.Id==product_id);
                    if (result != null)
                        return Ok(result);
                    return BadRequest("Yanlış Yoldasın.... :)");
                }
                return Ok("Yetkisiz İşlem");
            }
            return Ok("Yetkisiz İşlem");
            
        }

        [HttpGet("delete")]
        public IActionResult deleteProduct(int? product_id, string ApiKey) {
            if (product_id != null && ApiKey != null)
            {
                try
                {
                    _urunService.Delete(new Tblurun()
                    {
                        Id = (int)product_id
                    });
                    return Ok("Ok");
                }
                catch (Exception ex)
                {
                    return Ok("Hata...: "+ ex.ToString());
                }
            }
            return Ok("Yetkisiz İşlem");
        }

        [HttpPost("save")]
        public IActionResult saveProduct(string Ad, string Aciklama, double? Fiyat, int? Kdv, string ApiKey) {
            if (Ad != null && Aciklama != null && Fiyat != null && Kdv != null && ApiKey != null) {
                if (ApiKey.Equals("vektorel"))
                {
                    try
                    {
                        Tblurun urun = new Tblurun()
                        {
                            Ad = Ad,
                            Aciklama = Aciklama,
                            Fiyat = Fiyat,
                            Kdv = Kdv
                        };
                        _urunService.Add(urun);
                        return Ok("Ok");
                    }
                    catch (Exception ex)
                    {
                        return Ok("Beklenmeyen Hata..: "+ ex.ToString());
                    }
                   
                }
                else
                    return Ok("Yetkisiz İşlem");
                
            }
            return Ok("Yetkisiz İşlem");
        }

        // HtppGet, Post, Update, Delete
        [HttpGet]
        public IActionResult Get() {
            return Ok("Ürünleri Getir");
        }

        [HttpPost]
        public IActionResult Post() {
            return Ok("Ürün Kayıt edildi.");
        }
    }
}