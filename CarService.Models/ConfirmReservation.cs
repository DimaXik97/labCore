using System;

namespace CarService.Model
{
    public class ConfirmReservation
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsConfirm { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
