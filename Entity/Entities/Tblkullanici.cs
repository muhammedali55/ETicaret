using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblkullanici : IEntity
    {
        public int Id { get; set; }
        public string Kullaniciadi { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
