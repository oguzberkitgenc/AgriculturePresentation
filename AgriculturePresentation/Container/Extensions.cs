using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace AgriculturePresentation.Container
{
    public static class Extensions
    {
        public static void ContaninerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<ITeamService, TeamManager>();
            services.AddScoped<ITeamsDal, EfTeamDal>();
            services.AddScoped<IAnnouncementsService, AnnouncementManager>();
            services.AddScoped<IAnnonuncementDal, EfAnnouncementDal>();
            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IImagesDal, EfImageDal>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAdressDal, EfAddressDal>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactsDal, EfContactDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminDal, EfAdminDal>();
        }
    }
}
