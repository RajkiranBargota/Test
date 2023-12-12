using System.ComponentModel.DataAnnotations;
namespace VacoTest
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string Title { get; set; } = "";

        [StringLength(5000)]
        public string Contents { get; set; } = "";


        public DateTime TimeStamp { get; set; }
        public int Category { get; set; }

    }
}
