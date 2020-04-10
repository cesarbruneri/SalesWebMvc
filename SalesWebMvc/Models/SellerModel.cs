using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SellerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public DepartmentModel Department { get; set; }          
        public ICollection<SalesRecordModel> Sales { get; set; } = new List<SalesRecordModel>();

        public SellerModel()
        {

        }

        public SellerModel(string name, string email, DateTime birthDate, double baseSalary, DepartmentModel department)
        {
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            Department = department;
            BirthDate = birthDate;
        }

        public SellerModel(int iD, string name, string email, DateTime birthDate, double baseSalary, DepartmentModel department )
        {
            ID = iD;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            Department = department;
            BirthDate = birthDate;
        }

        public void AddSales(SalesRecordModel sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecordModel sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime intial, DateTime final)
        {
            return Sales.Where(x => x.Date >= intial && x.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
