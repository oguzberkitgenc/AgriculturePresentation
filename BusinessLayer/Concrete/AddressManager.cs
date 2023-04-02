using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAdressDal _adressDal;

        public AddressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public void Delete(Address t)
        {
            throw new NotImplementedException();
        }
        public Address GetById(int id)
        {
            return _adressDal.GetById(id);
        }
        public List<Address> GetListAll()
        {
            return _adressDal.GetListAll();
        }
        public void Insert(Address t)
        {
            throw new NotImplementedException();
        }

        public void Update(Address t)
        {
            _adressDal.Update(t);
        }
    }
}
