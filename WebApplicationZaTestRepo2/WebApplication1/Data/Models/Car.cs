using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Car
    {

        public Car()
        {
            this.Issues = new HashSet<Issue>();
        }
        public int Id { get; set; }

        public string Model { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
