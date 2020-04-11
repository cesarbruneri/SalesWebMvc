using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public SellerModel Seller { get; set; }
        public ICollection<DepartmentModel> Departments { get; set; }
    }
}
