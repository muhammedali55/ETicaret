using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblsiparisdetay : IEntity
    {
        public int Id { get; set; }
        public int? SiparisId { get; set; }
        public int? UrunId { get; set; }
        public int? Adet { get; set; }
        public double? Birimfiyat { get; set; }
        public double? Indirimlifiyat { get; set; }
        public double? Toplamfiyat { get; set; }
        public double? Kdvtutari { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
