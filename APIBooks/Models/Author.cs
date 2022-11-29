using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBooks.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
    }
}
