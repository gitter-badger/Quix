using System.Collections.Generic;

namespace Quix.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
