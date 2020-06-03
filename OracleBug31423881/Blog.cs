using System;
using System.ComponentModel.DataAnnotations;

namespace OracleBug31423881
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        public string Url { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
