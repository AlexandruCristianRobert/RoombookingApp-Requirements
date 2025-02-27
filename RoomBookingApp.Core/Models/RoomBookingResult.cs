namespace RoomBookingApp.Core.Models
{
    public class RoomBookingResult
    {
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public DateTime Date { get; set; }
    }
}