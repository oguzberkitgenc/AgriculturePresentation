using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Abstract.Base;
using EntityLayer.Concrete;

namespace DataAccesLayer.Abstract
{
    public interface IImagesDal : IGenericDal<Image>
    {
    }
}
