using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialManager
    {

        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial testimonial)
        {
            var roworder = _testimonialDal.GetAll().Count();
            testimonial.RowOrder = roworder + 1;
            _testimonialDal.Add(testimonial);
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.Get(id);
        }

        public List<Testimonial> GetList()
        {
            var listele = _testimonialDal.GetAll();
            return listele;
        }

        public List<TestimonialListDto> GetTestimonialListManager()
        {
            var listdto = _testimonialDal.GetTestimonialListDal();
            return listdto;
        }

        public void Remove(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);    
        }

        public void Update(Testimonial testimonial)
        {
            var roworder = _testimonialDal.GetAll().Count();
           testimonial.RowOrder = roworder;
           testimonial.LastUpdatedAt = DateTime.Now;
            _testimonialDal.Update(testimonial);
        }
    }
}
