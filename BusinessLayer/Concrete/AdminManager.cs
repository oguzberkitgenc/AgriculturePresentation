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
	public class AdminManager : IAdminService
	{
		IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public void Delete(Admin t)
		{
			throw new NotImplementedException();
		}

		public Admin GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Admin> GetListAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(Admin t)
		{
			throw new NotImplementedException();
		}

		public void Update(Admin t)
		{
			throw new NotImplementedException();
		}
	}
}
