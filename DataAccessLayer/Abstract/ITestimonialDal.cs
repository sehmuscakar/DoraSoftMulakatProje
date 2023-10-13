using CoreLayer.DataAccess;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface ITestimonialDal:IEntityRepository<Testimonial>
    {
        List<TestimonialListDto> GetTestimonialListDal();
    }
}
