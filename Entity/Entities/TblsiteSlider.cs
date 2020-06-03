using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TblsiteSlider : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Backimgurl { get; set; }
        public string Frontimgurl { get; set; }
        public string Discount { get; set; }
        public string Baslik { get; set; }
        public string Altbaslik { get; set; }
        public string Butontext { get; set; }
        public string Butonlinkurl { get; set; }
        public int? Silid { get; set; }
    }
}
