using System;
using System.Threading.Tasks;
using CarService.Model;

namespace CarService.Repository.Interfaces
{
    public interface IConfirmReservationRepository
    {
        ConfirmReservation Get(Guid guid);
        Task Create(ConfirmReservation item);
        Task Update(ConfirmReservation item);

    }
}
