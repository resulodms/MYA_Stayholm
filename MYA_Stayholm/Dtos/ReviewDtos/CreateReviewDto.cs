namespace MYA_Stayholm.Dtos.ReviewDtos
{
    public class CreateReviewDto
    {
     
        public string HouseId { get; set; }
        public string AppUserId { get; set; }
        public string ReservationId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsApproved { get; set; }
    }
}
