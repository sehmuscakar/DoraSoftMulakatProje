using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class PollReportManager : IPollReportManager
    {

        private readonly IPollReportDal _pollReportDal;

        public PollReportManager(IPollReportDal pollReportDal)
        {
            _pollReportDal = pollReportDal;
        }

        public void Add(PollReport pollReport)
        {
            var roworder = _pollReportDal.GetAll().Count();
            pollReport.RowOrder = roworder + 1;
            _pollReportDal.Add(pollReport);
        }

        public PollReport GetByID(int id)
        {
            return _pollReportDal.Get(id);
        }

        public List<PollReport> GetList()
        {
            return _pollReportDal.GetAll();
        }

        public List<PollReportListDto> GetPollReportListManager()
        {
            return _pollReportDal.GetPollReportListDal();
        }

        public void Remove(PollReport pollReport)
        {
            _pollReportDal.Delete(pollReport);
        }

        public void Update(PollReport pollReport)
        {
            var roworder = _pollReportDal.GetAll().Count();
            pollReport.RowOrder = roworder;
            pollReport.LastUpdatedAt = DateTime.Now;
            _pollReportDal.Update(pollReport);
        }
    }
}
