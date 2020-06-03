using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblsoneklenenlerHomedesign : IEntity
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Tab1 { get; set; }
        public string Tab2 { get; set; }
        public string Tab3 { get; set; }
        public string Tab4 { get; set; }
        public int? Kategori1 { get; set; }
        public int? Kategori2 { get; set; }
        public int? Kategori3 { get; set; }
        public int? Kategori4 { get; set; }
        public int? Silid { get; set; }
    }
}
