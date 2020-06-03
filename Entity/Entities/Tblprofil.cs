using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblprofil : IEntity
    {
        public int Id { get; set; }
        public int? KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckimlik { get; set; }
        public string Adres { get; set; }
        public string Evtel { get; set; }
        public string Istel { get; set; }
        public string Ceptel { get; set; }
        public string Profilresim { get; set; }
        public DateTime? Dogumtarihi { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
