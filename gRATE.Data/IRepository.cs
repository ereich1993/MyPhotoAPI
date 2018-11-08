using gRATE.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gRATE.Data
{
    public interface IRepository
    {
        Task<bool> SaveAll();

        void Add(object newRecord);

        Task<Image> GetAnImage(Category cat = Category.All);

        IEnumerable<string> GetCategories();

        Task<bool> PutVote(Vote vote);

        Task<bool> PutImage(Image image);

        Task<IEnumerable<Image>> GetAllImagesByUserId(int userId);

        Task<bool> GenerateImageStatistics(int imageId);
    }
}