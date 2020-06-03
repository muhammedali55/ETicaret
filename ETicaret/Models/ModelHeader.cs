using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class ModelHeader
    {
        public bool isLogin { get; set; }

        public List<Tblkategori> ListKategori { get; set; }
    }
}
