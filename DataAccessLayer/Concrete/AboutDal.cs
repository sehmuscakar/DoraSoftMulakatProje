using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AboutDal : BaseRepository<About, ProjeContext>, IAboutDal
    {
        public List<AboutListDto> GetAboutListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Abouts.Select(about => new AboutListDto()
                {
                    Id = about.Id,
               Description= about.Description,
               SubDescription1= about.SubDescription1,
               SubDescription2= about.SubDescription2,
               Title1= about.Title1,
               Title2= about.Title2,
               TitleDescription1= about.TitleDescription1,
               TitleDescription2= about.TitleDescription2,
               ImageUrl= about.ImageUrl,

                    LastUpdatedAt = about.LastUpdatedAt,
                    CreatedFullName = about.AppUser.Name,
                    RowOrder = about.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
