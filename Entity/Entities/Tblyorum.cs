using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblyorum : IEntity
    {
        public int Id { get; set; }
        public string Yorum { get; set; }
        public int? KullaniciId { get; set; }
        public int? UrunId { get; set; }
        public int? Puan { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
