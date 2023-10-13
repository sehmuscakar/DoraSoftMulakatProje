using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class TestimonialDal : BaseRepository<Testimonial, ProjeContext>, ITestimonialDal
    {
        public List<TestimonialListDto> GetTestimonialListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Testimonials.Select(testimonial => new TestimonialListDto()
                {
                    Id = testimonial.Id,
                    Image = testimonial.Image,
                    Decsription = testimonial.Decsription,
                    FullNnme = testimonial.FullNnme,
                    Profession = testimonial.Profession,
                    LastUpdatedAt = testimonial.LastUpdatedAt,
                    CreatedFullName = testimonial.AppUser.Name,                
                    RowOrder = testimonial.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
