using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities
{
    public class AppUser:IdentityUser<int> 
 
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int ConfirmCode { get; set; }//onay kodu,mail doğrulama işlemi için kullanılacak ,migration olduğunda migration da nullable yi true yaptık ayrıntı
      
        
        
        
        
        
        
        
        public List<Head> Heads { get; set; }
        public List<Poll> Polls { get; set; }
        public List<PollCategory> pollCategories { get; set; }
        public List<PollReport> pollReports { get; set; }
        public List<About> Abouts { get; set; }
        public List<Service> Services { get; set; }
        public List<Team> Teams { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<ContactCompany> ContactCompanies { get; set; }




    }
}
