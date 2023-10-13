using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class PollCategoryManager : IPollCategoryManager
    {

        private readonly IPollCategoryDal _pollCategoryDal;

        public PollCategoryManager(IPollCategoryDal pollCategoryDal)
        {
            _pollCategoryDal = pollCategoryDal;
        }

        public void Add(PollCategory pollCategory)
        {
   
            var roworder = _pollCategoryDal.GetAll().Count();
            pollCategory.RowOrder = roworder + 1;
            _pollCategoryDal.Add(pollCategory);
        }

        public PollCategory GetByID(int id)
        {
           return _pollCategoryDal.Get(id);
        }

        public List<PollCategory> GetList()
        {
            return _pollCategoryDal.GetAll();
        }

        public List<PollCategoryListDto> GetPollCategoryListManager()
        {
            return _pollCategoryDal.GetPollCategoryListDal();
        }

        public void Remove(PollCategory pollCategory)
        {
            _pollCategoryDal.Delete(pollCategory);
        }

        public void Update(PollCategory pollCategory)
        {
       
            var roworder = _pollCategoryDal.GetAll().Count();
            pollCategory.RowOrder = roworder;
           pollCategory.LastUpdatedAt = DateTime.Now;
            _pollCategoryDal.Update(pollCategory);
        }
    }
}
