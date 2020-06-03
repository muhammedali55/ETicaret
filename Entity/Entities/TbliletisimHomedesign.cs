using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TbliletisimHomedesign : IEntity
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Button { get; set; }
        public int? Silid { get; set; }
    }
}
