using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutManager
    {
        List<AboutListDto> GetAboutListManager();
        List<About> GetList();
        void Add(About about);
        void Update(About about);
        void Remove(About about);
        About GetByID(int id);
    }
}
