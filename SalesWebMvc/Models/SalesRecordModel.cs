using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecordModel
    {
        public int ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "${0:F2}")]
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
