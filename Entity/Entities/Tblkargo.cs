using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblkargo : IEntity
    {
        public int Id { get; set; }
        public string Firmaadi { get; set; }
        public string Iletisim { get; set; }
        public string Aciklama { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
