using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPollCategoryManager
    {
        List<PollCategoryListDto> GetPollCategoryListManager();
        List<PollCategory> GetList();
        void Add(PollCategory pollCategory);
        void Update(PollCategory pollCategory);
        void Remove(PollCategory pollCategory);
        PollCategory GetByID(int id);
    }
}
