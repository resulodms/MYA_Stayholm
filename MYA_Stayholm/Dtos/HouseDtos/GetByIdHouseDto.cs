namespace MYA_Stayholm.Dtos.HouseDtos
{
    public class GetByIdHouseDto
    {
        public string HouseId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CategoryId { get; set; }
        public decimal PricePerNight { get; set; }
        public int GuestCapacity { get; set; }
        public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public List<string> Amenities { get; set; }
        public List<string> ImageUrls { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
