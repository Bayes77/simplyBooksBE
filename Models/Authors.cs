namespace simplyBooksBE.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string? Uid { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public bool Favorite { get; set; }
        public string? ImageUrl { get; set; }

    }
}
