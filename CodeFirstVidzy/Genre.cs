using System.Collections.Generic;

namespace CodeFirstVidzy
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }

        public Genre()
        {
            Videos = new List<Video>();
        }
    }
}
