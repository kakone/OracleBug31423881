using System;
using System.Linq;

namespace OracleBug31423881
{
    internal class Program
    {
        private static void Main()
        {
            using var dbContext = new MyDbContext();
            var days = (from r in dbContext.Blogs
                        select (DateTime.Now - r.CreationDate).Days).FirstOrDefault();
            Console.WriteLine($"{days} days");
        }
    }
}
