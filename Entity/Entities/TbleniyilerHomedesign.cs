using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entity.Entities
{
    public partial class TbleniyilerHomedesign:IEntity
    {
        public int Id { get; set; }
        public string Solbaslik { get; set; }
        public string Solicerik { get; set; }
        public string Solbutton { get; set; }
        public string Solresimurl { get; set; }
        public string Ortaresimurl { get; set; }
        public string Sagustresimurl { get; set; }
        public string Sagustbaslik { get; set; }
        public string Sagortaresimurl { get; set; }
        public string Sagortabaslik { get; set; }
        public string Sagaltresimurl { get; set; }
        public string Sagaltbaslik { get; set; }
        public int? Silid { get; set; }
    }
}
