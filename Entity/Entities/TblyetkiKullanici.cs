using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblyetkiKullanici : IEntity
    {
        public int Id { get; set; }
        public int? YetkiId { get; set; }
        public int? KullaniciId { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
