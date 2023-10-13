using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class HeadManager : IHeadManager
    {
        private readonly IHeadDal _headDal;

        public HeadManager(IHeadDal headDal)
        {
            _headDal = headDal;
        }

        public void Add(Head head)
        {
       
            var roworder = _headDal.GetAll().Count();
            head.RowOrder = roworder + 1;
            _headDal.Add(head); 
        }

        public Head GetByID(int id)
        {
            return _headDal.Get(id);
        }

        public List<HeadListDto> GetHeadListManager()
        {
            return _headDal.GetHeadListDal();
        }

        public List<Head> GetList()
        {
            return _headDal.GetAll();
        }

        public void Remove(Head head)
        {
           _headDal.Delete(head);
        }

        public void Update(Head head)
        {
          
            var roworder = _headDal.GetAll().Count();
           head.RowOrder = roworder;
           head.LastUpdatedAt = DateTime.Now;
            _headDal.Update(head);
        }
    }
}
