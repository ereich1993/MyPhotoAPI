using System;
using gRATE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Remotion.Linq.Clauses;
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
            if (cat==Category.All)
            {
                images = from item in _gRateCtx.Images where  (item.Owner != user) select item;

            }
            else
            {
               images = from item in _gRateCtx.Images where (item.Category == cat) && (item.Owner != user) select item;
            }
            var imagesList = await images.ToListAsync(); 

            return  imagesList.FirstOrDefault();    
        }

        public IEnumerable<string> GetCategories()
        {
            string[] array;
            array = Enum.GetNames(typeof(Category));
            return array.ToList();

        }

        public Task<bool> PutVote(Vote vote)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> SaveAll()
        {
           int result = await _gRateCtx.SaveChangesAsync();
           return result > 0;
        }
    }
}