using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int BookDetailId { get; set; }
        public BookDetail BookDetail { get; set; } = null!;
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;
        public ICollection<BookAuthor> BookAuthors { get; set; } = null!;
    }
}
