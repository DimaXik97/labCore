using System;
using System.Collections.Generic;

namespace CarService.Model
{
    public class Reservation
    {
        public int Id { get; set; }

        public string Purpose { get; set; }
        public string BreakdownDetails { get; set; }
        public string DesiredDiagnosis { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public virtual Worker Worker { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual ConfirmReservation ConfirmReservation { get; set; }
    }
}