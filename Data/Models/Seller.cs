namespace ISProject.Data.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RatingSeller { get; set; }
    }
}