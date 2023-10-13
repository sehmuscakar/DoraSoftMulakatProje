using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface ITestimonialManager
    {
        List<TestimonialListDto> GetTestimonialListManager();
        List<Testimonial> GetList();
        void Add(Testimonial testimonial);

        void Update(Testimonial testimonial);

        void Remove(Testimonial testimonial);

       Testimonial GetById(int id);



    }
}
