namespace simplyBooksBE.Models
{
    public class Books
    {
        public int Id { get; set; }
        public int Author_Id { get; set; }
        public string? Uid { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public bool Sale { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public  Authors? Author { get; set; }
       
    }
}
