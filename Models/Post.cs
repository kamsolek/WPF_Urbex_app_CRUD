using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUrbexApp.Models
{
    public class Post
    {
        public int Id { get; set; }  // Unikalne ID
        public string Title { get; set; }  // Tytuł posta
        public string Description { get; set; }  // Opis posta
        public DateTime Date { get; set; }  // Data dodania posta
        public string Location { get; set; }  // Lokalizacja miejsca
        public byte[] Image { get; set; }  // Obraz jako BLOB

        public Post(int id, string title, string description, DateTime date, string location, byte[] image)
        {
            Id = id;
            Title = title;
            Description = description;
            Date = date;
            Location = location;
            Image = image;
        }

        public Post(string title, string description, DateTime date, string location, byte[] image)
        {
            Title = title;
            Description = description;
            Date = date;
            Location = location;
            Image = image;

        }
    }
}
