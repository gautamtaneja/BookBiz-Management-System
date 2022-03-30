using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.Models
{
    public class Category
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
