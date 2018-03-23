using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarService.Model;
using CarService.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarService.Repository.Repositories
{
    public class ImageRepository : BaseRepository, IImageRepository
    {
        public ImageRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public void Create(Image item)
        {
            throw new System.NotImplementedException();
        }

        public List<Image> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        /*public async Task<List<Image>> GetAll()
        {
            var result = new List<Image>();
            using (var context = ContextFactory.CreateDbContext(ConnectionString)) // 1
            {
				result= await context.Images.ToListAsync();
			}
            return result;
        }*/
    }
}
