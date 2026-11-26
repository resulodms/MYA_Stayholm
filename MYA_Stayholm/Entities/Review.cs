namespace MYA_Stayholm.Entities
{
    public class Review
    {
        public string ReviewId { get; set; }

        public string HouseId { get; set; }
        public string AppUserId { get; set; }
        public string ReservationId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsApproved { get; set; }

    }
}
