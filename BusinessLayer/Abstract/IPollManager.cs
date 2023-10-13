using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IPollManager
    {
        List<PollListDto> GetPollListManager();
        List<PollListDto> GetPollListActiveManager();
        List<Poll> GetList();
        void Add(Poll poll);
        void Update(Poll poll);
        void Remove(Poll poll);
        Poll GetByID(int id);
    }
}
