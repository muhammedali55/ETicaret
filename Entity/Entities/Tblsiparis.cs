using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblsiparis : IEntity
    {
        public int Id { get; set; }
        public int? KullaniciId { get; set; }
        public string TeslimatAdres { get; set; }
        public string FaturaAdres { get; set; }
        public int? KargoId { get; set; }
        public string KargoTakipNo { get; set; }
        public string OdemeTuru { get; set; }
        public int? Durumu { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
