using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
    public class TestimonialListDto:AdminBaseDto
    {
      
        public string Decsription { get; set; }
     
        public string FullNnme { get; set; }
      
        public string Profession { get; set; }//yapılan iş

      
        public string Image { get; set; }
    }
}
