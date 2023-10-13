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
    public class PollUserDal : BaseRepository<PollUser, ProjeContext>, IPollUserDal
    {
        public List<PollUserListDto> GetPollUserListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.PollUsers.Select(pollUser => new PollUserListDto()
                {
                    Id = pollUser.Id,
                    PostMail= pollUser.PostMail,
                 GenderMan= pollUser.GenderMan,
                 GenderWomen= pollUser.GenderWomen,
                 GenderUncertain= pollUser.GenderUncertain,
                 Age=pollUser.Age,
                 City= pollUser.City,
                 Positive= pollUser.Positive,
                 Negative= pollUser.Negative,
                 Uncertain= pollUser.Uncertain,
                 UniversityDiplaed= pollUser.UniversityDiplaed,
                 UniversityNot=pollUser.UniversityNot,
                 PollId= pollUser.Poll.Id,
                 PollSubject=pollUser.Poll.Subject,
                 PollDescription=pollUser.Poll.Description,
                CreatedAt= pollUser.CreatedAt,
                    RowOrder = pollUser.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
