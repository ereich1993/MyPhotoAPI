using gRATE.Models;
using gRATE.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Image = gRATE.Models.Image;

namespace gRATE.Data
{
    public class Repository : IRepository
    {
        private GRateDbContext _gRateCtx;

        public Repository(GRateDbContext gRate)
        {
            _gRateCtx = gRate;
        }

        public void Add(object newRecord)
        {
            _gRateCtx.Add(newRecord);
        }

        public Task<bool> PutImage(Image image)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Image>> GetAllImagesByUserId(int userId)
        {
            return await _gRateCtx.Images.Where(img => img.Owner.Id == userId).ToListAsync();
        }

        public Task<bool> GenerateImageStatistics(int imageId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// return an image where user havent voted for and check limit of image count is below expectation.
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public async Task<Image> GetAnImage(Category cat = Category.All)
        {
            User user = _gRateCtx.Users.FirstOrDefault();
            IQueryable<Image> images;
            if (cat == Category.All)
            {
                images = from item in _gRateCtx.Images where (item.Owner != user) select item;
            }
            else
            {
                images = from item in _gRateCtx.Images where (item.Category == cat) && (item.Owner != user) select item;
            }
            var imagesList = await images.ToListAsync();

            return imagesList.FirstOrDefault();
        }

        public IEnumerable<string> GetCategories()
        {
            string[] array;
            array = Enum.GetNames(typeof(Category));
            return array.ToList();
        }

        public async Task<bool> SaveAll()
        {
            int result = await _gRateCtx.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> PutVote(VoteViewModel voteVM)
        {
            var sameVotes = await _gRateCtx.Votes.Where(v => (v.Image.Id == voteVM.ImageId && v.User.Id == voteVM.UserId)).ToListAsync();

            if (sameVotes.Count > 0) return false;

            User user = await _gRateCtx.Users.Where(u => u.Id == voteVM.UserId).FirstOrDefaultAsync();
            Image image = await _gRateCtx.Images.Where(i => i.Id == voteVM.ImageId).FirstOrDefaultAsync();

            if (image != null && user != null)
            {
                Vote newVote = new Vote()
                {
                    User = user,
                    Image = image,
                    Date = DateTime.Now
                };
                await _gRateCtx.AddAsync(newVote);
                return await SaveAll();
            }

            return false;
        }
    }
}