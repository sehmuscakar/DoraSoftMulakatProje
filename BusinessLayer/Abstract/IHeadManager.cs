using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadManager
    {
        List<HeadListDto> GetHeadListManager();
        List<Head> GetList();
        void Add(Head head);
        void Update(Head head);
        void Remove(Head head);
        Head GetByID(int id);
    }
}
