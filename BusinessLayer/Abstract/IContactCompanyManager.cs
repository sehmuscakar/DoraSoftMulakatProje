using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactCompanyManager
    {
        List<ContactCompanyListDto> GetContactCompanyListManager();
        List<ContactCompany> GetList();
        void Add(ContactCompany contactCompany);
        void Update(ContactCompany contactCompany);
        void Remove(ContactCompany contactCompany);
        ContactCompany GetByID(int id);
    }
}
