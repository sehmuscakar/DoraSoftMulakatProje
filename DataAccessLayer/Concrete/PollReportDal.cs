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
    public class PollReportDal : BaseRepository<PollReport, ProjeContext>, IPollReportDal
    {
        public List<PollReportListDto> GetPollReportListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.PollReports.Select(pollReport => new PollReportListDto()
                {
                    Id = pollReport.Id,
                    ManCount= pollReport.ManCount,
                    WomenCount= pollReport.WomenCount,
                    WomenAvg= pollReport.WomenAvg,
                    ManAvg= pollReport.ManAvg,
                    PositiveCount = pollReport.PositiveCount, 
                    NegativeCount= pollReport.NegativeCount,
                    Noİdea=pollReport.Noİdea,
                    UniversityDiplomad= pollReport.UniversityDiplomad,
                    UniversityNot= pollReport.UniversityNot,
                    LastUpdatedAt = pollReport.LastUpdatedAt,
                    CreatedFullName = pollReport.AppUser.Name,
                    RowOrder = pollReport.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
