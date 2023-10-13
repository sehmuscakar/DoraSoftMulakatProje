using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PollManager : IPollManager
    {

        private readonly IPollDal _pollDal;

        public PollManager(IPollDal pollDal)
        {
            _pollDal = pollDal;
        }

        public void Add(Poll poll)
        {
           
            var roworder = _pollDal.GetAll().Count();
            poll.RowOrder = roworder + 1;
            _pollDal.Add(poll);
        }

        public Poll GetByID(int id)
        {
           return _pollDal.Get(id);
        }

        public List<Poll> GetList()
        {
            return _pollDal.GetAll();
        }

        public List<PollListDto> GetPollListActiveManager()
        {
            return _pollDal.GetPollListActiveDal();
        }

        public List<PollListDto> GetPollListManager()
        {
            return _pollDal.GetPollListDal();
        }

        public void Remove(Poll poll)
        {
             _pollDal.Delete(poll);
        }

        public void Update(Poll poll)
        {
            var roworder = _pollDal.GetAll().Count();
           poll.RowOrder = roworder;
           poll.LastUpdatedAt = DateTime.Now;
            _pollDal.Update(poll);   
        }
    }
}
