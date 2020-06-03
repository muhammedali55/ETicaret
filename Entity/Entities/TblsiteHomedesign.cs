using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblsiteHomedesign:IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool? Durum { get; set; }
        public int? Silid { get; set; }
    }
}
