using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecordModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatusEnum Status { get; set; }
        public SellerModel Seller { get; set; }

        public SalesRecordModel()
        {

        }

        public SalesRecordModel(DateTime date, double amount, SaleStatusEnum status, SellerModel seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecordModel(int iD, DateTime date, double amount, SaleStatusEnum status, SellerModel seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
