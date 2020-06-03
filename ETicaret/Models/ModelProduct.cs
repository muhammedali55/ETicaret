using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class ModelProduct
    {
        public Tblurun  urun { get; set; }

        public List<Tblurunresim> resimlistesi { get; set; }
    }
}
