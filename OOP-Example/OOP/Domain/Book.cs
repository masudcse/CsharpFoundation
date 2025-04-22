using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    public abstract class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public virtual string GetBookDetails()
        {
            return $"{Title} by {Author},${Price}";
        }
    }
    public class PhysicalBook : Book
    {
        public double Weight { get; set; }
        public int InStock { get; set; }

        public override string GetBookDetails()
        {
            return $"{base.GetBookDetails()},{Weight},Stock-{InStock}";
        }
    }
    public class AudioBook : Book
    {
        public int LenghtInMinutes { get; set; }
        public string Narrator { get; set; }
        public override string GetBookDetails()
        {
            return $"{base.GetBookDetails()},{LenghtInMinutes},{Narrator}";
        }
    }
    public class Ebook : Book
    {
        public double FileSizeInMb { get; set; }
        public string DownloadLink { get; set; }

        public override string GetBookDetails()
        {
            return $"{base.GetBookDetails()},E-Book,{FileSizeInMb}";
        }
    }
}
