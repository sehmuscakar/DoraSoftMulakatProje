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
    public class HeadDal : BaseRepository<Head, ProjeContext>, IHeadDal
    {
        public List<HeadListDto> GetHeadListDal()
        {
          
                using (var context = new ProjeContext())
                {
                    var a = context.Heads.Select(Head => new HeadListDto()
                    {
                        Id = Head.Id,
                        Title = Head.Title,
                        Description= Head.Description,  
                   
                        
                        LastUpdatedAt = Head.LastUpdatedAt,
                        CreatedFullName = Head.AppUser.Name,
                        RowOrder = Head.RowOrder
                    });
                    return a.ToList();
                }
            
        }
    }
}
