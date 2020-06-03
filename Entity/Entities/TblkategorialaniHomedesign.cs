using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblkategorialaniHomedesign:IEntity
    {
        public int Id { get; set; }
        public string ResimUrl { get; set; }
        public string Baslik { get; set; }
        public int? KategoriId { get; set; }
        public string ButtonText { get; set; }
        public string AltBaslik { get; set; }
        public int? SilId { get; set; }
    }
}
