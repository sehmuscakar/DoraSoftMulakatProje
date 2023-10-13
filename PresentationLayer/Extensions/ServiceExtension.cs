using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace PresentationLayer.Extensions
{
    public static class ServiceExtension
    {
        public static void MyconfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IHeadManager, HeadManager>();
            services.AddScoped<IHeadDal, HeadDal>();

            services.AddScoped<IPollCategoryManager, PollCategoryManager>();
            services.AddScoped<IPollCategoryDal, PollCategoryDal>();

            services.AddScoped<IPollManager, PollManager>();
            services.AddScoped<IPollDal, PollDal>();

            services.AddScoped<IPollReportManager, PollReportManager>();
            services.AddScoped<IPollReportDal, PollReportDal>();

            services.AddScoped<IPollUserManager, PollUserManager>();
            services.AddScoped<IPollUserDal, PollUserDal>();

            services.AddScoped<IAboutManager, AboutManager>();
            services.AddScoped<IAboutDal, AboutDal>();

            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IServiceDal, ServiceDal>();

            services.AddScoped<ITeamManager, TeamManager>();
            services.AddScoped<ITeamDal, TeamDal>();

            services.AddScoped<ITestimonialManager, TestimonialManager>();
            services.AddScoped<ITestimonialDal, TestimonialDal>();

            services.AddScoped<IPostContactManager, PostContactManager>();
            services.AddScoped<IPostContactDal, PostContactDal>();

            services.AddScoped<IContactCompanyManager, ContactCompanyManager>();
            services.AddScoped<IContactCompanyDal, ContactCompanyDal>();

        }
    }
}
