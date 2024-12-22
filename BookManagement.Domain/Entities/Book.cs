using BookManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookManagement.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please provide Tilte")]
        [StringLength(100)]
        public  string? Title { get; set; }
        [Required(ErrorMessage ="Please prodive Authoris Name")]
        [StringLength(100)]
        public string? Author {  get; set; }
        public DateTime? PublicationDate { get; set; }
        [EnumDataType(typeof(Category),ErrorMessage ="Please select the Category")]
        public Category Category { get; set; }
    }
}
