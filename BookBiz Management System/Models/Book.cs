using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.Models
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int UnitPrice { get; set; }
        public DateTime YearOfPublish { get; set; }
        public int QOH { get; set; }
        public List<Author> Authors { get; set; }
        public int Category { get; set; }
        public Publisher Publisher { get; set; }
    }
}
