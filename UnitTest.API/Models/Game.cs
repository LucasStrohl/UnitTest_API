using System.ComponentModel.DataAnnotations;

namespace UnitTest.API.Models
{
    public class Game
    {
        [Key]
        public string playstationId { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string platform { get; set; }
        public DateTime releaseDate { get; set; }
        public string publisher { get; set; }
        public string genre { get; set; }
        public DateTime createdAt { get; set; }

    }
}
