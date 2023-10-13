using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class PollCategoryDal : BaseRepository<PollCategory, ProjeContext>, IPollCategoryDal
    {
        public List<PollCategoryListDto> GetPollCategoryListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.PollCategories.Select(pollCategory => new PollCategoryListDto()
                {
                    Id = pollCategory.Id,
                   Name= pollCategory.Name,
                    LastUpdatedAt = pollCategory.LastUpdatedAt,
                    CreatedFullName = pollCategory.AppUser.Name,
                    RowOrder = pollCategory.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
