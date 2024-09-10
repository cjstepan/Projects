using System.ComponentModel.DataAnnotations;

namespace MusicShop.com.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string? Genre { get; set; }
        public string? Performer { get; set; }
        public string? Song { get; set; }
        public decimal Price { get; set; }
    }
}
