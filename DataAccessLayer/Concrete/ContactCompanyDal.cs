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
    public class ContactCompanyDal : BaseRepository<ContactCompany, ProjeContext>, IContactCompanyDal
    {
        public List<ContactCompanyListDto> GetContactCompanyListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.ContactCompanies.Select(contactCompany => new ContactCompanyListDto()
                {
                    Id = contactCompany.Id,
                    Address= contactCompany.Address,
                    MailCity= contactCompany.MailCity,
                    Phone= contactCompany.Phone,
                    Twiter=contactCompany.Twiter,
                    Facebook=contactCompany.Facebook,
                    Instegram=contactCompany.Instegram,
                    Linkedin=contactCompany.Linkedin,
                    Skype=contactCompany.Skype,
                    LastUpdatedAt = contactCompany.LastUpdatedAt,
                    CreatedFullName = contactCompany.AppUser.Name,
                    RowOrder = contactCompany.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
