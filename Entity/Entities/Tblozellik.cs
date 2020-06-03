using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class Tblozellik : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int? ParentId { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
