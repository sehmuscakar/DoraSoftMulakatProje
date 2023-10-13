using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PollUserManager : IPollUserManager
    {
        private readonly IPollUserDal _pollUserDal;

        public PollUserManager(IPollUserDal pollUserDal)
        {
            _pollUserDal = pollUserDal;
        }

        public void Add(PollUser pollUser)
        {

            var roworder = _pollUserDal.GetAll().Count();
            pollUser.RowOrder = roworder + 1;
            pollUser.CreatedAt= DateTime.Now;
            _pollUserDal.Add(pollUser); 
        }

        public PollUser GetByID(int id)
        {
            return _pollUserDal.Get(id);
        }

        public List<PollUser> GetList()
        {
            return _pollUserDal.GetAll();
        }

        public List<PollUserListDto> GetPollUserListManager()
        {
            return _pollUserDal.GetPollUserListDal();
        }

        public void Remove(PollUser pollUser)
        {
            _pollUserDal.Delete(pollUser);
        }

        public void Update(PollUser pollUser)
        {
            var roworder = _pollUserDal.GetAll().Count();
            pollUser.RowOrder = roworder;
            _pollUserDal.Update(pollUser);
        }
    }
}
