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
    public class ContactCompanyManager : IContactCompanyManager
    {
        private readonly IContactCompanyDal _contactCompanyDal;

        public ContactCompanyManager(IContactCompanyDal contactCompanyDal)
        {
            _contactCompanyDal = contactCompanyDal;
        }

        public void Add(ContactCompany contactCompany)
        {
            var roworder = _contactCompanyDal.GetAll().Count();
            contactCompany.RowOrder = roworder + 1;
            _contactCompanyDal.Add(contactCompany);
        }

        public ContactCompany GetByID(int id)
        {
            return _contactCompanyDal.Get(id);
        }

        public List<ContactCompanyListDto> GetContactCompanyListManager()
        {
            return _contactCompanyDal.GetContactCompanyListDal();
        }

        public List<ContactCompany> GetList()
        {
            return _contactCompanyDal.GetAll();
        }

        public void Remove(ContactCompany contactCompany)
        {
            _contactCompanyDal.Delete(contactCompany);
        }

        public void Update(ContactCompany contactCompany)
        {
            var roworder = _contactCompanyDal.GetAll().Count();
            contactCompany.RowOrder = roworder;
            contactCompany.LastUpdatedAt = DateTime.Now;
             _contactCompanyDal.Update(contactCompany);
        }
    }
}
