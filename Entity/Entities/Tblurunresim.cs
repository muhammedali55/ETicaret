using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblurunresim : IEntity
    {
        public int Id { get; set; }
        public string UrunUrl { get; set; }
        public bool? Anaresim { get; set; }
        public int? SilId { get; set; }
        public int? UrunId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
