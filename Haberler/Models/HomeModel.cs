using Haberler.Utility;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haberler.Models
{
    public class HomeModel
    {
        public ArticlesResult haberler { get; set; }
        public List<Dil> dillistesi { get; set; }
        public List<string> kategorilistesi { get; set; }
        public int dilid { get; set; }
        public int kategoriid { get; set; }

    }
}
