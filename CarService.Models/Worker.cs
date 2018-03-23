using System.Collections.Generic;

namespace CarService.Model
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public List<Reservation> Reservation { get; set; }
        public List<WorkTime> WorkTimes { get; set; }
    }
}
