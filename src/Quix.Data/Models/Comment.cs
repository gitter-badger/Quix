using System;

namespace Quix.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string AuthorIp { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public virtual Post Post { get; set; }
    }
}
