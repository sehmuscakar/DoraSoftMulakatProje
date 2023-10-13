using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
  public class Testimonial:BaseEntity
    {
        [DisplayName("Açıklama")]
        public string Decsription { get; set; }
        [DisplayName("Adı ve Soyadı")]
        public string FullNnme { get; set; }
        [DisplayName("Yapılan iş")]
        public string Profession { get; set; }//yapılan iş

        [DisplayName("Resim")]
        public string Image { get; set; }
   

    }
}
