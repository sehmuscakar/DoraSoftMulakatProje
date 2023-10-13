using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPollUserManager
    {
        List<PollUserListDto> GetPollUserListManager();
        List<PollUser> GetList();
        void Add(PollUser pollUser);
        void Update(PollUser pollUser);
        void Remove(PollUser pollUser);
        PollUser GetByID(int id);
    }
}
