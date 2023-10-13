using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPollReportManager
    {
        List<PollReportListDto> GetPollReportListManager();
        List<PollReport> GetList();
        void Add(PollReport pollReport);
        void Update(PollReport pollReport);
        void Remove(PollReport pollReport);
        PollReport GetByID(int id);
    }
}
