using System.Collections.Generic;
using System;
using System.Linq;

namespace WebSales.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saler> Salers { get; set; } = new List<Saler>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaler(Saler saler)
        {
            Salers.Add(saler);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Salers.Sum(saler => saler.TotalSales(initial, final));
        }
    }

}
