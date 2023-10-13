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
    public class PollDal : BaseRepository<Poll, ProjeContext>, IPollDal
    {
        public List<PollListDto> GetPollListActiveDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Polls.Where(x=>x.IsActive).Select(poll => new PollListDto()
                {
                    Id = poll.Id,
                    ImageUrl = poll.ImageUrl,
                    LastTime= poll.LastTime,    
                    Subject = poll.Subject,
                    Description = poll.Description,
                
                });
                return a.ToList();
            }
        }

        public List<PollListDto> GetPollListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Polls.Select(poll => new PollListDto()
                {
                    Id = poll.Id,
                    ImageUrl = poll.ImageUrl,
                    Subject = poll.Subject,
                    LastTime = poll.LastTime,
                    Description = poll.Description,
                    IsActive = poll.IsActive,
                    PollCategoryName = poll.PollCategory.Name,
                    PollReportId = poll.PollReport.Id,
                    LastUpdatedAt = poll.LastUpdatedAt,
                    CreatedFullName = poll.AppUser.Name,
                    RowOrder = poll.RowOrder
                }) ;
                return a.ToList();
            }
        }
    }
}
