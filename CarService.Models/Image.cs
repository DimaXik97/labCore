namespace CarService.Model
{
    public class Image
    {
        public int Id { get; set; }
        public string URL { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
