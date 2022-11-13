﻿namespace WizLib_Model.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Location { get; set; } = null!;
        public List<Book> Books { get; set; } = null!;
    }
}
