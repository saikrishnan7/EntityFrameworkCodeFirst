using System.Collections.Generic;

namespace CodeFirstVidzy
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Video> Videos { get; set; }
    }
}
