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
    public class AnnouncementManager : IAnnouncementsService
    {
        private readonly IAnnonuncementDal _annonuncementsDal;

        public AnnouncementManager(IAnnonuncementDal annonuncementsDal)
        {
            _annonuncementsDal = annonuncementsDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _annonuncementsDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _annonuncementsDal.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement t)
        {
            _annonuncementsDal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _annonuncementsDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _annonuncementsDal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _annonuncementsDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _annonuncementsDal.Update(t);
        }
    }
}
