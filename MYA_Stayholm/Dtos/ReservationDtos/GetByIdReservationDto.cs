namespace MYA_Stayholm.Dtos.ReservationDtos
{
    public class GetByIdReservationDto
    {
        public string ReservationId { get; set; }

        public string HouseId { get; set; }
        public string AppUserId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int GuestCount { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
