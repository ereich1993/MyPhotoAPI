using gRATE.Models;
using System.Collections.Generic;

namespace gRATE.Data
{
    public class Repository : IRepository
    {
        public bool Add(object newRecord)
        {
            throw new System.NotImplementedException();
        }

        public bool GenerateImageStatistics(int imageId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Image> GetAllImagesByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Image GetAnImage(Category cat = Category.All)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetCategories()
        {
            throw new System.NotImplementedException();
        }

        public bool PutImage(Image image)
        {
            throw new System.NotImplementedException();
        }

        public bool PutVote(Vote vote)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveAll()
        {
            throw new System.NotImplementedException();
        }
    }
}