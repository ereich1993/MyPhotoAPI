using gRATE.Models;
using gRATE.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gRATE.Data
{
    public interface IRepository
    {
        Task<bool> SaveAll();

        bool Add(object newRecord);

        Task<Image> GetAnImage(Category cat = Category.All);

        IEnumerable<string> GetCategories();

        Task<IEnumerable<Image>> GetAllImagesByUserId(int userId);

        Task<bool> GenerateImageStatistics(int imageId);

        Task<User> GetCurrentUser();

        Task<bool> PutVote(VoteViewModel voteVM);
    }
}