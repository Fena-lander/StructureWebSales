using System.Collections.Generic;
using System;
using System.Linq;

namespace WebSales.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaler(Seller saler)
        {
            Sellers.Add(saler);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(saler => saler.TotalSales(initial, final));
        }
    }

}
