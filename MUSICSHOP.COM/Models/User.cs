using System.ComponentModel.DataAnnotations;
namespace MusicShop.com.Models
{
    public class User
    {
        public int id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
    }
}
