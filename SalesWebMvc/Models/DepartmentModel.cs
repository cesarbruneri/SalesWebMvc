using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class DepartmentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<SellerModel> Sellers { get; set; } = new List<SellerModel>();

        public DepartmentModel()
        {

        }

        public DepartmentModel(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public void AddSeller(SellerModel seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
