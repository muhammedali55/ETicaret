﻿using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblmodelUrun : IEntity
    {
        public int Id { get; set; }
        public int? ModelId { get; set; }
        public int? UrunId { get; set; }
        public int? SilId { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
