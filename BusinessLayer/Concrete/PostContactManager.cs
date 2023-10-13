using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class PostContactManager : IPostContactManager
    {
        private readonly IPostContactDal _postContactDal;

        public PostContactManager(IPostContactDal postContactDal)
        {
            _postContactDal = postContactDal;
        }

        public void Add(PostContact postContact)
        {
            _postContactDal.Add(postContact);
        }

        public PostContact GetByID(int id)
        {
            return _postContactDal.Get(id);
        }

        public List<PostContact> GetList()
        {
            return _postContactDal.GetAll();
        }

        public void Remove(PostContact postContact)
        {
            _postContactDal.Delete(postContact);
        }

        public void Update(PostContact postContact)
        {
           _postContactDal.Update(postContact);
        }
    }
}
