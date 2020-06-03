using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblgaleriHomedesign : IEntity
    {
        public int Id { get; set; }
        public string Resimurl { get; set; }
        public int? Silid { get; set; }
    }
}
