using System;

namespace CarService.Model
{
    public class WorkTime
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
