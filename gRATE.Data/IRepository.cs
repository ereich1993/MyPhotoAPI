using gRATE.Models;
using System.Collections;
using System.Collections.Generic;

namespace gRATE.Data
{
    public interface IRepository
    {
        bool SaveAll();

        bool Add(object newRecord);

        Image GetAnImage(Category cat = Category.All);

        IEnumerable<string> GetCategories();

        bool PutVote(Vote vote);

        bool PutImage(Image image);

        IEnumerable<Image> GetAllImagesByUserId(int userId);

        bool GenerateImageStatistics(int imageId);
    }
}