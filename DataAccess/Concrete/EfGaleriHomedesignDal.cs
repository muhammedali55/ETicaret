using Core.DataAccess;
using Entity.Entities;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfGaleriHomedesignDal : EfEntityRepositoryBase<TblgaleriHomedesign, DBETICARETContext>, IGaleriHomedesignDal
    { }
}