using System.Collections.Generic;
using System.Threading.Tasks;
using CarService.Model;

namespace CarService.Repository.Interfaces
{
    public interface IImageRepository
    {
        Task Create(Image item);
        Task<List<Image>> Get(int id);
    }
}
