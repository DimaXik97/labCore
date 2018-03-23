using System.Collections.Generic;
using System.Threading.Tasks;
using CarService.Model;

namespace Car_Service.DAL.Interfaces
{
    public interface IWorkerRepository
    {
        Task<List<Worker>> Get();
        Task Create(Worker item);
    }
}
