using System.Collections.Generic;
using System.Threading.Tasks;
using CarService.Model;

namespace CarService.Repository.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> Get();
        Task Create(Reservation item);
    }
}
