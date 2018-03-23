using System.Collections.Generic;
using System.Threading.Tasks;
using CarService.Model;

namespace CarService.Repository.Interfaces
{
    public interface IWorkTimeRepository
    {
        Task<List<WorkTime>> Get();
        Task Create(WorkTime item);
    }
}
